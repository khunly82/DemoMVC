using DemoMVC.Configurations;
using DemoMVC.Entities;
using DemoMVC.Utils;
using Microsoft.EntityFrameworkCore;

namespace DemoMVC
{
    // pour travailler avec EF
    // il faut hériter de DbContext
    public class StockContext(DbContextOptions options) : DbContext(options)
    {
        // il faut aussi déclarer les tables
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new OrderLineConfiguration());

            // si je suis en debug
            // ajouter des fausses données (seed)

#if DEBUG
            modelBuilder.Entity<Product>().HasData([
                new Product { Reference = "P001", Name = "Clavier mécanique", Description = "Clavier mécanique rétroéclairé RGB", Price = 89.99m, LastBuyingPrice = 65.00m, Quantity = 25, IsDeleted = false },
    new Product { Reference = "P002", Name = "Souris gaming", Description = "Souris sans fil haute précision", Price = 49.99m, LastBuyingPrice = 35.00m, Quantity = 40, IsDeleted = false },
    new Product { Reference = "P003", Name = "Écran 24 pouces", Description = "Moniteur Full HD 75Hz", Price = 159.90m, LastBuyingPrice = 120.00m, Quantity = 12, IsDeleted = false },
    new Product { Reference = "P004", Name = "Écran 27 pouces", Description = "Moniteur 2K IPS 144Hz", Price = 329.90m, LastBuyingPrice = 250.00m, Quantity = 8, IsDeleted = false },
    new Product { Reference = "P005", Name = "Casque audio", Description = "Casque sans fil avec réduction de bruit", Price = 119.00m, LastBuyingPrice = 90.00m, Quantity = 15, IsDeleted = false },
    new Product { Reference = "P006", Name = "Webcam HD", Description = "Caméra 1080p avec micro intégré", Price = 59.00m, LastBuyingPrice = 40.00m, Quantity = 30, IsDeleted = false },
    new Product { Reference = "P007", Name = "Disque SSD 500GB", Description = "SSD NVMe haute performance", Price = 75.00m, LastBuyingPrice = 55.00m, Quantity = 50, IsDeleted = false },
    new Product { Reference = "P008", Name = "Disque SSD 1TB", Description = "SSD NVMe PCIe Gen4 rapide", Price = 139.00m, LastBuyingPrice = 110.00m, Quantity = 35, IsDeleted = false },
    new Product { Reference = "P009", Name = "Clé USB 64GB", Description = "Clé USB 3.1 haute vitesse", Price = 14.99m, LastBuyingPrice = 9.00m, Quantity = 100, IsDeleted = false },
    new Product { Reference = "P010", Name = "Clé USB 128GB", Description = "Clé USB 3.2 ultra rapide", Price = 24.99m, LastBuyingPrice = 18.00m, Quantity = 80, IsDeleted = false },
    new Product { Reference = "P011", Name = "Station d’accueil", Description = "Dock USB-C avec HDMI et RJ45", Price = 89.00m, LastBuyingPrice = 65.00m, Quantity = 20, IsDeleted = false },
    new Product { Reference = "P012", Name = "Chargeur 65W", Description = "Chargeur universel USB-C Power Delivery", Price = 39.00m, LastBuyingPrice = 25.00m, Quantity = 60, IsDeleted = false },
    new Product { Reference = "P013", Name = "Câble HDMI 2m", Description = "Câble HDMI 2.1 compatible 4K/8K", Price = 19.90m, LastBuyingPrice = 10.00m, Quantity = 150, IsDeleted = false },
    new Product { Reference = "P014", Name = "Câble USB-C 1m", Description = "Câble USB-C vers USB-C 3.2", Price = 12.90m, LastBuyingPrice = 7.00m, Quantity = 200, IsDeleted = false },
    new Product { Reference = "P015", Name = "Enceinte Bluetooth", Description = "Enceinte portable étanche IPX7", Price = 59.99m, LastBuyingPrice = 40.00m, Quantity = 45, IsDeleted = false },
    new Product { Reference = "P016", Name = "Imprimante jet d’encre", Description = "Imprimante couleur Wi-Fi multifonction", Price = 129.00m, LastBuyingPrice = 95.00m, Quantity = 10, IsDeleted = false },
    new Product { Reference = "P017", Name = "Imprimante laser", Description = "Imprimante laser monochrome rapide", Price = 189.00m, LastBuyingPrice = 150.00m, Quantity = 7, IsDeleted = false },
    new Product { Reference = "P018", Name = "Tablette 10 pouces", Description = "Tablette Android 128GB", Price = 249.00m, LastBuyingPrice = 200.00m, Quantity = 18, IsDeleted = false },
    new Product { Reference = "P019", Name = "Ordinateur portable", Description = "Laptop 15,6'' i5 16GB RAM 512GB SSD", Price = 899.00m, LastBuyingPrice = 750.00m, Quantity = 5, IsDeleted = false },
    new Product { Reference = "P020", Name = "Ordinateur portable gaming", Description = "Laptop 17'' i7 RTX 4060", Price = 1699.00m, LastBuyingPrice = 1450.00m, Quantity = 3, IsDeleted = false }
            ]);

