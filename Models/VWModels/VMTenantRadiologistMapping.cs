using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIS.Models.VWModels
{
    public class VMTenantRadiologistMapping
    {
        public int Id { get; set; }
        public int TenantId { get; set; }
        public string TenantName { get; set; }
        public int RCId { get; set; }
        public string ConsultantName { get; set; }
        public string Modality { get; set; }
    }
}
