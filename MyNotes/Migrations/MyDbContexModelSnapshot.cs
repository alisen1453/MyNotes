﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyNotes.DbCobtex;

#nullable disable

namespace MyNotes.Migrations
{
    [DbContext(typeof(MyDbContex))]
    partial class MyDbContexModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MyNotes.Models.Category", b =>
                {
                    b.Property<Guid>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CategoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("MyNotes.Models.CategoryNote", b =>
                {
                    b.Property<Guid>("NoteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CategoryId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NoteDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NoteName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NoteId");

                    b.HasIndex("CategoryId1");

                    b.ToTable("categoryNotes");
                });

            modelBuilder.Entity("MyNotes.Models.CategoryNote", b =>
                {
                    b.HasOne("MyNotes.Models.Category", null)
                        .WithMany("Notes")
                        .HasForeignKey("CategoryId1");
                });

            modelBuilder.Entity("MyNotes.Models.Category", b =>
                {
                    b.Navigation("Notes");
                });
#pragma warning restore 612, 618
        }
    }
}