            modelBuilder.Entity<Customer>().HasData([
               new Customer { Reference = "C001", LastName = "Durand", FirstName = "Alice", Email = "alice.durand@example.com", Phone = "0612345678", IsDeleted = false },
    new Customer { Reference = "C002", LastName = "Martin", FirstName = "Thomas", Email = "thomas.martin@example.com", Phone = "0698765432", IsDeleted = false },
    new Customer { Reference = "C003", LastName = "Bernard", FirstName = "Julie", Email = "julie.bernard@example.com", Phone = "0711122233", IsDeleted = false },
    new Customer { Reference = "C004", LastName = "Petit", FirstName = "Hugo", Email = "hugo.petit@example.com", Phone = "0788889999", IsDeleted = false },
    new Customer { Reference = "C005", LastName = "Robert", FirstName = "Emma", Email = "emma.robert@example.com", Phone = "0677001122", IsDeleted = false },
    new Customer { Reference = "C006", LastName = "Richard", FirstName = "Lucas", Email = "lucas.richard@example.com", Phone = "0655443322", IsDeleted = false },
    new Customer { Reference = "C007", LastName = "Moreau", FirstName = "Chloé", Email = "chloe.moreau@example.com", Phone = "0777001122", IsDeleted = false },
    new Customer { Reference = "C008", LastName = "Simon", FirstName = "Nathan", Email = "nathan.simon@example.com", Phone = "0611223344", IsDeleted = false },
    new Customer { Reference = "C009", LastName = "Laurent", FirstName = "Manon", Email = "manon.laurent@example.com", Phone = "0666554433", IsDeleted = false },
    new Customer { Reference = "C010", LastName = "Lefebvre", FirstName = "Louis", Email = "louis.lefebvre@example.com", Phone = "0622334455", IsDeleted = false },
    new Customer { Reference = "C011", LastName = "Michel", FirstName = "Camille", Email = "camille.michel@example.com", Phone = "0688997744", IsDeleted = false },
    new Customer { Reference = "C012", LastName = "Garcia", FirstName = "Arthur", Email = "arthur.garcia@example.com", Phone = "0633445566", IsDeleted = false },
    new Customer { Reference = "C013", LastName = "David", FirstName = "Léa", Email = "lea.david@example.com", Phone = "0700112233", IsDeleted = false },
    new Customer { Reference = "C014", LastName = "Roux", FirstName = "Gabriel", Email = "gabriel.roux@example.com", Phone = "0755667788", IsDeleted = false },
    new Customer { Reference = "C015", LastName = "Vincent", FirstName = "Sarah", Email = "sarah.vincent@example.com", Phone = "0766007788", IsDeleted = false },
    new Customer { Reference = "C016", LastName = "Muller", FirstName = "Noah", Email = "noah.muller@example.com", Phone = "0799001122", IsDeleted = false },
    new Customer { Reference = "C017", LastName = "Fournier", FirstName = "Clara", Email = "clara.fournier@example.com", Phone = "0644556677", IsDeleted = false },
    new Customer { Reference = "C018", LastName = "Girard", FirstName = "Ethan", Email = "ethan.girard@example.com", Phone = "0722003344", IsDeleted = false },
    new Customer { Reference = "C019", LastName = "Andre", FirstName = "Sophie", Email = "sophie.andre@example.com", Phone = "0677889900", IsDeleted = false },
    new Customer { Reference = "C020", LastName = "Mercier", FirstName = "Antoine", Email = "antoine.mercier@example.com", Phone = "0611998877", IsDeleted = false }
            ]);


