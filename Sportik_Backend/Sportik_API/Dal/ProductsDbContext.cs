using Microsoft.EntityFrameworkCore;

namespace Sportik_API.Dal
{
    public class ProductsDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; } = null!;

        public ProductsDbContext(DbContextOptions<ProductsDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, TypeOfProduct = "protein", Title = "OPTIMUM NUTRITION", Description = "OPTIMUM NUTRITION 100% WHEY GOLD STANDARD", Price = 450, imgSrc = "https://ik.imagekit.io/w5l3jpc0n/optimum.jpg?updatedAt=1686178714662" },
                new Product { ProductId = 2, TypeOfProduct = "protein", Title = "SCITEC NUTRITION", Description = "SCITEC NUTRITION 100% WHEY PROTEIN PROFESSIONAL", Price = 530, imgSrc = "https://ik.imagekit.io/w5l3jpc0n/scitec.jpg?updatedAt=1686178715027" },
                new Product { ProductId = 3, TypeOfProduct = "protein", Title = "AMIX ISOPRIME", Description = "AMIX ISOPRIME CFM", Price = 770, imgSrc = "https://ik.imagekit.io/w5l3jpc0n/optimum.jpg?updatedAt=1686178714662" },
                new Product { ProductId = 4, TypeOfProduct = "protein", Title = "SCITEC NUTRITION", Description = "AMIX ISOPRIMESCITEC NUTRITION 100% WHEY ISOLATE", Price = 1030, imgSrc = "https://ik.imagekit.io/w5l3jpc0n/scitecN.jpg?updatedAt=1686178714431" },
                new Product { ProductId = 5, TypeOfProduct = "protein", Title = "IRONMAXX", Description = "IRONMAXX 100% WHEY PROTEIN", Price = 960, imgSrc = "https://ik.imagekit.io/w5l3jpc0n/ironmax.jpg?updatedAt=1686178718701" },
                new Product { ProductId = 6, TypeOfProduct = "creatine", Title = "SPORTER CREATINE", Description = "SPORTER CREATINE MONOHYDRATE", Price = 830, imgSrc = "https://ik.imagekit.io/w5l3jpc0n/monohydrate.jpg?updatedAt=1686178714523" },
                new Product { ProductId = 7, TypeOfProduct = "creatine", Title = "SPORTER CREATINE HCL", Description = "SPORTER CREATINE HCL 1400", Price = 750, imgSrc = "https://ik.imagekit.io/w5l3jpc0n/hcl.jpg?updatedAt=1686178718775" },
                new Product { ProductId = 8, TypeOfProduct = "creatine", Title = "AMIXPRО CREATINE", Description = "AMIX AMIXPRО CREATINE HCL", Price = 630, imgSrc = "https://ik.imagekit.io/w5l3jpc0n/amixpro.jpg?updatedAt=1686178718387" },
                new Product { ProductId = 9, TypeOfProduct = "creatine", Title = "TREC NUTRITION", Description = "TREC NUTRITION CM3 HMB - 200 КАПС", Price = 590, imgSrc = "https://ik.imagekit.io/w5l3jpc0n/trecN.png?updatedAt=1686178714986" },
                new Product { ProductId = 10, TypeOfProduct = "creatine", Title = "TREC NUTRITION CM3", Description = "TREC NUTRITION CM3 POWDER", Price = 730, imgSrc = "https://ik.imagekit.io/w5l3jpc0n/trecN2.png?updatedAt=1686178714889" },
                new Product { ProductId = 11, TypeOfProduct = "creatine", Title = "TREC NUTRITION CM3", Description = "TREC NUTRITION CM3 PRO+ - 200 КАПС", Price = 450, imgSrc = "https://ik.imagekit.io/w5l3jpc0n/trecN3.png?updatedAt=1686178714929" },
                new Product { ProductId = 12, TypeOfProduct = "l-carnitine", Title = "AMIX XFAT 2IN1", Description = "AMIX XFAT 2IN1 SHOT", Price = 780, imgSrc = "https://ik.imagekit.io/w5l3jpc0n/XFat.jpg?updatedAt=1686178714900" },
                new Product { ProductId = 13, TypeOfProduct = "l-carnitine", Title = "HAYA LABS", Description = "HAYA LABS ACETYL L-CARNITINE", Price = 450, imgSrc = "https://ik.imagekit.io/w5l3jpc0n/acetyl.jpg?updatedAt=1686178718108" },
                new Product { ProductId = 14, TypeOfProduct = "l-carnitine", Title = "HAYA LABS ADVANCED", Description = "HAYA LABS ADVANCED LIQUID", Price = 305, imgSrc = "https://ik.imagekit.io/w5l3jpc0n/liquid.jpg?updatedAt=1686178718796" },
                new Product { ProductId = 15, TypeOfProduct = "l-carnitine", Title = "TREC NUTRITION", Description = "TREC NUTRITION L-CARNITINE 3000", Price = 450, imgSrc = "https://ik.imagekit.io/w5l3jpc0n/trec.png?updatedAt=1686178714843" },
                new Product { ProductId = 16, TypeOfProduct = "l-carnitine", Title = "SPORTER L- CARNITINE", Description = "SPORTER L- CARNITINE 60000 - 0,5Л", Price = 380, imgSrc = "https://ik.imagekit.io/w5l3jpc0n/sporter.png?updatedAt=1686178714667" }
                );
        }
    }
}
