﻿// <auto-generated />
using KenitaCodeTest.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KenitaCodeTest.Migrations
{
    [DbContext(typeof(LoanContext))]
    [Migration("20200215033737_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KenitaCodeTest.Models.Loan", b =>
                {
                    b.Property<int>("Details")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BorrowerName")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("FundingAmount")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LoanID")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("RepaymentAmount")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Details");

                    b.ToTable("Loans");
                });
#pragma warning restore 612, 618
        }
    }
}
