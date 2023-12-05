using System.Text.Json;
using Core.Entities;

namespace Infrastructure.Data
{
    public class StoreContextSeed
    {
        public static async Task SeedAsync(StoreContext context)
        {
            if(!context.ProductBrands.Any())
            {
                var brandsData = File.ReadAllText("/Users/sakethkalam/skinet/Infrastructure/SeedData/brands.json");
                var brands = JsonSerializer.Deserialize<List<ProductBrand>>(brandsData);
                context.ProductBrands.AddRange(brands);
            }

            if(!context.ProductTypes.Any())
            {
                var typesdata = File.ReadAllText("/Users/sakethkalam/skinet/Infrastructure/SeedData/types.json");
                var types = JsonSerializer.Deserialize<List<ProductType>>(typesdata);
                context.ProductTypes.AddRange(types);
            }

            if(!context.Products.Any())
            {
                var productsdata = File.ReadAllText("/Users/sakethkalam/skinet/Infrastructure/SeedData/products.json");
                var products = JsonSerializer.Deserialize<List<Product>>(productsdata);
                context.Products.AddRange(products);
            }

            if(context.ChangeTracker.HasChanges()) await context.SaveChangesAsync();
        }
    }
}