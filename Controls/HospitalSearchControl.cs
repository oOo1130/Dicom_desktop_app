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
    public class HospitalSearchControl : SearchResultListControl<Tenant>
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
            header2.Text = "Hospital Name";
            header2.TextAlign = HorizontalAlignment.Left;
            header2.Width = 500;

            view.Columns.Add(header1);
            view.Columns.Add(header2);
        }

        protected override void FillListViewItem(System.Windows.Forms.ListViewItem lvItem, Tenant item)
        {
            lvItem.Text = item.TenantId.ToString();
            lvItem.SubItems.Add(item.Name);
        }

        protected override IList<Tenant> GetItems()
        {
            return new RISService().GetAllTenants();
        }

        protected override IList<Tenant> GetFilteredList(IList<Tenant> fullList, string filterstring)
        {

            if (fullList == null) return null;

            int itemId;
            if (int.TryParse(filterstring, out itemId))
            {
                return fullList.Where(x => x.TenantId.ToString().Contains(filterstring)).ToList();
            }
            return fullList.Where(x => x.Name.ToLower().Contains(filterstring.ToLower())).ToList();

        }

        protected override IList<Tenant> GetItemsByType(string _type)
        {
            throw new NotImplementedException();
        }

        protected override IList<Tenant> GetItemsByTypeFromSuppliedList(string _type, List<Tenant> item)
        {
            throw new NotImplementedException();
        }

       
    }
}
