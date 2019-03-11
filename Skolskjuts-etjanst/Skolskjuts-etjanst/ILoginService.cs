using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Skolskjuts_etjanst
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ILoginService" in both code and config file together.
    [ServiceContract]
    public interface ILoginService
    {
        // will check if user exists, not grant admin permissions with sessions
        [OperationContract]
        bool CheckUser(string username, string password);

        // will check if user is admin, grants admin permissions with sessions
        [OperationContract]
        bool CheckUserAdmin(string username, string password);
    }
}