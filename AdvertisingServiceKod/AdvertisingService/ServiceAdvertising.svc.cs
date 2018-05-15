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

        AnnonsKlass[] IServiceAdvertising.ReadAnnons()
        {
            using (var DBA = new Grupp8_AnnonserEntities())
            {
                var GetListFromDB = from y in DBA.Annons
                                    select y;
                List<AnnonsKlass> AnnonsList = new List<AnnonsKlass>();

                foreach (var rad in GetListFromDB)
                {
                    AnnonsKlass x = new AnnonsKlass();
                    x.resource = rad.Resurs;
                    x.resource = rad.HooverText;
                    AnnonsList.Add(x);
                }
                return AnnonsList.ToArray();
            }
        }

        void IServiceAdvertising.CreateAnnons(string resource, string onHooverText)
        {
            using (var DBA = new Grupp8_AnnonserEntities())
            {
                Annons updateAnnons = new Annons
                {
                    Resurs = resource,
                    HooverText = onHooverText
                };
                DBA.Annons.Add(updateAnnons);
                DBA.SaveChanges();
            }
        }

        void IServiceAdvertising.UpdateAnnons(int addId, string resource, string onHooverText)
        {
            using (var db = new Grupp8_AnnonserEntities())
            {
                var UpdateAnnons = from Per in db.Grupp8_AnnonserEntities
                                   where Per.Id == addId
                                   select Per;


                    foreach (var AnnonsEdit in UpdateAnnons)
                    {

                        if (resource == null)
                        {
                            AnnonsEdit.ShortCode = onHooverText;

                        }

                        else if (onHooverText == null)
                        {
                            AnnonsEdit.Partie = resource;


                        }
                        else
                        {
                            AnnonsEdit.ShortCode = onHooverText;
                            AnnonsEdit.Partie = resource;

                        }

                    }
                    db.SaveChanges();
                }
        }
        }

        void IServiceAdvertising.DeleteAnnons(int addId)
        {
            using (var db = new Grupp8_AnnonserEntities())
            {
                var DeleteAnnonser = from AnnonsEdit in db.Grupp8_AnnonserEntities
                                     where AnnonsEdit.Id == addId
                                     select AnnonsEdit;


                foreach (var AnnonsEdit in DeleteAnnonser)
                {
                    db.PartieContainerDB.Remove(AnnonsEdit);
                }
                db.SaveChanges();
            }
        }

    }

}