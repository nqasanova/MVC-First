using System;
using DemoApplication.Database;
using DemoApplication.Database.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoApplication.Controllers
{
    public class BookController : Controller
    {
        //Read
        public List<Book> Index()
        {
            return DatabaseAccess.Books;
        }

        [HttpPost]
        //Create 
        public ViewResult Add(int id, [FromForm] string name, [FromForm] decimal price)
        {
            Database.DatabaseAccess.Books.Add(new Book(id, name, price)); //FULLY QUALIFIED NAMESPACE
            return View();
        }
    }
}