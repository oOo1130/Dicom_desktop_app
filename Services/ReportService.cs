using RIS.Models;
using RIS.Models.VWModels;
using RIS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIS.Services
{
    public class ReportService
    {
        internal List<VMRadProcTemplate> GetTemplates(int rCId)
        {
            return new ReportRepository().GetTemplates(rCId);
        }

        public bool IsMatchedSecurityCode(string securityCode)
        {
            return new ReportRepository().IsMatchedSecurityCode(securityCode);
        }

        internal bool SaveMasterTemplate(MasterTemplate template)
        {
            return new ReportRepository().SaveMasterTemplate(template);
        }

        internal MasterTemplate GetWordMasterTemplateContent()
        {
            return new ReportRepository().GetWordMasterTemplateContent();
        }

        internal ProcedureRadiologistTemplate GetWordTemplateContent(VMRISWorklist wlObj)
        {
            return new ReportRepository().GetWordTemplateContent(wlObj);
        }

        internal ReportConsultant GetReportConsultant(int rCId)
        {
            return new ReportRepository().GetReportConsultant(rCId);
        }

        internal MasterTemplate GetWordMasterTemplate()
        {
            return new ReportRepository().GetWordMasterTemplate();
        }

        internal bool UpdateMasterTemplate(MasterTemplate template)
        {
            return new ReportRepository().UpdateMasterTemplate(template);
        }

      
        internal bool SaveDxDrCrReport(RadiologistOpinionOne newReport, bool isReportCompleted)
        {
            return new ReportRepository().SaveDxDrCrReport(newReport, isReportCompleted);
        }

        internal RadiologistOpinionOne DxRxCrExistingReportForThisConsultant(int procId, int consultantId)
        {
            return new ReportRepository().DxRxCrExistingReportForThisConsultant(procId, consultantId);
        }

        internal bool UpdateDxDrCrReport(RadiologistOpinionOne _existingOpinion, bool isReportCompleted)
        {
            return new ReportRepository().UpdateDxDrCrReport(_existingOpinion, isReportCompleted);
        }

        internal RadiologistOpinionTwo CTMRExistingReportForThisConsultant(int procId, int consultantId)
        {
            return new ReportRepository().CTMRExistingReportForThisConsultant(procId, consultantId);
        }

        internal bool UpdateCTMRReport(RadiologistOpinionTwo existingOpinion,bool isReportCompleted)
        {
            return new ReportRepository().UpdateCTMRReport(existingOpinion, isReportCompleted);
        }

        internal bool SaveCTMRReport(RadiologistOpinionTwo newReport, bool isReportCompleted)
        {
            return new ReportRepository().SaveCTMRReport(newReport, isReportCompleted);
        }

        internal List<VMRISWorklist> LoadAllIncompleteStudiesByBackgroundService(DateTime datefrm, DateTime dateto, int roleId, int tenantId, int consultantId, string status)
        {
            return new ReportRepository().LoadAllIncompleteStudiesByBackgroundService(datefrm, dateto, roleId, tenantId, consultantId, status);
        }

        internal void SaveShortCutKey(ShortCutKey key)
        {
            new ReportRepository().SaveShortCutKey(key);
        }

        internal List<VMRISWorklist> LoadAllCompletedStudiesByBackgroundService(DateTime datefrm, DateTime dateto, int roleId, int tenantId, int consultantId, string status)
        {
            return new ReportRepository().LoadAllCompletedStudiesByBackgroundService(datefrm, dateto, roleId, tenantId, consultantId, status);
        }

        internal List<ShortCutKey> GetShortCutKeys(int rCId)
        {
            return new ReportRepository().GetShortCutKeys(rCId);
        }

        internal ConsultantOpinionOnStudy GetReportConsultantOpinionOnStudy(int procId, int rCId)
        {
            return new ReportRepository().GetReportConsultantOpinionOnStudy(procId, rCId);
        }

        internal bool UpdateConsultantOpinionOnStudy(ConsultantOpinionOnStudy existingOpinion, bool isReportCompleted)
        {
            return new ReportRepository().UpdateConsultantOpinionOnStudy(existingOpinion, isReportCompleted);
        }

        internal bool SaveConsultantOpinionOnStudy(ConsultantOpinionOnStudy newReport)
        {
            return new ReportRepository().SaveConsultantOpinionOnStudy(newReport);
        }
    }
}
