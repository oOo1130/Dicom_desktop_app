using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIS.Models.VWModels
{
    public class VMRISWorklist
    {
        [JsonProperty("ProcId")]
        public int ProcId { get; set; }
        [JsonProperty("PatientId")]
        public string PatientId { get; set; }
        [JsonProperty("AccessionNumber")]
        public string AccessionNumber { get; set; }
        [JsonProperty("StudyInstanceUid")]
        public string StudyInstanceUid { get; set; }
        [JsonProperty("PatientName")]
        public string PatientName { get; set; }
        [JsonProperty("PatientBirthdate")]
        public DateTime? PatientBirthdate { get; set; }
        [JsonProperty("PatientSex")]
        public string PatientSex { get; set; }
        [JsonProperty("ProcedureName")]
        public string ProcedureName { get; set; }
        [JsonProperty("NoOfImages")]
        public int? NoOfImages { get; set; }
        [JsonProperty("Modality")]
        public string Modality { get; set; }
        [JsonProperty("ArrivalDateTime")]
        public DateTime ArrivalDateTime { get; set; }
        [JsonProperty("OrderDateTime")]
        public DateTime? OrderDateTime { get; set; }
        [JsonProperty("ClinicalHistory")]
        public string ClinicalHistory { get; set; }
        [JsonProperty("ReferralPhysician")]
        public string ReferralPhysician { get; set; }
        [JsonProperty("TenantId")]
        public int TenantId { get; set; }
        [JsonProperty("ConsultantId")]
        public int ConsultantId { get; set; }
        [JsonProperty("Status")]
        public int Status { get; set; }
        [JsonProperty("StatusString")]
        public string StatusString { get; set; }
        [JsonProperty("HospitalName")]
        public string HospitalName { get; set; }
        [JsonProperty("ConsultantName")]
        public string ConsultantName { get; set; }
        [JsonProperty("ProcedureHISName")]
        public string ProcedureHISName { get; set; }
        [JsonProperty("DatasetId")]
        public int DatasetId { get; set; }
        [JsonProperty("SeriesDescription")]
        public string SeriesDescription { get; set; }
        [JsonProperty("StudyId")]
        public string StudyId { get; set; }
        [JsonProperty("StudyDate")]
        public DateTime? StudyDate { get; set; }
        [JsonProperty("SeriesDate")]
        public DateTime? SeriesDate { get; set; }
        [JsonProperty("SeriesNumber")]
        public string SeriesNumber { get; set; }
        [JsonProperty("SeriesInstanceUid")]
        public string SeriesInstanceUid { get; set; }
        [JsonProperty("SopInstanceUid")]
        public string SopInstanceUid { get; set; }
        [JsonProperty("SopClassUid")]
        public string SopClassUid { get; set; }
        [JsonProperty("InstanceNumber")]
        public string InstanceNumber { get; set; }
        [JsonProperty("InstanceDateTime")]
        public DateTime? InstanceDateTime { get; set; }
        [JsonProperty("DatasetPath")]
        public string DatasetPath { get; set; }

        public int? Share_Id { get; set; }

    }
}
