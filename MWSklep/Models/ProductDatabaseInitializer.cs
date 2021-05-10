using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace MWSklep.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseAlways<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Koszulki"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Książki"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Kubki"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Plakaty"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Długopisy"
                },
            };

            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product> {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Koszulka Adidas",
                    Description = "Standardowa koszulka firmy Adidas",
                    ImagePath="kosz3.jpg",
                    UnitPrice = 36.50,
                    CategoryID = 1
               },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Koszulka HunterxHunter",
                    Description = "Koszulka reprezentująca Killue z popularnego anime HunterxHunter",
                    ImagePath="kosz1.jpg",
                    UnitPrice = 25.95,
                     CategoryID = 1
               },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Koszulka Metal Gear Solid",
                    Description = "Koszulka wzorowana na grze Metal Gear Solid",
                    ImagePath="kosz2.jpg",
                    UnitPrice = 33.99,
                    CategoryID = 1
                },
              
                
                new Product
                {
                    ProductID = 4,
                    ProductName = "Książka Pan Tadeusz",
                    Description = "Wielkie dzieło Adama Mickiewicza. Lektura szkolna.",
                    ImagePath="ks1.jpg",
                    UnitPrice = 20.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Książka Hrabia Monte Cristo",
                    Description = "Klasyk autorstwa Alexandra Dumas. Poleca autor strony.",
                    ImagePath="ks2.jpg",
                    UnitPrice = 25.30,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Książka Storm of Swords",
                    Description = "Trzecia część serii Pieśń Lodu i Ognia Georga R.R Martina. Znacznie lepsza niż serial.",
                    ImagePath="ks3.png",
                    UnitPrice = 35.95,
                    CategoryID = 2
                },
               
                new Product
                {
                    ProductID = 7,
                    ProductName = "Kubek Biały",
                    Description = "Krystalicznie biały kubek.",
                    ImagePath="kub1.jpg",
                    UnitPrice = 26.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "Kubek Czarny",
                    Description = "Elegancki czarny kubek.",
                    ImagePath="kub2.jpg",
                    UnitPrice = 29.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "Plakat Metallica",
                    Description = "Plakat promujący płytę Ride the Lightning.",
                    ImagePath="pla1.jpg",
                    UnitPrice = 42.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "Plakat Rolling Stones",
                    Description = "Plakat z logiem zespołu Rolling Stones.",
                    ImagePath="pla2.jpg",
                    UnitPrice = 39.95,
                    CategoryID = 4
                },
                
                new Product
                {
                    ProductID = 11,
                    ProductName = "Długopis Niebieski",
                    Description = "Długopis piszący na niebiesko.",
                    ImagePath="dlu1.jpg",
                    UnitPrice = 2.95,
                    CategoryID = 5
                },

                new Product
                {
                    ProductID = 12,
                    ProductName = "Długopis Czarny",
                    Description = "Długopis piszący na czarno.",
                    ImagePath="dlu2.jpg",
                    UnitPrice = 2.95,
                    CategoryID = 5
                },

                new Product
                {
                    ProductID = 13,
                    ProductName = "Kubek Smile",
                    Description = "Kubek z śmiejącym się emotikonem.",
                    ImagePath="kub3.jpg",
                    UnitPrice = 32.00,
                    CategoryID = 3
                },

                new Product
                {
                    ProductID = 14,
                    ProductName = "Plakat The Smiths",
                    Description = "Plakat zespołu The Smiths.",
                    ImagePath="pla3.jpg",
                    UnitPrice = 36.99,
                    CategoryID = 4
                },

                new Product
                {
                    ProductID = 15,
                    ProductName = "Długopis Czerwony",
                    Description = "Długopis piszący na czerwono.",
                    ImagePath="dlu3.jpg",
                    UnitPrice = 2.95,
                    CategoryID = 5
                }
            };

            return products;
        }
    }
}