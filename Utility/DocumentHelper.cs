using RIS.Models;
using RIS.Models.VWModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace RIS.Utility
{
    public class DocumentHelper
    {
        const float SIGNATURE_HEIGHT = 50F;

        public static Dictionary<string, string> PatientToTemplateDictionary(VMRISWorklistSubSetForLV patient, ReportConsultant consultant) =>
            new Dictionary<string, string>()
            {
                ["Report_Type"] = "DEPARTMENT OF RADIOLOGY & IMAGING",
                ["Id_No"] = patient?.PatientId,
                ["Patient_Name"] = patient?.PatientName,
                ["Patient_Age"] = GetAgeFromDob(patient?.PatientBirthdate,patient.ArrivalDateTime),
                ["Received_date"] = patient?.ArrivalDateTime.ToString(),
                ["Report_Date"] = patient?.ArrivalDateTime.ToString(),
                ["Patient_Sex"] = patient?.PatientSex,
                ["Refd_By"] = patient?.ReferralPhysician,

                ["DOCTOR_NAME"] = consultant?.Name,
                ["IDENTITY_LINE1"] = consultant?.IdentityLine1,
                ["IDENTITY_LINE2"] = consultant?.IdentityLine2,
                ["IDENTITY_LINE3"] = consultant?.IdentityLine3,
                ["IDENTITY_LINE4"] = consultant?.IdentityLine4,
                ["IDENTITY_LINE5"] = consultant?.IdentityLine5

            };


        public static string GetAgeFromDob(DateTime? patientBirthdate,DateTime studyArrivalDate)
        {

            if (patientBirthdate == null) { return ""; }

            DateTime _todaydate = studyArrivalDate;
            int Years = new DateTime(_todaydate.Subtract(patientBirthdate.GetValueOrDefault()).Ticks).Year - 1;
            DateTime PastYearDate = patientBirthdate.GetValueOrDefault().AddYears(Years);
            int Months = 0;
            for (int i = 1; i <= 12; i++)
            {
                if (PastYearDate.AddMonths(i) == _todaydate)
                {
                    Months = i;
                    break;
                }
                else if (PastYearDate.AddMonths(i) >= _todaydate)
                {
                    Months = i - 1;
                    break;
                }
            }
            int Days = _todaydate.Subtract(PastYearDate.AddMonths(Months)).Days;
            //int Hours = Now.Subtract(PastYearDate).Hours;
            //int Minutes = Now.Subtract(PastYearDate).Minutes;
            //int Seconds = Now.Subtract(PastYearDate).Seconds;
            return String.Format("{0}Y {1}M {2}D",
            Years, Months, Days);

        }


        public static Dictionary<string, DocumentLib.Image> SignatureToTemplateDictionary(MemoryStream ms) =>
            new Dictionary<string, DocumentLib.Image>()
            {
                ["Signature"] = new DocumentLib.Image(bytes: ms?.ToArray(), height: SIGNATURE_HEIGHT),
            };
    }
}
