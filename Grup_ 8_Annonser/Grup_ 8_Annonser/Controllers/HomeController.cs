<<<<<<< HEAD
﻿using Grup__8_Annonser.ServiceReferenceAnnonser;
=======
﻿using Grup__8_Annonser.ServiceReferenceAdvertising;
>>>>>>> 3168f486acee55785786224a4155dfbc8ef7bb27
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Grup__8_Annonser.Controllers
{
    public class HomeController : Controller
    {
        //Genererar en klass från en entitet
        LoginDBEntities LoginDB = new LoginDBEntities();
        ServiceAdvertisingClient ServiceAnnons = new ServiceAdvertisingClient();

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
        public ActionResult Create(string Resurs, string HooverText)
        {
            ServiceAnnons.CreateAnnons(Resurs, HooverText);
            return RedirectToAction("Read");
        }

        public ActionResult Read()
        {
<<<<<<< HEAD
            List<ServiceReferenceAnnonser.AnnonsKlass> x = ServiceAnnons.ReadAnnons().ToList();
=======
            List<ServiceReferenceAdvertising.AnnonsKlass> x = ServiceAnnons.ReadAnnons().ToList();
>>>>>>> 3168f486acee55785786224a4155dfbc8ef7bb27
            return View(x);
        }

        public ActionResult Update(int? id)
        {
            //if (id == null)
            //{
            //    return RedirectToAction("Read");
            //}

<<<<<<< HEAD
            ServiceReferenceAnnonser.Annonser Update = ServiceAnnons.GetAnnonsId(id);
            return View(Update);
=======
            Annons Update;
            return View(/*Update*/);
>>>>>>> 3168f486acee55785786224a4155dfbc8ef7bb27
        }

        [HttpPost]
        public ActionResult Update(ServiceReferenceAnnonser.Annonser Update)
        {
            ServiceAnnons.UpdateAnnons(Update);
            return RedirectToAction("Read");
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Read");
            }

            ServiceReferenceAnnonser.Annonser Delete = ServiceAnnons.GetAnnonsId(id);
            return View(Delete); 
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            ServiceAnnons.DeleteAnnons(id);
            return RedirectToAction("Read");
        }

        public ActionResult Login()
        {
            return View();
        }

        //Skapar inloggning som är kopplad till en databas
        // taget från exempel .asp hv
        // skapa inloggning via db H
        [HttpPost]
        public ActionResult Login(Models.LoginModel thisLogin)
        {
            if (thisLogin.Username == null || thisLogin.Password == null)
            {
                ModelState.AddModelError("", "Du har inte fyllt in fälten");
                return View();
            }

            bool validUser = false;

            validUser = CheckUser(thisLogin.Username, thisLogin.Password);

            if (validUser == true)
            {
                System.Web.Security.FormsAuthentication.RedirectFromLoginPage(thisLogin.Username, false);
            }
            ModelState.AddModelError("", "Fel inloggning");
            return View();
        }

        private bool CheckUser(string username, string password)
        {
            //LINQ method
            var anvandare = from rows in LoginDB.Users
                            where rows.Username.ToUpper() == username.ToUpper()
                            && rows.Password == password
                            select rows;

            // if inlog success, skicka sant. annars falsk
            if (anvandare.Count() == 1)
            {
                var user = anvandare.FirstOrDefault();
                Session["thisLogin"] = 1;
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}