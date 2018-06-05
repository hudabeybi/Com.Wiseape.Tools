using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Tools.Data.Model;
using Com.Wiseape.Tools.OAuthServerManager.View;
using Com.Wiseape.Utility;

namespace Com.Wiseape.Tools.OAuthServerManager.Business.Contract
{
    public interface IHandleAccessTokenRequestBusinessService
    {
        OperationResult CheckClientIDAndClientSecret(string clientID, string clientSecret);

        OperationResult CheckAuthorizationCode(string clientID, string clientSecret, string authorizationCode);

        OperationResult CreateAccessToken(AuthenticationCode authenticationCode);

        OperationResult SaveAccessToken(AccessToken accessToken);

 

    }
}
