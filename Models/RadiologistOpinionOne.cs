using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIS.Models
{
    public class RadiologistOpinionOne   // This table will hold DX, DR, CR, MG and ECG Report
    {
        [Key]
        public int OpId { get; set; }
        [ForeignKey("RISWorkList")]
        public int ProcId { get; set; }
        [ForeignKey("ReportConsultant")]
        public int RCId { get; set; }
        public DateTime OpDate { get; set; }
        public string  OpTime { get; set; }
        public byte[] ReportContent { get; set; }
        public string ReportPath { get; set; } // Will be used in future if ReportContent saved in DB shows low performance

        public bool isReportComplete { get; set; }

        public RISWorkList RISWorkList { get; set; }

        public ReportConsultant ReportConsultant { get; set; }

    }
}
