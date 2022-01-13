using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIS.Models
{
    public class PrintPageSetup
    {
        public int Id { get; set; }
        public int TenantId { get; set; }
        public float TopMargin { get; set; }
        public float BottomMargin { get; set; }
        public float LeftMargin { get; set; }
        public float RightMargin { get; set; }

    }
}
