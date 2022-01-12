using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIS.Models
{
    public class HISModalityProcedureMapping 
    {  
        [Key]
        public int MapId { get; set; }
        public int TenantId { get; set; }  // Hospital Id
        public int PId { get; set; }   // HIS Procedure Id
        public string ModalityProcDescription { get; set; }
    }
}
