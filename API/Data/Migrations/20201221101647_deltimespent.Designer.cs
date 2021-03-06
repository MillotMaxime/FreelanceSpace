﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20201221101647_deltimespent")]
    partial class deltimespent
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("API.Entities.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("BLOB");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("Discriminator").HasValue("AppUser");
                });

            modelBuilder.Entity("API.Entities.Offre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("BusinessValidation")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ComputerLanguage")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Create")
                        .HasColumnType("TEXT");

                    b.Property<int?>("CreatorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<bool>("FreelanceValidation")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Language")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Penaltyid")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Salaryid")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TermsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.HasIndex("Penaltyid");

                    b.HasIndex("Salaryid");

                    b.HasIndex("TermsId");

                    b.ToTable("Offre");
                });

            modelBuilder.Entity("API.Entities.Salary", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Montant")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("RecurenceId")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.HasIndex("RecurenceId");

                    b.ToTable("Salary");
                });

            modelBuilder.Entity("API.Entities.SalaryPenalty", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Montant")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("RecurenceId")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.HasIndex("RecurenceId");

                    b.ToTable("SalaryPenalty");
                });

            modelBuilder.Entity("API.Entities.Terms", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Begin")
                        .HasColumnType("TEXT");

                    b.Property<int?>("EndId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("EndId");

                    b.ToTable("Terms");
                });

            modelBuilder.Entity("API.Entities.TimeLimit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Nombre")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TypeTime")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("TimeLimit");
                });

            modelBuilder.Entity("API.Entities.Business", b =>
                {
                    b.HasBaseType("API.Entities.AppUser");

                    b.Property<string>("Activity")
                        .HasColumnType("TEXT");

                    b.Property<string>("LegalStatus")
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("Business");
                });

            modelBuilder.Entity("API.Entities.Freelance", b =>
                {
                    b.HasBaseType("API.Entities.AppUser");

                    b.Property<int>("Ago")
                        .HasColumnType("INTEGER");

                    b.HasDiscriminator().HasValue("Freelance");
                });

            modelBuilder.Entity("API.Entities.Offre", b =>
                {
                    b.HasOne("API.Entities.Business", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId");

                    b.HasOne("API.Entities.SalaryPenalty", "Penalty")
                        .WithMany()
                        .HasForeignKey("Penaltyid");

                    b.HasOne("API.Entities.Salary", "Salary")
                        .WithMany()
                        .HasForeignKey("Salaryid");

                    b.HasOne("API.Entities.Terms", "Terms")
                        .WithMany()
                        .HasForeignKey("TermsId");

                    b.Navigation("Creator");

                    b.Navigation("Penalty");

                    b.Navigation("Salary");

                    b.Navigation("Terms");
                });

            modelBuilder.Entity("API.Entities.Salary", b =>
                {
                    b.HasOne("API.Entities.TimeLimit", "Recurence")
                        .WithMany()
                        .HasForeignKey("RecurenceId");

                    b.Navigation("Recurence");
                });

            modelBuilder.Entity("API.Entities.SalaryPenalty", b =>
                {
                    b.HasOne("API.Entities.TimeLimit", "Recurence")
                        .WithMany()
                        .HasForeignKey("RecurenceId");

                    b.Navigation("Recurence");
                });

            modelBuilder.Entity("API.Entities.Terms", b =>
                {
                    b.HasOne("API.Entities.TimeLimit", "End")
                        .WithMany()
                        .HasForeignKey("EndId");

                    b.Navigation("End");
                });
#pragma warning restore 612, 618
        }
    }
}
