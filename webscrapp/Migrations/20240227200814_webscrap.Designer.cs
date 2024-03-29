﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace webscrapp.Migrations
{
    [DbContext(typeof(LogContext))]
    [Migration("20240227200814_webscrap")]
    partial class webscrap
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Log", b =>
                {
                    b.Property<int>("IdLog")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdLog"), 1L, 1);

                    b.Property<string>("CodRob")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateLog")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdProd")
                        .HasColumnType("int");

                    b.Property<string>("InfLog")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Processo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UsuRob")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdLog");

                    b.ToTable("Logs");
                });
#pragma warning restore 612, 618
        }
    }
}
