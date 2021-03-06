﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            var products = new[]
            {
                        new {Name = "Kayak", Price = 275M},
                        new {Name = "Lifejacket", Price = 48.95M},
                        new {Name = "Soccer ball", Price = 19.50M},
                        new {Name = "Corner flag", Price = 34.95M}
                    };

            return View(products.Select(p => $"{nameof(p.Name)}: {p.Name}, {nameof(p.Price)}: {p.Price}"));
        }

    }
}

//object[] data = new object[]
//{
//    275M, 29.95M, "apple", "orange", 100, 10
//};

//decimal total = 0;

//for (var i = 0; i < data.Length; i++)
//{
//    switch (data[i])
//    {
//        case decimal decimalValue:
//            total += decimalValue;
//            break;
//        case int intValue when intValue > 50:
//            total += intValue;
//            break;
//    }
//}

//Dictionary<string, Product> products = new Dictionary<string, Product>
//{
//    ["Kayak"] = new Product { Name = "Kayak", Price = 275M},
//    ["Lifejacket"] = new Product { Name = "Lifejacket", Price = 48.95M}
//};
//List<string> results = new List<string>();

//foreach (var product in Product.GetProducts())
//{
//    var name = product?.Name?? "<No Name>";
//    var price = product?.Price?? 0;

//    var relatedName = product?.Related?.Name?? "<None>";


//    results.Add($"Name: {name}, Price {price}, Related {relatedName}");              
//}

//var priceFilterTotal = productArray.FilterByPrice(20).TotalPrices();
//var nameFilterTotal = productArray.FilterByName('S').TotalPrices();

//public ViewResult Index()
//{
//    ShoppingCart cart = new ShoppingCart {Products = Product.GetProducts()};

//    Product[] productArray =
//    {
//        new Product {Name = "Kayak", Price = 275M},
//        new Product {Name = "Lifejacket", Price = 48.95M},
//        new Product {Name = "Soccer ball", Price = 19.50M},
//        new Product {Name = "Corner flag", Price = 34.95M}
//    };

//    //Func<Product, bool> nameFilter = delegate(Product prod) { return prod?.Name?[0] == 'S'; };

//    decimal priceFilterTotal = productArray.Filter(p => (p?.Price ?? 0) >= 20).TotalPrices();
//    decimal nameFilterTotal = productArray.Filter(p => p?.Name?[0] == 'S').TotalPrices();

//    return View("Index", new string[]
//    {
//        $"Price Total: {priceFilterTotal:C2}",
//        $"Name Total: {nameFilterTotal:C2}"
//    } );
//}

//bool FilterByPrice(Product p)
//{
//    return (p.Price ?? 0) >= 20;
//}

//public ViewResult Index()
//{
//    var products = new[]
//    {
//            new {Name = "Kayak", Price = 275M},
//            new {Name = "Lifejacket", Price = 48.95M},
//            new {Name = "Soccer ball", Price = 19.50M},
//            new {Name = "Corner flag", Price = 34.95M}
//        };
//    return View(products.Select(p => p.GetType().Name));
//}

//public async Task<ViewResult> Index()
//{
//    var length = await MyAsynchMethods.GetPageLength();
//    return View(new string[] {$"Length: {length}"});
//}