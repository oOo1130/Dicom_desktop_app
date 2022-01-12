using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIS.Models
{
    public class HISProcedure
    {
        [Key]
        public int PId { get; set; }
        public string Modality { get; set; }
        public string ProcName { get; set; }
      
    }
}
