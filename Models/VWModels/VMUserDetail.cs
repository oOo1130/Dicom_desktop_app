using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIS.Models.VWModels
{
    public class VMUserDetail
    {
        public int UserId { get; set; }
        public string LoginName { get; set; }
        public string FullName { get; set; }
        public string MobileNo { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public int RCId { get; set; }  // If radiologist then his Id
        public int TenantId { get; set; }
        public string Status { get; set; }
        public string Comments { get; set; }

        public bool IsAssignToRadAllow { get; set; }
        public bool IsMainViewerAlloted { get; set; }
        public bool IsReportWriteAllow { get; set; }
        public bool IsReportViewAllow { get; set; }

    }
}
