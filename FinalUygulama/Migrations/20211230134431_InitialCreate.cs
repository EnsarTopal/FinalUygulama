using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalUygulama.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Haber",
                columns: table => new
                {
                    HaberID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HaberBaslik = table.Column<string>(nullable: false),
                    HaberAciklama = table.Column<string>(nullable: false),
                    HaberDetay = table.Column<string>(nullable: false),
                    HaberResimYolu = table.Column<string>(nullable: true),
                    Kategori = table.Column<string>(nullable: false),
                    HaberTarihi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Haber", x => x.HaberID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Haber");
        }
    }
}
