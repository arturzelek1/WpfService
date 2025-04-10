using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShopApp.Models;

namespace ShopApp
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Models.Product> Products { get; set; }

        public DbSet<Models.Category> Categories { get; set; }

        public DbSet<Models.Client> Clients { get; set; }

        public DbSet<Models.Order> Orders { get; set; }

        public DbSet<Models.OrderDetail> OrderDetails { get; set; }

        public AppDbContext(){

            if (this.Database.EnsureCreated())
                SeedData();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder ob)
        {
            ob.UseInMemoryDatabase(@"ShopDb");
        }

        public void SeedData() {
            Categories.Add(new Category() {Name = "Monitors" });
            Categories.Add(new Category() {Name = "Power Supplies" });
            Categories.Add(new Category() {Name = "Motherboards" });
            Categories.Add(new Category() {Name = "GPU" });
            Categories.Add(new Category() {Name = "CPU" });
            Categories.Add(new Category() {Name = "Headphones" });
            Categories.Add(new Category() {Name = "Keyboards" });
            Categories.Add(new Category() {Name = "Mice" });

            SaveChanges();

            var category = Categories.FirstOrDefault();

            Products.Add(new Product()
            {
                Id = 1,
                Name = "Monitor BENQ Zowie XL2540K",
                CategoryId = category.Id,
                Description = "24,5 CALOWY MONITOR E-SPORTOWY",
                Price = 1349.0
            });
            Products.Add(new Product()
            {
                Id = 2,
                Name = "Logitech G Pro X Superlight",
                CategoryId = 8,
                Description = "Myszka gamingowa",
                Price = 487.0
            });

            Products.Add(new Product()
            {
                Id = 3,
                Name = "LOGITECH G Pro",
                CategoryId = 7,
                Description = "Klawiatura gamingowa",
                Price = 468.0
            });

            SaveChanges();

            Clients.Add(new Client() {Name = "Artur Zelek", Discount = 5, Address = "Kordoszanki Wielkie, ul. Willove" });
            Clients.Add(new Client() { Name = "Baki Perreira", Discount = 60, Address = "Małeogórkowice, ul.Ogórka Zielonego" });

            SaveChanges();

            var client = Clients.First();


            Orders.Add(new Order()
            {
                Id = 1,
                Client = client,
                OrderDate = DateTime.Now,
                Items = new List<OrderDetail>() { new OrderDetail() { Id = 1, OrderId = 1, Count = 5, ProductId = 1 }, new OrderDetail() { Id = 2, OrderId = 1, Count = 10, ProductId = 2 } }
            });

            SaveChanges();
        }
    }
}
