using System;
using Microsoft.AspNetCore.Mvc;

namespace DemoApplication.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
    }
}