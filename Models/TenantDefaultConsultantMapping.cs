using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIS.Models
{
    public class TenantDefaultConsultantMapping
    {
        public int Id { get; set; }
        public int TenantId { get; set; }
        public int RCId { get; set; }
        public string Modality { get; set; }
    }
}
