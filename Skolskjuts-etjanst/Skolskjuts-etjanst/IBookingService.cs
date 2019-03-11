using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Skolskjuts_etjanst
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBookingService" in both code and config file together.
    [ServiceContract]
    public interface IBookingService
    {
        [OperationContract]
        List<Bookings> RetrieveAllBookings();

        [OperationContract]
        List<Bookings> RetrieveAllAvailableBookings();

        [OperationContract]
        List<Bookings> RetrieveUsersBookings(string userName);

        [OperationContract]
        void BookById(int id, string userName);

        [OperationContract]
        void RemoveById(int id);

        [OperationContract]
        void AddEntry(DateTime date, string driver, string zone1, string zone2);

        [OperationContract]
        List<Bookings> DummyBooking();
    }
    
    [DataContract]
    public class Bookings
    {
        [DataMember]
        public int TransactionId { get; set; }

        [DataMember]
        public DateTime LeavingTime { get; set; }

        [DataMember]
        public string Driver { get; set; }

        [DataMember]
        public string PickUpZone { get; set; }

        [DataMember]
        public string Destination { get; set; }

        [DataMember]
        public string Customer { get; set; }
    }
}
