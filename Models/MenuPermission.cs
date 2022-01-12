using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIS.Models
{
    [Table("MenuPermissions")]
    public class MenuPermission
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Role")]
        public int RoleId { get; set; }
        [ForeignKey("ProjectMenu")]
        public int MenuId { get; set; }
        public bool IsPermissionGranted { get; set; }
        public Role Role { get; set; }
        public ProjectMenu ProjectMenu { get; set; }
    }
}
