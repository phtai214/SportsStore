﻿using Microsoft.EntityFrameworkCore;

namespace SportsStore.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();
            if (context.Database.GetPendingMigrations().Any()) { context.Database.Migrate(); }
            if (!context.Products.Any())
            {
                context.Products.AddRange(new Products { Name = "Kayak", Description = "A boat for one person", Category = "Watersports", Price = 275 }, 
                    new Products { Name = "Lifejacket", Description = "Protective and fashionable", Category = "Watersports", Price = 48.95m }, 
                    new Products { Name = "Soccer Ball", Description = "FIFA-approved size and weight", Category = "Soccer", Price = 19.50m }, 
                    new Products { Name = "Corner Flags", Description = "Give your playing field a professional touch", Category = "Soccer", Price = 34.95m },
                    new Products { Name = "Stadium", Description = "Flat-packed 35,000-seat stadium", Category = "Soccer", Price = 79500 }, 
                    new Products { Name = "Thinking Cap", Description = "Improve brain efficiency by 75%", Category = "Chess", Price = 16 }, 
                    new Products { Name = "Unsteady Chair", Description = "Secretly give your opponent a disadvantage", Category = "Chess", Price = 29.95m }, 
                    new Products { Name = "Human Chess Board", Description = "A fun game for the family", Category = "Chess", Price = 75 }, 
                    new Products { Name = "Bling-Bling King", Description = "Gold-plated, diamond-studded King", Category = "Chess", Price = 1200 });
                context.SaveChanges();      
            }
            
        }
    }
}