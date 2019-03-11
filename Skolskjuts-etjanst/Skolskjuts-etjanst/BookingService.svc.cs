using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Skolskjuts_etjanst
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BookingService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select BookingService.svc or BookingService.svc.cs at the Solution Explorer and start debugging.
    public class BookingService : IBookingService
    {
        // establish db-connection
        SkjutsDBEntities skjutsDb = new SkjutsDBEntities();

        public List<Bookings> RetrieveAllBookings()
        {
            List<Bookings> listAllBookings = new List<Bookings>();

            foreach (var item in skjutsDb.Transactions)
            {
                // create temp booking to add to list
                Bookings tempBookings = new Bookings();

                // fill bookings
                tempBookings.TransactionId = item.TransaktionsId;
                tempBookings.LeavingTime = item.DepartureTime;
                tempBookings.Driver = item.Driver;
                tempBookings.PickUpZone = item.PickUpPlace;
                tempBookings.Destination = item.Destination;
                tempBookings.Customer = item.Customer;

                listAllBookings.Add(tempBookings);
            }
            
            // check if list is empty, else return null
            if (listAllBookings.Count > 0)
            {
                return listAllBookings;
            }
            else
            {
                return DummyBooking();
            }           
        }

        public List<Bookings> RetrieveAllAvailableBookings()
        {
            List<Bookings> listAllAvailableBookings = new List<Bookings>();

            foreach (var item in skjutsDb.Transactions)
            {
                // check is bookings is available
            if (item.Customer == "Tillgänglig")
                {
                    // create temp booking to add to list
                    Bookings tempBookings = new Bookings();

                    // fill bookings
                    tempBookings.TransactionId = item.TransaktionsId;
                    tempBookings.LeavingTime = item.DepartureTime;
                    tempBookings.Driver = item.Driver;
                    tempBookings.PickUpZone = item.PickUpPlace;
                    tempBookings.Destination = item.Destination;
                    tempBookings.Customer = item.Customer;

                    listAllAvailableBookings.Add(tempBookings);
                }
            else
                {
                    // do nothing, dont add
                }
                
            }

            // check if list is empty, else return null
            if (listAllAvailableBookings.Count > 0)
            {
                return listAllAvailableBookings;
            }
            else
            {
                return DummyBooking();
            }
        }

        public List<Bookings> RetrieveUsersBookings(string userName)
        {
            List<Bookings> listUserBookings = new List<Bookings>();

            foreach (var item in skjutsDb.Transactions)
            {
                // check if bookings on username
                if (item.Customer.ToLower() == userName.ToLower())
                {
                    // create temp booking to add to list
                    Bookings tempBookings = new Bookings();

                    // fill bookings
                    tempBookings.TransactionId = item.TransaktionsId;
                    tempBookings.LeavingTime = item.DepartureTime;
                    tempBookings.Driver = item.Driver;
                    tempBookings.PickUpZone = item.PickUpPlace;
                    tempBookings.Destination = item.Destination;
                    tempBookings.Customer = item.Customer;

                    listUserBookings.Add(tempBookings);
                }
                else
                {
                    // do nothing, dont add
                }

            }

            // check if list is empty, else return null
            if (listUserBookings.Count > 0)
            {
                return listUserBookings;
            }
            else
            {
                return DummyBooking();
            }
        }

        public void BookById(int id, string userName)
        {
            foreach (var item in skjutsDb.Transactions)
            {
                // find by id
                if (item.TransaktionsId == id)
                {
                    // change customer to selected customer
                    item.Customer = userName;

                    // stop search when found and commited
                    break;
                }
            }

            // save changes
            skjutsDb.SaveChanges();
        }

        public List<Bookings> RetrieveDriverBookings(string driverName)
        {
            List<Bookings> listDriverBookings = new List<Bookings>();

            foreach (var item in skjutsDb.Transactions)
            {
                // check if bookings on username
                if (item.Driver.ToLower() == driverName.ToLower())
                {
                    // create temp booking to add to list
                    Bookings tempBookings = new Bookings();

                    // fill bookings
                    tempBookings.TransactionId = item.TransaktionsId;
                    tempBookings.LeavingTime = item.DepartureTime;
                    tempBookings.Driver = item.Driver;
                    tempBookings.PickUpZone = item.PickUpPlace;
                    tempBookings.Destination = item.Destination;
                    tempBookings.Customer = item.Customer;

                    listDriverBookings.Add(tempBookings);
                }
                else
                {
                    // do nothing, dont add
                }

            }

            // check if list is empty, else return null
            if (listDriverBookings.Count > 0)
            {
                return listDriverBookings;
            }
            else
            {
                return DummyBooking();
            }
        }

        public void RemoveById(int id)
        {
            foreach (var item in skjutsDb.Transactions)
            {
                if (item.TransaktionsId == id)
                {
                    // remove item from db
                    skjutsDb.Transactions.Remove(item);
                    break;
                }
            }
            // save changes
            skjutsDb.SaveChanges();
        }

        public void AddEntry(DateTime date, string driver, string zone1, string zone2)
        {
            // create new booking
            Transaction newBook = new Transaction();

            newBook.DepartureTime = date;
            newBook.Driver = driver;
            newBook.PickUpPlace = zone1;
            newBook.Destination = zone2;
            newBook.Customer = "Tillgänglig";

            // add booking
            skjutsDb.Transactions.Add(newBook);

            // save changes
            skjutsDb.SaveChanges();
        }

        public List<Bookings> DummyBooking()
        {
            // create dummy-list
            List<Bookings> dummyList = new List<Bookings>();

            // create dummy-booking
            Bookings dummyBookings = new Bookings();

            // add dummy-data
            dummyBookings.TransactionId = 0;
            dummyBookings.LeavingTime = DateTime.MinValue;
            dummyBookings.Driver = "Invalid Driver";
            dummyBookings.PickUpZone = "Anywhere";
            dummyBookings.Destination = "Nowhere";
            dummyBookings.Customer = "No one";

            dummyList.Add(dummyBookings);

            return dummyList;
        }
    }
}
