using OVIT.BDC.MiddleLabrary.Data.Model.SDE;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OVIT.BDC.MiddleLabrary.Data.DB
{
   public class SdeContext:DbContext
    {
        public SdeContext() : base("name=SdeDB") {

        }

        public virtual DbSet<ZRZ> ZRZ { get; set; }

        public virtual DbSet<LJZ> LJZ { get; set; }
        public virtual DbSet<C> C { get; set; }
        public virtual DbSet<H> H { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.HasDefaultSchema("SDE");
            

            modelBuilder.Entity<ZRZ>().ToTable("ZRZ");

            modelBuilder.Entity<LJZ>().ToTable("LJZ");

            modelBuilder.Entity<C>().ToTable("C");

            modelBuilder.Entity<H>().ToTable("H");

        }
    }
}
