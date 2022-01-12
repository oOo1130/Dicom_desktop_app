using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIS.Models.VWModels
{
    public class VMRadProcTemplate
    {
        public int Id { get; set; }
        public int PId { get; set; }  // Procedure Id
        public int RCId { get; set; } // Report Consultant Id
        public string FileName { get; set; }
        public string TemplateName { get; set; }
        public byte[] TemplateContent { get; set; }
        public string ProcedureName { get; set; }
        public string Modality { get; set; }
    }
}
