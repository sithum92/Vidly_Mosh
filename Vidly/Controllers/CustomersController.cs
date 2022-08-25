﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }

        public ActionResult Details(int Id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == Id);
            return View();
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
        { 
                new Customer{ Id =1, Name= "Sithum"},
                new Customer{ Id=2,Name="Malaka"}
        };
        }
    }
}