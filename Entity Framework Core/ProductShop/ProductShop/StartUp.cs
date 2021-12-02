﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using ProductShop.Data;
using ProductShop.DataTransfereObject;
using ProductShop.Models;

namespace ProductShop
{
    public class StartUp
    {
        private static IMapper mapper;

        public static void Main(string[] args)
        {
            var productShopContext = new ProductShopContext();
            //productShopContext.Database.EnsureDeleted();
            //productShopContext.Database.EnsureCreated();


            //string usersJson = File.ReadAllText("../../../Datasets/users.json");
            //string productJson = File.ReadAllText("../../../Datasets/products.json");
            //string categoryJson = File.ReadAllText("../../../Datasets/categories.json");
            //string categoryProductJson = File.ReadAllText("../../../Datasets/categories-products.json");
            //ImportUsers(productShopContext, usersJson);
            //ImportProducts(productShopContext, productJson);
            //ImportCategories(productShopContext, categoryJson);
            var result = GetUsersWithProducts(productShopContext);
            Console.WriteLine(result);
        }

        public static string GetUsersWithProducts(ProductShopContext context)
        {
            var users = context.Users
                .Include(x => x.ProductsSold)
                .ToList()
                .Where(u => u.ProductsSold.Any(x => x.BuyerId != null))
                .Select(x => new
                {
                    firstName = x.FirstName,
                    lastName = x.LastName,
                    age = x.Age,
                    soldProducts = new
                    {
                        count = x.ProductsSold.Count(product => product.BuyerId != null),
                        products = x.ProductsSold
                            .Where(product => product.BuyerId != null)
                            .Select(p => new
                        {
                            name = p.Name,
                            price = p.Price
                        })

                    }
                })
                .OrderByDescending(x => x.soldProducts.products.Count())
                .ToList();

            var resultObject = new
            {
                usersCount = context.Users
                    .Count(x => x.ProductsSold.Any(p => p.BuyerId != null)),
                users = users
            };

            var jsonSerializerSettings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            };

            var resultJson = JsonConvert
                .SerializeObject(resultObject, Formatting.Indented, jsonSerializerSettings);

            return resultJson;
        }

        public static string GetCategoriesByProductsCount(ProductShopContext context)
        {
            var categoriesInfo = context.Categories
                .Select(c => new
                {
                    category = c.Name,
                    productsCount = c.CategoryProducts.Count,
                    averagePrice = c.CategoryProducts.Count == 0 ? 
                        0.ToString("F2") : 
                        c.CategoryProducts.Average(p => p.Product.Price)
                        .ToString("F2"),
                    totalRevenue = c.CategoryProducts.Sum(p => p.Product.Price)
                        .ToString("F2")
                })
                .OrderByDescending(x => x.productsCount)
                .ToList();

            var result = JsonConvert.SerializeObject(categoriesInfo, Formatting.Indented);

            return result;
        }

        public static string GetSoldProducts(ProductShopContext context)
        {
            var users = context.Users
                .Where(x => x.ProductsSold.Any(p => p.BuyerId != null))
                .Select(user => new
                {
                    firstName = user.FirstName,
                    lastName = user.LastName,
                    soldProducts = user.ProductsSold
                        .Where(p => p.BuyerId != null)
                        .Select(b => new
                        {
                            name = b.Name,
                            price = b.Price,
                            buyerFirstName = b.Buyer.FirstName,
                            buyerLastName = b.Buyer.LastName
                        })
                        .ToList()
                })
                .OrderBy(x => x.lastName)
                .ThenBy(x => x.firstName)
                .ToList();

            var result = JsonConvert.SerializeObject(users, Formatting.Indented);

            return result;
        }

        public static string GetProductsInRange(ProductShopContext context)
        {
            var products = context.Products
                .Where(x => x.Price >= 500 && x.Price <= 1000)
                .Select(product => new
                {
                    name = product.Name,
                    price = product.Price,
                    seller = product.Seller.FirstName + " " + product.Seller.LastName
                })
                .OrderBy(x => x.price)
                .ToList();

            var result = JsonConvert.SerializeObject(products, Formatting.Indented);

            return result;
        }


        public static string ImportCategoryProducts(ProductShopContext context, string inputJson)
        {
            InitliazeAutoMapper();

            var dtoCategoryProduct = JsonConvert
                .DeserializeObject<IEnumerable<CategoryProductInputModel>>(inputJson);

            var catProduct = mapper.Map<IEnumerable<CategoryProduct>>(dtoCategoryProduct);

            context.CategoryProducts.AddRange(catProduct);
            context.SaveChanges();

            return $"Successfully imported {catProduct.Count()}";
        }

        public static string ImportCategories(ProductShopContext context, string inputJson)
        {
            InitliazeAutoMapper();

            var dtoCategories = JsonConvert.DeserializeObject<IEnumerable<CategoryInputModel>>(inputJson)
                .Where(x => x.Name != null)
                .ToList();

            var categories = mapper.Map<IEnumerable<Category>>(dtoCategories);

            context.Categories.AddRange(categories);
            context.SaveChanges();

            return $"Successfully imported {categories.Count()}";
        }

        public static string ImportProducts(ProductShopContext context, string inputJson)
        {
            InitliazeAutoMapper();

            var dtoProducts = JsonConvert.DeserializeObject<IEnumerable<ProductInputModel>>(inputJson);

            var products = mapper.Map<IEnumerable<Product>>(dtoProducts);

            context.Products.AddRange(products);
            context.SaveChanges();

            return $"Successfully imported {products.Count()}";
        }



        public static string ImportUsers(ProductShopContext context, string inputJson)
        {
            InitliazeAutoMapper();

            var dtoUsers = JsonConvert.DeserializeObject<IEnumerable<UsersInputModel>>(inputJson);

            var users = mapper.Map<IEnumerable<User>>(dtoUsers);

            context.Users.AddRange(users);
            context.SaveChanges();

            return $"Successfully imported {users.Count()}";
        }

        private static void InitliazeAutoMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<ProductShopProfile>();
            });

            mapper = config.CreateMapper();
        }

    }
}