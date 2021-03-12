using BankingSystem.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingSystem.Models
{
    public class BankContext : DbContext
    {
        public BankContext(DbContextOptions<BankContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Adding Constraints To The AccountHolder Table
            modelBuilder.Entity<AccountHolder>().Property(ach => ach.FirstName)
                .IsRequired()
                .HasMaxLength(255);
            modelBuilder.Entity<AccountHolder>().Property(ach => ach.LastName)
                .IsRequired()
                .HasMaxLength(255);
            modelBuilder.Entity<AccountHolder>().Property(ach => ach.MiddleName)
                 .IsRequired();
            modelBuilder.Entity<AccountHolder>().Property(ach => ach.Email)
               .IsRequired()
               .HasMaxLength(255);
            modelBuilder.Entity<AccountHolder>().Property(ach => ach.Password)
               .IsRequired()
               .HasMaxLength(255);
            modelBuilder.Entity<AccountHolder>().Property(ach => ach.DateOfBirth)
               .IsRequired();
            modelBuilder.Entity<AccountHolder>().Property(ach => ach.PhoneNumber)
               .IsRequired()
               .HasMaxLength(11);
            modelBuilder.Entity<AccountHolder>().Property(ach => ach.Address)
               .IsRequired()
               .HasMaxLength(255);

            // Declaring The  Relationship Between The Tables

            modelBuilder.Entity<AccountHolder>()
                .HasOne(ach => ach.Account)
                .WithOne(ac => ac.AccountHolder);

            modelBuilder.Entity<AccountHolder>()
                .HasMany(ach => ach.Loans)
                .WithOne(loan => loan.AccountHolder);

            modelBuilder.Entity<AccountHolder>()
              .HasMany(ach => ach.OverDrafts)
              .WithOne(ov => ov.AccountHolder);

            //Configure Primary Key For Account

            modelBuilder.Entity<Account>()
                .HasKey(ach => ach.AccountHolderId);



        }

        public DbSet<AccountHolder> AccountHolders { get; set; }

        public DbSet<Account> Accounts { get; set; }

        public DbSet<Manager> Managers { get; set; }

        //public DbSet<Loan> Loans { get; set; }

        //public DbSet<OverDraft> OverDrafts { get; set; }

    }
}
