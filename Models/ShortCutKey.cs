using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIS.Models
{
    public class ShortCutKey
    {
        public int Id { get; set; }
        public int RCId { get; set; }
        public string textmacro { get; set; }
        public string expandedtext { get; set; }
    }
}
