using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIS.Models
{
    public class HtmlTemplate
    {
        public int Id { get; set; }
        public int RCId { get; set; }
        public string snippetname { get; set; }
        public string snippettext { get; set; }
    }
}
