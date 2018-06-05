using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Framework;
using Com.Wiseape.Utility;
using Com.Wiseape.Factory;
using Com.Wiseape.Tools.Data.Model;
using Com.Wiseape.Tools.OAuthServerManager.Repository.Contract;
using Com.Wiseape.Tools.OAuthServerManager.Business.Contract;


namespace Com.Wiseape.Tools.OAuthServerManager.Business.Service
{
    public class HandleAccessTokenRequestBusinessService : IHandleAccessTokenRequestBusinessService
    {
        public OperationResult CheckAuthorizationCode(string clientID, string clientSecret, string authorizationCode)
        {
            IFindAuthenticationCodeRepository bs = (IFindAuthenticationCodeRepository)RepositoryFactory.Create("Find.Tools.OAuthServerManager.AuthenticationCode");
            List<AuthenticationCode> codes = bs.FindByAuthenticationCodeString(authorizationCode);
            if (codes.Count > 0)
            {
                AuthenticationCode code = codes[0];
                if (code.ClientID == clientID)
                    return new OperationResult(true);
                else
                    return new OperationResult(false);
            }
            else
                return new OperationResult(false);
        }

        public OperationResult CheckClientIDAndClientSecret(string clientID, string clientSecret)
        {
            IFindRegisteredApplicationRepositoryExt bs = (IFindRegisteredApplicationRepositoryExt)RepositoryFactory.Create("Find.Tools.OAuthServerManager.RegisteredApplication");
            List<RegisteredApplication> apps = bs.FindByClientIDAndClientSecret(clientID, clientSecret);
            if (apps.Count > 0)
            {
                return new OperationResult(true);
            }
            else
                return new OperationResult(false);
        }

        public OperationResult CreateAccessToken(AuthenticationCode authenticationCode)
        {
            AccessToken newAccessToken = new AccessToken();
            newAccessToken.AccessTokenString = Com.Wiseape.Utility.StringUtility.GenerateRandom(10);
            newAccessToken.ClientID = authenticationCode.ClientID;
            newAccessToken.CreatedDate = DateTime.Now;
            newAccessToken.ExpiredDate = DateTime.Now.AddHours(1);
            newAccessToken.RefreshToken = Com.Wiseape.Utility.StringUtility.GenerateRandom(10); ;
            newAccessToken.UserID = authenticationCode.UserID;

            return new OperationResult(true, newAccessToken);
        }

        public OperationResult SaveAccessToken(AccessToken accessToken)
        {
            IDeleteAccessTokenBusinessService bs = (IDeleteAccessTokenBusinessService)BusinessFactory.Create("Delete.Tools.OAuthServerManager.AccessToken");
            OperationResult result = bs.DeleteByRefreshToken(accessToken.RefreshToken);
            if (result.Result)
            {
                Com.Wiseape.Framework.BaseBusinessService<AccessToken> bs2 = (Com.Wiseape.Framework.BaseBusinessService<AccessToken>)bs;
                result = bs2.Add(accessToken);
            }
            return result;
        }
    }
}
