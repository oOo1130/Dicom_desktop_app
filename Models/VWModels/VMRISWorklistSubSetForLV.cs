using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIS.Models.VWModels
{
    public class VMRISWorklistSubSetForLV
    {

        public VMRISWorklistSubSetForLV(int _ProcId, string _PatientId, string _StatusString, string _PatientName, 
            string _ProcedureHISName, string _ProcedureName, string _ClinicalHistory, int? _NoOfImages, DateTime _ArrivalDateTime, 
            string _HospitalName,  string _Modality, string _ConsultantName, string _ReferralPhysician, DateTime? _OrderDateTime,
            string _StudyInstanceUid, int _tenantId,int _consultantId, int _status,DateTime? _PatientBirthdate, string _PatientSex) 
        {
            ProcId = _ProcId;
            PatientId = _PatientId;
            StatusString = _StatusString;
            PatientName = _PatientName;
            ProcedureHISName = _ProcedureHISName;
            ProcedureName = _ProcedureName;
            ClinicalHistory = _ClinicalHistory;
            NoOfImages = _NoOfImages;
            ArrivalDateTime = _ArrivalDateTime;
            HospitalName = _HospitalName;
            Modality = _Modality;
            ConsultantName = _ConsultantName;
            ReferralPhysician = _ReferralPhysician;
            OrderDateTime = _OrderDateTime;
            StudyInstanceUid = _StudyInstanceUid;
            TenantId = _tenantId;
            ConsultantId = _consultantId;
            Status = _status;
            PatientBirthdate = _PatientBirthdate;
            PatientSex = _PatientSex;

        }

        public int ProcId { get; set; }
        public string PatientId { get; set; }
        public string StatusString { get; set; }
        public string PatientName { get; set; }
        public string ProcedureHISName { get; set; }
        public string ProcedureName { get; set; }
        public string ClinicalHistory { get; set; }
        public int? NoOfImages { get; set; }
        public DateTime ArrivalDateTime { get; set; }
        public string HospitalName { get; set; }
        public string Modality { get; set; }
        public string ConsultantName { get; set; }
        public string ReferralPhysician { get; set; }
        public DateTime? OrderDateTime { get; set; }

        public int TenantId { get; set; }
        public string StudyInstanceUid { get; set; }
        public int ConsultantId { get; set; }

        public DateTime? PatientBirthdate { get; set; }
        public string PatientSex { get; set; }
        public int Status { get; set; }

    }
}
