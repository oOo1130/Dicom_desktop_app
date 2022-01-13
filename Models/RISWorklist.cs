using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIS.Models
{
    public class RISWorkList
    {
        [Key]
        public int ProcId { get; set; }
        public string PatientId { get; set; }
        public string StudyInstanceUid { get; set; }
        public string AccessionNumber { get; set; }
        public string PatientName { get; set; }
        public DateTime? PatientBirthdate { get; set; }
        public string PatientSex { get; set; }
        public string ProcedureName { get; set; }
        public int NoOfImages { get; set; }
        public string Modality { get; set; }
        public DateTime ArrivalDateTime { get; set; }
        public DateTime? OrderDateTime { get; set; }
        public string ClinicalHistory { get; set; }
        public string ReferralPhysician { get; set; }
        public int TenantId { get; set; }
        public int ConsultantId { get; set; }
        public int Status { get; set; }

        public int? Share_Id { get; set; }
    }
}
