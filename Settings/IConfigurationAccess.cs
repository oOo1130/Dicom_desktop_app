using System;
using System.Threading.Tasks;

namespace RIS.Settings
{
    /// <summary>
    /// The configuration access interface.
    /// </summary>
    public interface IConfigurationAccess
    {
        /// <summary>
        /// Gets the configuration file path.
        /// </summary>
        String ConfigurationPath { get; }

        /// <summary>
        /// Gets/sets the configuration object.
        /// </summary>
        Configuration Configuration { get; set; }

        /// <summary>
        /// Loads the cofiguration.
        /// </summary>
        Task LoadConfigurationAsync();

        /// <summary>
        /// Save the cofiguration.
        /// </summary>
        Task SaveConfigurationAsync();
    }
}
