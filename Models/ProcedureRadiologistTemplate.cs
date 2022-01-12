using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIS.Models
{
    public class ProcedureRadiologistTemplate
    {
        public int Id { get; set; }
        public int PId { get; set; }  // Procedure Id
        public int RCId { get; set; } // Report Consultant Id
        public string FileName { get; set; }
        public string TemplateName { get; set; }
        public byte[] TemplateContent { get; set; }
        public bool IsDefaultTemplate { get; set; }
    }
}
