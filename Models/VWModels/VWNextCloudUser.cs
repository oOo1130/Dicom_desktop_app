using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RIS.Models.VWModels
{
    public class VWNextCloudUser
    {
        public int ProcId { get; set; }
        public string GroupName { get; set; }
        public string RadNextCloudId { get; set; }
        public string Share_id { get; set; }
        public string StudyInstanceUid { get; set; }
    }
}
