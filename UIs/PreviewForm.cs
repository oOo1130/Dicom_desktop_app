using Autofac;
using Dicom.Imaging;
using RIS;
using RIS.Models;
using RIS.Models.VWModels;
using RIS.Services;
using RIS.Settings;
using RIS.Storage;
using RIS.Utility;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DicomServer
{
    /// <summary>
    /// This form provides a preview of studies.
    /// </summary>
    public partial class PreviewForm : Form
    {
        #region Private Variables

        
        /// <summary>
        /// The injected configuration access module.
        /// </summary>
       // private readonly IConfigurationAccess _configurationAccess;


        /// <summary>
        /// The injected data access module.
        /// </summary>
        private readonly IStorageAccess _storageAccess;

        /// <summary>
        /// The list of queried database datasets.
        /// </summary>
        private readonly List<VMRISWorklistSubSetForLV> _databaseDatasets;

        /// <summary>
        /// The thumbnail size.
        /// </summary>
        private const int ThumbNailSize = 100;

        /// <summary>
        /// The default thumbnail.
        /// </summary>
        private Bitmap _defaultThumbnail;

        /// <summary>
        /// Flag to indicate if the form is closing.
        /// </summary>
        bool _closing;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="PreviewForm"/> class.
        /// </summary>
        /// <param name="databaseDatasets">The list of database datasets to preview.</param>
        public PreviewForm(List<VMRISWorklistSubSetForLV> databaseDatasets)
        {
            InitializeComponent();

            _storageAccess = Program.Container.Resolve<IStorageAccess>();
            _databaseDatasets = databaseDatasets;
            _closing = false;

            ListViewNativeMethods.SetWindowTheme(previewListView.Handle, "explorer", null);
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// This method is called when the form is loaded.
        /// </summary>
        private void OnPreviewFormLoad(object sender, EventArgs e)
        {
            previewListView.SetGroupState(ListViewGroupState.Collapsible);

            var imageList = new ImageList
            {
                ImageSize = new Size(ThumbNailSize, ThumbNailSize),
                ColorDepth = ColorDepth.Depth24Bit,
                TransparentColor = Color.White
            };
            previewListView.LargeImageList = imageList;

            _defaultThumbnail = CreateDefaultThumbnail();

            RenderStudyImages();
        }

        /// <summary>
        /// This method is called when the form is closing.
        /// </summary>
        private void OnPreviewFormClosing(object sender, FormClosingEventArgs e)
        {
            _closing = true;
        }

        /// <summary>
        /// This the default preview thumbnail.
        /// </summary>
        private Bitmap CreateDefaultThumbnail()
        {
            var defaultBitmap = new Bitmap(ThumbNailSize, ThumbNailSize, PixelFormat.Format24bppRgb);
            using (var graphics = Graphics.FromImage(defaultBitmap))
            {
                using (var brush = new SolidBrush(Color.White))
                {
                    var rect = new Rectangle(0, 0, defaultBitmap.Width - 1, defaultBitmap.Height - 1);
                    graphics.FillRectangle(brush, rect);
                    using (var pen = new Pen(Color.Wheat, 1))
                        graphics.DrawRectangle(pen, 0, 0, defaultBitmap.Width - 1, defaultBitmap.Height - 1);
                }
            }

            return defaultBitmap;
        }

        /// <summary>
        /// Populates the listview with the thumbnails.
        /// </summary>
        /// <param name="grouppedDatabaseDatasets">The groupped database dataset information.</param>
        private async void PopulatePreviewListview(dynamic grouppedDatabaseDatasets)
        {
            // Add items
            previewListView.Items.Clear();
            previewListView.Groups.Clear();
            previewListView.LargeImageList.Images.Clear();
            previewListView.LargeImageList.Images.Add(_defaultThumbnail);
            previewListView.BeginUpdate();

            foreach (var study in grouppedDatabaseDatasets)
            {
                foreach (var series in study.Series)
                {
                    var seriesDescription = "No Description";
                    if (!String.IsNullOrWhiteSpace(series.Dataset.SeriesDescription))
                        seriesDescription = series.Dataset.SeriesDescription;
                    seriesDescription += " (" + series.Dataset.SeriesInstanceUid + ")";
                    var group = new ListViewGroup(seriesDescription);
                    previewListView.Groups.Add(group);

                    foreach (var instance in series.Instances)
                    {
                        if (_closing)
                            return;

                        var item = new ListViewItem(instance.SopInstanceUid, group)
                        {
                            ImageIndex = 0
                        };
                        previewListView.Items.Add(item);
                    }
                }
            }

            previewListView.EndUpdate();

            // Draw items
            foreach (var study in grouppedDatabaseDatasets)
            {
                foreach (var series in study.Series)
                {
                    foreach (var instance in series.Instances)
                    {
                        var bitmap = await CreateInstanceThumbnail(instance);

                        if (_closing)
                            return;

                        previewListView.LargeImageList.Images.Add(bitmap);
                        var index = previewListView.LargeImageList.Images.Count - 1;
                        previewListView.Items[index - 1].ImageIndex = index;
                    }
                }
            }
        }

        /// <summary>
        /// Creates the thumbnail out of an instance.
        /// </summary>
        /// <param name="databaseDataset">The database dataset.</param>
        private async Task<Bitmap> CreateInstanceThumbnail(DatabaseDataset databaseDataset)
        {
            Bitmap bitmap = null;

            try
            {
                await Task.Run(async () =>
                {
                    var dicomImage =
                        new DicomImage(
                            await _storageAccess.QueryDicomDatasetFromStorageAsync(
                                Path.Combine(new Configuration().LocalStorageDirectory,
                                    databaseDataset.DatasetPath)));
                    using (var originalBitmap = dicomImage.RenderImage().AsBitmap())
                    {
                        var bitmapWidth = originalBitmap.Width > ThumbNailSize ? ThumbNailSize : originalBitmap.Width;
                        var bitmapHeight = originalBitmap.Height > ThumbNailSize
                            ? ThumbNailSize
                            : originalBitmap.Height;
                        bitmap = new Bitmap(bitmapWidth, bitmapHeight, PixelFormat.Format24bppRgb);
                        using (var graphics = Graphics.FromImage(bitmap))
                        {
                            int tnWidth = bitmapWidth, tnHeight = bitmapHeight;
                            if (originalBitmap.Width > originalBitmap.Height)
                                tnHeight = (int)(originalBitmap.Height / (float)originalBitmap.Width * tnWidth);
                            else if (originalBitmap.Width < originalBitmap.Height)
                                tnWidth = (int)(originalBitmap.Width / (float)originalBitmap.Height * tnHeight);

                            var left = bitmapWidth / 2 - tnWidth / 2;
                            var top = bitmapHeight / 2 - tnHeight / 2;

                            graphics.PixelOffsetMode = PixelOffsetMode.None;
                            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

                            graphics.DrawImage(originalBitmap, left, top, tnWidth, tnHeight);
                            using (var pen = new Pen(Color.Wheat, 1))
                                graphics.DrawRectangle(pen, 0, 0, bitmap.Width - 1, bitmap.Height - 1);
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                Log.ApplicationLog.Error("CreateThumbnail: " + ex.GetAllMessages());
                bitmap = _defaultThumbnail;
            }

            return bitmap;
        }

        /// <summary>
        /// Renders the studies images.
        /// </summary>
        private void RenderStudyImages()
        {
            dynamic grouppedDatabaseDatasets = null;

            Exception exception = null;
            using (var form = new WaitingForm(async () =>
            {
                try
                {
                    var databaseDatasets = new List<DatabaseDataset>();
                    foreach (var study in _databaseDatasets)
                    {
                       

                        var moveDataset = DicomDatasetHelpers.CreateStudyMoveDicomDataset(
                            study.StudyInstanceUid);
                        var resultDatabaseDatasets =
                             await new DicomService().QueryStudyDatabaseDatasetsForMoveAsync(moveDataset);
                        if (resultDatabaseDatasets != null)
                            databaseDatasets.AddRange(resultDatabaseDatasets);
                    }

                    grouppedDatabaseDatasets = databaseDatasets
                        .GroupBy(s => s.StudyInstanceUid)
                        .Select(studyGroup => new
                        {
                            Key = studyGroup.Key,
                            Dataset = studyGroup.OrderByDescending(p => p.ReceptionDateTime).First(),
                            Count = studyGroup.Count(),
                            Series = studyGroup.Select(s => s)
                                .GroupBy(s => s.SeriesInstanceUid)
                                .Select(seriesGroup => new
                                {
                                    Key = seriesGroup.Key,
                                    Dataset = seriesGroup.OrderByDescending(p => p.ReceptionDateTime).First(),
                                    Count = seriesGroup.Count(),
                                    Instances = seriesGroup.Select(i => i)
                                        .OrderBy(p => p.InstanceNumber, new NaturalSortComparer<String>())
                                })
                        });
                }
                catch (Exception ex)
                {
                    exception = ex;
                    Log.ApplicationLog.Error("PreviewStudies: " + ex.GetAllMessages());
                }
            })
            {
                Title = "Studies",
                Message = "Preview studies..."
            })
            {
                form.ShowDialog();

                if (exception != null)
                {
                    MessageBox.Show(this, exception.GetAllMessages(),
                        "Study preview error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (grouppedDatabaseDatasets != null)
                    PopulatePreviewListview(grouppedDatabaseDatasets);
            }
        }

        #endregion
    }
}
