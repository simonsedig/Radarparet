using Grup__8_Annonser.ServiceReferenceAnnons;
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
        Grupp8_AnnonserEntities AnnonsDB = new Grupp8_AnnonserEntities();
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
            List<ServiceReferenceAnnons.AnnonsKlass> x = ServiceAnnons.ReadAnnons().ToList();
            return View(x);
        }

        public ActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Update(string Resurs, string HooverText)
        {
            ServiceAnnons.CreateAnnons(Resurs, HooverText);
            return RedirectToAction("Read");
        }

        public ActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(string Resurs, string HooverText)
        {
            ServiceAnnons.CreateAnnons(Resurs, HooverText);
            return RedirectToAction("Read");
        }

        public ActionResult Login()
        {
            return View();
        }

        //Skapar inloggning som är kopplad till en databas
        // taget från exempel .asp hv
        // skapa inloggning via db
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
                //Session[USER_ID] = user.Id;
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}