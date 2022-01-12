using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  RIS.Repository.ServiceObjects
{
    public class LoginUser
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string RoleName { get; set; }

        public string ReportCreateLocation { get; set; }


        public bool IsAssignToRadAllow { get; set; }
        public bool IsMainViewerAlloted { get; set; }
        public bool IsReportWriteAllow { get; set; }
        public bool IsReportViewAllow { get; set; }

        public MenuCollection Menus { get; set; }

        public LoginUser()
        {
           
            Menus = new MenuCollection();
        }
    }
}
