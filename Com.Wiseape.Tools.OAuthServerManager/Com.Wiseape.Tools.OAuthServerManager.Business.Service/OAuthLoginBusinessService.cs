using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Tools.Data.Model;
using Com.Wiseape.Tools.OAuthServerManager.View.Model;
using Com.Wiseape.Tools.OAuthServerManager.Repository.Contract;
using Com.Wiseape.Tools.OAuthServerManager.Business.Contract;
using Com.Wiseape.Utility;
using Com.Wiseape.Factory;
using System.Configuration;
using System.Security.Cryptography;

namespace Com.Wiseape.Tools.OAuthServerManager.Business.Service
{
    public class OAuthLoginBusinessService : IOAuthLoginBusinessService
    {
        public OperationResult CallCallbackUrlWithAuthorizationResult(string clientID, string authorizationCode)
        {
            IFindRegisteredApplicationRepository repo = (IFindRegisteredApplicationRepository)RepositoryFactory.Create("Find.Tools.OAuthServerManager.RegisteredApplication");
            List<RegisteredApplication> list = repo.FindByClientID(clientID);
            if(list.Count > 0)
            {
                string url = list[0].AuthorizationTokenRedirectURI;
                if (url != null && url.Contains("?"))
                    url += "&authorization_code=" + authorizationCode;
                else if(url != null && url.Contains("?") == false)
                    url += "?authorization_code=" + authorizationCode;
                return new OperationResult(true, url, url);
            }
            return new OperationResult(false);
        }

        public OperationResult CheckAuthenticationSession(OAuthLoginForm loginForm)
        {
            OperationResult result = new OperationResult();
            IFindAuthenticationSessionRepository sessionRepo = (IFindAuthenticationSessionRepository)RepositoryFactory.Create("Find.Tools.OAuthServerManager.AuthenticationSession");
            List<AuthenticationSession> sessions = sessionRepo.FindByAuthenticationSessionString(loginForm.AuthorizationSessionID);
            if (sessions.Count > 0)
            {
                return new OperationResult(true, sessions[0], "");
            }
            else
                return new OperationResult(false, null);
        }

        public OperationResult GenerateAuthorizationCode(OperationResult authorizationResult, string userID, string clientID, string authorizationSessionID)
        {
            AuthenticationCode authenticationCode = new AuthenticationCode();
            authenticationCode.AuthenticationCodeString = Com.Wiseape.Utility.StringUtility.GenerateRandom(10);
            authenticationCode.AuthorizationSessionID = authorizationSessionID;
            authenticationCode.ClientID = clientID;
            authenticationCode.CreatedDate = DateTime.Now;
            authenticationCode.ExpiredDate = DateTime.Now.AddMinutes(1);
            authenticationCode.UserID = userID;

            return new OperationResult(true, authenticationCode, "Ok");
        }

        public OperationResult GetAuthenticationServer(string clientID)
        {
            IFindRegisteredApplicationRepository repo = (IFindRegisteredApplicationRepository)RepositoryFactory.Create("Find.Tools.OAuthServerManager.RegisteredApplication");
            List<RegisteredApplication> applications = repo.FindByClientID(clientID);
            if(applications.Count > 0)
            {
                RegisteredApplication app = applications[0];
                return new OperationResult(true, app.AuthenticationUrl, app.AuthenticationUrl);
            }

            return new OperationResult(false, null);
        }

        public OperationResult QueryAuthenticationServer(string authServer, string username, string password)
        {
            string url = authServer;
            string pass = MD5(password);
            string sResult = Com.Wiseape.Utility.HttpUtility.WebClient.Get(authServer + "/" + username + "/" + password, null);
            OperationResult result = Com.Wiseape.Utility.Serializer.Json.Deserialize<OperationResult>(sResult);
            return result;
        }

        public OperationResult QueryAuthenticationServerAskForUserInfo(string authServer, string userID)
        {


            string url = authServer;
            url = url.Replace("/login", "/info");
            string sResult = Com.Wiseape.Utility.HttpUtility.WebClient.Get(url + "/" + userID, null);
            OperationResult result = Com.Wiseape.Utility.Serializer.Json.Deserialize<OperationResult>(sResult);
            return result;
        }

        public OperationResult SaveAuthenticationResult(OperationResult authorizationResult)
        {
            throw new NotImplementedException();
        }

        public OperationResult SaveAuthorizationCode(AuthenticationCode authorizationCode)
        {
            Com.Wiseape.Framework.BaseBusinessService<AuthenticationCode> bs = (Com.Wiseape.Framework.BaseBusinessService<AuthenticationCode>)BusinessFactory.Create("Update.Tools.OAuthServerManager.AuthenticationCode");
            return bs.Add(authorizationCode);
        }

        protected string MD5(string input)
        {

            // step 1, calculate MD5 hash from input
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {

                sb.Append(hash[i].ToString("X2"));

            }

            return sb.ToString();
        }

    }
}
