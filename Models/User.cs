using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RIS.Models
{
    [Table("Users")]
public class User{
    [Key]
public int UserId { get; set; }
public string LoginName { get; set; }
public string FullName { get; set; }
public string MobileNo { get; set; }
public string Password { get; set; }
public string Salt { get; set; }
public int RoleId { get; set; }
public int RCId { get; set; }  // If radiologist then his Id
public int TenantId { get; set; }
public string Status { get; set; }

public string Comments { get; set; }
public string ReportCreateLocation { get; set; }
public bool IsAssignToRadAllow { get; set; }
public bool IsMainViewerAlloted { get; set; }
public bool IsReportWriteAllow { get; set; }
public bool IsReportViewAllow { get; set; }


    }
}