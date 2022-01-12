using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DicomServer
{
    /// <summary>
    /// This form provides an animation during long operations.
    /// </summary>
    public partial class WaitingForm : Form
    {
        #region Private Variables

        /// <summary>
        /// The worker function.
        /// </summary>
        private readonly Func<Task> _worker;

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets/sets the title of the form.
        /// </summary>
        /// <value>The title of the form.</value>
        public String Title { get; set; }

        /// <summary>
        /// Gets/sets the message of the form.
        /// </summary>
        /// <value>The message of the form.</value>
        public String Message { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="WaitingForm"/> class.
        /// </summary>
        /// <param name="worker">The worker function.</param>
        public WaitingForm(Func<Task> worker)
        {
            InitializeComponent();
            _worker = worker ?? throw new ArgumentNullException();
        }

        #endregion

        #region Protected Methods

        /// <summary>
        /// This method is called when the form is loaded.
        /// </summary>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            loadingCircle.OuterCircleRadius = 25;
            loadingCircle.NumberSpoke = 20;

            Text = Title;
            lbMessage.Text = Message;

            Task.Run(_worker)
                .ContinueWith(t => { Close(); },
                    TaskScheduler.FromCurrentSynchronizationContext());
        }

        #endregion
    }
}
