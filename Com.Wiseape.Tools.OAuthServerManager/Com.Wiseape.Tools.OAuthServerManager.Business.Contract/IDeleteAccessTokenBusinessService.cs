using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Utility;
using Com.Wiseape.Tools.Data.Model;


namespace Com.Wiseape.Tools.OAuthServerManager.Business.Contract
{
    public interface IDeleteAccessTokenBusinessService
    {

        /// <summary>
        /// Delete all  Access Token data with access Token String containing specified keyword
        /// </summary>
		/// <param name="accessTokenString"> Access Token String</param>
		/// <returns>List of  Access Token</returns>
		OperationResult DeleteByAccessTokenString(string accessTokenString);

        /// <summary>
        /// Delete all  Access Token data with refresh Token containing specified keyword
        /// </summary>
		/// <param name="refreshToken"> Refresh Token</param>
		/// <returns>List of  Access Token</returns>
		OperationResult DeleteByRefreshToken(string refreshToken);

        /// <summary>
        /// Delete all  Access Token data with client I D containing specified keyword
        /// </summary>
		/// <param name="clientID"> Client I D</param>
		/// <returns>List of  Access Token</returns>
		OperationResult DeleteByClientID(string clientID);

        /// <summary>
        /// Delete all  Access Token data with client Secret containing specified keyword
        /// </summary>
		/// <param name="clientSecret"> Client Secret</param>
		/// <returns>List of  Access Token</returns>
		OperationResult DeleteByClientSecret(string clientSecret);

        /// <summary>
        /// Delete all  Access Token data with created Date containing specified keyword
        /// </summary>
		/// <param name="createdDate"> Created Date</param>
		/// <returns>List of  Access Token</returns>
		OperationResult DeleteByCreatedDate(DateTime createdDate);

        /// <summary>
        /// Delete all  Access Token data with expired Date containing specified keyword
        /// </summary>
		/// <param name="expiredDate"> Expired Date</param>
		/// <returns>List of  Access Token</returns>
		OperationResult DeleteByExpiredDate(DateTime expiredDate);

	}
}