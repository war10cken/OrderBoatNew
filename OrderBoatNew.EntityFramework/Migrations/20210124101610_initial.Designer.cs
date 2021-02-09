﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OrderBoatNew.EntityFramework;

namespace OrderBoatNew.EntityFramework.Migrations
{
    [DbContext(typeof(OrderBoatNewDbContext))]
    [Migration("20210124101610_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("OrderBoatNew.Domain.Models.Accessory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AccName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescriptionOfAccessory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Inventory")
                        .HasColumnType("int");

                    b.Property<int>("OrderBatch")
                        .HasColumnType("int");

                    b.Property<int>("OrderLevel")
                        .HasColumnType("int");

                    b.Property<int>("PartnerId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("VAT")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.HasIndex("PartnerId");

                    b.ToTable("Accessories");
                });

            modelBuilder.Entity("OrderBoatNew.Domain.Models.Boat", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<decimal>("BasePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("BoatTypeId")
                        .HasColumnType("int");

                    b.Property<int?>("ColorID")
                        .HasColumnType("int");

                    b.Property<bool>("Mast")
                        .HasColumnType("bit");

                    b.Property<int?>("ModelID")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfRowers")
                        .HasColumnType("int");

                    b.Property<decimal>("VAT")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("WoodID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("BoatTypeId");

                    b.HasIndex("ColorID");

                    b.HasIndex("ModelID");

                    b.HasIndex("WoodID");

                    b.ToTable("Boats");
                });

            modelBuilder.Entity("OrderBoatNew.Domain.Models.BoatAccessory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AccessoryId")
                        .HasColumnType("int");

                    b.Property<int>("BoatId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AccessoryId");

                    b.HasIndex("BoatId");

                    b.ToTable("BoatAccessories");
                });

            modelBuilder.Entity("OrderBoatNew.Domain.Models.BoatType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("BoatTypes");
                });

            modelBuilder.Entity("OrderBoatNew.Domain.Models.Color", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("OrderBoatNew.Domain.Models.Customers", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("DocumentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FamilyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrganizationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("OrderBoatNew.Domain.Models.Deliver", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("BoatId")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeliveryAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ManagerId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("BoatId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ManagerId");

                    b.ToTable("Delivers");
                });

            modelBuilder.Entity("OrderBoatNew.Domain.Models.DeliveryDetails", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AccessoryId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AccessoryId");

                    b.HasIndex("OrderId");

                    b.ToTable("DeliveryDetails");
                });

            modelBuilder.Entity("OrderBoatNew.Domain.Models.Invoice", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ContractId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("OrderID")
                        .HasColumnType("int");

                    b.Property<bool>("Settled")
                        .HasColumnType("bit");

                    b.Property<decimal>("Sum")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Sum_incVAT")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.HasIndex("OrderID");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("OrderBoatNew.Domain.Models.Managers", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("FamilyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Managers");
                });

            modelBuilder.Entity("OrderBoatNew.Domain.Models.Model", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Models");
                });

            modelBuilder.Entity("OrderBoatNew.Domain.Models.Orders", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<decimal>("ContractTotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ContractTotalPrice_IncVAT")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("DepositPayed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<string>("ProductionProcess")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("OrderBoatNew.Domain.Models.Partners", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Partners");
                });

            modelBuilder.Entity("OrderBoatNew.Domain.Models.Wood", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Woods");
                });

            modelBuilder.Entity("OrderBoatNew.Domain.Models.Accessory", b =>
                {
                    b.HasOne("OrderBoatNew.Domain.Models.Partners", "Partner")
                        .WithMany()
                        .HasForeignKey("PartnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Partner");
                });

            modelBuilder.Entity("OrderBoatNew.Domain.Models.Boat", b =>
                {
                    b.HasOne("OrderBoatNew.Domain.Models.BoatType", "BoatType")
                        .WithMany()
                        .HasForeignKey("BoatTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OrderBoatNew.Domain.Models.Color", "Color")
                        .WithMany()
                        .HasForeignKey("ColorID");

                    b.HasOne("OrderBoatNew.Domain.Models.Model", "Model")
                        .WithMany()
                        .HasForeignKey("ModelID");

                    b.HasOne("OrderBoatNew.Domain.Models.Wood", "Wood")
                        .WithMany()
                        .HasForeignKey("WoodID");

                    b.Navigation("BoatType");

                    b.Navigation("Color");

                    b.Navigation("Model");

                    b.Navigation("Wood");
                });

            modelBuilder.Entity("OrderBoatNew.Domain.Models.BoatAccessory", b =>
                {
                    b.HasOne("OrderBoatNew.Domain.Models.Accessory", "Accessory")
                        .WithMany()
                        .HasForeignKey("AccessoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OrderBoatNew.Domain.Models.Boat", "Boat")
                        .WithMany()
                        .HasForeignKey("BoatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Accessory");

                    b.Navigation("Boat");
                });

            modelBuilder.Entity("OrderBoatNew.Domain.Models.Deliver", b =>
                {
                    b.HasOne("OrderBoatNew.Domain.Models.Boat", "Boat")
                        .WithMany()
                        .HasForeignKey("BoatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OrderBoatNew.Domain.Models.Customers", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OrderBoatNew.Domain.Models.Managers", "Manager")
                        .WithMany()
                        .HasForeignKey("ManagerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Boat");

                    b.Navigation("Customer");

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("OrderBoatNew.Domain.Models.DeliveryDetails", b =>
                {
                    b.HasOne("OrderBoatNew.Domain.Models.Accessory", "Accessory")
                        .WithMany()
                        .HasForeignKey("AccessoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OrderBoatNew.Domain.Models.Orders", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Accessory");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("OrderBoatNew.Domain.Models.Invoice", b =>
                {
                    b.HasOne("OrderBoatNew.Domain.Models.Orders", "Order")
                        .WithMany()
                        .HasForeignKey("OrderID");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("OrderBoatNew.Domain.Models.Orders", b =>
                {
                    b.HasOne("OrderBoatNew.Domain.Models.Orders", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });
#pragma warning restore 612, 618
        }
    }
}
