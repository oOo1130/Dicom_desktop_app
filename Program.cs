using Autofac;
using RIS.Storage;
using RIS.UI;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RIS
{
    static class Program
    {


        /// <summary>
        /// Gets/sets the dependency injection container.
        /// </summary>
        /// <value>The dependency injection container.</value>
        public static IContainer Container { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           
            Bootstrap();

            Application.Run(new LoginForm());
        }

        /// <summary>
        /// Bootstraps the application.
        /// </summary>
        private static void Bootstrap()
        {
            //StateTracker = new Tracker();
            //StateTracker.Configure<Form>()
            //    .Id(f => f.Name, SystemInformation.VirtualScreen.Size)
            //    .Properties(f => new { f.Top, f.Width, f.Height, f.Left, f.WindowState })
            //    .PersistOn(nameof(Form.Move), nameof(Form.Resize), nameof(Form.FormClosing))
            //    .WhenPersistingProperty((f, p) => p.Cancel = f.WindowState != FormWindowState.Normal &&
            //                                                 (p.Property == nameof(Form.Height) ||
            //                                                  p.Property == nameof(Form.Width) ||
            //                                                  p.Property == nameof(Form.Top) ||
            //                                                  p.Property == nameof(Form.Left)))
            //    .StopTrackingOn(nameof(Form.FormClosing));


            var builder = new ContainerBuilder();

            //// Configuration
            //builder.RegisterInstance(new LocalXmlConfigurationAccess(Configuration.ConfigurationPath))
            //    .As<IConfigurationAccess>().SingleInstance();

            //// Database
            //builder.RegisterInstance(new SqlCeDataAccess(Configuration.SqlCeDatabaseConnection))
            //    .As<IDataAccess>().SingleInstance();

            // Storage
            builder.RegisterInstance(new LocalStorage())
                .As<IStorageAccess>().SingleInstance();

            Container = builder.Build();
        }
    }
}
