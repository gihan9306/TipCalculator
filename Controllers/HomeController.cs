using System.Diagnostics;
using GihanTipCalculator.Models;
using Microsoft.AspNetCore.Mvc;

namespace GihanTipCalculator.Controllers
{
    public class HomeController : Controller
    {
        // Show empty form
        public IActionResult Index()
        {
            ViewBag.Tip15 = 0.00m;  
            ViewBag.Tip20 = 0.00m;  
            ViewBag.Tip25 = 0.00m;  
            return View();          
        }

        [HttpPost]
        // Calculate tips from input
        public IActionResult Index(TipModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Tip15 = model.CalculateTip(0.15m); 
                ViewBag.Tip20 = model.CalculateTip(0.20m); 
                ViewBag.Tip25 = model.CalculateTip(0.25m); 
                ViewBag.MealCost = model.MealCost;         // Pass meal cost
            }
            else
            {
                // Reset tip value to 0
                ViewBag.Tip15 = 0.00m;  
                ViewBag.Tip20 = 0.00m;  
                ViewBag.Tip25 = 0.00m;  
            }

            return View(model); // Return view with model
        }
    }
}
