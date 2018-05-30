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

        [Authorize]
        public ActionResult RndAnnons()
        {
            //Gör det möjligt för användaren att testa rndAnnons funktionen
            return View(ServiceAnnons.RndAnnons());
        }

        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ServiceReferenceAnnonser.AnnonsKlass Model)
        {
            //Skickar in värdena som annonsen ska ha. Id skapas automatiskt
            ServiceAnnons.CreateAnnons(Model.resource, Model.onHooverText);
            return RedirectToAction("Read");
        }

        [Authorize]
        public ActionResult Read()
        {
            //Tar in annnonserna i en lista, skickar listan till html
            List<ServiceReferenceAnnonser.AnnonsKlass> x = ServiceAnnons.ReadAnnons().ToList();
            return View(x);
        }

        [Authorize]
        public ActionResult Update(int? id)
        {
            //Läser in id för att hitta rätt annons att uppdatera
            ServiceReferenceAnnonser.AnnonsKlass Update = ServiceAnnons.GetAnnonsId(id);
            return View(Update);
        }

        [HttpPost]
        public ActionResult Update(ServiceReferenceAnnonser.AnnonsKlass Update)
        {
            //Uppdaterar den valda annonsen och sedan skickas man tilbaka till "Read"
            ServiceAnnons.UpdateAnnons(Update);
            return RedirectToAction("Read");
        }

        [Authorize]
        public ActionResult Delete(int? id)
        {
            //Raderar en annons
            ServiceReferenceAnnonser.AnnonsKlass Delete = ServiceAnnons.GetAnnonsId(id);
            return View(Delete); 
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            //Läser in den annons man vill radera genom ett id som skickas med
            ServiceAnnons.DeleteAnnons(id);
            return RedirectToAction("Read");
        }

        ServiceReferenceLogin.LogginClient loggain = new ServiceReferenceLogin.LogginClient();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Models.LoginModel login)
        {
            //Checkar om inloggningen sker korrekt för att sedan få tillgång till sidan
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
    }
}