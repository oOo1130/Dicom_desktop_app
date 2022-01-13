using RIS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RIS.Controls
{
    public partial class ConsultantTemplateSearchControl : SearchResultListControl<HtmlTempleForReport>
    {
        protected override void FillListColumns(ListView view)
        {
            view.Width = 3500;
            ColumnHeader header1;

            header1 = new ColumnHeader();
            header1.Text = "Template Name";
            header1.TextAlign = HorizontalAlignment.Left;
            header1.Width = 500;

           

            view.Columns.Add(header1);
          
        }

        protected override void FillListViewItem(ListViewItem lvItem, HtmlTempleForReport item)
        {

            lvItem.Text = item.TemplateName;
            
        }

        protected override IList<HtmlTempleForReport> GetFilteredList(IList<HtmlTempleForReport> fullList, string filterstring)
        {
            if (fullList == null) return null;

            
            return fullList.Where(x => x.TemplateName.ToLower().StartsWith(filterstring.ToLower())).ToList();
        }

        protected override IList<HtmlTempleForReport> GetItems()
        {
            throw new NotImplementedException();
        }

        protected override IList<HtmlTempleForReport> GetItemsByType(string _type)
        {
            throw new NotImplementedException();
        }

        protected override IList<HtmlTempleForReport> GetItemsByTypeFromSuppliedList(string _type, List<HtmlTempleForReport> item)
        {
            string filterString = _type;
            return item.Where(x => x.TemplateName.ToLower().StartsWith(filterString.ToLower())).ToList();
        }
    }
}
