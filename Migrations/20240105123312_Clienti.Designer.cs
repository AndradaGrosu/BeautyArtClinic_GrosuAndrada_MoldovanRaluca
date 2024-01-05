﻿// <auto-generated />
using System;
using BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Migrations
{
    [DbContext(typeof(BeautyArtClinic_GrosuAndrada_MoldovanRalucaContext))]
    [Migration("20240105123312_Clienti")]
    partial class Clienti
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Models.Client", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MedicID")
                        .HasColumnType("int");

                    b.Property<string>("NumeClient")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("MedicID");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Models.Departament", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("NumeDepartament")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Departament");
                });

            modelBuilder.Entity("BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Models.Medic", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("DepartamentID")
                        .HasColumnType("int");

                    b.Property<string>("NumeMedic")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("DepartamentID");

                    b.ToTable("Medic");
                });

            modelBuilder.Entity("BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Models.Programare", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("ClientID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataProgramare")
                        .HasColumnType("datetime2");

                    b.Property<int>("ServiciuID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ClientID");

                    b.HasIndex("ServiciuID");

                    b.ToTable("Programare");
                });

            modelBuilder.Entity("BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Models.Serviciu", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("DENUMIRE")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DESCRIERE")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DepartamentID")
                        .HasColumnType("int");

                    b.Property<int?>("MedicID")
                        .HasColumnType("int");

                    b.Property<decimal>("PRET")
                        .HasColumnType("decimal(6, 2)");

                    b.HasKey("ID");

                    b.HasIndex("DepartamentID");

                    b.HasIndex("MedicID");

                    b.ToTable("Serviciu");
                });

            modelBuilder.Entity("BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Models.Client", b =>
                {
                    b.HasOne("BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Models.Medic", null)
                        .WithMany("Clienti")
                        .HasForeignKey("MedicID");
                });

            modelBuilder.Entity("BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Models.Medic", b =>
                {
                    b.HasOne("BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Models.Departament", "Departament")
                        .WithMany("Medici")
                        .HasForeignKey("DepartamentID");

                    b.Navigation("Departament");
                });

            modelBuilder.Entity("BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Models.Programare", b =>
                {
                    b.HasOne("BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Models.Client", "Client")
                        .WithMany("Programari")
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Models.Serviciu", "Serviciu")
                        .WithMany("Programari")
                        .HasForeignKey("ServiciuID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Serviciu");
                });

            modelBuilder.Entity("BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Models.Serviciu", b =>
                {
                    b.HasOne("BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Models.Departament", "Departament")
                        .WithMany("Servicii")
                        .HasForeignKey("DepartamentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Models.Medic", "Medic")
                        .WithMany("ServiciiOferite")
                        .HasForeignKey("MedicID");

                    b.Navigation("Departament");

                    b.Navigation("Medic");
                });

            modelBuilder.Entity("BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Models.Client", b =>
                {
                    b.Navigation("Programari");
                });

            modelBuilder.Entity("BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Models.Departament", b =>
                {
                    b.Navigation("Medici");

                    b.Navigation("Servicii");
                });

            modelBuilder.Entity("BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Models.Medic", b =>
                {
                    b.Navigation("Clienti");

                    b.Navigation("ServiciiOferite");
                });

            modelBuilder.Entity("BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Models.Serviciu", b =>
                {
                    b.Navigation("Programari");
                });
#pragma warning restore 612, 618
        }
    }
}
