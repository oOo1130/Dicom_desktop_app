using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RIS.Models.VWModels
{
    public class OcsResponse
    {
        public int id { get; set; }
        public string path { get; set; }
        public string file_target { get; set; }
        public string share_with { get; set; }
        public string share_with_displayname { get; set; }
        public string groupname { get; set; }
        public string share_status { get; set; }

    }
}

