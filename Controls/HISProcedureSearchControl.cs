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
    public partial class HISProcedureSearchControl : SearchResultListControl<HISProcedure>
    {
        protected override void FillListColumns(ListView view)
        {
            view.Width = 6500;
            ColumnHeader header1, header2;

            header1 = new ColumnHeader();
            header1.Text = "Procedure Name";
            header1.TextAlign = HorizontalAlignment.Left;
            header1.Width = 500;

            header2 = new ColumnHeader();
            header2.Text = "Modality";
            header2.TextAlign = HorizontalAlignment.Left;
            header2.Width = 100;

            view.Columns.Add(header1);
            view.Columns.Add(header2);
        }

        protected override void FillListViewItem(ListViewItem lvItem, HISProcedure item)
        {
            lvItem.Text = item.ProcName.ToString();
            lvItem.SubItems.Add(item.Modality);
        }

        protected override IList<HISProcedure> GetFilteredList(IList<HISProcedure> fullList, string filterstring)
        {
            if (fullList == null) return null;

            int itemId;
            if (int.TryParse(filterstring, out itemId))
            {
                return fullList.Where(x => x.PId.ToString().Contains(filterstring)).ToList();
            }
            return fullList.Where(x => x.ProcName.ToLower().Contains(filterstring.ToLower())).ToList();
        }

        protected override IList<HISProcedure> GetItems()
        {
            return new RISService().GetAllHISProcedure();
        }

        protected override IList<HISProcedure> GetItemsByType(string _type)
        {
            throw new NotImplementedException();
        }

        protected override IList<HISProcedure> GetItemsByTypeFromSuppliedList(string _type, List<HISProcedure> item)
        {
            throw new NotImplementedException();
        }
    }
}
