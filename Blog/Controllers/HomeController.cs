using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static DataLibrary.Logic.UserDB;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(UsersModel model)
        {
            if(ModelState.IsValid)
            {
                createUser(model.age, model.name, model.surname, model.Email, model.Password);
                return RedirectToAction("Index");
            }

            return View();
        }
        public ActionResult viewUsers()
        {
            var data = loadUsers();
            List<UsersModel> users = new List<UsersModel>();

            foreach(var el in data)
            {
                users.Add(new UsersModel
                {
                    age = el.age,
                    name = el.name,
                    surname = el.surname,
                    Email = el.email,
                    Password = el.password
                });
            }

            return View(users);
        }
    }
}