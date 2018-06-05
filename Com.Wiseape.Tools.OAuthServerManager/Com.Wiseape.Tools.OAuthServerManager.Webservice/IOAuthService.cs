using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Com.Wiseape.Tools.OAuthServerManager.View.Model;

namespace Com.Wiseape.Tools.OAuthServerManager.Webservice
{


    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IOAuthService" in both code and config file together.
    [ServiceContract]
    public interface IOAuthService
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        Stream CheckAccessToken(string accessToken);

        [OperationContract]
        Stream HandleAuthorizationRequest(string ClientID);

        [OperationContract]
        Stream HandleOAuthLogin(OAuthLoginForm loginForm);

        [OperationContract]
        Stream HandleAccessTokenRequest(string authorizationCode, string clientID, string clientSecret);

        [OperationContract]
        Stream UserInfo();
    }
}
