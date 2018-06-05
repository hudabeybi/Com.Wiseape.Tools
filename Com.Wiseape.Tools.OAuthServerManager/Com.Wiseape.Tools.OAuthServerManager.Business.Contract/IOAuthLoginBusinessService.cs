using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Utility;
using Com.Wiseape.Tools.OAuthServerManager.View.Model;
using Com.Wiseape.Tools.Data.Model;

namespace Com.Wiseape.Tools.OAuthServerManager.Business.Contract
{
    public interface IOAuthLoginBusinessService
    {
        /// <summary>
        /// Step 1 : Check Authentication Session if it's valid
        /// </summary>
        /// <param name="loginForm"></param>
        /// <returns></returns>
        OperationResult CheckAuthenticationSession(OAuthLoginForm loginForm);

        /// <summary>
        /// Step 2: Get Authentication server to authenticate username and password
        /// </summary>
        /// <returns></returns>
        OperationResult GetAuthenticationServer(string clientID);

        /// <summary>
        /// Step 3: Call Authentication server with username and password parameter
        /// </summary>
        /// <param name="authServer"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        OperationResult QueryAuthenticationServer(string authServer, string username, string password);

        /// <summary>
        /// Step 4: Save authentication result sent by authentication server
        /// </summary>
        /// <param name="authorizationResult"></param>
        /// <returns></returns>
        OperationResult SaveAuthenticationResult(OperationResult authorizationResult);

        /// <summary>
        /// Step 5: Generate authorization code
        /// </summary>
        /// <param name="authorizationResult"></param>
        /// <returns></returns>
        OperationResult GenerateAuthorizationCode(OperationResult authorizationResult, string userID, string clientID, string sessionCode);

        /// <summary>
        /// Step 6: Save authorization code to database
        /// </summary>
        /// <param name="authorizationCode"></param>
        /// <returns></returns>
        OperationResult SaveAuthorizationCode(AuthenticationCode authorizationCode);

        /// <summary>
        /// Step 7: Assemble url with callback url + authorization code
        /// </summary>
        /// <param name="authorizationCode"></param>
        /// <returns></returns>
        OperationResult CallCallbackUrlWithAuthorizationResult(string clientID, string authorizationCode);


        OperationResult QueryAuthenticationServerAskForUserInfo(string authServer, string username);
    }
}
