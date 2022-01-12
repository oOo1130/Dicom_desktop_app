using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIS.Models
{
    public class ProcedureLog
    {
        [Key]
        public int LogId { get; set; }
        public int ProcId { get; set; }
        public string LogText { get; set; }
        public string UserName { get; set; }
        public DateTime EventDate { get; set; }
        public string EventTime { get; set; }
    }
}
