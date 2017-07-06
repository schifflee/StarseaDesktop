namespace Starsea.DB
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model3 : DbContext
    {
        public Model3()
            : base("name=Model3")
        {
        }

        public virtual DbSet<BASE_ACCOUNT> BASE_ACCOUNT { get; set; }
        public virtual DbSet<BlogArticles> BlogArticles { get; set; }
        public virtual DbSet<Blogs> Blogs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BASE_ACCOUNT>()
                .Property(e => e.ID)
                .IsFixedLength();

            modelBuilder.Entity<BASE_ACCOUNT>()
                .Property(e => e.ACCOUNT)
                .IsFixedLength();

            modelBuilder.Entity<BASE_ACCOUNT>()
                .Property(e => e.PASSWORD)
                .IsFixedLength();

            modelBuilder.Entity<BASE_ACCOUNT>()
                .Property(e => e.PERSONNAME)
                .IsFixedLength();

            modelBuilder.Entity<BASE_ACCOUNT>()
                .Property(e => e.AGE)
                .HasPrecision(2, 0);

            modelBuilder.Entity<BASE_ACCOUNT>()
                .Property(e => e.SEX)
                .IsFixedLength();

            modelBuilder.Entity<Blogs>()
                .HasMany(e => e.BlogArticles)
                .WithRequired(e => e.Blogs)
                .HasForeignKey(e => e.Blog_Id)
                .WillCascadeOnDelete(false);
        }
    }
}
