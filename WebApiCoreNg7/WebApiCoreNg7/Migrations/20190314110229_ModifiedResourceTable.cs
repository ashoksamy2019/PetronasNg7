using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiCoreNg7.Migrations
{
    public partial class ModifiedResourceTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ResouceName",
                table: "ResourceDetails",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ResURL",
                table: "ResourceDetails",
                type: "nvarchar(500)",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedDate",
                table: "ResourceDetails",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ResouceName",
                table: "ResourceDetails",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "ResURL",
                table: "ResourceDetails",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedDate",
                table: "ResourceDetails",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");
        }
    }
}
