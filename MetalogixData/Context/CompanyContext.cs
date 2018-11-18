namespace MetalogixData
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CompanyContext : DbContext
    {
        public CompanyContext()
            : base("name=CompanyContext")
        {
        }

        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Company_Type> Company_Type { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>()
                .Property(e => e.Country_Code)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Company_Type>()
                .HasOptional(e => e.Company)
                .WithRequired(e => e.Company_Type);
        }
    }
}
