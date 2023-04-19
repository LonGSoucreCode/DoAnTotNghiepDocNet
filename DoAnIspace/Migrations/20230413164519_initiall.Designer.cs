﻿// <auto-generated />
using System;
using DoAnIspace.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DoAnIspace.Migrations
{
    [DbContext(typeof(ProductDbContact))]
    [Migration("20230413164519_initiall")]
    partial class initiall
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DoAnIspace.Models.Bag", b =>
                {
                    b.Property<int>("Bag_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Bag_id"));

                    b.Property<int>("Bag_Count")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("User_id")
                        .HasColumnType("int");

                    b.HasKey("Bag_id");

                    b.ToTable("DM_Bag");
                });

            modelBuilder.Entity("DoAnIspace.Models.Bill", b =>
                {
                    b.Property<int>("Bill_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Bill_id"));

                    b.Property<int>("Bill_Count")
                        .HasColumnType("int");

                    b.Property<bool>("Bill_Status")
                        .HasColumnType("bit");

                    b.Property<string>("Bill_Total")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("User_id")
                        .HasColumnType("int");

                    b.HasKey("Bill_id");

                    b.ToTable("DM_Bill");
                });

            modelBuilder.Entity("DoAnIspace.Models.Brand", b =>
                {
                    b.Property<int>("Brand_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Brand_id"));

                    b.Property<string>("Brand_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("Nsx_id")
                        .HasColumnType("int");

                    b.HasKey("Brand_id");

                    b.ToTable("DM_Brand");
                });

            modelBuilder.Entity("DoAnIspace.Models.CT_Bag", b =>
                {
                    b.Property<int>("CT_Bag_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CT_Bag_id"));

                    b.Property<int>("Bag_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("Product_id")
                        .HasColumnType("int");

                    b.Property<string>("Quality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Size_id")
                        .HasColumnType("int");

                    b.HasKey("CT_Bag_id");

                    b.ToTable("DM_CT_bag");
                });

            modelBuilder.Entity("DoAnIspace.Models.CT_Bill", b =>
                {
                    b.Property<int>("CT_Bill_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CT_Bill_id"));

                    b.Property<int>("Bill_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Product_Price")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Product_id")
                        .HasColumnType("int");

                    b.Property<int>("Size_id")
                        .HasColumnType("int");

                    b.HasKey("CT_Bill_id");

                    b.ToTable("DM_CT_Bill");
                });

            modelBuilder.Entity("DoAnIspace.Models.CT_Size", b =>
                {
                    b.Property<int>("CT_Size_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CT_Size_id"));

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("Product_id")
                        .HasColumnType("int");

                    b.Property<int>("Size_Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Size_Surcharges")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Size_id")
                        .HasColumnType("int");

                    b.HasKey("CT_Size_id");

                    b.ToTable("DM_CT_Size");
                });

            modelBuilder.Entity("DoAnIspace.Models.CT_View", b =>
                {
                    b.Property<int>("CT_View_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CT_View_id"));

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("User_id")
                        .HasColumnType("int");

                    b.Property<int>("View_id")
                        .HasColumnType("int");

                    b.HasKey("CT_View_id");

                    b.ToTable("DM_CT_View");
                });

            modelBuilder.Entity("DoAnIspace.Models.CT_WishList", b =>
                {
                    b.Property<int>("CT_WishList_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CT_WishList_id"));

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("Product_id")
                        .HasColumnType("int");

                    b.Property<int>("Size_id")
                        .HasColumnType("int");

                    b.Property<int>("WishList_id")
                        .HasColumnType("int");

                    b.HasKey("CT_WishList_id");

                    b.ToTable("DM_CT_WishList");
                });

            modelBuilder.Entity("DoAnIspace.Models.Category", b =>
                {
                    b.Property<int>("Category_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Category_id"));

                    b.Property<string>("Category_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("Category_id");

                    b.ToTable("DM_Category");
                });

            modelBuilder.Entity("DoAnIspace.Models.FeedBack", b =>
                {
                    b.Property<int>("FeedBack_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FeedBack_id"));

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("FeedBack_Status")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("User_id")
                        .HasColumnType("int");

                    b.HasKey("FeedBack_id");

                    b.ToTable("DM_FeedBack");
                });

            modelBuilder.Entity("DoAnIspace.Models.Image_Product", b =>
                {
                    b.Property<int>("Image_Product_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Image_Product_id"));

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image_Product_Ass")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image_Product_Cond")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image_Product_Detail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image_Product_Main")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("Image_Product_id");

                    b.ToTable("DM_Image_Product");
                });

            modelBuilder.Entity("DoAnIspace.Models.Nsx", b =>
                {
                    b.Property<int>("Nsx_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Nsx_id"));

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Nsx_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Nsx_id");

                    b.ToTable("DM_Nsx");
                });

            modelBuilder.Entity("DoAnIspace.Models.Product", b =>
                {
                    b.Property<int>("Product_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Product_id"));

                    b.Property<int>("Brand_id")
                        .HasColumnType("int");

                    b.Property<int>("Category_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Image_Product_id")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Product_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Product_Price")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Product_Story")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sale_id")
                        .HasColumnType("int");

                    b.Property<int>("View_id")
                        .HasColumnType("int");

                    b.HasKey("Product_id");

                    b.ToTable("DM_Product");
                });

            modelBuilder.Entity("DoAnIspace.Models.Role", b =>
                {
                    b.Property<int>("Role_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Role_id"));

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Role_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Role_id");

                    b.ToTable("DM_Role");
                });

            modelBuilder.Entity("DoAnIspace.Models.Sale", b =>
                {
                    b.Property<int>("Sale_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Sale_id"));

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Sale_Price")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Sale_Status")
                        .HasColumnType("bit");

                    b.HasKey("Sale_id");

                    b.ToTable("DM_Sale");
                });

            modelBuilder.Entity("DoAnIspace.Models.Size", b =>
                {
                    b.Property<int>("Size_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Size_id"));

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Size_Number")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Size_id");

                    b.ToTable("DM_Size");
                });

            modelBuilder.Entity("DoAnIspace.Models.User", b =>
                {
                    b.Property<int>("User_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("User_id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Credit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role_id")
                        .HasColumnType("int");

                    b.HasKey("User_id");

                    b.ToTable("DM_User");
                });

            modelBuilder.Entity("DoAnIspace.Models.View", b =>
                {
                    b.Property<int>("View_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("View_id"));

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("View_count")
                        .HasColumnType("int");

                    b.HasKey("View_id");

                    b.ToTable("DM_View");
                });

            modelBuilder.Entity("DoAnIspace.Models.WishList", b =>
                {
                    b.Property<int>("WishList_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WishList_id"));

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("User_id")
                        .HasColumnType("int");

                    b.Property<int>("WishList_Count")
                        .HasColumnType("int");

                    b.HasKey("WishList_id");

                    b.ToTable("DM_WishList");
                });
#pragma warning restore 612, 618
        }
    }
}
