using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIS.Models.VWModels
{
    public class VMRemoteDicomNode
    {
        public Guid NodeGuid { get; set; }
        public string NodeName { get; set; }
        public string NodeHost { get; set; }
        public int NodePort { get; set; }
        public string NodeAet { get; set; }
        public int TenantId { get; set; }
        public string TenantName { get; set; }
    }
}
