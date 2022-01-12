using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIS.Models.VWModels
{
    public class VMHISModalityProcedureMapping
    {
        public int MapId { get; set; }
        public int TenantId { get; set; }  // Hospital Id
        public int PId { get; set; }   // HIS Procedure Id
        public string ModalityProcDescription { get; set; }
        public string HospitalName { get; set; }
        public string HISProcedureName { get; set; }
        public string Modality { get; set; }
    }
}
