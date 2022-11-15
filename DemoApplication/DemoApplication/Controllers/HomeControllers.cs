using System;
using DemoApplication.Database;
using DemoApplication.Database.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoApplication.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        //Read
        [HttpGet]
        public ActionResult Contact()
        {
            return View();
        }

        //Create
        [HttpPost]
        public ActionResult Contact([FromForm] int id, [FromForm] string name, [FromForm] string email, [FromForm] string phone, [FromForm] string message)
        {
            DatabaseAccess.Contacts.Add(new Contact(TablePKAutoIncrement.ContactCounter, name, email, phone, message));
            return RedirectToAction("contacts", "home"); //type safety
        }

        public List<Contact> contacts()
        {
            return DatabaseAccess.Contacts;
        }
    }
}