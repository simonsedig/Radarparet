using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AdvertisingService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceAdvertising" in both code and config file together.
    [ServiceContract]
    public interface IServiceAdvertising
    {
        [OperationContract]
        void DoWork();
        [OperationContract]
        AnnonsKlass[] ReadAnnons();
        [OperationContract]
        void CreateAnnons(string Resurs, string HooverText);
    }

    [DataContract]
    public class AnnonsKlass
    {
        [DataMember]
        public string Resurs { get; set; }
        [DataMember]
        public string HooverText { get; set; }
    }
}
}
