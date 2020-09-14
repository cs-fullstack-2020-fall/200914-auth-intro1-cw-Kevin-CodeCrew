using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using authintrocw.Models;
using Microsoft.AspNetCore.Authorization;
using authintrocw.Data;

namespace authintrocw.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationDbContext _context;
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult ListMembers()
        {
            return View(_context);
        }


        [Authorize]
        [HttpGet]
        public IActionResult AddMemberForm()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult AddMember(CustomerModel customer)
        {
            if (ModelState.IsValid)
            {
                _context.customers.Add(customer);
                _context.SaveChanges();
                return RedirectToAction("ListMembers", "Home");
            }
            else
            {
                return View("AddMemberForm", customer);
            }
        }


        [Authorize]
        [HttpGet]
        public IActionResult EditMemberForm(int id)
        {
            CustomerModel foundCustomer = _context.customers.FirstOrDefault(customer => customer.id == id);
            // if customer is found
            if (foundCustomer != null)
            {
                return View(foundCustomer);
            }
            else
            // if customer is not found
            {
                ViewData["error"] = ($"No Customer found for id {id}");
                return View("Error");
            }
        }

        [HttpPost]
        [Authorize]
        public IActionResult EditMember(CustomerModel customer)
        {
            CustomerModel foundCustomer = _context.customers.FirstOrDefault(cust => cust.id == customer.id);
            if (foundCustomer != null)
            {
                // if model created from form passes validation set using data annotations            
                if (ModelState.IsValid)
                {
                    // update the value of the found user in the database to the values from the object passed in (from form)
                    foundCustomer.customerFirstName = customer.customerFirstName;
                    foundCustomer.customerLastName = customer.customerLastName;
                    foundCustomer.customerProfile = customer.customerProfile;
                    _context.SaveChanges();
                    return RedirectToAction("ListMembers", "Home");
                }
                else
                // if model created from form does not pass validation set using data annotations
                {
                    return View("EditMemberForm", customer);
                }
            }
            else
            {
                ViewData["error"] = ($"No Customer found for id {customer.id}");
                return View("Error");
            }
        }


    }
}
