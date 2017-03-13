using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CheeseMVC.Models;

namespace CheeseMVC.Controllers
{
    // view location: /Views/Cheese/*
    public class CheeseController : Controller
    {
        // static propery is available to *any* instance
        // of the CheeseController class
        //private static Dictionary<string, string> cheeses = new Dictionary<string, string>();
        private static List<Cheese> cheeses = new List<Cheese>();

        // Display the list of cheeses
        // GET: /cheese
        public IActionResult Index()
        {
            // data for the view
            //ViewBag.cheeses = cheeses;

            // view defaults to action name: Index.cshtml
            // /Views/Cheese/Index.cshtml
            return View(cheeses);

            // OR render particular view *by name*
            // return View("Index");
        }

        public IActionResult Add()
        {
            // /Views/Cheese/Add.cshtml
            var cheese = new Cheese();
            return View(cheese);
        }

        // by default, the route will be: /Cheese/NewCheese
        // but we want to post the form to the same route
        // from which we loaded it: /Cheese/Add
        [Route("/cheese/add")]
        [HttpPost]
        //public IActionResult NewCheese(string name, string description)
        public IActionResult NewCheese(Cheese cheese)
        {
            // add new cheese to static class list
            //cheeses.Add(name, description);
            cheeses.Add(cheese);

            // go back to the list of cheeses
            return Redirect("/cheese");
        }
    }
}
