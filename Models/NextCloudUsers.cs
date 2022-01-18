using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIS.Models
{
    public class NextCloudUsers
    {
        
        [JsonProperty("GroupName")]
        public string GroupName { get; set; }
        
        [JsonProperty("UserName")]
        public string UserName { get; set; }
        
        [JsonProperty("ShareStatus")]
        public string ShareStatus { get; set; }
    }
}
