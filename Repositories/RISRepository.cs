using RIS.Models;
using RIS.Models.VWModels;
using RIS.Repository.ServiceObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIS.Repositories
{
    public class RISRepository
    {
        string sql = string.Empty;


        internal bool SaveOrUpdateReportConsultant(ReportConsultant consultant)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                try
                {
                    if (consultant.RCId > 0)
                    {
                        context.Entry(consultant).State=EntityState.Modified;
                        context.SaveChanges();
                    }
                    else
                    {
                        context.ReportConsultants.Add(consultant);
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

        internal async Task<int> GetAlldWorklistsCount(DateTime datefrm, DateTime dateto, int roleId, int TenantId, int ConsultantId, string status, string SearchFilter)
        {
            return await Task.Run(() =>
            {

                using (DICOMServerDbContext context = new DICOMServerDbContext())
                {
                    try
                    {
                        var resList = context.Database.SqlQuery<int>(@"Exec spGetInCompleteWorklistItems_Cnt @datefrm, @dateto, @roleId,@TenantId, @ConsultantId, @Status,@SearchFilter", new SqlParameter("@datefrm", datefrm), new SqlParameter("@dateto", dateto), new SqlParameter("@roleId", roleId), new SqlParameter("@TenantId", TenantId), new SqlParameter("@ConsultantId", ConsultantId), new SqlParameter("@Status", status), new SqlParameter("@SearchFilter", SearchFilter)).ToList();
                        return resList[0];

                    }
                    catch (Exception ex)
                    {
                        return -1;
                    }



                }
            });

        }


        internal async Task<int> GetCompletedItemCount(DateTime datefrm, DateTime dateto, int roleId, int TenantId, int ConsultantId, string status, string SearchFilter)
        {
            return await Task.Run(() =>
            {

                using (DICOMServerDbContext context = new DICOMServerDbContext())
                {
                    try
                    {
                        var resList = context.Database.SqlQuery<int>(@"Exec spGetCompletedWorklistItems_Cnt @datefrm, @dateto, @roleId,@TenantId, @ConsultantId, @Status,@SearchFilter", new SqlParameter("@datefrm", datefrm), new SqlParameter("@dateto", dateto), new SqlParameter("@roleId", roleId), new SqlParameter("@TenantId", TenantId), new SqlParameter("@ConsultantId", ConsultantId), new SqlParameter("@Status", status), new SqlParameter("@SearchFilter", SearchFilter)).ToList();

                        return resList[0];

                    }
                    catch (Exception ex)
                    {
                        return -1;
                    }



                }
            });

        }

        internal async Task<List<VMRISWorklist>> GetOnePagedWorklists(DateTime datefrm, DateTime dateto, int roleId, int TenantId, int ConsultantId, string status, int PageNo, int RecsPerPage)
        {
            return await Task.Run(() =>
            {

                using (DICOMServerDbContext context = new DICOMServerDbContext())
                {
                    try
                    {
                        return context.Database.SqlQuery<VMRISWorklist>(@"Exec spGetInCompleteWorklistItems @datefrm, @dateto, @roleId,@TenantId, @ConsultantId, @Status, @PageNo,  @RecsPerPage", new SqlParameter("@datefrm", datefrm), new SqlParameter("@dateto", dateto), new SqlParameter("@roleId", roleId), new SqlParameter("@TenantId", TenantId), new SqlParameter("@ConsultantId", ConsultantId), new SqlParameter("@Status", status), new SqlParameter("@PageNo", PageNo), new SqlParameter("@RecsPerPage", RecsPerPage)).ToList();

                    }
                    catch (Exception ex)
                    {
                        return null;
                    }



                }

            });
        }


        internal async Task<List<VMRISWorklist>> GetSearchFilterOnePageItems(DateTime datefrm, DateTime dateto, int roleId, int TenantId, int ConsultantId, string status, string SearchFilter, int PageNo, int RecsPerPage)
        {
            return await Task.Run(() =>
            {

                using (DICOMServerDbContext context = new DICOMServerDbContext())
                {
                    try
                    {
                        return context.Database.SqlQuery<VMRISWorklist>(@"Exec spGetInCompleteWorklistItems @datefrm, @dateto, @roleId,@TenantId, @ConsultantId, @Status, @SearchFilter, @PageNo,  @RecsPerPage", new SqlParameter("@datefrm", datefrm), new SqlParameter("@dateto", dateto), new SqlParameter("@roleId", roleId), new SqlParameter("@TenantId", TenantId), new SqlParameter("@ConsultantId", ConsultantId), new SqlParameter("@Status", status), new SqlParameter("@SearchFilter", SearchFilter), new SqlParameter("@PageNo", PageNo), new SqlParameter("@RecsPerPage", RecsPerPage)).ToList();

                    }
                    catch (Exception ex)
                    {
                        return null;
                    }



                }

            });
        }


        internal async Task<List<VMRISWorklist>> GetCompletedFilterdOnePageItems(DateTime datefrm, DateTime dateto, int roleId, int TenantId, int ConsultantId, string status, string SearchFilter, int PageNo, int RecsPerPage)
        {
            return await Task.Run(() =>
            {

                using (DICOMServerDbContext context = new DICOMServerDbContext())
                {
                    try
                    {
                        return context.Database.SqlQuery<VMRISWorklist>(@"Exec spGetCompletedWorklistItems @datefrm, @dateto, @roleId,@TenantId, @ConsultantId, @Status, @SearchFilter, @PageNo,  @RecsPerPage", new SqlParameter("@datefrm", datefrm), new SqlParameter("@dateto", dateto), new SqlParameter("@roleId", roleId), new SqlParameter("@TenantId", TenantId), new SqlParameter("@ConsultantId", ConsultantId), new SqlParameter("@Status", status), new SqlParameter("@SearchFilter", SearchFilter), new SqlParameter("@PageNo", PageNo), new SqlParameter("@RecsPerPage", RecsPerPage)).ToList();

                    }
                    catch (Exception ex)
                    {
                        return null;
                    }



                }

            });
        }


        internal RISWorkList GetWorkList(int procId)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                return context.RISWorkLists.Where(x => x.ProcId == procId).FirstOrDefault();
            }
        }

        internal bool UpdateHISProcedure(HISProcedure hisProc)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                try
                {
                    context.Entry(hisProc).State=EntityState.Modified;
                    context.SaveChanges();
                    return true;

                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        internal List<ProcedureStatus> GetAllStatuses()
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                return context.ProcedureStatus.ToList();
            }
        }

        internal IList<HISProcedure> GetAllHISProcedure()
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                return context.HISProcedures.ToList();
            }
        }
        internal bool SaveHISProcedure(HISProcedure hisProc)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                try
                {
                    context.HISProcedures.Add(hisProc);
                    context.SaveChanges();
                    return true;

                }catch(Exception ex)
                {
                    return false;
                }
            }
        }

        internal DataSet GetAllUnAssignedWorkDataSet()
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                DataTable dataTable = new DataTable();
                DbConnection connection = context.Database.Connection;
                DbProviderFactory dbFactory = DbProviderFactories.GetFactory(connection);
                using (var cmd = dbFactory.CreateCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"Select wl.*, t.Name as HospitalName,p.HISProcDescription as    ProcedureHISName,rc.Name as ConsultantName from RISWorkLists wl inner
                      join Tenants t on wl.TenantId = t.TenantId Left
                      join [Procedures] p on UPPER(wl.ProcedureName) = UPPER(p.ModalityProcDescription)
                      Left Join ReportConsultants rc on wl.ConsultantId = rc.RCId where UPPER(wl.Status)= 'UNASSIGNED'";
                  
                    using (DbDataAdapter adapter = dbFactory.CreateDataAdapter())
                    {
                        adapter.SelectCommand = cmd;
                        adapter.Fill(dataTable);
                    }
                }

                DataSet ds = new DataSet();
                ds.Tables.Add(dataTable);
                return ds;
            }
        }

        internal List<HtmlTempleForReport> GetHtmlTemplateForReport(int rCId)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                return context.HtmlTempleForReports.Where(x => x.RCId == rCId).ToList();
            }
        }

        internal HISModalityProcedureMapping GetHISModaliProcedureMapObj(int tenantId, int pId)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                return context.HISModalityProcedureMappings.Where(x => x.TenantId==tenantId && x.PId== pId).FirstOrDefault();
            }
        }

        internal List<HISProcedure> GetHISProcedures(string modality)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                return context.HISProcedures.Where(x=>x.Modality.ToUpper().Equals(modality.ToUpper())).ToList();
            }
        }

        internal async Task<List<VMRISWorklist>> GetCompletedWorklists(DateTime datefrm, DateTime dateto, int roleId, int tenantId, int consultantId, string status)
        {

            return await Task.Run(() =>
            {
                using (DICOMServerDbContext context = new DICOMServerDbContext())
                {
                    try
                    {
                        return context.Database.SqlQuery<VMRISWorklist>(@"Exec spGetCompletedWorklistItems @datefrm, @dateto, @roleId,@TenantId, @ConsultantId, @Status", new SqlParameter("@datefrm", datefrm.Date), new SqlParameter("@dateto", dateto.Date), new SqlParameter("@roleId", roleId), new SqlParameter("@TenantId", tenantId), new SqlParameter("@ConsultantId", consultantId), new SqlParameter("@Status", status)).ToList();

                    }
                    catch (Exception ex)
                    {
                        return null;
                    }



                }

            });
        }

        internal IList<ProcedureRadiologistTemplate> GetAllTemplate()
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
              return context.ProcedureRadiologistTemplates.ToList();
            }
        }

        internal async Task<List<RISWorkList>> GetIncompletedWorkList()
        {
           
                return await Task.Run(() => {

                    using (DICOMServerDbContext context = new DICOMServerDbContext())
                    {
                       return context.RISWorkLists.ToList();
                        
                     }
                    
                });
            }
      

        internal IList<ProcedureRadiologistTemplate> GetTemplateByRadiologist(string radiologistId)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                int _rcId = 0; int.TryParse(radiologistId, out _rcId);
                return context.ProcedureRadiologistTemplates.Where(x => x.RCId == _rcId).ToList();
            }
        }
        internal bool UpdateWorklist(RISWorkList wlObj)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                try
                {
                    context.Entry(wlObj).State = EntityState.Modified;
                    context.SaveChanges();
                    return true;

                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        internal bool UpdateTenant(Tenant tnt)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                try
                {
                    context.Entry(tnt).State = EntityState.Modified;
                    context.SaveChanges();
                    return true;

                }catch(Exception ex)
                {
                    return false;
                }
            }
        }

        internal bool CreateTemplate(ProcedureRadiologistTemplate templatemap)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                try
                {
                    context.ProcedureRadiologistTemplates.Add(templatemap);
                    context.SaveChanges();
                    return true;

                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        internal async Task<List<VMRISWorklist>>  GetAlldWorklists(DateTime datefrm, DateTime dateto, int roleId, int TenantId, int ConsultantId, string status)
        {
            return await Task.Run(() =>
            {

                using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                try
                {
                    return context.Database.SqlQuery<VMRISWorklist>(@"Exec spGetInCompleteWorklistItems @datefrm, @dateto, @roleId,@TenantId, @ConsultantId, @Status", new SqlParameter("@datefrm", datefrm), new SqlParameter("@dateto", dateto),new SqlParameter("@roleId", roleId), new SqlParameter("@TenantId", TenantId), new SqlParameter("@ConsultantId", ConsultantId), new SqlParameter("@Status", status)).ToList();

                }catch(Exception ex)
                {
                    return null;
                }



            }

            });
        }

        internal async Task<List<VMRISWorklist>> GetCompletedWorklistsUsingHtmlEditor(DateTime datefrm, DateTime dateto, int roleId, int tenantId, int consultantId, string status)
        {
            return await Task.Run(() =>
            {
                using (DICOMServerDbContext context = new DICOMServerDbContext())
                {
                    try
                    {
                        return context.Database.SqlQuery<VMRISWorklist>(@"Exec spGetCompletedWorklistItemsUsingHtmlEditor @datefrm, @dateto, @roleId,@TenantId, @ConsultantId, @Status", new SqlParameter("@datefrm", datefrm.Date), new SqlParameter("@dateto", dateto.Date), new SqlParameter("@roleId", roleId), new SqlParameter("@TenantId", tenantId), new SqlParameter("@ConsultantId", consultantId), new SqlParameter("@Status", status)).ToList();

                    }
                    catch (Exception ex)
                    {
                        return null;
                    }



                }

            });
        }

        internal bool SaveHtmlReportTemplate(HtmlTempleForReport template)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                try
                {
                    context.HtmlTempleForReports.Add(template);
                    context.SaveChanges();
                    return true;
                }catch(Exception ex)
                {
                    return false;
                }
            }
        }

        internal void SaveDefaultTenantRcMapping(List<TenantDefaultConsultantMapping> mapList)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                 context.TenantDefaultConsultantMappings.AddRange(mapList);
                 context.SaveChanges();
            }
        }

        internal List<Modality> GetAllowedModalities()
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                return  context.Modalities.ToList();
            }
        }

        internal void DeleteExistingAllowedGroups(int rCId)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                context.Database.ExecuteSqlCommand(@"Delete from AllowedModalities Where RCId={0}", new object[] { rCId });

            }
        }

        internal List<ReportConsultant> GetReportConsultants()
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                return  context.ReportConsultants.ToList();
                
            }
        }

        internal void SaveAllowedModalities(List<AllowedModality> rcMList)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                context.AllowedModalities.AddRange(rcMList);
                context.SaveChanges();
            }
        }

        internal bool AssignedToRadiologist(List<RISWorkList> selectedWorklists)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                try
                {
                    foreach (var item in selectedWorklists)
                    {
                        context.Entry(item).State = EntityState.Modified;
                        context.SaveChanges();
                    }
                    return true;

                }catch(Exception ex)
                {
                    return false;
                }
            }
        }

        internal ProcedureRadiologistTemplate GetWordTemplateContent(int templateId)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                return context.ProcedureRadiologistTemplates.Where(x=>x.Id== templateId).FirstOrDefault();
               
            }
        }

        internal bool SaveProcedure(HISModalityProcedureMapping procObj)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                try
                {
                    context.HISModalityProcedureMappings.Add(procObj);
                    context.SaveChanges();
                    return true;
                }catch(Exception ex)
                {
                    return false;
                }
            }
        }

        internal void DeleteTenantRcMapping(int id)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                context.Database.ExecuteSqlCommand(@"Delete from TenantDefaultConsultantMappings Where Id={0}", new object[] { id });
            }
        }
        internal List<VMTenantRadiologistMapping> GetTenantRCMappingList(int tenantId)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                try
                {
                    return context.Database.SqlQuery<VMTenantRadiologistMapping>(@"Select tds.Id, t.TenantId,t.Name, rc.RCId, rc.Name as ConsultantName,tds.Modality from Tenants t Left join TenantDefaultConsultantMappings tds on t.TenantId=tds.TenantId Left Join ReportConsultants rc on tds.RCId=rc.RCId  where t.TenantId=@tenantId", new SqlParameter("@tenantId", tenantId)).ToList();
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }

        internal bool UpdateProcedure(HISModalityProcedureMapping upprocObj)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                try
                {
                     context.Entry(upprocObj).State=EntityState.Modified;
                     context.SaveChanges();
                     return true;
                }
                catch(Exception ex)
                {
                    return false;
                }
            }
        }

        internal Tenant GetTenant(int tenantId)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                return context.Tenants.Where(x=>x.TenantId== tenantId).FirstOrDefault();
            }
        }

        internal List<Tenant> GetAllTenants()
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
               return context.Tenants.ToList();
            }
        }

        internal List<VMHISModalityProcedureMapping> GetAllHISModalityProcedures()
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                return context.Database.SqlQuery<VMHISModalityProcedureMapping>(@"SELECT        dbo.HISModalityProcedureMappings.*, dbo.Tenants.Name as HospitalName, dbo.HISProcedures.ProcName as HISProcedureName,dbo.HISProcedures.Modality 
FROM            dbo.HISModalityProcedureMappings INNER JOIN
                         dbo.Tenants ON dbo.HISModalityProcedureMappings.TenantId = dbo.Tenants.TenantId INNER JOIN
                         dbo.HISProcedures ON dbo.HISModalityProcedureMappings.PId = dbo.HISProcedures.PId").ToList();
            }
        }

        internal bool CreateRole(Role role)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                try
                {
                    context.Roles.Add(role);
                    context.SaveChanges();
                    return true;

                }catch(Exception ex)
                {
                    return false;
                }
            }
        }

        internal Role GetRoleByName(string roleName)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                return context.Roles.Where(x => x.Name.ToUpper() == roleName.ToUpper()).FirstOrDefault();
            }
        }

        internal void GrantMenuPermission(List<int> selectedModules, int roleId)
        {
            List<MenuPermission> _permissionList = new List<MenuPermission>();
            foreach (int _menuId in selectedModules)
            {
                MenuPermission _mp = new MenuPermission();
                _mp.MenuId = _menuId;
                _mp.RoleId = roleId;
                _mp.IsPermissionGranted = true;
               
                _permissionList.Add(_mp);
            }

            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                context.Database.ExecuteSqlCommand(@"Delete from MenuPermissions Where RoleId={0}", new object[] { roleId });

                context.MenuPermissions.AddRange(_permissionList);
                context.SaveChanges();
            }
        }

        internal User GetUserByConsultant(int consultantId)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                return context.Users.Where(x => x.RCId == consultantId).FirstOrDefault();
            }
        }

        internal User GetUserById(int userId)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                return context.Users.Where(x=>x.UserId== userId).FirstOrDefault();
            }
        }

        internal void UpdateUser(User user)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                 context.Entry(user).State=EntityState.Modified;
                 context.SaveChanges();
            }
        }

        internal List<MenuPermission> GetPermittedMenusByRoleId(int roleId)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                return context.MenuPermissions.Where(x => x.RoleId == roleId).ToList();
            }
        }

        internal bool SaveTenant(Tenant tenant)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                try
                {
                    context.Tenants.Add(tenant);
                    context.SaveChanges();
                    return true;

                }catch(Exception ex)
                {
                    return false;
                }
            }
        }

        internal bool CreateNewRemoteNode(RemoteDicomNode newNode)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                try
                {
                    context.RemoteDicomNodes.Add(newNode);
                    context.SaveChanges();
                    return true;
                }catch(Exception ex)
                {
                    return false;
                }
            }
        }

        internal int CreateUser(User user)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
               context.Users.Add(user);
                context.SaveChanges();
                return user.UserId;
            }
        }

        internal IList<VMUserDetail> GetUserDetails()
        {

            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
               return context.Database.SqlQuery<VMUserDetail>(@"Select u.UserId,u.LoginName,u.FullName,u.MobileNo,u.RoleId,r.Name as RoleName,u.RCId,u.TenantId,u.Status,u.Comments,u.IsAssignToRadAllow,u.IsMainViewerAlloted,u.IsReportWriteAllow,u.IsReportViewAllow from Users u Join Roles r on u.RoleId = r.RoleId").ToList();
              
            }
        }

        internal bool MapUserWithRole(UserRole urole)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                context.UserRoles.Add(urole);
                context.SaveChanges();
                return true;
            }
        }

        internal bool IsLoginNameExists(string logiName)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
               User _user = context.Users.Where(x=>x.LoginName.ToUpper().Equals(logiName.ToUpper())).FirstOrDefault();

                if (_user == null) return false;

                return true;
            }
        }

        internal List<Role> GetRoles()
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                return context.Roles.ToList(); ;
            }
        }

        internal List<VMRemoteDicomNode> GetAllRemoteDicomNodes()
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                return context.Database.SqlQuery<VMRemoteDicomNode>(@"Select n.*,t.TenantId,t.Name as TenantName from RemoteDicomNodes n join Tenants t on n.TenantId=t.TenantId").ToList(); ;
            }
        }
        internal bool UpdateRemoteNode(RemoteDicomNode _node)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                try
                {
                    context.Entry(_node).State = EntityState.Modified;
                    context.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        internal RemoteDicomNode GetNodeWithSameAet(string aet)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                return context.RemoteDicomNodes.Where(x => x.NodeAet.ToUpper().Equals(aet)).FirstOrDefault();
            }
        }
        public LoginUser GetUserByName(string userName)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                try
                {

                    var anom = context.Users.Select(s => new
                    {
                        s.UserId,
                        Name = s.LoginName,
                        s.Password,
                        s.RoleId,
                        s.Salt,
                        s.IsAssignToRadAllow,
                        s.IsReportViewAllow,
                        s.IsReportWriteAllow,
                        s.IsMainViewerAlloted,
                        s.ReportCreateLocation
                    }
                        ).Where(x => string.Compare(x.Name, userName, true) == 0 && !string.IsNullOrEmpty(x.Name)).FirstOrDefault();

                    if (anom == null) return null;

                    Role role = GetRoleById(anom.RoleId);

                    return new LoginUser()
                    {
                        UserId = anom.UserId,
                        RoleId = anom.RoleId,
                        Name = anom.Name,
                        Password = anom.Password,
                        Salt = anom.Salt,
                        RoleName = role.Name,
                        IsAssignToRadAllow=anom.IsAssignToRadAllow,
                        IsReportViewAllow=anom.IsReportViewAllow,
                        IsReportWriteAllow=anom.IsReportWriteAllow,
                        IsMainViewerAlloted=anom.IsMainViewerAlloted,
                        ReportCreateLocation = anom.ReportCreateLocation
                    };

                }catch(Exception ex)
                {
                    return null;
                }
            }
        }

        internal List<AllowedModality> GetAllowedModalities(int rCId)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                return context.AllowedModalities.Where(x => x.RCId == rCId).ToList();
            }
        }

        internal List<ProjectMenu> GetPermittedMenusByUser(int userId)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                sql = string.Format(@"Select * from ProjectMenus Where MenuId in (select  m.MenuId from ProjectMenus m join  MenuPermissions mp on  m.MenuId=mp.MenuId
                   join UserRoles r on mp.RoleId=r.RoleId  where  m.IsActive=1 and   r.UserId={0})", userId);
               
                return context.ProjectMenus.SqlQuery(sql).ToList();
            }
        }

        private Role GetRoleById(int _roleId)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                return context.Roles.Where(x => x.RoleId == _roleId).FirstOrDefault();
            }
        }

        public void FillPermissionData(LoginUser user)
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
               
                var menus = context.ProjectMenus.SqlQuery(@"SELECT pm.* FROM [dbo].[Roles] r INNER JOIN [dbo].[MenuPermissions] mp ON r.RoleId = mp.RoleId 
                     INNER JOIN ProjectMenus pm on mp.MenuId = pm.MenuId where r.RoleId = @p0", user.RoleId).ToList();

                menus.ForEach(x => user.Menus.Add(x));
                
               
            }
        }

        internal List<ProjectMenu> GetAllMenus()
        {
            using (DICOMServerDbContext context = new DICOMServerDbContext())
            {
                return context.ProjectMenus.ToList();
            }
        }
    }
}
