using RIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RIS.Models;

namespace RIS.Repository.ServiceObjects
{
    public class MenuCollection : List<ProjectMenu>
    {
        public bool IsMenuExists(string menuName)
        {
            return Exists(x => string.Compare(menuName, x.Name, true) == 0);
        }
    }
}
