﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TelegramAutomationWithRequest.Data;

#nullable disable

namespace TelegramAutomationWithRequest.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240102040634_a")]
    partial class a
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TelegramAutomationWithRequest.Entities.Accounts", b =>
                {
                    b.Property<Guid>("IdAccount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Activiti")
                        .HasColumnType("int");

                    b.Property<string>("AppHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AppId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Avatar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateDelete")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateImport")
                        .HasColumnType("datetime2");

                    b.Property<string>("Device")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("IdFile")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Info")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Interac")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Proxy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Session")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdAccount");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("TelegramAutomationWithRequest.Entities.Actions", b =>
                {
                    b.Property<Guid>("IdAction")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Configuration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("IdScript")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ListCheckbox")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdAction");

                    b.ToTable("Actions");
                });

            modelBuilder.Entity("TelegramAutomationWithRequest.Entities.Filess", b =>
                {
                    b.Property<Guid>("IdFile")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Active")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdFile");

                    b.ToTable("Files");
                });

            modelBuilder.Entity("TelegramAutomationWithRequest.Entities.InteractAccounts", b =>
                {
                    b.Property<Guid>("IdInteractaccount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Configuration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("IdAccount")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdAction")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdInteractaccount");

                    b.ToTable("InteractAccounts");
                });

            modelBuilder.Entity("TelegramAutomationWithRequest.Entities.Interacts", b =>
                {
                    b.Property<Guid>("IdInteract")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Configuration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Describe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdInteract");

                    b.ToTable("Interacts");
                });

            modelBuilder.Entity("TelegramAutomationWithRequest.Entities.Scripts", b =>
                {
                    b.Property<Guid>("IdScript")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Configuration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdScript");

                    b.ToTable("Scripts");
                });
#pragma warning restore 612, 618
        }
    }
}
