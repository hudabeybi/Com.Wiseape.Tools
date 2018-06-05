using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Utility;
using Com.Wiseape.Tools.Data.Model;

namespace Com.Wiseape.Tools.OAuthServerManager.Business.Contract
{
    public interface IAuthorizationBusinessService
    {
        bool CheckClientID(string clientID);

        AuthenticationSession GenerateAuthenticationSession(string clientID);

        OperationResult SaveAuthenticationSession(AuthenticationSession session);

        string GetLoginHtml(string clientID, AuthenticationSession session, string loginFile);
           
    }
}
