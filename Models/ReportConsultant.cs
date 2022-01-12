using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIS.Models
{
    public class ReportConsultant
    {
        [Key]
        public int RCId { get; set; }
        public string Name { get; set; }
        public int? Fsize1 { get; set; } //
        public string IdentityLine1 { get; set; }
        public int? Fsize2 { get; set; }
        public string IdentityLine2 { get; set; }
        public int? Fsize3 { get; set; }
        public string IdentityLine3 { get; set; }
        public int? Fsize4 { get; set; }
        public string IdentityLine4 { get; set; }
        public int? Fsize5 { get; set; }
        public string IdentityLine5 { get; set; }
        public int? Fsize6 { get; set; }
        public string IdentityLine6 { get; set; }
        public int? Fsize7 { get; set; }
        public byte[] ESignature { get; set; }
        public bool IsESignatureAllow { get; set; }
        public string Status { get; set; }

        public string SignatureBase64HtmlEmbeded { get; set; }
        public bool IsViewerWithDefaultTemplate { get; set; }

        public string RadNextCloudID { get; set; }

        public string DicomImagePath { get; set; }

    }
}
