using RIS.Models;
using RIS.Models.VWModels;
using RIS.Repository.ServiceObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace RIS.Services
{
    public class RISAPIConsumerService
    {
        private string _baseUrl = "http://localhost:5100/api/Riswork/";
        //private string _baseUrl = "http://115.69.214.82/api/Riswork/";

        private HttpClient client;
        private string _idval = "";

        public RISAPIConsumerService()
        {

        }

        public async Task<int> GetIncompleteItemCount(DateTime dateFrom, DateTime dateTo, int roleId, int tenantId, int consultantId, string _status, string SearchFilter)
        {
            using (client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                string strGetItemCountApiCall;
                if (SearchFilter == "")
                    strGetItemCountApiCall = $"_dateFrom={dateFrom}&_dateTo={dateTo}&roleId={roleId}&tenantId={tenantId}&consultantId={consultantId}&_status={_status}";
                else
                    strGetItemCountApiCall = $"_dateFrom={dateFrom}&_dateTo={dateTo}&roleId={roleId}&tenantId={tenantId}&consultantId={consultantId}&_status={_status}&SearchFilter={SearchFilter}";

                HttpResponseMessage response = await client.GetAsync("GetIncompleteItemCount?" + strGetItemCountApiCall);
                if (response.IsSuccessStatusCode)
                {
                    int Departmentdepartment = await response.Content.ReadAsAsync<int>();
                    return Departmentdepartment;
                }
                else
                {
                    return 0;
                }
            }


        }

        public async Task<int> GetIncompleteUserCount(string GroupName, string SearchFilter)
        {
            using (client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                string strGetUSerCountApiCall;
                if (GroupName == "")
                    strGetUSerCountApiCall = $"SearchFilter&{SearchFilter}";
                else
                    strGetUSerCountApiCall = $"GroupName={GroupName}&SearchFilter&{SearchFilter}";

                HttpResponseMessage response = await client.GetAsync("GetUserCount?" + strGetUSerCountApiCall);
                if (response.IsSuccessStatusCode)
                {
                    int Departmentdepartment = await response.Content.ReadAsAsync<int>();
                    return Departmentdepartment;
                }
                else
                {
                    return 0;
                }
            }


        }

        internal async Task<bool> UpdateHtmlTempalate(HtmlTempleForReport template)
        {
            using (client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.PostAsJsonAsync<HtmlTempleForReport>("UpdateHtmlTempalate", template);
                if (response.IsSuccessStatusCode)
                {

                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        internal async Task<List<ReferralPhysician>> GetTenantPhysicianList(int tenantId)
        {
            using (client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync("GetTenantPhysicianList?TenantId=" + tenantId);
                if (response.IsSuccessStatusCode)
                {
                    List<ReferralPhysician> _phylist = await response.Content.ReadAsAsync<List<ReferralPhysician>>();
                    return _phylist;
                }
                else
                {
                    return null;
                }
            }
        }

        internal async Task<bool> SaveNewHtmlTempalate(HtmlTempleForReport templateObj)
        {
            using (client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.PostAsJsonAsync<HtmlTempleForReport>("SaveNewHtmlTempalate", templateObj);
                if (response.IsSuccessStatusCode)
                {
                    //DateTime resultDate = await response.Content.ReadAsAsync<DateTime>();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        internal async Task<List<ShortCutKey>> GetShortCutKeys(int rCId)
        {
            using (client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync("GetShortcutKeyList?ConsultantId=" + rCId);
                if (response.IsSuccessStatusCode)
                {
                    List<ShortCutKey> _shortcutkeyList = await response.Content.ReadAsAsync<List<ShortCutKey>>();
                    return _shortcutkeyList;
                }
                else
                {
                    return null;
                }
            }
        }

        internal async Task<RISWorkList> GetWorkList(int procId)
        {
            HttpClient client;
            using (client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync("GetRISWorklist?ProcId=" + procId);
                if (response.IsSuccessStatusCode)
                {
                    RISWorkList _worklist = await response.Content.ReadAsAsync<RISWorkList>();
                    return _worklist;
                }
                else
                {
                    return null;
                }
            }
        }

        public int GetPageCount(int totalItemCount, int pagePerItemCount)
        {
            return (totalItemCount % pagePerItemCount == 0) ? totalItemCount / pagePerItemCount : totalItemCount / pagePerItemCount + 1;
        }

        internal async Task<bool> DeleteHtmlTemplate(HtmlTempleForReport template)
        {

            using (client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.PostAsJsonAsync<HtmlTempleForReport>("DeleteHtmlTemplate", template);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }


        }

        public async Task<List<VMRISWorklist>> GetOnePageItems(DateTime dateFrom, DateTime dateTo, int roleId, int tenantId, int consultantId, string _status, int PageNo, int RecsPerPage)
        {
            using (client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                string strGetOnepageItemApiCall;


                strGetOnepageItemApiCall = $"_dateFrom={dateFrom}&_dateTo={dateTo}&roleId={roleId}&tenantId={tenantId}&consultantId={consultantId}&_status={_status}&PageNo={PageNo}&RecsPerPage={RecsPerPage}";
                //_dateFrom=2021%2F10%2F1&_dateTo=2021%2F11%2F28&roleId=1&tenantId=1&consultantId=1&_status=All&PageNo=1&RecsPerPage=1

                HttpResponseMessage response = await client.GetAsync("GetOnePageItems?" + strGetOnepageItemApiCall);
                if (response.IsSuccessStatusCode)
                {
                    List<VMRISWorklist> OnePageItems = await response.Content.ReadAsAsync<List<VMRISWorklist>>();
                    return OnePageItems;
                }
                else
                {
                    return null;
                }
            }

        }

        internal async Task<LoginUser> CheckLoginAsync(string userName, string password)
        {
            HttpClient client;
            using (client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync("CheckLogin?userName=" + userName + "&password=" + password);
                if (response.IsSuccessStatusCode)
                {
                    LoginUser _loggeduser = await response.Content.ReadAsAsync<LoginUser>();
                    return _loggeduser;
                }
                else
                {
                    return null;
                }
            }
        }

        internal async Task<bool> AddToReferral(ReferralPhysician physician)
        {

            using (client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.PostAsJsonAsync<ReferralPhysician>("AddToReferral", physician);

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        internal async Task<User> GetUserById(int userId)
        {
            HttpClient client;
            using (client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync("GetUserById?userId=" + userId);
                if (response.IsSuccessStatusCode)
                {
                    User _user = await response.Content.ReadAsAsync<User>();
                    return _user;
                }
                else
                {
                    return null;
                }
            }
        }

        public async Task<List<VMRISWorklistSubSetForLV>> GetSearchFilterIncompleteOnePageItems(DateTime dateFrom, DateTime dateTo, int roleId, int tenantId, int consultantId, string _status, string SearchFilter, int PageNo, int RecsPerPage)
        {
            using (client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                string strGetSearchFilterOnepageItemApiCall;

                if (SearchFilter == "")
                {
                    strGetSearchFilterOnepageItemApiCall = $"_dateFrom={dateFrom}&_dateTo={dateTo}&roleId={roleId}&tenantId={tenantId}&consultantId={consultantId}&_status={_status}&PageNo={PageNo}&RecsPerPage={RecsPerPage}";

                }
                else
                {
                    strGetSearchFilterOnepageItemApiCall = $"_dateFrom={dateFrom}&_dateTo={dateTo}&roleId={roleId}&tenantId={tenantId}&consultantId={consultantId}&_status={_status}&SearchFilter={SearchFilter}&PageNo={PageNo}&RecsPerPage={RecsPerPage}";

                }
                //_dateFrom=2021%2F10%2F1&_dateTo=2021%2F11%2F28&roleId=1&tenantId=1&consultantId=1&_status=All&PageNo=1&RecsPerPage=1

                HttpResponseMessage response = await client.GetAsync("GetSearchFilterIncompleteOnePageItems?" + strGetSearchFilterOnepageItemApiCall);
                if (response.IsSuccessStatusCode)
                {
                    List<VMRISWorklistSubSetForLV> OnePageItems = await response.Content.ReadAsAsync<List<VMRISWorklistSubSetForLV>>();
                    return OnePageItems;
                }
                else
                {
                    return null;
                }
            }

        }

        public async Task<List<VWNextCloudUser>> GetSearchFilterOnePageUserItems(string GroupName, string SearchFilter, int PageNo, int RecsPerPage)
        {
            using (client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                string strGetSearchFilterOnepageItemApiCall;

                //if (SearchFilter == "")
                //{
                //    strGetSearchFilterOnepageItemApiCall = $"PageNo={PageNo}&RecsPerPage={RecsPerPage}";

                //}
                //else if(GroupName == "")
                //{
                //    strGetSearchFilterOnepageItemApiCall = $"SearchFilter={SearchFilter}&PageNo={PageNo}&RecsPerPage={RecsPerPage}";

                //}
                //else
                //{
                //    strGetSearchFilterOnepageItemApiCall = $"GroupName={GroupName}&SearchFilter={SearchFilter}&PageNo={PageNo}&RecsPerPage={RecsPerPage}";

                //}
                //_dateFrom=2021%2F10%2F1&_dateTo=2021%2F11%2F28&roleId=1&tenantId=1&consultantId=1&_status=All&PageNo=1&RecsPerPage=1

                strGetSearchFilterOnepageItemApiCall = $"GroupName={GroupName}&SearchFilter={SearchFilter}&PageNo={PageNo}&RecsPerPage={RecsPerPage}";


                HttpResponseMessage response = await client.GetAsync("GetSearchFilterIncompleteOnePageUserItems?" + strGetSearchFilterOnepageItemApiCall);
                if (response.IsSuccessStatusCode)
                {
                    List<VWNextCloudUser> OnePageItems = await response.Content.ReadAsAsync<List<VWNextCloudUser>>();
                    return OnePageItems;
                }
                else
                {
                    return null;
                }
            }

        }


        internal async Task<bool> UpdateWorklist(RISWorkList wlObj)
        {
            using (client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.PostAsJsonAsync<RISWorkList>("UpdateRISWorklist", wlObj);
                if (response.IsSuccessStatusCode)
                {

                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        internal async Task<bool> AssignedToRadiologistAPICall(List<SelectedProcedureForAssign> selectedWorklists)
        {

            using (client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.PostAsJsonAsync<List<SelectedProcedureForAssign>>("AssignedToRadiologist", selectedWorklists);
                if (response.IsSuccessStatusCode)
                {

                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        internal async Task<bool> AssignedToUserAPICall(string fileName, string userName)
        {
            using (client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                string GetFileNameUserName = $"fileName={fileName}&userName={userName}";

                HttpResponseMessage response = await client.GetAsync("AssignedToUser?" + GetFileNameUserName);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        internal async Task<bool> CancelAssignedToRadiologistAPICall(List<SelectedProcedureForAssign> selectedWorklists)
        {

            using (client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.PostAsJsonAsync<List<SelectedProcedureForAssign>>("CancelAssignedToRadiologist", selectedWorklists);
                if (response.IsSuccessStatusCode)
                {

                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        internal async Task<bool> CancelAssignedToUser(int shareId)
        {

            using (client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync("CancelAssignedToUser?shareId=" + shareId);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        internal async Task<List<VMUserDetail>> GetUserDetails()
        {
            using (client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync("GetUserDetails");
                if (response.IsSuccessStatusCode)
                {
                    List<VMUserDetail> _userList = await response.Content.ReadAsAsync<List<VMUserDetail>>();
                    return _userList;
                }
                else
                {
                    return null;
                }
            }
        }

        internal async Task<List<HtmlTempleForReport>> GetHtmlTemplateForReport(int rCId)
        {
            using (client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync("GetHtmlTemplateForReport?ConsultantId=" + rCId);
                if (response.IsSuccessStatusCode)
                {
                    List<HtmlTempleForReport> _templates = await response.Content.ReadAsAsync<List<HtmlTempleForReport>>();
                    return _templates;
                }
                else
                {
                    return null;
                }
            }
        }

        internal async Task<IDictionary<string, string>> GetMacroList(int RCId)
        {
            using (client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync("GetTextMacrosList?ConsultantId=" + RCId);
                if (response.IsSuccessStatusCode)
                {
                    Dictionary<string, string> _d = await response.Content.ReadAsAsync<Dictionary<string, string>>();
                    return _d;
                }
                else
                {
                    return null;
                }
            }
        }

        internal async Task<ReportConsultant> GetReportConsultant(int consultantId)
        {
            using (client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync("GetReportConsultant?ConsultantId=" + consultantId);
                if (response.IsSuccessStatusCode)
                {
                    ReportConsultant _consultant = await response.Content.ReadAsAsync<ReportConsultant>();
                    return _consultant;
                }
                else
                {
                    return null;
                }
            }
        }

        public async Task<DateTime> GetServerDateAndTimeAPICallFuncAsync()
        {
            HttpClient client;
            using (client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync("GetServerDateTime");
                if (response.IsSuccessStatusCode)
                {
                    DateTime resultDate = await response.Content.ReadAsAsync<DateTime>();
                    return resultDate;
                }
                else
                {
                    return DateTime.Now;
                }
            }
        }

        internal async Task<MasterTemplate> GetWordMasterTemplateContent()
        {
            using (client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync("GetMasterTemplate");
                if (response.IsSuccessStatusCode)
                {
                    MasterTemplate _mtemplate = await response.Content.ReadAsAsync<MasterTemplate>();
                    return _mtemplate;
                }
                else
                {
                    return null;
                }
            }
        }

        internal async Task<bool> SaveConsultantOpinionOnStudy(ConsultantOpinionOnStudy newReport)
        {
            using (client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.PostAsJsonAsync<ConsultantOpinionOnStudy>("SaveConsultantStudyOpinions", newReport);
                if (response.IsSuccessStatusCode)
                {
                    //DateTime resultDate = await response.Content.ReadAsAsync<DateTime>();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        internal async Task<ConsultantOpinionOnStudy> GetReportConsultantOpinionOnStudy(int procId, int consultantId)
        {
            using (client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync("GetReportConsultantOpinionOnStudy?ProcTd=" + procId + "&ConsultantId=" + consultantId);
                if (response.IsSuccessStatusCode)
                {
                    ConsultantOpinionOnStudy _opinion = await response.Content.ReadAsAsync<ConsultantOpinionOnStudy>();
                    return _opinion;
                }
                else
                {
                    return null;
                }
            }
        }

        internal async Task<bool> UpdateConsultantOpinionOnStudy(ConsultantOpinionOnStudy existingOpinion)
        {
            using (client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.PostAsJsonAsync<ConsultantOpinionOnStudy>("UpdateConsultantOpinionOnStudy", existingOpinion);
                if (response.IsSuccessStatusCode)
                {
                    //DateTime resultDate = await response.Content.ReadAsAsync<DateTime>();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        internal async Task<int> GetCompletedItemCount(DateTime dateFrom, DateTime dateTo, int roleId, int tenantId, int consultantId, string _status, string SearchFilter)
        {
            using (client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                string strGetItemCountApiCall;
                if (SearchFilter == "")
                    strGetItemCountApiCall = $"_dateFrom={dateFrom}&_dateTo={dateTo}&roleId={roleId}&tenantId={tenantId}&consultantId={consultantId}&_status={_status}";
                else
                    strGetItemCountApiCall = $"_dateFrom={dateFrom}&_dateTo={dateTo}&roleId={roleId}&tenantId={tenantId}&consultantId={consultantId}&_status={_status}&SearchFilter={SearchFilter}";

                HttpResponseMessage response = await client.GetAsync("GetCompletedItemCount?" + strGetItemCountApiCall);
                if (response.IsSuccessStatusCode)
                {
                    int Departmentdepartment = await response.Content.ReadAsAsync<int>();
                    return Departmentdepartment;
                }
                else
                {
                    return 0;
                }
            }

        }

        internal async Task<List<VMRISWorklistSubSetForLV>> GetSearchFilterCompleteOnePageItems(DateTime dateFrom, DateTime dateTo, int roleId, int tenantId, int consultantId, string _status, string SearchFilter, int PageNo, int RecsPerPage)
        {
            using (client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                string strGetSearchFilterOnepageItemApiCall;

                if (SearchFilter == "")
                {
                    strGetSearchFilterOnepageItemApiCall = $"_dateFrom={dateFrom}&_dateTo={dateTo}&roleId={roleId}&tenantId={tenantId}&consultantId={consultantId}&_status={_status}&PageNo={PageNo}&RecsPerPage={RecsPerPage}";

                }
                else
                {
                    strGetSearchFilterOnepageItemApiCall = $"_dateFrom={dateFrom}&_dateTo={dateTo}&roleId={roleId}&tenantId={tenantId}&consultantId={consultantId}&_status={_status}&SearchFilter={SearchFilter}&PageNo={PageNo}&RecsPerPage={RecsPerPage}";

                }
                //_dateFrom=2021%2F10%2F1&_dateTo=2021%2F11%2F28&roleId=1&tenantId=1&consultantId=1&_status=All&PageNo=1&RecsPerPage=1

                HttpResponseMessage response = await client.GetAsync("GetSearchFilterCompletedOnePageItems?" + strGetSearchFilterOnepageItemApiCall);
                if (response.IsSuccessStatusCode)
                {
                    List<VMRISWorklistSubSetForLV> OnePageItems = await response.Content.ReadAsAsync<List<VMRISWorklistSubSetForLV>>();
                    return OnePageItems;
                }
                else
                {
                    return null;
                }
            }
        }

        internal async Task<List<VMReportConsultant>> GetReportConsultants()
        {
            using (client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync("GetAllRadiologists");
                if (response.IsSuccessStatusCode)
                {
                    List<VMReportConsultant> _consultants = await response.Content.ReadAsAsync<List<VMReportConsultant>>();
                    return _consultants;
                }
                else
                {
                    return null;
                }
            }
        }


        internal async Task<bool> AddEditRadiologistAPICall(ReportConsultant _consultant)
        {

            using (client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.PostAsJsonAsync<ReportConsultant>("AddEditRadiologist", _consultant);

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
        internal async Task<bool> DeleteExistingAllowedGroupsAPICall(int RCId)
        {

            using (client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.PostAsJsonAsync<int>("DeleteExistingAllowedGroups", RCId);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        internal async Task<bool> UpdateTemplate(VMUpdateTemplate template)
        {
            using (client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.PostAsJsonAsync<VMUpdateTemplate>("UpdateHtmlTemplate", template);

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        internal async Task<bool> UpdateProcedureStatus(VMProcIdAndStatus Procstatus)
        {
            using (client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.PostAsJsonAsync<VMProcIdAndStatus>("UpdateProcedureStatus", Procstatus);

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        internal async Task<List<string>> GetGroupName()
        {
            HttpClient client;
            using (client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync("GetGroupName");
                //string jsonStr = Task.Run(async () => await response.Content.ReadAsStringAsync()).GetAwaiter().GetResult();
                if (response.IsSuccessStatusCode)
                {
                    List<string> _grouplist = await response.Content.ReadAsAsync<List<string>>();

                    return _grouplist;
                }
                else
                {
                    return null;
                }
            }
        }

        internal async void SetGroupName()
        {
            HttpClient client;
            using (client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Accept.Clear(); 
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync("SetGroupName");
                //string jsonStr = Task.Run(async () => await response.Content.ReadAsStringAsync()).GetAwaiter().GetResult();
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Set Groupname");
                }
            }
        }

        internal async Task<List<string>> GetUserName()
        {
            HttpClient client;
            using (client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync("GetUserName");
                //string jsonStr = Task.Run(async () => await response.Content.ReadAsStringAsync()).GetAwaiter().GetResult();
                if (response.IsSuccessStatusCode)
                {
                    List<string> _userlist = await response.Content.ReadAsAsync<List<string>>();
                    return _userlist;
                }
                else
                {
                    return null;
                }
            }
        }

        internal async Task<string> GetGroupNameOfUser(string user)
        {
            HttpClient client;
            using (client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync("GetGroupNameOfUser?user=" + user);
                //string jsonStr = Task.Run(async () => await response.Content.ReadAsStringAsync()).GetAwaiter().GetResult();
                if (response.IsSuccessStatusCode)
                {
                    string _groupName = await response.Content.ReadAsAsync<string>();

                    return _groupName;
                }
                else
                {
                    return null;
                }
            }
        }

        internal async Task<List<OcsResponse>> GetUserInfo()
        {
            HttpClient client;
            using (client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync("GetUserInfo");
                //string jsonStr = Task.Run(async () => await response.Content.ReadAsStringAsync()).GetAwaiter().GetResult();
                if (response.IsSuccessStatusCode)
                {
                    List<OcsResponse> _userInfo = await response.Content.ReadAsAsync<List<OcsResponse>>();
                    return _userInfo;
                }
                else
                {
                    return null;
                }
            }
        }

        internal async Task<List<string>> GetUserNameOfGroup(string groupName)
        {
            HttpClient client;
            using (client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync("GetUserNameOfGroup?groupName=" + groupName);
                //string jsonStr = Task.Run(async () => await response.Content.ReadAsStringAsync()).GetAwaiter().GetResult();
                if (response.IsSuccessStatusCode)
                {
                    List<string> _userlist = await response.Content.ReadAsAsync<List<string>>();
                    return _userlist;
                }
                else
                {
                    return null;
                }
            }
        }

        internal async Task<string> GetFilePathFromName(string fileName)
        {
            HttpClient client;
            using (client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync("GetFilePathFromName?fileName=" + fileName);
                //string jsonStr = Task.Run(async () => await response.Content.ReadAsStringAsync()).GetAwaiter().GetResult();
                if (response.IsSuccessStatusCode)
                {
                    string filePath = await response.Content.ReadAsAsync<string>();
                    return filePath;
                }
                else
                {
                    return null;
                }
            }
        }


    }
        

    
}
