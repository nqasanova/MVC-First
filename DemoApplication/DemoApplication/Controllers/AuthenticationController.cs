using System;
using DemoApplication.Database;
using DemoApplication.Database.ViewModels.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace DemoApplication.Controllers
{
    public class AuthenticationController : Controller
    {
        public ViewResult Login()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Register()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Register(RegisterViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            Database.DatabaseAccess.Users.Add(new Database.Models.User
            {
                Id = TablePkAutoincrement.UserCounter,
                Email = viewModel.Email,
                Password = viewModel.Password
            });
            //add to db

            return View();
        }
    }
}