using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DemoMVC.Migrations
{
    /// <inheritdoc />
    public partial class DataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Reference", "Email", "FirstName", "IsDeleted", "LastName", "Phone" },
                values: new object[,]
                {
                    { "C001", "alice.durand@example.com", "Alice", false, "Durand", "0612345678" },
                    { "C002", "thomas.martin@example.com", "Thomas", false, "Martin", "0698765432" },
                    { "C003", "julie.bernard@example.com", "Julie", false, "Bernard", "0711122233" },
                    { "C004", "hugo.petit@example.com", "Hugo", false, "Petit", "0788889999" },
                    { "C005", "emma.robert@example.com", "Emma", false, "Robert", "0677001122" },
                    { "C006", "lucas.richard@example.com", "Lucas", false, "Richard", "0655443322" },
                    { "C007", "chloe.moreau@example.com", "Chloé", false, "Moreau", "0777001122" },
                    { "C008", "nathan.simon@example.com", "Nathan", false, "Simon", "0611223344" },
                    { "C009", "manon.laurent@example.com", "Manon", false, "Laurent", "0666554433" },
                    { "C010", "louis.lefebvre@example.com", "Louis", false, "Lefebvre", "0622334455" },
                    { "C011", "camille.michel@example.com", "Camille", false, "Michel", "0688997744" },
                    { "C012", "arthur.garcia@example.com", "Arthur", false, "Garcia", "0633445566" },
                    { "C013", "lea.david@example.com", "Léa", false, "David", "0700112233" },
                    { "C014", "gabriel.roux@example.com", "Gabriel", false, "Roux", "0755667788" },
                    { "C015", "sarah.vincent@example.com", "Sarah", false, "Vincent", "0766007788" },
                    { "C016", "noah.muller@example.com", "Noah", false, "Muller", "0799001122" },
                    { "C017", "clara.fournier@example.com", "Clara", false, "Fournier", "0644556677" },
                    { "C018", "ethan.girard@example.com", "Ethan", false, "Girard", "0722003344" },
                    { "C019", "sophie.andre@example.com", "Sophie", false, "Andre", "0677889900" },
                    { "C020", "antoine.mercier@example.com", "Antoine", false, "Mercier", "0611998877" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Reference", "Description", "IsDeleted", "LastBuyingPrice", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { "P001", "Clavier mécanique rétroéclairé RGB", false, 65.00m, "Clavier mécanique", 89.99m, 25 },
                    { "P002", "Souris sans fil haute précision", false, 35.00m, "Souris gaming", 49.99m, 40 },
                    { "P003", "Moniteur Full HD 75Hz", false, 120.00m, "Écran 24 pouces", 159.90m, 12 },
                    { "P004", "Moniteur 2K IPS 144Hz", false, 250.00m, "Écran 27 pouces", 329.90m, 8 },
                    { "P005", "Casque sans fil avec réduction de bruit", false, 90.00m, "Casque audio", 119.00m, 15 },
                    { "P006", "Caméra 1080p avec micro intégré", false, 40.00m, "Webcam HD", 59.00m, 30 },
                    { "P007", "SSD NVMe haute performance", false, 55.00m, "Disque SSD 500GB", 75.00m, 50 },
                    { "P008", "SSD NVMe PCIe Gen4 rapide", false, 110.00m, "Disque SSD 1TB", 139.00m, 35 },
                    { "P009", "Clé USB 3.1 haute vitesse", false, 9.00m, "Clé USB 64GB", 14.99m, 100 },
                    { "P010", "Clé USB 3.2 ultra rapide", false, 18.00m, "Clé USB 128GB", 24.99m, 80 },
                    { "P011", "Dock USB-C avec HDMI et RJ45", false, 65.00m, "Station d’accueil", 89.00m, 20 },
                    { "P012", "Chargeur universel USB-C Power Delivery", false, 25.00m, "Chargeur 65W", 39.00m, 60 },
                    { "P013", "Câble HDMI 2.1 compatible 4K/8K", false, 10.00m, "Câble HDMI 2m", 19.90m, 150 },
                    { "P014", "Câble USB-C vers USB-C 3.2", false, 7.00m, "Câble USB-C 1m", 12.90m, 200 },
                    { "P015", "Enceinte portable étanche IPX7", false, 40.00m, "Enceinte Bluetooth", 59.99m, 45 },
                    { "P016", "Imprimante couleur Wi-Fi multifonction", false, 95.00m, "Imprimante jet d’encre", 129.00m, 10 },
                    { "P017", "Imprimante laser monochrome rapide", false, 150.00m, "Imprimante laser", 189.00m, 7 },
                    { "P018", "Tablette Android 128GB", false, 200.00m, "Tablette 10 pouces", 249.00m, 18 },
                    { "P019", "Laptop 15,6'' i5 16GB RAM 512GB SSD", false, 750.00m, "Ordinateur portable", 899.00m, 5 },
                    { "P020", "Laptop 17'' i7 RTX 4060", false, 1450.00m, "Ordinateur portable gaming", 1699.00m, 3 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Reference", "CreationDate", "CustomerRef", "OrderStatus", "PaymentDate", "TotalPrice" },
                values: new object[,]
                {
                    { "O001", new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "C001", 2, new DateTime(2025, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 259.90m },
                    { "O002", new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "C003", 1, null, 89.99m },
                    { "O003", new DateTime(2025, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "C002", 2, new DateTime(2025, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1599.00m },
                    { "O004", new DateTime(2025, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "C005", 0, null, 49.99m },
                    { "O005", new DateTime(2025, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "C004", 2, new DateTime(2025, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 329.90m },
                    { "O006", new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C006", 1, null, 75.00m },
                    { "O007", new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "C010", 2, new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1249.00m },
                    { "O008", new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "C008", 0, null, 199.00m },
                    { "O009", new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "C012", 3, null, 59.99m },
                    { "O010", new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "C015", 2, new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 899.00m }
                });

            migrationBuilder.InsertData(
                table: "OrderLines",
                columns: new[] { "Id", "OrderRef", "Price", "ProductRef", "Quantity" },
                values: new object[,]
                {
                    { 1, "O001", 89.99m, "P001", 1 },
                    { 2, "O001", 49.99m, "P002", 2 },
                    { 3, "O001", 59.00m, "P006", 1 },
                    { 4, "O002", 59.99m, "P015", 1 },
                    { 5, "O002", 19.90m, "P013", 2 },
                    { 6, "O002", 12.90m, "P014", 1 },
                    { 7, "O003", 1699.00m, "P020", 1 },
                    { 8, "O003", 75.00m, "P007", 2 },
                    { 9, "O003", 14.99m, "P009", 3 },
                    { 10, "O004", 49.99m, "P002", 1 },
                    { 11, "O004", 89.99m, "P001", 1 },
                    { 12, "O004", 24.99m, "P010", 2 },
                    { 13, "O005", 329.90m, "P004", 1 },
                    { 14, "O005", 19.90m, "P013", 2 },
                    { 15, "O005", 12.90m, "P014", 2 },
                    { 16, "O005", 89.00m, "P011", 1 },
                    { 17, "O006", 75.00m, "P007", 1 },
                    { 18, "O006", 139.00m, "P008", 1 },
                    { 19, "O006", 14.99m, "P009", 3 },
                    { 20, "O007", 899.00m, "P019", 1 },
                    { 21, "O007", 129.00m, "P016", 1 },
                    { 22, "O007", 59.00m, "P006", 1 },
                    { 23, "O007", 39.00m, "P012", 2 },
                    { 24, "O008", 119.00m, "P005", 1 },
                    { 25, "O008", 59.99m, "P015", 1 },
                    { 26, "O008", 19.90m, "P013", 2 },
                    { 27, "O008", 12.90m, "P014", 3 },
                    { 28, "O009", 59.99m, "P015", 1 },
                    { 29, "O009", 24.99m, "P010", 2 },
                    { 30, "O009", 59.00m, "P006", 1 },
                    { 31, "O009", 49.99m, "P002", 1 },
                    { 32, "O010", 899.00m, "P019", 1 },
                    { 33, "O010", 75.00m, "P007", 1 },
                    { 34, "O010", 139.00m, "P008", 1 },
                    { 35, "O010", 14.99m, "P009", 2 },
                    { 36, "O010", 39.00m, "P012", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Reference",
                keyValue: "C007");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Reference",
                keyValue: "C009");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Reference",
                keyValue: "C011");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Reference",
                keyValue: "C013");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Reference",
                keyValue: "C014");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Reference",
                keyValue: "C016");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Reference",
                keyValue: "C017");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Reference",
                keyValue: "C018");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Reference",
                keyValue: "C019");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Reference",
                keyValue: "C020");

            migrationBuilder.DeleteData(
                table: "OrderLines",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderLines",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderLines",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderLines",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrderLines",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OrderLines",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "OrderLines",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "OrderLines",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "OrderLines",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "OrderLines",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "OrderLines",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "OrderLines",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "OrderLines",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "OrderLines",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "OrderLines",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "OrderLines",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "OrderLines",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "OrderLines",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "OrderLines",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "OrderLines",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "OrderLines",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "OrderLines",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "OrderLines",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "OrderLines",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "OrderLines",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "OrderLines",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "OrderLines",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "OrderLines",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "OrderLines",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "OrderLines",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "OrderLines",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "OrderLines",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "OrderLines",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "OrderLines",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "OrderLines",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "OrderLines",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Reference",
                keyValue: "P003");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Reference",
                keyValue: "P017");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Reference",
                keyValue: "P018");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Reference",
                keyValue: "O001");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Reference",
                keyValue: "O002");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Reference",
                keyValue: "O003");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Reference",
                keyValue: "O004");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Reference",
                keyValue: "O005");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Reference",
                keyValue: "O006");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Reference",
                keyValue: "O007");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Reference",
                keyValue: "O008");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Reference",
                keyValue: "O009");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Reference",
                keyValue: "O010");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Reference",
                keyValue: "P001");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Reference",
                keyValue: "P002");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Reference",
                keyValue: "P004");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Reference",
                keyValue: "P005");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Reference",
                keyValue: "P006");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Reference",
                keyValue: "P007");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Reference",
                keyValue: "P008");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Reference",
                keyValue: "P009");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Reference",
                keyValue: "P010");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Reference",
                keyValue: "P011");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Reference",
                keyValue: "P012");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Reference",
                keyValue: "P013");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Reference",
                keyValue: "P014");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Reference",
                keyValue: "P015");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Reference",
                keyValue: "P016");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Reference",
                keyValue: "P019");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Reference",
                keyValue: "P020");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Reference",
                keyValue: "C001");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Reference",
                keyValue: "C002");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Reference",
                keyValue: "C003");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Reference",
                keyValue: "C004");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Reference",
                keyValue: "C005");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Reference",
                keyValue: "C006");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Reference",
                keyValue: "C008");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Reference",
                keyValue: "C010");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Reference",
                keyValue: "C012");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Reference",
                keyValue: "C015");
        }
    }
}
