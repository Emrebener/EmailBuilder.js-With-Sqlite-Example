﻿// <auto-generated />
using System;
using EmailBuilderTest.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmailBuilderTest.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250519112932_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.5");

            modelBuilder.Entity("EmailBuilderTest.Models.EmailTemplateDto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("HtmlContent")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("JsonDesign")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("EmailTemplates");
                });
#pragma warning restore 612, 618
        }
    }
}
