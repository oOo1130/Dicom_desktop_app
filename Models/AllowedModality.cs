using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIS.Models
{
    public class AllowedModality
    {
        public int Id { get; set; }
        [ForeignKey("ReportConsultant")]
        public int RCId { get; set; }
        public string Modality { get; set; }
        public ReportConsultant ReportConsultant { get; set; }
    }
}
