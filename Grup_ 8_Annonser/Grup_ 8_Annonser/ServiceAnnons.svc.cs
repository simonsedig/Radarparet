using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Grup__8_Annonser
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceAnnons" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceAnnons.svc or ServiceAnnons.svc.cs at the Solution Explorer and start debugging.
    public class ServiceAnnons : IServiceAnnons
    {
        public void DoWork()
        {
        }

        AnnonsKlass[] IServiceAnnons.ReadAnnons()
        {
            using (var DBA = new Grupp8_AnnonserEntities())
            {
                var GetListFromDB = from y in DBA.Annons
                                    select y;
                List<AnnonsKlass> MatList = new List<AnnonsKlass>();

                foreach (var rad in GetListFromDB)
                {
                    AnnonsKlass x = new AnnonsKlass();
                    x.Resurs = rad.Resurs;
                    x.HooverText = rad.HooverText;
                    MatList.Add(x);
                }
                return MatList.ToArray();
            }
        }

        void IServiceAnnons.CreateAnnons(string Resurs, string HooverText)
        {
            using (var DBA = new Grupp8_AnnonserEntities())
            {
                Annons updateAnnons = new Annons
                {
                    Resurs = Resurs,
                    HooverText = HooverText
                };
                DBA.Annons.Add(updateAnnons);
                DBA.SaveChanges();
            }
        }
    }
}