            modelBuilder.Entity<Order>().HasData([
                new Order { Reference = "O001", CreationDate = new DateTime(2025, 1, 12), PaymentDate = new DateTime(2025, 1, 13), CustomerRef = "C001", TotalPrice = 259.90m, OrderStatus = Order.Status.Payed },
    new Order { Reference = "O002", CreationDate = new DateTime(2025, 1, 20), PaymentDate = null, CustomerRef = "C003", TotalPrice = 89.99m, OrderStatus = Order.Status.Pending },
    new Order { Reference = "O003", CreationDate = new DateTime(2025, 2, 5), PaymentDate = new DateTime(2025, 2, 6), CustomerRef = "C002", TotalPrice = 1599.00m, OrderStatus = Order.Status.Payed },
    new Order { Reference = "O004", CreationDate = new DateTime(2025, 2, 14), PaymentDate = null, CustomerRef = "C005", TotalPrice = 49.99m, OrderStatus = Order.Status.InProgress },
    new Order { Reference = "O005", CreationDate = new DateTime(2025, 2, 22), PaymentDate = new DateTime(2025, 2, 23), CustomerRef = "C004", TotalPrice = 329.90m, OrderStatus = Order.Status.Payed },
    new Order { Reference = "O006", CreationDate = new DateTime(2025, 3, 2), PaymentDate = null, CustomerRef = "C006", TotalPrice = 75.00m, OrderStatus = Order.Status.Pending },
    new Order { Reference = "O007", CreationDate = new DateTime(2025, 3, 10), PaymentDate = new DateTime(2025, 3, 12), CustomerRef = "C010", TotalPrice = 1249.00m, OrderStatus = Order.Status.Payed },
    new Order { Reference = "O008", CreationDate = new DateTime(2025, 3, 15), PaymentDate = null, CustomerRef = "C008", TotalPrice = 199.00m, OrderStatus = Order.Status.InProgress },
    new Order { Reference = "O009", CreationDate = new DateTime(2025, 3, 22), PaymentDate = null, CustomerRef = "C012", TotalPrice = 59.99m, OrderStatus = Order.Status.Canceled },
    new Order { Reference = "O010", CreationDate = new DateTime(2025, 3, 25), PaymentDate = new DateTime(2025, 3, 26), CustomerRef = "C015", TotalPrice = 899.00m, OrderStatus = Order.Status.Payed }
            ]);

