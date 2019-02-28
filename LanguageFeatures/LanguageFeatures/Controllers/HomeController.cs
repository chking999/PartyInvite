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
            object[] data = new object[]
            {
                275M, 29.95M, "apple", "orange", 100, 10
            };

            decimal total = 0;

            for (var i = 0; i < data.Length; i++)
            {
                switch (data[i])
                {
                    case decimal decimalValue:
                        total += decimalValue;
                        break;
                    case int intValue when intValue > 50:
                        total += intValue;
                        break;
                }
            }

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

            return View("Index", products.Keys);
        }
    }
}