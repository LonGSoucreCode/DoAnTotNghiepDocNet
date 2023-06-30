using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoAnIspace.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DM_Bag",
                columns: table => new
                {
                    Bag_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_id = table.Column<int>(type: "int", nullable: false),
                    Bag_Count = table.Column<int>(type: "int", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_Bag", x => x.Bag_id);
                });

            migrationBuilder.CreateTable(
                name: "DM_Bill",
                columns: table => new
                {
                    Bill_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_id = table.Column<int>(type: "int", nullable: false),
                    Bill_Count = table.Column<int>(type: "int", nullable: false),
                    Bill_Total = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bill_Status = table.Column<bool>(type: "bit", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_Bill", x => x.Bill_id);
                });

            migrationBuilder.CreateTable(
                name: "DM_Brand",
                columns: table => new
                {
                    Brand_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nsx_id = table.Column<int>(type: "int", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_Brand", x => x.Brand_id);
                });

            migrationBuilder.CreateTable(
                name: "DM_Category",
                columns: table => new
                {
                    Category_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_Category", x => x.Category_id);
                });

            migrationBuilder.CreateTable(
                name: "DM_CT_bag",
                columns: table => new
                {
                    CT_Bag_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bag_id = table.Column<int>(type: "int", nullable: false),
                    Product_id = table.Column<int>(type: "int", nullable: false),
                    Size_id = table.Column<int>(type: "int", nullable: false),
                    Quality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_CT_bag", x => x.CT_Bag_id);
                });

            migrationBuilder.CreateTable(
                name: "DM_CT_Bill",
                columns: table => new
                {
                    CT_Bill_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bill_id = table.Column<int>(type: "int", nullable: false),
                    Product_id = table.Column<int>(type: "int", nullable: false),
                    Product_Price = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Size_id = table.Column<int>(type: "int", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_CT_Bill", x => x.CT_Bill_id);
                });

            migrationBuilder.CreateTable(
                name: "DM_CT_Size",
                columns: table => new
                {
                    CT_Size_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Size_id = table.Column<int>(type: "int", nullable: false),
                    Product_id = table.Column<int>(type: "int", nullable: false),
                    Size_Quantity = table.Column<int>(type: "int", nullable: false),
                    Size_Surcharges = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_CT_Size", x => x.CT_Size_id);
                });

            migrationBuilder.CreateTable(
                name: "DM_CT_View",
                columns: table => new
                {
                    CT_View_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    View_id = table.Column<int>(type: "int", nullable: false),
                    User_id = table.Column<int>(type: "int", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_CT_View", x => x.CT_View_id);
                });

            migrationBuilder.CreateTable(
                name: "DM_CT_WishList",
                columns: table => new
                {
                    CT_WishList_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WishList_id = table.Column<int>(type: "int", nullable: false),
                    Product_id = table.Column<int>(type: "int", nullable: false),
                    Size_id = table.Column<int>(type: "int", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_CT_WishList", x => x.CT_WishList_id);
                });

            migrationBuilder.CreateTable(
                name: "DM_FeedBack",
                columns: table => new
                {
                    FeedBack_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeedBack_Status = table.Column<int>(type: "int", nullable: false),
                    User_id = table.Column<int>(type: "int", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_FeedBack", x => x.FeedBack_id);
                });

            migrationBuilder.CreateTable(
                name: "DM_Image_Product",
                columns: table => new
                {
                    Image_Product_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image_Product_Main = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image_Product_Detail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image_Product_Ass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image_Product_Cond = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_Image_Product", x => x.Image_Product_id);
                });

            migrationBuilder.CreateTable(
                name: "DM_ListCode",
                columns: table => new
                {
                    List_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    List_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    List_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_ListCode", x => x.List_id);
                });

            migrationBuilder.CreateTable(
                name: "DM_Nsx",
                columns: table => new
                {
                    Nsx_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nsx_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_Nsx", x => x.Nsx_id);
                });

            migrationBuilder.CreateTable(
                name: "DM_Product",
                columns: table => new
                {
                    Product_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image_Product_id = table.Column<int>(type: "int", nullable: false),
                    Product_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Product_Price = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brand_id = table.Column<int>(type: "int", nullable: false),
                    Product_Story = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category_id = table.Column<int>(type: "int", nullable: false),
                    View_id = table.Column<int>(type: "int", nullable: false),
                    Sale_id = table.Column<int>(type: "int", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_Product", x => x.Product_id);
                });

            migrationBuilder.CreateTable(
                name: "DM_Role",
                columns: table => new
                {
                    Role_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Role_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_Role", x => x.Role_id);
                });

            migrationBuilder.CreateTable(
                name: "DM_Sale",
                columns: table => new
                {
                    Sale_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sale_Price = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sale_Status = table.Column<bool>(type: "bit", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_Sale", x => x.Sale_id);
                });

            migrationBuilder.CreateTable(
                name: "DM_Size",
                columns: table => new
                {
                    Size_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Size_Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_Size", x => x.Size_id);
                });

            migrationBuilder.CreateTable(
                name: "DM_User",
                columns: table => new
                {
                    User_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role_id = table.Column<int>(type: "int", nullable: false),
                    Credit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_User", x => x.User_id);
                });

            migrationBuilder.CreateTable(
                name: "DM_View",
                columns: table => new
                {
                    View_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    View_count = table.Column<int>(type: "int", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_View", x => x.View_id);
                });

            migrationBuilder.CreateTable(
                name: "DM_WishList",
                columns: table => new
                {
                    WishList_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_id = table.Column<int>(type: "int", nullable: false),
                    WishList_Count = table.Column<int>(type: "int", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_WishList", x => x.WishList_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DM_Bag");

            migrationBuilder.DropTable(
                name: "DM_Bill");

            migrationBuilder.DropTable(
                name: "DM_Brand");

            migrationBuilder.DropTable(
                name: "DM_Category");

            migrationBuilder.DropTable(
                name: "DM_CT_bag");

            migrationBuilder.DropTable(
                name: "DM_CT_Bill");

            migrationBuilder.DropTable(
                name: "DM_CT_Size");

            migrationBuilder.DropTable(
                name: "DM_CT_View");

            migrationBuilder.DropTable(
                name: "DM_CT_WishList");

            migrationBuilder.DropTable(
                name: "DM_FeedBack");

            migrationBuilder.DropTable(
                name: "DM_Image_Product");

            migrationBuilder.DropTable(
                name: "DM_ListCode");

            migrationBuilder.DropTable(
                name: "DM_Nsx");

            migrationBuilder.DropTable(
                name: "DM_Product");

            migrationBuilder.DropTable(
                name: "DM_Role");

            migrationBuilder.DropTable(
                name: "DM_Sale");

            migrationBuilder.DropTable(
                name: "DM_Size");

            migrationBuilder.DropTable(
                name: "DM_User");

            migrationBuilder.DropTable(
                name: "DM_View");

            migrationBuilder.DropTable(
                name: "DM_WishList");
        }
    }
}
