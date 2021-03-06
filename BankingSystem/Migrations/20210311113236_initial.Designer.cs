// <auto-generated />
using System;
using BankingSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BankingSystem.Migrations
{
    [DbContext(typeof(BankContext))]
    [Migration("20210311113236_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BankingSystem.Models.Entities.Account", b =>
                {
                    b.Property<int>("AccountHolderId")
                        .HasColumnType("int");

                    b.Property<double>("AccountBalance")
                        .HasColumnType("double");

                    b.Property<string>("AccountNumber")
                        .HasColumnType("text");

                    b.Property<int>("AccountStatus")
                        .HasColumnType("int");

                    b.Property<int>("Pin")
                        .HasColumnType("int");

                    b.HasKey("AccountHolderId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("BankingSystem.Models.Entities.AccountHolder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("varchar(11)")
                        .HasMaxLength(11);

                    b.HasKey("Id");

                    b.ToTable("AccountHolders");
                });

            modelBuilder.Entity("BankingSystem.Models.Entities.Loan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AccountHolderId")
                        .HasColumnType("int");

                    b.Property<double>("Amount")
                        .HasColumnType("double");

                    b.Property<double>("AmountLeft")
                        .HasColumnType("double");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("TypeofLoan")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AccountHolderId");

                    b.ToTable("Loan");
                });

            modelBuilder.Entity("BankingSystem.Models.Entities.OverDraft", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AccountHolderId")
                        .HasColumnType("int");

                    b.Property<double>("Amount")
                        .HasColumnType("double");

                    b.Property<double>("AmountLeft")
                        .HasColumnType("double");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountHolderId");

                    b.ToTable("OverDraft");
                });

            modelBuilder.Entity("BankingSystem.Models.Entities.Account", b =>
                {
                    b.HasOne("BankingSystem.Models.Entities.AccountHolder", "AccountHolder")
                        .WithOne("Account")
                        .HasForeignKey("BankingSystem.Models.Entities.Account", "AccountHolderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BankingSystem.Models.Entities.Loan", b =>
                {
                    b.HasOne("BankingSystem.Models.Entities.AccountHolder", "AccountHolder")
                        .WithMany("Loans")
                        .HasForeignKey("AccountHolderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BankingSystem.Models.Entities.OverDraft", b =>
                {
                    b.HasOne("BankingSystem.Models.Entities.AccountHolder", "AccountHolder")
                        .WithMany("OverDrafts")
                        .HasForeignKey("AccountHolderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
