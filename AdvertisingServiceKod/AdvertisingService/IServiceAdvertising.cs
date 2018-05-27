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
        string DoILive();
        [OperationContract]
        AdvertisingService.AnnonsKlass GetAnnonsId(int? id);
        [OperationContract]
        List<string> RndAnnons(int p);
        [OperationContract]
        AnnonsKlass[] ReadAnnons();
        [OperationContract]
        void CreateAnnons(string resource, string onHooverText);
        [OperationContract]
        void UpdateAnnons(AnnonsKlass Update);
        [OperationContract]
        void DeleteAnnons(int? addId);
    }

    [DataContract]
    public class AnnonsKlass
    {
        [DataMember]
        public string resource { get; set; }
        [DataMember]
        public string onHooverText { get; set; }
        [DataMember]
        public string addId { get; set; }
    }
}

