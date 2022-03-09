using BusinessLogicObject;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UILayerSample.Controllers
{
    public class LoginController : Controller
    {
        RegisterUser rg = null;
        public LoginController()
        {
            rg = new RegisterUser();
        }
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(UserLogin data)
        {
            if (rg.Auth(data))
            {
                return RedirectToAction("Index");
            }
            else
            {
                return Content("unsuccess");
            }
        }
    }
}