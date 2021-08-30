using Microsoft.EntityFrameworkCore;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopApp.DataAccess.Concrete.EfCore
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new ShopContext();

            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Categories.Count() == 0)
                {
                    context.Categories.AddRange(Categories);
                }

                if (context.Products.Count() == 0)
                {
                    context.Products.AddRange(Products);
                    context.AddRange(ProductCategory);
                }

                context.SaveChanges();
            }
        }

        private static Category[] Categories =     {
            new Category() { Name="League of Legends"},
            new Category() { Name="FIFA"},
            new Category() { Name="Steam"}
        };

        private static Product[] Products =
        {
            new Product(){ Name="League of Legends 840RP", Price=24, ImageUrl="1.jpg", Description="<p>Ürün açıklaması hazırlanıyor...</p>"},
            new Product(){ Name="League of Legends 1.780RP", Price=48, ImageUrl="2.jpg", Description="<pÜrün açıklaması hazırlanıyor...</p>"},
            new Product(){ Name="League of Legends 3.620RP", Price=96, ImageUrl="3.jpg", Description="<p>Ürün açıklaması hazırlanıyor...</p>"},
            new Product(){ Name="League of Legends 6.450RP", Price=162, ImageUrl="4.jpg", Description="<p>Ürün açıklaması hazırlanıyor...</p>"},
            new Product(){ Name="League of Legends 12.800RP", Price=300, ImageUrl="5.jpg", Description="<p>Ürün açıklaması hazırlanıyor...</p>"},
            new Product(){ Name="FIFA 4.600Point", Price=240, ImageUrl="6.jpg", Description="<p>Ürün açıklaması hazırlanıyor...</p>"},
            new Product(){ Name="FIFA 12.000Point", Price=589, ImageUrl="7.jpg", Description="<p>Ürün açıklaması hazırlanıyor...</p>"},
        };

        private static ProductCategory[] ProductCategory =
       {
            new ProductCategory() { Product= Products[0],Category= Categories[0]},
            new ProductCategory() { Product= Products[1],Category= Categories[0]},
            new ProductCategory() { Product= Products[2],Category= Categories[0]},
            new ProductCategory() { Product= Products[3],Category= Categories[0]},
            new ProductCategory() { Product= Products[4],Category= Categories[0]},
            new ProductCategory() { Product= Products[5],Category= Categories[1]},
            new ProductCategory() { Product= Products[6],Category= Categories[1]}
        };
    }
}