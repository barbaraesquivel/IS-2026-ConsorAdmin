using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class AgregarEmailTelefono : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "USUARIO",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "telefono",
                table: "USUARIO",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "email_guardado",
                table: "HISTORIAL_USUARIO",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "telefono_guardado",
                table: "HISTORIAL_USUARIO",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "email", table: "USUARIO");
            migrationBuilder.DropColumn(name: "telefono", table: "USUARIO");
            migrationBuilder.DropColumn(name: "email_guardado", table: "HISTORIAL_USUARIO");
            migrationBuilder.DropColumn(name: "telefono_guardado", table: "HISTORIAL_USUARIO");
        }
    }
}
