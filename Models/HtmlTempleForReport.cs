using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIS.Models
{
    public class HtmlTempleForReport
    {
        public int Id { get; set; }
        public int RCId { get; set; }
        public string TemplateName { get; set; }
        public string TemplateContent { get; set; }
    }
}
