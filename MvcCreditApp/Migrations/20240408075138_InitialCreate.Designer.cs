﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcCreditApp.Data;

#nullable disable

namespace MvcCreditApp.Migrations
{
    [DbContext(typeof(CreditContext))]
    [Migration("20240408075138_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MvcCreditApp.Models.Bid", b =>
                {
                    b.Property<int>("BidId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BidId"));

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("CreditId")
                        .HasColumnType("int");

                    b.Property<DateTime>("bidDate")
                        .HasColumnType("datetime2");

                    b.HasKey("BidId");

                    b.HasIndex("ClientId");

                    b.HasIndex("CreditId");

                    b.ToTable("Bids");
                });

            modelBuilder.Entity("MvcCreditApp.Models.Client", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("MvcCreditApp.Models.Credit", b =>
                {
                    b.Property<int>("CreditId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CreditId"));

                    b.Property<string>("Head")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Period")
                        .HasColumnType("int");

                    b.Property<int>("Procent")
                        .HasColumnType("int");

                    b.Property<int>("Sum")
                        .HasColumnType("int");

                    b.HasKey("CreditId");

                    b.ToTable("Credits");
                });

            modelBuilder.Entity("MvcCreditApp.Models.Bid", b =>
                {
                    b.HasOne("MvcCreditApp.Models.Client", "Client")
                        .WithMany("Bids")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MvcCreditApp.Models.Credit", "Credit")
                        .WithMany("Bids")
                        .HasForeignKey("CreditId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Credit");
                });

            modelBuilder.Entity("MvcCreditApp.Models.Client", b =>
                {
                    b.Navigation("Bids");
                });

            modelBuilder.Entity("MvcCreditApp.Models.Credit", b =>
                {
                    b.Navigation("Bids");
                });
#pragma warning restore 612, 618
        }
    }
}