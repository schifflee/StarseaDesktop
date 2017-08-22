using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starsea.DataAnalyze.DB
{
    public class DataAnalyzeContext : DbContext
    {

        public DataAnalyzeContext()
            : base("name=OracleDbContext")
        {
           // Database.Initialize(false);
          //  Database.SetInitializer<DataAnalyzeContext>(new CreateDatabaseIfNotExists<DataAnalyzeContext>());
            

        }
        public virtual DbSet<DA_DBA_USERS> DA_DBA_USERS { get; set; }
        public virtual DbSet<DA_DBA_TABLES> DA_DBA_TABLES { get; set; }

        public virtual DbSet<DA_DBA_TAB_COLS> DA_DBA_TAB_COLS { get; set; }
        public virtual DbSet<DA_DBA_TAB_COMMENTS> DA_DBA_TAB_COMMENTS { get; set; }

        public virtual DbSet<DA_DBA_COL_COMMENTS> DA_DBA_COL_COMMENTS { get; set; }

        public virtual DbSet<TEST> TEST { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("DA");

            //modelBuilder.Entity<TEST>().ToTable("TEST");

            //modelBuilder.Entity<DA_DBA_TABLES>().ToTable("DA_DBA_TABLES");
            //modelBuilder.Entity<DA_DBA_TAB_COLS>().ToTable("DA_DBA_TAB_COLS");
            //modelBuilder.Entity<DA_DBA_TAB_COMMENTS>().ToTable("DA_DBA_TAB_COMMENTS");
            //modelBuilder.Entity<DA_DBA_COL_COMMENTS>().ToTable("DA_DBA_COL_COMMENTS");


            modelBuilder.Entity<TEST>().ToTable("TEST");

          // modelBuilder.Entity<DA_DBA_TABLES>();
          // modelBuilder.Entity<DA_DBA_TAB_COLS>();
          // modelBuilder.Entity<DA_DBA_TAB_COMMENTS>();
          //  modelBuilder.Entity<DA_DBA_COL_COMMENTS>();

            // modelBuilder.Entity<DA_DBA_TABLES>().("DA_DBA_TABLES");
        }

    }

    
}
