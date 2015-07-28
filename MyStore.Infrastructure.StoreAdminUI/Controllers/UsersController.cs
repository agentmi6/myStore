using MyStore.Domain;
using MyStore.Infrastructure.DataMSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyStore.Infrastructure.StoreAdminUI.Controllers
{
    public class UsersController : Controller
    {
        UserRepository userRepository = new UserRepository();

        // GET: Users
        public ActionResult Index()
        {
            var users = userRepository.GetAll();            
            return View(users);
        }

        public ActionResult Create()
        {            
            return View();
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            if(ModelState.IsValid)
            {
                userRepository.Create(user);
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(User user)
        {
            userRepository.Delete(user.ID);
            return RedirectToAction("Index");
        }

    }
}