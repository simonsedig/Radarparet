using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Skolskjuts_etjanst.Models;

namespace Skolskjuts_etjanst.Controllers
{      
    public class HomeController : Controller
    {
        // create login-service reference
        LoginService userService = new LoginService();

        // create booking-service reference
        BookingService bookingService = new BookingService();

        // GET: Home
        public ActionResult Index()
        {
            // create viewmodel to show bookings
            List<Bookings> AllBookings = new List<Bookings>();

            AllBookings = bookingService.RetrieveAllBookings();

            return View(AllBookings);
        }

        // login page
        public ActionResult Login()
        {
            return View();
        }

        // login page - POST
        [HttpPost]
        public ActionResult Login(Users user)
        {
            // service - does user exist? true/false
            if (userService.CheckUser(user.UserName, user.PassWord))
            {
                Session["UserLogged"] = user.UserName;

                // service - user is admin? true/false
                if (userService.CheckUserAdmin(user.UserName, user.PassWord))
                    Session["IsAdmin"] = "AdminConfirmed";

                // transfer user to other page
                Response.Redirect("Index");
            }
            // bad login? let em know
            else
            {
                ModelState.AddModelError("infoLogin", "Felaktig inloggning");
            }

            return View();
        }

        // booking page - require logon (user or admin) 
        public ActionResult Boka()
        {
            if (Session["UserLogged"] != null)
            {
                // create viewmodel
                ViewModelBookings viewModel = new ViewModelBookings();

                // fill list from service
                viewModel.AllBookingsList = bookingService.RetrieveAllAvailableBookings();

                // fill list from userSession
                viewModel.CustomerCurrentBookingList = bookingService.RetrieveUsersBookings(Session["UserLogged"].ToString());

                return View(viewModel);
            }
            else
            {
                return View();
            }
        }

        // post - user will book selected route by id
        public ActionResult Bokat(int id)
        {            
            string userName = Session["UserLogged"].ToString().ToLower();

            // call booking-service to book by id
            bookingService.BookById(id, userName);

            return View(id);
        }

        // publish page - require logon (admin ONLY) 
        public ActionResult Publicera()
        {
            if (Session["UserLogged"] != null)
            {
                // create viewmodel
                ViewModelBookings viewModel = new ViewModelBookings();

                // create datetime for 2 days with 2x-loops (days, hrs)
                for (int d = 1; d < 3; d++)
                {
                    for (int h = 8; h < 18; h++)
                    {
                        viewModel.timeOfBooking.Add(DateTime.Today.AddDays(d).AddHours(h));
                    }
                }

                // fill list from userSession
                viewModel.CustomerCurrentBookingList = bookingService.RetrieveDriverBookings(Session["UserLogged"].ToString());

                return View(viewModel);
            }
            else
            {
                return View();
            }
        }

        // post - driver has posted new route
        [HttpPost]
        public ActionResult Publicera(ViewModelBookings viewModel)
        {
            // check if fields are input
            if (viewModel.newBooking.LeavingTime == null || viewModel.newBooking.PickUpZone.Length < 1 || viewModel.newBooking.Destination.Length < 1) 
            {
                ModelState.AddModelError("BookingError", "Kolla att fälten är korrekt i fyllda och försök igen!");
            }
            else {
                // complete transaction and add new entry to db
                bookingService.AddEntry(viewModel.newBooking.LeavingTime,
                    Session["UserLogged"].ToString(),
                    viewModel.newBooking.PickUpZone,
                    viewModel.newBooking.Destination);
            }

            if (Session["UserLogged"] != null)
            {
                // fill list from userSession
                viewModel.CustomerCurrentBookingList = bookingService.RetrieveDriverBookings(Session["UserLogged"].ToString());

                // create datetime for 2 days with 2x-loops (days, hrs)
                for (int d = 1; d < 3; d++)
                {
                    for (int h = 8; h < 18; h++)
                    {
                        viewModel.timeOfBooking.Add(DateTime.Today.AddDays(d).AddHours(h));
                    }
                }

                return View(viewModel);
            }
            else
            {
                return View();
            }
        }

        // publish page - require logon (admin ONLY) 
        public ActionResult Avbokat(int id)
        {
            // call remove booking-service to remove by id
            bookingService.RemoveById(id);

            return View(id);
        }
    }
}