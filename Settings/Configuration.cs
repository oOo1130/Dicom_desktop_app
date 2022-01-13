using DicomServer;
using RIS.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace RIS.Settings
{
   
    /// <summary>
    /// This class describes the application's configuration.
    /// </summary>
    [DataContract]
    [XmlRoot("Configuration")]
    public class Configuration
    {
        

        public int DatabaseCommandTimeout { get; set; }
        
        public String LocalStorageDirectory { get; set; }

       

        /// <summary>
        /// Initializes a new instance of the <see cref="Configuration"/> class.
        /// </summary>	
        public Configuration()
        {

            LocalStorageDirectory = Constants._DicomFilePath;  //Path.Combine(DirectoryHelpers.GetStartDirectory(), "Incoming");
          
        }

       
    }
}