            modelBuilder.Entity<OrderLine>().HasData([new OrderLine { Id = 1, OrderRef = "O001", ProductRef = "P001", Price = 89.99m, Quantity = 1 },
    new OrderLine { Id = 2, OrderRef = "O001", ProductRef = "P002", Price = 49.99m, Quantity = 2 },
    new OrderLine { Id = 3, OrderRef = "O001", ProductRef = "P006", Price = 59.00m, Quantity = 1 },

    // O002 (Julie Bernard)
    new OrderLine { Id = 4, OrderRef = "O002", ProductRef = "P015", Price = 59.99m, Quantity = 1 },
    new OrderLine { Id = 5, OrderRef = "O002", ProductRef = "P013", Price = 19.90m, Quantity = 2 },
    new OrderLine { Id = 6, OrderRef = "O002", ProductRef = "P014", Price = 12.90m, Quantity = 1 },

    // O003 (Thomas Martin)
    new OrderLine { Id = 7, OrderRef = "O003", ProductRef = "P020", Price = 1699.00m, Quantity = 1 },
    new OrderLine { Id = 8, OrderRef = "O003", ProductRef = "P007", Price = 75.00m, Quantity = 2 },
    new OrderLine { Id = 9, OrderRef = "O003", ProductRef = "P009", Price = 14.99m, Quantity = 3 },

    // O004 (Emma Robert)
    new OrderLine { Id = 10, OrderRef = "O004", ProductRef = "P002", Price = 49.99m, Quantity = 1 },
    new OrderLine { Id = 11, OrderRef = "O004", ProductRef = "P001", Price = 89.99m, Quantity = 1 },
    new OrderLine { Id = 12, OrderRef = "O004", ProductRef = "P010", Price = 24.99m, Quantity = 2 },

    // O005 (Hugo Petit)
    new OrderLine { Id = 13, OrderRef = "O005", ProductRef = "P004", Price = 329.90m, Quantity = 1 },
    new OrderLine { Id = 14, OrderRef = "O005", ProductRef = "P013", Price = 19.90m, Quantity = 2 },
    new OrderLine { Id = 15, OrderRef = "O005", ProductRef = "P014", Price = 12.90m, Quantity = 2 },
    new OrderLine { Id = 16, OrderRef = "O005", ProductRef = "P011", Price = 89.00m, Quantity = 1 },

    // O006 (Lucas Richard)
    new OrderLine { Id = 17, OrderRef = "O006", ProductRef = "P007", Price = 75.00m, Quantity = 1 },
    new OrderLine { Id = 18, OrderRef = "O006", ProductRef = "P008", Price = 139.00m, Quantity = 1 },
    new OrderLine { Id = 19, OrderRef = "O006", ProductRef = "P009", Price = 14.99m, Quantity = 3 },

    // O007 (Louis Lefebvre)
    new OrderLine { Id = 20, OrderRef = "O007", ProductRef = "P019", Price = 899.00m, Quantity = 1 },
    new OrderLine { Id = 21, OrderRef = "O007", ProductRef = "P016", Price = 129.00m, Quantity = 1 },
    new OrderLine { Id = 22, OrderRef = "O007", ProductRef = "P006", Price = 59.00m, Quantity = 1 },
    new OrderLine { Id = 23, OrderRef = "O007", ProductRef = "P012", Price = 39.00m, Quantity = 2 },

    // O008 (Nathan Simon)
    new OrderLine { Id = 24, OrderRef = "O008", ProductRef = "P005", Price = 119.00m, Quantity = 1 },
    new OrderLine { Id = 25, OrderRef = "O008", ProductRef = "P015", Price = 59.99m, Quantity = 1 },
    new OrderLine { Id = 26, OrderRef = "O008", ProductRef = "P013", Price = 19.90m, Quantity = 2 },
    new OrderLine { Id = 27, OrderRef = "O008", ProductRef = "P014", Price = 12.90m, Quantity = 3 },

    // O009 (Arthur Garcia)
    new OrderLine { Id = 28, OrderRef = "O009", ProductRef = "P015", Price = 59.99m, Quantity = 1 },
    new OrderLine { Id = 29, OrderRef = "O009", ProductRef = "P010", Price = 24.99m, Quantity = 2 },
    new OrderLine { Id = 30, OrderRef = "O009", ProductRef = "P006", Price = 59.00m, Quantity = 1 },
    new OrderLine { Id = 31, OrderRef = "O009", ProductRef = "P002", Price = 49.99m, Quantity = 1 },

    // O010 (Sarah Vincent)
    new OrderLine { Id = 32, OrderRef = "O010", ProductRef = "P019", Price = 899.00m, Quantity = 1 },
    new OrderLine { Id = 33, OrderRef = "O010", ProductRef = "P007", Price = 75.00m, Quantity = 1 },
    new OrderLine { Id = 34, OrderRef = "O010", ProductRef = "P008", Price = 139.00m, Quantity = 1 },
    new OrderLine { Id = 35, OrderRef = "O010", ProductRef = "P009", Price = 14.99m, Quantity = 2 },
    new OrderLine { Id = 36, OrderRef = "O010", ProductRef = "P012", Price = 39.00m, Quantity = 1 }]);


            modelBuilder.Entity<User>().HasData([
                new User { Id = 1, Username = "Khun", Password = PasswordUtils.Hash("khun", "550e8400-e29b-41d4-a716-446655440000"), UserRole = User.Role.Admin },
                new User { Id = 2, Username = "Yass", Password = PasswordUtils.Hash("yass", "3f2504e0-4f89-11d3-9a0c-0305e82c3301"), UserRole = User.Role.Seller },
                new User { Id = 3, Username = "Laur", Password = PasswordUtils.Hash("laur", "9a3b1c6d-7f9e-4a2f-b8e7-123456789abc"), UserRole = User.Role.Restocker },
            ]);
#endif
        }
    }
}
