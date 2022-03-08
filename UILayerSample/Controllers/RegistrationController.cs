using BusinessLogicObject;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UILayerSample.Controllers
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
            RegisterUser ru = new RegisterUser();
            user.id = 0;
            if (ModelState.IsValid)
            {
                ru.Add(user);
                return View();
            }
            else
            {
                return Content("unsuccesfull");
            }
            

        }
        /* public ActionResult Index1()
         {
             return View();
         }*/
    
}
}