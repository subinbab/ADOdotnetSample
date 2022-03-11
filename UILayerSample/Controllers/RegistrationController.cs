using BusinessLogicObject;
using DataAccessLayer;
using DataAccessLayer.user;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UILayerSample.Controllers
{
    
    public class RegistrationController : Controller
    {
        IUserRepository _userRepository;
        public RegistrationController()
        {
            _userRepository = new UserRepository();
        }
        // GET: Registration
        
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Index([Bind]UserRegisterModel user)
        {
            try
            {
                user.id = 0;
                if (ModelState.IsValid)
                {     
                    string message = _userRepository.RegisterUser(user);
                    
                    return Json(new { data = message, success = true }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { data = "error",success=true}, JsonRequestBehavior.AllowGet); 
                }
            }
            catch (Exception ex)
            {
                return Json(new { data = "error", success = true }, JsonRequestBehavior.AllowGet);
            }
            
            

        }
        /* public ActionResult Index1()
         {
             return View();
         }*/
    
}
}