using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoAnIspace.Migrations
{
    /// <inheritdoc />
    public partial class initiall : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Product_Price",
                table: "DM_CT_Bill",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Size_id",
                table: "DM_CT_Bill",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Product_Price",
                table: "DM_CT_Bill");

            migrationBuilder.DropColumn(
                name: "Size_id",
                table: "DM_CT_Bill");
        }
    }
}
