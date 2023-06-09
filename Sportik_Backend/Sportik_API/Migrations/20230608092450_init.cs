using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sportik_API.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TypeOfProduct = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    imgSrc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Description", "Price", "Title", "TypeOfProduct", "imgSrc" },
                values: new object[,]
                {
                    { 1, "OPTIMUM NUTRITION 100% WHEY GOLD STANDARD", 450m, "OPTIMUM NUTRITION", "protein", "https://ik.imagekit.io/w5l3jpc0n/optimum.jpg?updatedAt=1686178714662" },
                    { 2, "SCITEC NUTRITION 100% WHEY PROTEIN PROFESSIONAL", 530m, "SCITEC NUTRITION", "protein", "https://ik.imagekit.io/w5l3jpc0n/scitec.jpg?updatedAt=1686178715027" },
                    { 3, "AMIX ISOPRIME CFM", 770m, "AMIX ISOPRIME", "protein", "https://ik.imagekit.io/w5l3jpc0n/optimum.jpg?updatedAt=1686178714662" },
                    { 4, "AMIX ISOPRIMESCITEC NUTRITION 100% WHEY ISOLATE", 1030m, "SCITEC NUTRITION", "protein", "https://ik.imagekit.io/w5l3jpc0n/scitecN.jpg?updatedAt=1686178714431" },
                    { 5, "IRONMAXX 100% WHEY PROTEIN", 960m, "IRONMAXX", "protein", "https://ik.imagekit.io/w5l3jpc0n/ironmax.jpg?updatedAt=1686178718701" },
                    { 6, "SPORTER CREATINE MONOHYDRATE", 830m, "SPORTER CREATINE", "creatine", "https://ik.imagekit.io/w5l3jpc0n/monohydrate.jpg?updatedAt=1686178714523" },
                    { 7, "SPORTER CREATINE HCL 1400", 750m, "SPORTER CREATINE HCL", "creatine", "https://ik.imagekit.io/w5l3jpc0n/hcl.jpg?updatedAt=1686178718775" },
                    { 8, "AMIX AMIXPRО CREATINE HCL", 630m, "AMIXPRО CREATINE", "creatine", "https://ik.imagekit.io/w5l3jpc0n/amixpro.jpg?updatedAt=1686178718387" },
                    { 9, "TREC NUTRITION CM3 HMB - 200 КАПС", 590m, "TREC NUTRITION", "creatine", "https://ik.imagekit.io/w5l3jpc0n/trecN.png?updatedAt=1686178714986" },
                    { 10, "TREC NUTRITION CM3 POWDER", 730m, "TREC NUTRITION CM3", "creatine", "https://ik.imagekit.io/w5l3jpc0n/trecN2.png?updatedAt=1686178714889" },
                    { 11, "TREC NUTRITION CM3 PRO+ - 200 КАПС", 450m, "TREC NUTRITION CM3", "creatine", "https://ik.imagekit.io/w5l3jpc0n/trecN3.png?updatedAt=1686178714929" },
                    { 12, "AMIX XFAT 2IN1 SHOT", 780m, "AMIX XFAT 2IN1", "l-carnitine", "https://ik.imagekit.io/w5l3jpc0n/XFat.jpg?updatedAt=1686178714900" },
                    { 13, "HAYA LABS ACETYL L-CARNITINE", 450m, "HAYA LABS", "l-carnitine", "https://ik.imagekit.io/w5l3jpc0n/acetyl.jpg?updatedAt=1686178718108" },
                    { 14, "HAYA LABS ADVANCED LIQUID", 305m, "HAYA LABS ADVANCED", "l-carnitine", "https://ik.imagekit.io/w5l3jpc0n/liquid.jpg?updatedAt=1686178718796" },
                    { 15, "TREC NUTRITION L-CARNITINE 3000", 450m, "TREC NUTRITION", "l-carnitine", "https://ik.imagekit.io/w5l3jpc0n/trec.png?updatedAt=1686178714843" },
                    { 16, "SPORTER L- CARNITINE 60000 - 0,5Л", 380m, "SPORTER L- CARNITINE", "l-carnitine", "https://ik.imagekit.io/w5l3jpc0n/sporter.png?updatedAt=1686178714667" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
