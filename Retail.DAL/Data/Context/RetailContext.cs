using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Retail.DAL;

public class RetailContext : DbContext
{
    public RetailContext() { }

    public RetailContext(DbContextOptions<RetailContext> options) : base(options)
    {

    }
    public DbSet<Product> Products => Set<Product>();
    public DbSet<Category> Categories => Set<Category>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());



        modelBuilder.Entity<Category>().HasData(

            new Category
            {
                ID = Guid.Parse("c2ae51c9-913a-4e7d-a7b5-ef1efc8f9d3e"),
                NAME = "Furnitures",
                DESCRIPTION = "Experience unparalleled comfort and style with our exquisite collection of furniture. Transform your living spaces with our carefully crafted pieces, designed for both beauty and functionality."

            },
            new Category
            {
                ID = Guid.Parse("4b9ad45e-864e-497c-94e8-37dd14027978"),
                NAME = "Shoes",
                DESCRIPTION = "Step into a world of fashion and comfort with our diverse range of shoes. From casual to formal, our footwear collection is curated to elevate your style and keep you on-trend."

            },
            new Category
            {
                ID = Guid.Parse("e18e42b7-799e-4b3b-a084-c55d4bb5da3f"),
                NAME = "Electronics",
                DESCRIPTION = "Explore cutting-edge technology and innovation with our electronic products. Our selection includes high-quality gadgets and devices that are designed to enhance your lifestyle and keep you connected."
            });

        //Furniture Products
        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                ID = Guid.NewGuid(),
                NAME = "Silver Lounge Chair",
                DESCRIPTION = "Very comfortable Silver lounge chair",
                PRICE = 2999,
                QTY = 77,
                PIC = "images/Furniture/Silver Lounge Chair.jpeg",
                CATEGORY_ID = Guid.Parse("c2ae51c9-913a-4e7d-a7b5-ef1efc8f9d3e")

            },
            new Product
            {
                ID = Guid.NewGuid(),
                NAME = "Luxury Leather Sofa",
                DESCRIPTION = "Elegant and comfortable luxury leather sofa.",
                PRICE = 1000,
                QTY = 0,
                PIC = "images/Furniture/Luxury Leather Sofa.jpeg",
                CATEGORY_ID = Guid.Parse("c2ae51c9-913a-4e7d-a7b5-ef1efc8f9d3e")

            },
            new Product
            {
                ID = Guid.NewGuid(),
                NAME = "Wooden Dining Table Set",
                DESCRIPTION = "Solid wood dining table set with chairs.",
                PRICE = 1499,
                QTY = 20,
                PIC = "images/Furniture/Wooden Dining Table Set.jpeg",
                CATEGORY_ID = Guid.Parse("c2ae51c9-913a-4e7d-a7b5-ef1efc8f9d3e")

            },
            new Product
            {

                ID = Guid.NewGuid(),
                NAME = "Lounge Chair",
                DESCRIPTION = "Very comfortable lounge chair",
                PRICE = 999,
                QTY = 10,
                PIC = "images/Furniture/Lounge Chair.jpeg",

                CATEGORY_ID = Guid.Parse("c2ae51c9-913a-4e7d-a7b5-ef1efc8f9d3e")

            },
            new Product
            {
                ID = Guid.NewGuid(),
                NAME = "Pink Leather Office Chair",
                DESCRIPTION = "Very comfortable pink leather office chair",
                PRICE = 4999,
                QTY = 56,
                PIC = "images/Furniture/Pink Leather Office Chair.jpeg",

                CATEGORY_ID = Guid.Parse("c2ae51c9-913a-4e7d-a7b5-ef1efc8f9d3e")

            },

              //Shoes

              new Product
              {
                  ID = Guid.NewGuid(),
                  NAME = "Running Shoes - Men",
                  DESCRIPTION = "High-performance running shoes for men.",
                  PRICE = 299,
                  QTY = 58,
                  PIC = "images/Shoes/Running Shoes - Men.jpeg",
                  CATEGORY_ID = Guid.Parse("4b9ad45e-864e-497c-94e8-37dd14027978")

              },
              new Product
              {
                  ID = Guid.NewGuid(),
                  NAME = "Casual Sneakers - Women",
                  DESCRIPTION = "Stylish and comfortable casual sneakers for women",
                  PRICE = 499,
                  QTY = 0,
                  PIC = "images/Shoes/Casual Sneakers - Women.jpeg",
                  CATEGORY_ID = Guid.Parse("4b9ad45e-864e-497c-94e8-37dd14027978")

              },
              new Product
              {
                  ID = Guid.NewGuid(),
                  NAME = "Leather Boots - Unisex",
                  DESCRIPTION = "Classic leather boots suitable for both men and women.",
                  PRICE = 334,
                  QTY = 95,
                  PIC = "images/Shoes/Leather Boots - Unisex.jpeg",
                  CATEGORY_ID = Guid.Parse("4b9ad45e-864e-497c-94e8-37dd14027978")

              },
              new Product
              {

                  ID = Guid.NewGuid(),
                  NAME = "Sandals with Arch Support",
                  DESCRIPTION = "Comfortable sandals designed for arch support",
                  PRICE = 99,
                  QTY = 90,
                  PIC = "images/Shoes/Sandals with Arch Support.jpeg",
                  CATEGORY_ID = Guid.Parse("4b9ad45e-864e-497c-94e8-37dd14027978")

              },
              new Product
              {
                  ID = Guid.NewGuid(),
                  NAME = "Formal Shoes - Men",
                  DESCRIPTION = "Elegant formal shoes for men.",
                  PRICE = 699,
                  QTY = 145,
                  PIC = "images/Shoes/Formal Shoes - Men.jpeg",
                  CATEGORY_ID = Guid.Parse("4b9ad45e-864e-497c-94e8-37dd14027978")

              },

              //Electronics Products
              new Product
              {
                  ID = Guid.NewGuid(),
                  NAME = "Canon Digital Camera",
                  DESCRIPTION = "Canon Digital Camera - High quality digital camera provided by Canon",
                  PRICE = 9999,
                  QTY = 8,
                  PIC = "images/Electronic/Canon Digital Camera.jpeg",
                  CATEGORY_ID = Guid.Parse("e18e42b7-799e-4b3b-a084-c55d4bb5da3f")

              },
              new Product
              {
                  ID = Guid.NewGuid(),
                  NAME = "Smart Home Security System",
                  DESCRIPTION = "Complete smart home security solution.",
                  PRICE = 29999,
                  QTY = 0,
                  PIC = "images/Electronic/Smart Home Security System.jpeg",
                  CATEGORY_ID = Guid.Parse("e18e42b7-799e-4b3b-a084-c55d4bb5da3f")

              },
              new Product
              {
                  ID = Guid.NewGuid(),
                  NAME = "Digital Camera Kit",
                  DESCRIPTION = "Professional digital camera with accessories.",
                  PRICE = 19999,
                  QTY = 15,
                  PIC = "images/Electronic/Digital Camera Kit.jpeg",
                  CATEGORY_ID = Guid.Parse("e18e42b7-799e-4b3b-a084-c55d4bb5da3f")

              },
              new Product
              {
                  ID = Guid.NewGuid(),
                  NAME = "Sennheiser Digital Camera with Tripod",
                  DESCRIPTION = "Sennheiser Digital Camera - High quality digital camera provided by Sennheiser - includes tripod",
                  PRICE = 14999,
                  QTY = 20,
                  PIC = "images/Electronic/Sennheiser Digital Camera with Tripod.jpeg",
                  CATEGORY_ID = Guid.Parse("e18e42b7-799e-4b3b-a084-c55d4bb5da3f")

              },
              new Product
              {
                  ID = Guid.NewGuid(),
                  NAME = "On-ear Black Headphones",
                  DESCRIPTION = "On-ear Black Headphones - these headphones are not wireless",
                  PRICE = 9977,
                  QTY = 37,
                  PIC = "images/Electronic/On-ear Black Headphones.jpeg",
                  CATEGORY_ID = Guid.Parse("e18e42b7-799e-4b3b-a084-c55d4bb5da3f")

              });
    }

}
