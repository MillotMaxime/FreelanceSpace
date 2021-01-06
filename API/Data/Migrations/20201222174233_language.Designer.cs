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
    [Migration("20201222174233_language")]
    partial class language
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

            modelBuilder.Entity("API.Entities.ComputerLanguage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Computer");
                });

            modelBuilder.Entity("API.Entities.Offre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Buisness")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("BusinessValidation")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Create")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<bool>("FreelanceValidation")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Penaltyid")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Salaryid")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TermsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("Buisness");

                    b.HasIndex("Penaltyid");

                    b.HasIndex("Salaryid");

                    b.HasIndex("TermsId");

                    b.ToTable("Offre");
                });

            modelBuilder.Entity("API.Entities.OffreLanguagesComputer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ComputerLanguageId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Favoris")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("OffreId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ComputerLanguageId");

                    b.HasIndex("OffreId");

                    b.ToTable("OffreLanguagesComputer");
                });

            modelBuilder.Entity("API.Entities.OffreLanguagesSpeak", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Favoris")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("OffreId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SpeakId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("OffreId");

                    b.HasIndex("SpeakId");

                    b.ToTable("OffreLanguagesSpeak");
                });

            modelBuilder.Entity("API.Entities.Salary", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Montant")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TimeLimit")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.HasIndex("TimeLimit");

                    b.ToTable("Salary");
                });

            modelBuilder.Entity("API.Entities.SalaryPenalty", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Montant")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TimeLimit")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.HasIndex("TimeLimit");

                    b.ToTable("SalaryPenalty");
                });

            modelBuilder.Entity("API.Entities.Speak", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Translate")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Speak");
                });

            modelBuilder.Entity("API.Entities.Terms", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Begin")
                        .HasColumnType("TEXT");

                    b.Property<int?>("TimeLimit")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TimeLimit");

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
                        .HasForeignKey("Buisness");

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

            modelBuilder.Entity("API.Entities.OffreLanguagesComputer", b =>
                {
                    b.HasOne("API.Entities.ComputerLanguage", "ComputerLanguage")
                        .WithMany()
                        .HasForeignKey("ComputerLanguageId");

                    b.HasOne("API.Entities.Offre", "Offre")
                        .WithMany()
                        .HasForeignKey("OffreId");

                    b.Navigation("ComputerLanguage");

                    b.Navigation("Offre");
                });

            modelBuilder.Entity("API.Entities.OffreLanguagesSpeak", b =>
                {
                    b.HasOne("API.Entities.Offre", "Offre")
                        .WithMany()
                        .HasForeignKey("OffreId");

                    b.HasOne("API.Entities.Speak", "Speak")
                        .WithMany()
                        .HasForeignKey("SpeakId");

                    b.Navigation("Offre");

                    b.Navigation("Speak");
                });

            modelBuilder.Entity("API.Entities.Salary", b =>
                {
                    b.HasOne("API.Entities.TimeLimit", "Recurence")
                        .WithMany()
                        .HasForeignKey("TimeLimit");

                    b.Navigation("Recurence");
                });

            modelBuilder.Entity("API.Entities.SalaryPenalty", b =>
                {
                    b.HasOne("API.Entities.TimeLimit", "Recurence")
                        .WithMany()
                        .HasForeignKey("TimeLimit");

                    b.Navigation("Recurence");
                });

            modelBuilder.Entity("API.Entities.Terms", b =>
                {
                    b.HasOne("API.Entities.TimeLimit", "End")
                        .WithMany()
                        .HasForeignKey("TimeLimit");

                    b.Navigation("End");
                });
#pragma warning restore 612, 618
        }
    }
}
