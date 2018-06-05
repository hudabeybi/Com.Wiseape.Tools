using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Utility;

namespace Com.Wiseape.Tools.OAuthServerManager.Business.Contract
{
    public interface IAccessTokenBusinessService
    {
        /// <summary>
        /// Check if access token exists and still valid
        /// </summary>
        /// <param name="accessToken"></param>
        /// <returns></returns>
        OperationResult CheckAccessToken(string accessToken);

        /// <summary>
        /// Create new access token by refresh token
        /// </summary>
        /// <param name="refreshToken"></param>
        /// <returns></returns>
        OperationResult RefreshAccessToken(string refreshToken, string clientID, string clientSecret);

        OperationResult CreateNewAccessToken(string refreshToken, string clientID, string clientSecret);
    }
}
