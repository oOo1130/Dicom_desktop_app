using RIS.Models;
using RIS.Models.VWModels;
using RIS.Repositories;
using RIS.Repository.ServiceObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIS.Services
{
    public class RISService
    {
        public bool SaveOrUpdateReportConsultant(ReportConsultant consultant)
        {
            return new RISRepository().SaveOrUpdateReportConsultant(consultant);
        }

        internal List<ReportConsultant> GetReportConsultants()
        {
            return new RISRepository().GetReportConsultants();
        }

        internal async Task<int> GetAlldWorklistsCount(DateTime datefrm, DateTime dateto, int roleId, int TenantId, int ConsultantId, string status, string SearchFilter)
        {
            return await new RISRepository().GetAlldWorklistsCount(datefrm, dateto, roleId, TenantId, ConsultantId, status, SearchFilter);
        }

        internal async Task<int> GetCompletedItemCount(DateTime datefrm, DateTime dateto, int roleId, int TenantId, int ConsultantId, string status, string SearchFilter)
        {
            return await new RISRepository().GetCompletedItemCount(datefrm, dateto, roleId, TenantId, ConsultantId, status, SearchFilter);
        }


        internal async Task<List<VMRISWorklist>> GetOnePagedWorklists(DateTime datefrm, DateTime dateto, int roleId, int TenantId, int ConsultantId, string status, int PageNo, int RecsPerPage)
        {
            return await new RISRepository().GetOnePagedWorklists(datefrm, dateto, roleId, TenantId, ConsultantId, status, PageNo, RecsPerPage);
        }

        internal async Task<List<VMRISWorklist>> GetSearchFilterOnePageItems(DateTime datefrm, DateTime dateto, int roleId, int TenantId, int ConsultantId, string status, string SearchFilter, int PageNo, int RecsPerPage)
        {
            return await new RISRepository().GetSearchFilterOnePageItems(datefrm, dateto, roleId, TenantId, ConsultantId, status, SearchFilter, PageNo, RecsPerPage);
        }

        internal async Task<List<VMRISWorklist>> GetCompletedFilterdOnePageItems(DateTime datefrm, DateTime dateto, int roleId, int TenantId, int ConsultantId, string status, string SearchFilter, int PageNo, int RecsPerPage)
        {
            return await new RISRepository().GetCompletedFilterdOnePageItems(datefrm, dateto, roleId, TenantId, ConsultantId, status, SearchFilter, PageNo, RecsPerPage);
        }

        internal void DeleteExistingAllowedGroups(int rCId)
        {
            new RISRepository().DeleteExistingAllowedGroups(rCId);
        }

        internal RISWorkList GetWorkList(int procId)
        {
            return new RISRepository().GetWorkList(procId);
        }

        internal DataSet GetAllUnAssignedWorkDataSet()
        {
            return new RISRepository().GetAllUnAssignedWorkDataSet();
        }

        internal List<Modality> GetAllowedModalities()
        {
            return new RISRepository().GetAllowedModalities();
        }

        internal bool SaveHISProcedure(HISProcedure hisProc)
        {
            return new RISRepository().SaveHISProcedure(hisProc);
        }

        internal bool UpdateHISProcedure(HISProcedure hisProc)
        {
            return new RISRepository().UpdateHISProcedure(hisProc);
        }

        internal async Task<List<VMRISWorklist>> GetAlldWorklists(DateTime datefrm, DateTime dateto, int roleId, int TenantId, int ConsultantId, string status)
        {
             return await new RISRepository().GetAlldWorklists(datefrm, dateto, roleId, TenantId, ConsultantId, status);
        }

        internal List<ProcedureStatus> GetAllStatuses()
        {
            return new RISRepository().GetAllStatuses();
        }

        internal IList<HISProcedure> GetAllHISProcedure()
        {
            return new RISRepository().GetAllHISProcedure();
        }

        internal bool UpdateTenant(Tenant tnt)
        {
            return new RISRepository().UpdateTenant(tnt);
        }

        internal IList<ProcedureRadiologistTemplate> GetAllTemplate()
        {
            return new RISRepository().GetAllTemplate();
        }

        internal List<HISProcedure> GetHISProcedures(string modality)
        {
            return new RISRepository().GetHISProcedures(modality);
        }

        internal List<ProjectMenu> GetAllMenus()
        {
            return new RISRepository().GetAllMenus();
        }

        internal void SaveAllowedModalities(List<AllowedModality> rcMList)
        {
            new RISRepository().SaveAllowedModalities(rcMList);
        }

        internal IList<ProcedureRadiologistTemplate> GetTemplateByRadiologist(string radiologistId)
        {
            return new RISRepository().GetTemplateByRadiologist(radiologistId);
        }

        internal List<HtmlTempleForReport> GetHtmlTemplateForReport(int rCId)
        {
            return new RISRepository().GetHtmlTemplateForReport(rCId);
        }

        internal bool UpdateWorklist(RISWorkList wlObj)
        {
           return new RISRepository().UpdateWorklist(wlObj);
        }

        public bool CheckLogin(string userName, string password, out LoginUser user)
        {
            user = new RISRepository().GetUserByName(userName);
            if (user == null) return false;
            string passwordToCheck = HashGenerator.GenerateSlatedHash(password, user.Salt);
            bool isLoginOk = string.Compare(user.Password, passwordToCheck) == 0;
            if (!isLoginOk) return isLoginOk;
            new RISRepository().FillPermissionData(user);
            return isLoginOk;
        }

        internal HISModalityProcedureMapping GetHISModaliProcedureMapObj(int tenantId, int pId)
        {
            return new RISRepository().GetHISModaliProcedureMapObj(tenantId, pId);
        }

        internal async Task<List<RISWorkList>> GetIncompletedWorkList()
        {
            return await new RISRepository().GetIncompletedWorkList();
        }

        internal List<Tenant> GetAllTenants()
        {
            return new RISRepository().GetAllTenants();
        }

        internal bool SaveProcedure(HISModalityProcedureMapping procObj)
        {
            return new RISRepository().SaveProcedure(procObj);
        }

        internal User GetUserById(int userId)
        {
            return new RISRepository().GetUserById(userId);
        }

        internal User GetUserByConsultant(int consultantId)
        {
            return new RISRepository().GetUserByConsultant(consultantId);
        }

        internal async Task<List<VMRISWorklist>> GetCompletedWorklists(DateTime datefrm, DateTime dateto, int roleId, int tenantId, int consultantId, string status)
        {
            return await new RISRepository().GetCompletedWorklists(datefrm, dateto, roleId, tenantId, consultantId, status);
        }

        internal bool UpdateProcedure(HISModalityProcedureMapping upprocObj)
        {
            return new RISRepository().UpdateProcedure(upprocObj);
        }

        internal bool CreateRole(Role role)
        {
            return new RISRepository().CreateRole(role);
        }

        internal bool CreateTemplate(ProcedureRadiologistTemplate templatemap)
        {
            return new RISRepository().CreateTemplate(templatemap);
        }

        internal bool SaveTenant(Tenant tenant)
        {
            return new RISRepository().SaveTenant(tenant);
        }

        internal List<VMHISModalityProcedureMapping> GetAllHISModalityProcedures()
        {
            return new RISRepository().GetAllHISModalityProcedures();
        }

        public List<ProjectMenu> GetPermittedMenusByUser(int userId)
        {
            return new RISRepository().GetPermittedMenusByUser(userId);
        }

        internal Role GetRoleByName(string _roleName)
        {
            return new RISRepository().GetRoleByName(_roleName);
        }

        internal void SaveDefaultTenantRcMapping(List<TenantDefaultConsultantMapping> mapList)
        {
            new RISRepository().SaveDefaultTenantRcMapping(mapList);
        }

        internal void UpdateUser(User user)
        {
            new RISRepository().UpdateUser(user);
        }

        internal void GrantMenuPermission(List<int> selectedModules, int roleId)
        {
            new RISRepository().GrantMenuPermission(selectedModules, roleId);
        }

        internal List<AllowedModality> GetAllowedModalities(int rCId)
        {
            return new RISRepository().GetAllowedModalities(rCId);
        }

        internal RemoteDicomNode GetNodeWithSameAet(string aet)
        {
            return new RISRepository().GetNodeWithSameAet(aet);
        }

        internal bool CreateNewRemoteNode(RemoteDicomNode newNode)
        {
           return new RISRepository().CreateNewRemoteNode(newNode);
        }

        internal bool UpdateRemoteNode(RemoteDicomNode _node)
        {
            return new RISRepository().UpdateRemoteNode(_node);
        }

        internal List<VMRemoteDicomNode> GetAllRemoteDicomNodes()
        {
            return new RISRepository().GetAllRemoteDicomNodes();
        }

        internal bool IsLoginNameExists(string logiName)
        {
            return new RISRepository().IsLoginNameExists(logiName);
        }

        internal List<Role> GetRoles()
        {
            return new RISRepository().GetRoles();
        }

        internal int CreateUser(User user)
        {
            return new RISRepository().CreateUser(user);
        }

        internal bool MapUserWithRole(UserRole urole)
        {
            return new RISRepository().MapUserWithRole(urole);
        }

        internal IList<VMUserDetail> GetUserDetails()
        {
            return new RISRepository().GetUserDetails();
        }

        internal List<MenuPermission> GetPermittedMenusByRoleId(int roleId)
        {
            return new RISRepository().GetPermittedMenusByRoleId(roleId);
        }

        internal Tenant GetTenant(int tenantId)
        {
            return new RISRepository().GetTenant(tenantId);
        }

        internal List<VMTenantRadiologistMapping> GetTenantRCMappingList(int tenantId)
        {
            return new RISRepository().GetTenantRCMappingList(tenantId);
        }

        internal void DeleteTenantRcMapping(int Id)
        {
            new RISRepository().DeleteTenantRcMapping(Id);
        }

        internal ProcedureRadiologistTemplate GetWordTemplateContent(int templateId)
        {
             return new RISRepository().GetWordTemplateContent(templateId);
        }

        internal bool AssignedToRadiologist(List<RISWorkList> selectedWorklists)
        {
            return new RISRepository().AssignedToRadiologist(selectedWorklists);
        }

        internal async Task<List<VMRISWorklist>> GetCompletedWorklistsUsingHtmlEditor(DateTime datefrm, DateTime dateto, int roleId, int tenantId, int consultantId, string status)
        {
            return await new RISRepository().GetCompletedWorklistsUsingHtmlEditor(datefrm, dateto, roleId, tenantId, consultantId, status);
        }

        internal bool SaveHtmlReportTemplate(HtmlTempleForReport template)
        {
            return new RISRepository().SaveHtmlReportTemplate(template);
        }
    }
}
