using RIS.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIS.Models
{
    public class DICOMServerDbContext : DbContext
    {
        public DICOMServerDbContext()
           : base("name=DBEntities")
        {
            //this.Configuration.LazyLoadingEnabled = false;
           // Database.SetInitializer<DICOMServerDbContext>(null);
            var adapter = (System.Data.Entity.Infrastructure.IObjectContextAdapter)this;
            var objectContext = adapter.ObjectContext;
            objectContext.CommandTimeout = 120; //2 minutes
        }


        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<ProjectMenu> ProjectMenus { get; set; }
        public virtual DbSet<MenuPermission> MenuPermissions { get; set; }
        public virtual DbSet<Modality> Modalities { get; set; }
        public virtual DbSet<HISProcedure> HISProcedures { get; set; }
        public virtual DbSet<HISModalityProcedureMapping> HISModalityProcedureMappings { get; set; }
        public virtual DbSet<ReportConsultant> ReportConsultants { get; set; }
        public virtual DbSet<AllowedModality> AllowedModalities { get; set; }

        public virtual DbSet<DatabaseDataset> DatabaseDatasets { get; set; }
        public virtual DbSet<RISWorkList> RISWorkLists { get; set; }
        public virtual DbSet<TenantDefaultConsultantMapping> TenantDefaultConsultantMappings { get; set; }
        public virtual DbSet<Tenant> Tenants { get; set; }
        public virtual DbSet<RemoteDicomNode> RemoteDicomNodes { get; set; }

        public virtual DbSet<ProcedureRadiologistTemplate> ProcedureRadiologistTemplates { get; set; }

        public virtual DbSet<RadiologistOpinionOne> RadiologistOpinionOnes { get; set; }
        public virtual DbSet<RadiologistOpinionTwo> RadiologistOpinionTwoes { get; set; }

        public virtual DbSet<ProcedureLog> ProcedureLogs { get; set; }
        public virtual DbSet<MasterTemplate> MasterTemplates { get; set; }

        public virtual DbSet<ProcedureStatus> ProcedureStatus { get; set; }

        public virtual DbSet<PrintPageSetup> PrintPageSetups { get; set; }
        
        public virtual DbSet<ReferralPhysician> ReferralPhysicians { get; set; }

        //For HTML Editor

        public virtual DbSet<ShortCutKey> ShortCutKeys { get; set; }
        public virtual DbSet<HtmlTempleForReport> HtmlTempleForReports { get; set; }
        
        public virtual DbSet<ConsultantOpinionOnStudy> ConsultantOpinionOnStudies { get; set; } //Report generated from Html editor will be saved here.

        //End of HTML Editor


    }
}
