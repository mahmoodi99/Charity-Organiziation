﻿// <auto-generated />
using CharityAccounts.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CharityAccounts.Migrations
{
    [DbContext(typeof(Contexts))]
    partial class ContextsModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "Arabic_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CharityAccounts.Model.TblCharityAccount", b =>
                {
                    b.Property<int>("CharityAccountId")
                        .HasColumnType("int");

                    b.Property<string>("AccountName")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("AccountNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("BankId")
                        .HasColumnType("int");

                    b.Property<string>("BranchName")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("CardNumber")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("OwnerName")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("CharityAccountId");

                    b.HasIndex(new[] { "AccountNumber" }, "IX_tblCharityAccounts")
                        .IsUnique();

                    b.ToTable("tblCharityAccounts");
                });
#pragma warning restore 612, 618
        }
    }
}