using RIS.Models;
using RIS.Services;
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
    public partial class TemplateSearchControl : SearchResultListControl<ProcedureRadiologistTemplate>
    {
        protected override void FillListColumns(ListView view)
        {
            view.Width = 6500;
            ColumnHeader header1, header2;

            header2 = new ColumnHeader();
            header2.Text = "Template Name";
            header2.TextAlign = HorizontalAlignment.Left;
            header2.Width = 500;

        
            view.Columns.Add(header2);
        }

        protected override void FillListViewItem(ListViewItem lvItem, ProcedureRadiologistTemplate item)
        {
            lvItem.Text = item.TemplateName.ToString();
         
        }

        protected override IList<ProcedureRadiologistTemplate> GetFilteredList(IList<ProcedureRadiologistTemplate> fullList, string filterstring)
        {

            if (fullList == null) return null;

            int itemId;
            if (int.TryParse(filterstring, out itemId))
            {
                return fullList.Where(x => x.Id.ToString().Contains(filterstring)).ToList();
            }
            return fullList.Where(x => x.TemplateName.ToLower().Contains(filterstring.ToLower())).ToList();
        }

        protected override IList<ProcedureRadiologistTemplate> GetItems()
        {
            return new RISService().GetAllTemplate();
        }

        protected override IList<ProcedureRadiologistTemplate> GetItemsByType(string _radiologistId)
        {
            return new RISService().GetTemplateByRadiologist(_radiologistId);
        }

        protected override IList<ProcedureRadiologistTemplate> GetItemsByTypeFromSuppliedList(string _type, List<ProcedureRadiologistTemplate> item)
        {
            throw new NotImplementedException();
        }
    }
}
