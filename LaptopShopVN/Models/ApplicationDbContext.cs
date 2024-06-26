using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LaptopShopVN.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }    
        public DbSet<OrderDetail> OrderDetails { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            /*------------------------------GENERATE DATA------------------------------*/

            /*--------------------CATEGORY--------------------*/
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Latop", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Bàn Phím", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Chuột", DisplayOrder = 3 });

            /*--------------------PRODUCT--------------------*/

            modelBuilder.Entity<Product>().HasData(
                //laptop
                new Product { Id = 1, Name = "Laptop gaming Lenovo LOQ 15ARP9 83JC003VVN", Price = 300, CategoryId = 1 },
                new Product { Id = 2, Name = "Laptop gaming Lenovo LOQ 15IRX9 83DV00D5VN", Price = 350, CategoryId = 1 },
                new Product { Id = 3, Name = "Laptop gaming Acer Nitro 5 Tiger AN515 58 50EE", Price = 400, CategoryId = 1 },
                new Product { Id = 4, Name = "Laptop gaming MSI Cyborg 15 A12VE 412VN", Price = 420, CategoryId = 1 },
                new Product { Id = 5, Name = "Laptop gaming Acer Aspire 7 A715 76G 73FM", Price = 630, CategoryId = 1 },
                new Product { Id = 6, Name = "Laptop gaming Gigabyte G5 MF F2PH333SH", Price = 750, CategoryId = 1 },
                new Product { Id = 7, Name = "Laptop gaming Acer Aspire 7 A715 76G 5806", Price = 820, CategoryId = 1 },
                new Product { Id = 8, Name = "Laptop gaming Gigabyte G5 ME 51VN263SH", Price = 950, CategoryId = 1 },
                new Product { Id = 9, Name = "Laptop gaming MSI Katana GF66 12UCK 804VN", Price = 1200, CategoryId = 1 },
                new Product { Id = 10, Name = "Laptop MSI Alpha 15 B5EEK 203VN ", Price = 1450, CategoryId = 1 },
                new Product { Id = 11, Name = "Laptop gaming Lenovo LOQ 15IAX9 83FQ0005VN", Price = 750, CategoryId = 1 },
                new Product { Id = 12, Name = "Laptop gaming MSI GF63 Thin 12VE 460VN", Price = 1250, CategoryId = 1 },
                //keyboard
                new Product { Id = 13, Name = "Bàn phím Không dây DareU EK87 Pro RGB Trắng Dream", Price = 950, CategoryId = 2 },
                new Product { Id = 14, Name = "Bàn phím AKKO MU01 Mountain Seclusion Piano Pro", Price = 1200, CategoryId = 2 },
                new Product { Id = 15, Name = "Bàn phím Không dây DareU EK87 Pro RGB Đen Dream ", Price = 1450, CategoryId = 2 },
                new Product { Id = 16, Name = "Bàn phím Asus ROG Strix Scope II 96 Wireless ROG NX Snow", Price = 750, CategoryId = 2 },
                new Product { Id = 17, Name = "Bàn phím DareU Không dây EK98 Pro RGB Trắng Dream", Price = 1250, CategoryId = 2 },
                //Mouse
                new Product { Id = 18, Name = "Chuột gaming Rapoo VT200 RGB Wireless", Price = 950, CategoryId = 3 },
                new Product { Id = 19, Name = "Chuột Razer Deathadder V3 Pro Faker Edition", Price = 1200, CategoryId = 3 },
                new Product { Id = 20, Name = "Chuột Rapoo Không dây V300SE Black ", Price = 1450, CategoryId = 3 },
                new Product { Id = 21, Name = "Chuột Rapoo VT9 Air Gaming Không Dây Trắng Tím", Price = 750, CategoryId = 3 },
                new Product { Id = 22, Name = "Chuột Razer Không dây Viper V3 Pro Trắng", Price = 1250, CategoryId = 3 }
                );

        }

    }
}
