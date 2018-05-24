using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AdvertisingService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceAdvertising" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceAdvertising.svc or ServiceAdvertising.svc.cs at the Solution Explorer and start debugging.
    public class ServiceAdvertising : IServiceAdvertising
    {
        public void DoWork()
        {
        }

        AdvertisingService.Annonser IServiceAdvertising.RndAnnonser(int? id)
        {
            Grupp8_AnnonserEntities db = new Grupp8_AnnonserEntities();
            Annonser RndAnnons = db.Annonsers.Find(id);
            return RndAnnons;
        }

        AnnonsKlass[] IServiceAdvertising.ReadAnnons()
        {
            using (var DBA = new Grupp8_AnnonserEntities())
            {
                var GetListFromDB = from y in DBA.Annonsers
                                    select y;
                List<AnnonsKlass> AnnonsList = new List<AnnonsKlass>();

                foreach (var rad in GetListFromDB)
                {
                    AnnonsKlass x = new AnnonsKlass();
                    x.resource = rad.resources;
                    x.onHooverText = rad.onHooverText;
                    AnnonsList.Add(x);
                }
                return AnnonsList.ToArray();
            }
        }

        void IServiceAdvertising.CreateAnnons(string resource, string onHooverText)
        {
            using (var DBA = new Grupp8_AnnonserEntities())
            {
                Annonser CreateAnnons = new Annonser
                {
                    resources = resource,
                    onHooverText = onHooverText
                };
                DBA.Annonsers.Add(CreateAnnons);
                DBA.SaveChanges();
            }
        }

        void IServiceAdvertising.UpdateAnnons(Annonser Update)
        {
            Grupp8_AnnonserEntities db = new Grupp8_AnnonserEntities();
            db.Entry(Update).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public void DeleteAnnons(int? addId)
        {
            throw new NotImplementedException();
        }

        void IServiceAdvertising.DeleteAnnons(int? addId)
        {
            using (var db = new Grupp8_AnnonserEntities())
            {
                var DeleteAnnonser = from AnnonsEdit in db.Annonsers
                                     where AnnonsEdit.addId == addId
                                     select AnnonsEdit;


                foreach (var AnnonsEdit in DeleteAnnonser)
                {
                    db.Annonsers.Remove(AnnonsEdit);
                }
                db.SaveChanges();
            }
        }

    }

}