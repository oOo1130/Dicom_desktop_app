using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIS.Models
{
    public class ConsultantOpinionOnStudy
    {
        [Key]
        public int OpId { get; set; }
        [ForeignKey("RISWorkList")]
        public int ProcId { get; set; }
        [ForeignKey("ReportConsultant")]
        public int RCId { get; set; }
        public DateTime OpDate { get; set; }
        public string OpTime { get; set; }
        public string ReportContent { get; set; }
  
        public bool isReportComplete { get; set; }

        public int TemplateId { get; set; }

        public RISWorkList RISWorkList { get; set; }

        public ReportConsultant ReportConsultant { get; set; }
    }
}
