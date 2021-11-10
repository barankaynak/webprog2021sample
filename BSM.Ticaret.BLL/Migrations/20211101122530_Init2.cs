using Microsoft.EntityFrameworkCore.Migrations;

namespace BSM.Ticaret.BLL.Migrations
{
    public partial class Init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UrunKategori");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UrunKategori",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FkKategoriId = table.Column<int>(type: "int", nullable: false),
                    FkUrunId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrunKategori", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UrunKategori_Kategori_FkKategoriId",
                        column: x => x.FkKategoriId,
                        principalTable: "Kategori",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UrunKategori_Urun_FkUrunId",
                        column: x => x.FkUrunId,
                        principalTable: "Urun",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UrunKategori_FkKategoriId",
                table: "UrunKategori",
                column: "FkKategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_UrunKategori_FkUrunId",
                table: "UrunKategori",
                column: "FkUrunId");
        }
    }
}
