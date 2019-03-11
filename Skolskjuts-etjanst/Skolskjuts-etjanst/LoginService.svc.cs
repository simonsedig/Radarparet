using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Skolskjuts_etjanst
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "LoginService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select LoginService.svc or LoginService.svc.cs at the Solution Explorer and start debugging.
    public class LoginService : ILoginService
    {
        // create db reference      
        SkjutsDBEntities userDatabase = new SkjutsDBEntities();

        public bool CheckUser(string username, string password)
        {
            foreach (var item in userDatabase.Users)
            {
                // find username
                if (item.Username.ToLower() == username.ToLower())
                {
                    // username found, does password match?
                    if (item.Password == password)
                    {
                        return true;
                    }
                    // username found, bad password
                    else
                    {
                        return false;
                    }
                }
            }
            // login failed - no username found
            return false;
        }

        public bool CheckUserAdmin(string username, string password)
        {
            foreach (var item in userDatabase.Users)
            {
                // find username
                if (item.Username.ToLower() == username.ToLower())
                {
                    // username found, does password match?
                    if (item.Password == password)
                    {
                        // is admin?
                        if (item.IsAdmin)
                        {
                            return true;
                        }
                        // not admin = false
                        else
                        {
                            return false;
                        }
                    }
                    // username found, bad password
                    else
                    {
                        return false;
                    }
                }
            }
            // login failed - no username found
            return false;
        }
    }
}
