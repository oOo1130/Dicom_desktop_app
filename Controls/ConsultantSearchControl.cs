using RIS.Models;
using RIS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RIS
{
    public class ConsultantSearchControl:SearchResultListControl<ReportConsultant>
    {
        protected override void FillListColumns(System.Windows.Forms.ListView view)
        {
            view.Width = 6500;
            ColumnHeader header1, header2;

            header1 = new ColumnHeader();
            header1.Text = "Id";
            header1.TextAlign = HorizontalAlignment.Left;
            header1.Width = 100;

            header2 = new ColumnHeader();
            header2.Text = "Consultant Name";
            header2.TextAlign = HorizontalAlignment.Left;
            header2.Width = 500;

            view.Columns.Add(header1);
            view.Columns.Add(header2);
        }

        protected override void FillListViewItem(System.Windows.Forms.ListViewItem lvItem, ReportConsultant item)
        {
            lvItem.Text = item.RCId.ToString();
            lvItem.SubItems.Add(item.Name);
        }

        protected override IList<ReportConsultant> GetItems()
        {
            return new RISService().GetReportConsultants();
        }

        protected override IList<ReportConsultant> GetFilteredList(IList<ReportConsultant> fullList, string filterstring)
        {

            if (fullList == null) return null;

            int itemId;
            if (int.TryParse(filterstring, out itemId))
            {
                return fullList.Where(x => x.RCId.ToString().Contains(filterstring)).ToList();
            }
            return fullList.Where(x => x.Name.ToLower().Contains(filterstring.ToLower())).ToList();

        }

        protected override IList<ReportConsultant> GetItemsByType(string _type)
        {
            throw new NotImplementedException();
        }

        protected override IList<ReportConsultant> GetItemsByTypeFromSuppliedList(string _type, List<ReportConsultant> item)
        {
            throw new NotImplementedException();
        }

       
    }
}
