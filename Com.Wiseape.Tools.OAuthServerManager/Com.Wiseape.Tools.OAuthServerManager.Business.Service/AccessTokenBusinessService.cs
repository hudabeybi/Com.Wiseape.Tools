using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Tools.Data.Model;
using Com.Wiseape.Tools.OAuthServerManager.Repository.Contract;
using Com.Wiseape.Tools.OAuthServerManager.Business.Contract;
using Com.Wiseape.Factory;
using Com.Wiseape.Utility;
using System.Configuration;

namespace Com.Wiseape.Tools.OAuthServerManager.Business.Service
{
    public class AccessTokenBusinessService : IAccessTokenBusinessService
    {
        public OperationResult CheckAccessToken(string accessToken)
        {
            IFindAccessTokenRepository repo = (IFindAccessTokenRepository)RepositoryFactory.Create("Find.Tools.OAuthServerManager.AccessToken");
            List<AccessToken> accessTokens = repo.FindByAccessTokenString(accessToken);

            OperationResult result = new OperationResult();
            if (accessTokens.Count == 0)
            {
                result.Result = false;
                result.Data = null;
                result.Message = "Access token does not exists. Please request for authorization by requesting to this url: " + ConfigurationManager.AppSettings["REQUEST.AUTHORIZATION.URL"];
            }
            else
            {
                AccessToken acctoken = accessTokens[0];
                if (acctoken.ExpiredDate > DateTime.Now)
                    result = new OperationResult(true, accessTokens[0]);
                else
                {
                    result.Result = false;
                    result.Data = null;
                    result.Message = "Access token has expired. Please request for new access token by requesting to this url: " + ConfigurationManager.AppSettings["REQUEST.REFRESHACCESSTOKEN.URL"];

                }

            }
                
            return result;
        }

        public OperationResult RefreshAccessToken(string refreshToken, string clientID, string clientSecret)
        {

            //Check first if the registered application with specified clientid and clientsecret exists
            IFindRegisteredApplicationRepositoryExt registeredAppRepo = (IFindRegisteredApplicationRepositoryExt)RepositoryFactory.Create("Find.Tools.OAuthServerManager.RegisteredApplication");
            List<RegisteredApplication> list = registeredAppRepo.FindByClientIDAndClientSecret(clientID, clientSecret);

            //If exists
            if (list != null && list.Count > 0)
            {
                //Check if the application has been authorized before by checking the access token previous existence
                IFindAccessTokenRepository accessTokenRepo = (IFindAccessTokenRepository)RepositoryFactory.Create("Find.Tools.OAuthServerManager.AccessToken");
                List<AccessToken> accessTokenList = accessTokenRepo.FindByClientID(clientID);
                if (accessTokenList.Count == 0)
                    return new OperationResult(false, null, "Access token for client ID " + clientID + " does not exists. The application had never asked for authorization!");
                else
                {
                    AccessToken newAccessToken = (AccessToken) CreateNewAccessToken(refreshToken, clientID, clientSecret).Data;
                    OperationResult result = SaveNewccessToken(newAccessToken);
                    if (result.Result)
                    {
                        return new OperationResult(true, newAccessToken, "New access token is created successfully!");
                    }
                    else
                        return result;
                }
            }
            else
                return new OperationResult(false, null, "Application for client ID " + clientID + " does not exists. Application is not registered!");

        }

        public OperationResult CreateNewAccessToken(string refreshToken, string clientID, string clientSecret)
        {
            AccessToken newAccessToken = new AccessToken();
            newAccessToken.AccessTokenString = Com.Wiseape.Utility.StringUtility.GenerateRandom(10);
            newAccessToken.ClientID = clientID;
            newAccessToken.CreatedDate = DateTime.Now;
            newAccessToken.ExpiredDate = DateTime.Now.AddHours(1);
            newAccessToken.RefreshToken = refreshToken;

            return new OperationResult(true, newAccessToken);
        }

        protected OperationResult SaveNewccessToken(AccessToken accessToken)
        {
            IDeleteAccessTokenBusinessService bs = (IDeleteAccessTokenBusinessService)BusinessFactory.Create("Find.Tools.OAuthServerManager.AccessToken");
            OperationResult result = bs.DeleteByRefreshToken(accessToken.RefreshToken);
            if(result.Result)
            {
                Com.Wiseape.Framework.BaseBusinessService<AccessToken> bs2 = (Com.Wiseape.Framework.BaseBusinessService<AccessToken>)bs;
                result = bs2.Add(accessToken);
            }
            return result;
        }
    }
}
