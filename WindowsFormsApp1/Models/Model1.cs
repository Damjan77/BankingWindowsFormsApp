using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WindowsFormsApp1
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<CLS_Currency> CLS_Currency { get; set; }
        public virtual DbSet<CLS_OperationType> CLS_OperationType { get; set; }
        public virtual DbSet<ExchangeRate> ExchangeRates { get; set; }
        public virtual DbSet<OfficialRate> OfficialRates { get; set; }
        public virtual DbSet<Operation> Operations { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CLS_Currency>()
                .Property(e => e.Code)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CLS_Currency>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<CLS_OperationType>()
                .Property(e => e.Code)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CLS_OperationType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ExchangeRate>()
                .Property(e => e.CurrencyFrom)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ExchangeRate>()
                .Property(e => e.CurrencyTo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ExchangeRate>()
                .Property(e => e.Rate)
                .HasPrecision(10, 4);

            modelBuilder.Entity<OfficialRate>()
                .Property(e => e.Currency)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OfficialRate>()
                .Property(e => e.Rate)
                .HasPrecision(10, 4);

            modelBuilder.Entity<Operation>()
                .Property(e => e.Amount)
                .HasPrecision(10, 4);

            modelBuilder.Entity<Operation>()
                .Property(e => e.CurrencyFrom)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Operation>()
                .Property(e => e.CurrencyTo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.surname)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Operations)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);
        }
    }
}
