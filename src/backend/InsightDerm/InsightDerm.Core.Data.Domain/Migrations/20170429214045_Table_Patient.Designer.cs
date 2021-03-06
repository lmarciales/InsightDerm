﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using InsightDerm.Core.Data.Domain.Infrastructure;

namespace InsightDerm.Core.Data.Domain.Migrations
{
    [DbContext(typeof(InsightDermContext))]
    [Migration("20170429214045_Table_Patient")]
    partial class Table_Patient
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "1.1.1");

            modelBuilder.Entity("InsightDerm.Core.Data.Domain.Model.City", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("City");
                });

            modelBuilder.Entity("InsightDerm.Core.Data.Domain.Model.Doctor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CellPhone")
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .HasMaxLength(255);

                    b.Property<string>("Identification")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .HasMaxLength(255);

                    b.Property<string>("Phone")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Doctor");
                });

            modelBuilder.Entity("InsightDerm.Core.Data.Domain.Model.MedicalCenter", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CityId");

                    b.Property<string>("Name")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("MedicalCenter");
                });

            modelBuilder.Entity("InsightDerm.Core.Data.Domain.Model.Patient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .HasMaxLength(255);

                    b.Property<DateTime>("BirthDate");

                    b.Property<string>("CellPhone")
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .HasMaxLength(255);

                    b.Property<string>("Identification")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .HasMaxLength(255);

                    b.Property<string>("Occupation")
                        .HasMaxLength(255);

                    b.Property<string>("Phone")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Patient");
                });

            modelBuilder.Entity("Microsoft.EntityFrameworkCore.Internal.AutoHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Changed")
                        .HasMaxLength(2048);

                    b.Property<DateTime>("Created");

                    b.Property<int>("Kind");

                    b.Property<string>("RowId")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("TableName")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.ToTable("AutoHistory");
                });

            modelBuilder.Entity("InsightDerm.Core.Data.Domain.Model.MedicalCenter", b =>
                {
                    b.HasOne("InsightDerm.Core.Data.Domain.Model.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
