using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace RIS
{
    /// <inheritdoc />
    /// <summary>
    /// A double-buffered listview control.
    /// </summary>
    [ToolboxItem(true)]
    [ToolboxBitmap(typeof(ListView))]
    public class ListViewDoubleBuffered : ListView
    {
        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="ListViewDoubleBuffered"/> class.
        /// </summary>
        public ListViewDoubleBuffered()
            : base()
        {
            if (SystemInformation.TerminalServerSession) 
                return;

            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            UpdateStyles();
        }
        #endregion
    }
}
