using System;
using Microsoft.AspNetCore.Mvc;

namespace DemoApplication.Controllers
{
    public class AuthenticationController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
    }
}