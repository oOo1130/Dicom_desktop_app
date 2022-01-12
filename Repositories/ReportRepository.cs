using RIS.Models;
using RIS.Models.VWModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIS.Repositories
{
    public class ReportRepository
    {
        internal List<VMRadProcTemplate> GetTemplates(int rCId)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                try
                {
                    return context.Database.SqlQuery<VMRadProcTemplate>(@"SELECT        dbo.ProcedureRadiologistTemplates.Id, dbo.ProcedureRadiologistTemplates.PId, dbo.ProcedureRadiologistTemplates.RCId, dbo.ProcedureRadiologistTemplates.FileName, dbo.ProcedureRadiologistTemplates.TemplateName, 
                         dbo.ProcedureRadiologistTemplates.TemplateContent, dbo.HISProcedures.Modality, dbo.HISProcedures.ProcName AS ProcedureName
FROM            dbo.ProcedureRadiologistTemplates INNER JOIN
                         dbo.HISProcedures ON dbo.ProcedureRadiologistTemplates.PId = dbo.HISProcedures.PId Where dbo.ProcedureRadiologistTemplates.RCId=@RCId", new SqlParameter("@RCId", rCId)).ToList();
                }catch(Exception ex)
                {
                    return null;
                }
            }
        }

        internal ReportConsultant GetReportConsultant(int rCId)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                var item = context.ReportConsultants.Where(x => x.RCId == rCId).FirstOrDefault();

                return item;
            }
        }

        internal bool SaveDxDrCrReport(RadiologistOpinionOne newReport, bool isReportCompleted)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                try
                {
                    context.RadiologistOpinionOnes.Add(newReport);
                    context.SaveChanges();

                    if (isReportCompleted)
                    {
                        RISWorkList _workList = context.RISWorkLists.Where(x => x.ProcId == newReport.ProcId).FirstOrDefault();

                        _workList.Status = 6;
                        context.Entry(_workList).State = EntityState.Modified;
                        context.SaveChanges();
                    }

                    return true;

                }catch(Exception ex)
                {
                    return false;
                }
            }
        }

        internal bool UpdateDxDrCrReport(RadiologistOpinionOne existingReport, bool isReportCompleted)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                try
                {
                    context.Entry(existingReport).State = EntityState.Modified;
                    context.SaveChanges();

                    if (isReportCompleted)
                    {
                        RISWorkList _workList = context.RISWorkLists.Where(x => x.ProcId == existingReport.ProcId).FirstOrDefault();

                        _workList.Status = 6;
                        context.Entry(_workList).State = EntityState.Modified;
                        context.SaveChanges();
                    }

                    return true;

                }catch(Exception ex)
                {
                    return false;
                }
            }
        }

        internal void SaveShortCutKey(ShortCutKey key)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                context.ShortCutKeys.Add(key);
                context.SaveChanges();
            }
        }

        internal List<VMRISWorklist> LoadAllCompletedStudiesByBackgroundService(DateTime datefrm, DateTime dateto, int roleId, int tenantId, int consultantId, string status)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                try
                {
                    return context.Database.SqlQuery<VMRISWorklist>(@"Exec spGetCompletedWorklistItems @datefrm, @dateto, @roleId, @TenantId, @ConsultantId, @Status", new SqlParameter("@datefrm", datefrm), new SqlParameter("@dateto", dateto), new SqlParameter("@roleId", roleId), new SqlParameter("@TenantId", tenantId), new SqlParameter("@ConsultantId", consultantId), new SqlParameter("@Status", status)).ToList();

                }
                catch (Exception ex)
                {
                    return null;
                }



            }
        }

        internal bool SaveConsultantOpinionOnStudy(ConsultantOpinionOnStudy newReport)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                try
                {
                    context.ConsultantOpinionOnStudies.Add(newReport);
                    context.SaveChanges();


                    if (newReport.isReportComplete)
                    {
                        RISWorkList _workList = context.RISWorkLists.Where(x => x.ProcId == newReport.ProcId).FirstOrDefault();

                        _workList.Status = 6;
                        context.Entry(_workList).State = EntityState.Modified;
                        context.SaveChanges();
                    }


                    return true;

                }
                catch(Exception ex)
                {
                    return false;
                }

            }
        }

        internal bool UpdateConsultantOpinionOnStudy(ConsultantOpinionOnStudy existingOpinion, bool isReportCompleted)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                try
                {
                    context.Entry(existingOpinion).State = EntityState.Modified;
                    context.SaveChanges();

                    if (isReportCompleted)
                    {
                        RISWorkList _workList = context.RISWorkLists.Where(x => x.ProcId == existingOpinion.ProcId).FirstOrDefault();

                        _workList.Status = 6;
                        context.Entry(_workList).State = EntityState.Modified;
                        context.SaveChanges();
                    }

                    return true;

                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        internal ConsultantOpinionOnStudy GetReportConsultantOpinionOnStudy(int procId, int rCId)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                return context.ConsultantOpinionOnStudies.Where(x =>x.ProcId== procId && x.RCId == rCId ).FirstOrDefault();
            }
        }

        internal List<ShortCutKey> GetShortCutKeys(int rCId)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                return context.ShortCutKeys.Where(x => x.RCId == rCId).ToList();
            }
        }
        internal List<VMRISWorklist> LoadAllIncompleteStudiesByBackgroundService(DateTime datefrm, DateTime dateto, int roleId, int tenantId, int consultantId, string status)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                try
                {
                    return context.Database.SqlQuery<VMRISWorklist>(@"Exec spGetInCompleteWorklistItems @datefrm, @dateto, @roleId,@TenantId, @ConsultantId, @Status", new SqlParameter("@datefrm", datefrm), new SqlParameter("@dateto", dateto), new SqlParameter("@roleId", roleId), new SqlParameter("@TenantId", tenantId), new SqlParameter("@ConsultantId", consultantId), new SqlParameter("@Status", status)).ToList();

                }
                catch (Exception ex)
                {
                    return null;
                }



            }
        }

        internal bool SaveCTMRReport(RadiologistOpinionTwo newReport, bool isReportCompleted)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                try
                {
                    context.RadiologistOpinionTwoes.Add(newReport);
                    context.SaveChanges();

                   
                    if (isReportCompleted)
                    {
                        RISWorkList _workList = context.RISWorkLists.Where(x => x.ProcId == newReport.ProcId).FirstOrDefault();

                        _workList.Status = 6;
                        context.Entry(_workList).State = EntityState.Modified;
                        context.SaveChanges();
                    }


                    return true;

                }
                catch
                {
                    return false;
                }

            }
        }

        internal bool UpdateCTMRReport(RadiologistOpinionTwo existingOpinion, bool isReportCompleted)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                try
                {
                    context.Entry(existingOpinion).State = EntityState.Modified;
                    context.SaveChanges();

                    if (isReportCompleted)
                    {
                        RISWorkList _workList = context.RISWorkLists.Where(x => x.ProcId == existingOpinion.ProcId).FirstOrDefault();

                        _workList.Status = 6;
                        context.Entry(_workList).State = EntityState.Modified;
                        context.SaveChanges();
                    }

                    return true;

                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        internal RadiologistOpinionTwo CTMRExistingReportForThisConsultant(int procId, int consultantId)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                return context.RadiologistOpinionTwoes.Where(x => x.ProcId == procId && x.RCId == consultantId).FirstOrDefault();
            }
        }

        internal bool UpdateMasterTemplate(MasterTemplate template)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                context.Entry(template).State= EntityState.Modified;
                context.SaveChanges();
                return true;
            }
        }

        internal RadiologistOpinionOne DxRxCrExistingReportForThisConsultant(int procId, int consultantId)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
               return context.RadiologistOpinionOnes.Where(x=>x.ProcId== procId && x.RCId== consultantId).FirstOrDefault();

            }
        }

        internal MasterTemplate GetWordMasterTemplate()
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                var item = context.MasterTemplates.Where(x => x.Id == 1).FirstOrDefault();

                return item;
            }
        }

        internal ProcedureRadiologistTemplate GetWordTemplateContent(VMRISWorklist wlObj)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
               return context.ProcedureRadiologistTemplates.Where(x => x.RCId == wlObj.ConsultantId && x.PId== wlObj.ProcId).FirstOrDefault();

               
            }
        }

        internal MasterTemplate GetWordMasterTemplateContent()
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                var item = context.MasterTemplates.Where(x => x.Id == 1).FirstOrDefault();

                return item;
            }
        }

        internal bool SaveMasterTemplate(MasterTemplate template)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                try
                {
                    context.MasterTemplates.Add(template);
                    context.SaveChanges();


                    return true;

                }
                catch
                {
                    return false;
                }

            }
        }

        internal bool IsMatchedSecurityCode(string securityCode)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                try
                {
                    var item = context.MasterTemplates.Where(x => x.SecurityCode.Equals(securityCode)).FirstOrDefault();

                    if (item != null) return true;

                    return false;

                }
                catch
                {
                    return false;
                }

            }
        }
    }
}
