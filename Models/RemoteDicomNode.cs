using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIS.Models
{
    public class RemoteDicomNode
    {
        [Key]
        public Guid NodeGuid { get; set; }
        public string NodeName { get; set; }
        public string NodeHost { get; set; }
        public int NodePort { get; set; }
        public string NodeAet { get; set; }
        [ForeignKey("Tenant")]
        public int TenantId { get; set; }

        public Tenant Tenant { get; set; }
    }
}
