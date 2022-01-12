using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIS.Models
{
    public class MasterTemplate
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public byte[] TemplateContent { get; set; }
        public string HtmlContent { get; set; }
        public string SecurityCode { get; set; }
    }
}
