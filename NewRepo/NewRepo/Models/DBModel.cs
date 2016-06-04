namespace NewRepo.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBModel : DbContext
    {
        public DBModel()
            : base("name=DBModel")
        {
        }

        public virtual DbSet<checkcode> checkcode { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Property(e => e.AC_Empid)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.AC_Level)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.AC_Enable)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.AC_Emppasswd)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.AC_Group)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.AC_Msid)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.AC_Email)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.AC_Tel)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.AC_MOB)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.AC_ifemail)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.AC_Baddid)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.AC_Bmodid)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.AC_Mweb)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.AC_Language)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.AC_Ifboss)
                .IsUnicode(false);
        }
    }
}
