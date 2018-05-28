using Grup__8_Annonser.ServiceReferenceAnnonser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Grup__8_Annonser.Controllers
{
    public class HomeController : Controller
    {
        //Genererar en klass från en entitet
        Models.LoginModel Login = new Models.LoginModel();
        ServiceAdvertisingClient ServiceAnnons = new ServiceReferenceAnnonser.ServiceAdvertisingClient();

        public ActionResult rndAnnons()
        {
            List<ServiceReferenceAnnonser.AnnonsKlass> x = ServiceAnnons.ReadAnnons().ToList();
            var rndindex = new Random().Next(x.Count);
            AnnonsKlass hej = x[rndindex];
            return View(hej);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ServiceReferenceAnnonser.AnnonsKlass Model)
        {
            ServiceAnnons.CreateAnnons(Model.resource, Model.onHooverText);
            return RedirectToAction("Read");
        }

        public ActionResult Read()
        {
            List<ServiceReferenceAnnonser.AnnonsKlass> x = ServiceAnnons.ReadAnnons().ToList();
            return View(x);
        }

        public ActionResult Update(int? id)
        {
            ServiceReferenceAnnonser.AnnonsKlass Update = ServiceAnnons.GetAnnonsId(id);
            return View(Update);
        }

        [HttpPost]
        public ActionResult Update(ServiceReferenceAnnonser.AnnonsKlass Update)
        {
            ServiceAnnons.UpdateAnnons(Update);
            return RedirectToAction("Read");
        }

        public ActionResult Delete(int? id)
        {
            ServiceReferenceAnnonser.AnnonsKlass Delete = ServiceAnnons.GetAnnonsId(id);
            return View(Delete); 
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            ServiceAnnons.DeleteAnnons(id);
            return RedirectToAction("Read");
        }

        //public ActionResult Login()
        //{
        //    return View();
        //}

        ////Skapar inloggning som är kopplad till en databas
        //// taget från exempel .asp hv
        //// skapa inloggning via db
        //[HttpPost]
        //public ActionResult Login(Models.LoginModel thisLogin)
        //{
        //    if (thisLogin.Username == null || thisLogin.Password == null)
        //    {
        //        ModelState.AddModelError("", "Du har inte fyllt in fälten");
        //        return View();
        //    }

        //    bool validUser = false;

        //    validUser = CheckUser(thisLogin.Username, thisLogin.Password);

        //    if (validUser == true)
        //    {
        //        System.Web.Security.FormsAuthentication.RedirectFromLoginPage(thisLogin.Username, false);
        //    }
        //    ModelState.AddModelError("", "Fel inloggning");
        //    return View();
        //}

        //private bool CheckUser(string username, string password)
        //{
        //    //LINQ method
        //    var anvandare = from rows in LoginDB.Users
        //                    where rows.Username.ToUpper() == username.ToUpper()
        //                    && rows.Password == password
        //                    select rows;

        //    // if inlog success, skicka sant. annars falsk
        //    if (anvandare.Count() == 1)
        //    {
        //        var user = anvandare.FirstOrDefault();
        //        Session["thisLogin"] = 1;
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        ServiceReferenceLogin.LogginClient loggain = new ServiceReferenceLogin.LogginClient();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Models.LoginModel login)
        {
            if (login.Username == null || login.Password == null)
            {
                ModelState.AddModelError("", "Fyll i användarnamn, lösenord");
                return View();
            }

            string CurrentUser = loggain.GetLoginData(login.Username, login.Password, "KodAnno");

            if (CurrentUser != "")
            {
                System.Web.Security.FormsAuthentication.RedirectFromLoginPage(login.Username, false);
                return RedirectToAction("Read", "Home");
            }
            ModelState.AddModelError("", "Felaktig inloggning");
            return View();
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon(); //rensar sessionen vid slutet av requesten
            return RedirectToAction("Index", "Home");
        }

    }
}