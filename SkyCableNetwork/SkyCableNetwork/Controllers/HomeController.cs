using SkyCableNetwork.Entity;
using SkyCableNetwork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SkyCableNetwork.Controllers
{
    public class HomeController : Controller
    {
        SVNCableEntities svn = new SVNCableEntities();

        public ActionResult Index(LoginModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = svn.tblRegs.Where(a => a.EmailID == model.Email && a.Password == model.Password).FirstOrDefault();

                    if (result!=null)
                    {
                       
                        return RedirectToAction("Index", "UserDashboard");
                    }
                    else
                    {
                        ViewBag.Message = "Invalid Email ID Or Password";
                    }
                }

            }catch(Exception exc)
            {

            }

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Registration(RegistrationModel model)
        {
            if (ModelState.IsValid)
            {
                var result = svn.tblRegs.Where(a => a.EmailID == model.Email).FirstOrDefault();

                try
                {
                    if (result == null)
                    {
                        tblReg _objReg = new tblReg();
                        _objReg.Name = model.Name;
                        _objReg.EmailID = model.Email;
                        _objReg.Password = model.Password;

                        svn.tblRegs.Add(_objReg);
                        svn.SaveChanges();
                        result _objResult = new result();
                        _objResult.success = 1;
                        _objResult.msg = "Success";
                        return RedirectToAction("Index", "Home");

                    }
                    else
                    {

                        

                    }
                }
                catch (Exception Exp)
                {

                }
            
            }
            return View();
        }

        public ActionResult Forgot()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Forgot(string email)
        {
            if (ModelState.IsValid)
            {

            }


            return View();
        }

        public ActionResult Reset()

        {
            return View();
        }

    }
}