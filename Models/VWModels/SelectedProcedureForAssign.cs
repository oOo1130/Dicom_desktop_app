using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIS.Models.VWModels
{
    public class SelectedProcedureForAssign
    {
        public int ProcId { get; set; }
        public int ConsultantID { get; set; }
        public int Status { get; set; }
        [StringLength(50)]
        public string RadNextCloudID { get; set; }
    }
}
