using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIS.Models
{
   public partial class DatabaseDataset
    {
        [Key]
        public int DatasetId { get; set; }
        public string PatientId { get; set; }
        public string PatientName { get; set; }
        public DateTime? PatientBirthdate { get; set; }
        public string PatientSex { get; set; }
        public string AccessionNumber { get; set; }
        public string StudyDescription { get; set; }
        public string SeriesDescription { get; set; }
        public string StudyId { get; set; }
        public DateTime? StudyDate { get; set; }
        public DateTime? SeriesDate { get; set; }
        public string Modality { get; set; }
        public string SeriesNumber { get; set; }
        public string StudyInstanceUid { get; set; }
        public string SeriesInstanceUid { get; set; }
        public string SopInstanceUid { get; set; }
        public string SopClassUid { get; set; }
        public string InstanceNumber { get; set; }
        public DateTime? InstanceDateTime { get; set; }
        public string DatasetPath { get; set; }
        public DateTime ReceptionDateTime { get; set; }
        public string ReceptionAet { get; set; }
        public int TenantId { get; set; }
       
    }
}
