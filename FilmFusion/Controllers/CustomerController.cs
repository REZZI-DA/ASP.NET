using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FilmFusion.Models;

namespace FilmFusion.Controllers
{
    public class CustomerController : Controller
    {



        public ViewResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }
        public ActionResult Details()
        {
            return View();
        }


        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { Id = 1, Name = "John Smith" },
                new Customer { Id = 2, Name = "Mary Williams" }

            };

        }

    }
}