using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CSharpMusic.Migrations
{
    /// <inheritdoc />
    public partial class inicial5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LinkImagem",
                table: "Produto",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LinkImagem",
                table: "Produto");
        }
    }
}
