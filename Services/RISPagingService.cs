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
    public class RISPagingService
    {
        public async Task<int> GetItemCount(DateTime dateFrom, DateTime dateTo,int roleId, int tenantId, int consultantId ,string _status,string SearchFilter)
        {
            return await new RISService().GetAlldWorklistsCount(dateFrom, dateTo, roleId, tenantId, consultantId, _status, SearchFilter);
        }

        public async Task<int> GetCompletedItemCount(DateTime dateFrom, DateTime dateTo, int roleId, int tenantId, int consultantId, string _status, string SearchFilter)
        {
            return await new RISService().GetCompletedItemCount(dateFrom, dateTo, roleId, tenantId, consultantId, _status, SearchFilter);
        }

        public int GetPageCount(int totalItemCount, int pagePerItemCount)
        {
            if (pagePerItemCount == 0) return 0;

            return (totalItemCount % pagePerItemCount == 0)? totalItemCount/pagePerItemCount : totalItemCount/pagePerItemCount+1;
        }

        public async Task<List<VMRISWorklist>> GetOnePageItems(DateTime dateFrom, DateTime dateTo, int roleId, int tenantId, int consultantId, string _status, int PageNo, int RecsPerPage)
        {
            return await new RISService().GetOnePagedWorklists(dateFrom, dateTo, roleId, tenantId, consultantId, _status, PageNo, RecsPerPage);
        }

        public async Task<List<VMRISWorklist>> GetSearchFilterOnePageItems(DateTime dateFrom, DateTime dateTo, int roleId, int tenantId, int consultantId, string _status, string SearchFilter, int PageNo, int RecsPerPage)
        {
            return await new RISService().GetSearchFilterOnePageItems(dateFrom, dateTo, roleId, tenantId, consultantId, _status, SearchFilter, PageNo, RecsPerPage);
        }

        public async Task<List<VMRISWorklist>> GetCompletedFilterdOnePageItems(DateTime dateFrom, DateTime dateTo, int roleId, int tenantId, int consultantId, string _status, string SearchFilter, int PageNo, int RecsPerPage)
        {
            return await new RISService().GetCompletedFilterdOnePageItems(dateFrom, dateTo, roleId, tenantId, consultantId, _status, SearchFilter, PageNo, RecsPerPage);
        }


    }
}
