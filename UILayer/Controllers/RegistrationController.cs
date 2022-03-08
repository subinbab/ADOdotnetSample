using BusinessLogicObject;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UILayer.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(User user)
        {
            if (ModelState.IsValid)
            {
                RegisterUser ru = new RegisterUser();
                user.id = 0;
                ru.Add(user);
                return View();
            }
            return Content("unsuccesfull");
            
        }
       /* public ActionResult Index1()
        {
            return View();
        }*/
    }
}