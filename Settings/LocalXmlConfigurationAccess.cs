using System;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace RIS.Settings
{
    /// <summary>
    /// This class implements the configuration access interface providing means to keep
    /// the application's configuration in an XML file.
    /// </summary>
    public class LocalXmlConfigurationAccess : IConfigurationAccess
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalXmlConfigurationAccess"/> class.
        /// </summary>
        /// <param name="configurationPath">The configuration file path.</param>
        public LocalXmlConfigurationAccess(String configurationPath)
        {
            ConfigurationPath = configurationPath;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets/sets the configuration file path.
        /// </summary>
        /// <value>The configuration file path.</value>
        public String ConfigurationPath { get; set; }

        /// <summary>
        /// Gets/sets the configuration object.
        /// </summary>
        /// <value>The configuration object.</value>
        public Configuration Configuration { get; set; }

        #endregion

        #region Public Methods

        /// <summary>
        /// Loads the configuration.
        /// </summary>
        public async Task LoadConfigurationAsync()
        {
            Configuration = await DeserializeObjectAsync<Configuration>(ConfigurationPath);
        }

        /// <summary>
        /// Save the configuration.
        /// </summary>
        public async Task SaveConfigurationAsync()
        {
            await SerializeObjectAsync<Configuration>(ConfigurationPath, Configuration);
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Deserializes the configuration from an XML file.
        /// </summary>
        /// <param name="path">The XML file path.</param>
        /// <returns>The deserialized configuration object.</returns>
        private Task<T> DeserializeObjectAsync<T>(String path)
        {
            return Task.Run(() =>
            {
                using (var xmlReader = new XmlTextReader(path))
                {
                    var serializer = new XmlSerializer(typeof(T));
                    var theObject = (T) serializer.Deserialize(xmlReader);
                    return theObject;
                }
            });
        }

        /// <summary>
        /// Serializes the configuration to an XML file.
        /// </summary>
        /// <param name="path">The XML file path.</param>
        /// <param name="theObject">The object to serialize.</param>
        private Task SerializeObjectAsync<T>(String path, T theObject)
        {
            return Task.Run(() =>
            {
                var xmlWriterSettings = new XmlWriterSettings()
                {
                    OmitXmlDeclaration = false,
                    Encoding = Encoding.UTF8,
                    Indent = true
                };

                var namespaces = new XmlSerializerNamespaces();
                namespaces.Add(String.Empty, String.Empty);

                using (var xmlWriter = XmlTextWriter.Create(path, xmlWriterSettings))
                {
                    var serializer = new XmlSerializer(typeof(T));
                    serializer.Serialize(xmlWriter, theObject, namespaces);
                }
            });
        }

        #endregion
    }
}
