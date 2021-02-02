﻿// <auto-generated />
using System;
using GestorDocumentacion.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace GestorDocumentacion.Migrations
{
    [DbContext(typeof(EntityContext))]
    [Migration("20200821104338_AddDocument")]
    partial class AddDocument
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("GestorDocumentacion.Models.Entities.Document", b =>
                {
                    b.Property<Guid>("DocumentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SavedRoute")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("DocumentId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Document");
                });

            modelBuilder.Entity("GestorDocumentacion.Models.Entities.Page", b =>
                {
                    b.Property<Guid>("PageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Route")
                        .HasColumnType("text");

                    b.HasKey("PageID");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Page");
                });

            modelBuilder.Entity("GestorDocumentacion.Models.Entities.Template", b =>
                {
                    b.Property<Guid>("TemplateID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("TemplateID");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Template");
                });
#pragma warning restore 612, 618
        }
    }
}
