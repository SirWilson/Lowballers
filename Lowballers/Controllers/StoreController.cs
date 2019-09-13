using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lowballers.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lowballers.Controllers
{
    public class StoreController : Controller
    {
        public IActionResult Index()
        {
            var categories = new List<Category>();

            // create 10 mock categories

            for (int i = 1; i <= 10; i++)
            {
                categories.Add(new Category { Name = "Category " + i.ToString() });
            } 
            return View(categories);
        }

        public IActionResult Browse(string category)
        {
            //add selected category to viewbag 

            ViewBag.category = category;

            return View();
        }
    }
}