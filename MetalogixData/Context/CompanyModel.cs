namespace MetalogixData
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Configuration;

    public partial class CompanyModel : DbContext
    {
        public CompanyModel()
            : base(ConfigurationManager.ConnectionStrings["CompanyModel1"]
    .ConnectionString)
        {
        }

        public virtual DbSet<C__RefactorLog> C__RefactorLog { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Company_Type> Company_Type { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company_Type>()
                .HasMany(e => e.Companies)
                .WithOptional(e => e.Company_Type1)
                .HasForeignKey(e => e.Company_Type);
        }
    }
}
