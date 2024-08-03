using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QazoniHisoblovchi.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FoydalanuvchiVaQazoNamozlari : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "foydalanuvchilar",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Martaba = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_foydalanuvchilar", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "qazoNamozlar",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bomdod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Peshin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PeshinSafar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Asr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AsrSafar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Shom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Xufton = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    XuftonSafar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vitr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Roza = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoydalanuvchiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_qazoNamozlar", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "foydalanuvchilar");

            migrationBuilder.DropTable(
                name: "qazoNamozlar");
        }
    }
}
