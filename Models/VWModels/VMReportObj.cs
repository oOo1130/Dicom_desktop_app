using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIS.Models.VWModels
{
    public class VMReportObj
    {
        public List<VMRISWorklistSubSetForLV> Studies { get; set; }
        public string ViewerExecutablePath { get; set; }
        public string NetworkRootPath { get; set; }
        public string WordfilePath { get; set; }
        public bool isReportWindowAllowed { get; set; }
        public bool isMainViewerAlloted { get; set; }
        public VMRISWorklistSubSetForLV vmRISWorkList { get; set; }
        public string ReportFileNameWithPath { get; set; }
        public string ReportFilePath { get; set; }
        public DateTime OpinionDateTime { get; set; }
        public List<HtmlTempleForReport> htmlTemplates { get; set; }
        public User user { get; set; }
        public ReportConsultant ReportConsultant { get; set; }
        public byte[]  MsWord_masteremplatecontent { get; set; }
        public string Html_masteremplatecontent { get; set; }
        public bool IsEditWillSave { get; set; }
        public ConsultantOpinionOnStudy ConsultantOpinionOnStudy { get; set; } // Report generated from Html Editor
        public Dictionary<string,string> macroDictionary { get; set; }
    }
}
