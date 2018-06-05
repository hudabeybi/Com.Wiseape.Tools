using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Utility;
using Com.Wiseape.Tools.Data.Model;


namespace Com.Wiseape.Tools.OAuthServerManager.Business.Contract
{
    public interface IFindAccessTokenBusinessService
    {

        /// <summary>
        /// Finds all  Access Token data with access Token String containing specified keyword
        /// </summary>
		/// <param name="accessTokenString"> Access Token String</param>
		/// <returns>List of  Access Token</returns>
		OperationResult FindByAccessTokenString(string accessTokenString);

        /// <summary>
        /// Finds all  Access Token data with refresh Token containing specified keyword
        /// </summary>
		/// <param name="refreshToken"> Refresh Token</param>
		/// <returns>List of  Access Token</returns>
		OperationResult FindByRefreshToken(string refreshToken);

        /// <summary>
        /// Finds all  Access Token data with client I D containing specified keyword
        /// </summary>
		/// <param name="clientID"> Client I D</param>
		/// <returns>List of  Access Token</returns>
		OperationResult FindByClientID(string clientID);

        /// <summary>
        /// Finds all  Access Token data with client Secret containing specified keyword
        /// </summary>
		/// <param name="clientSecret"> Client Secret</param>
		/// <returns>List of  Access Token</returns>
		OperationResult FindByClientSecret(string clientSecret);

        /// <summary>
        /// Finds all  Access Token with CreatedDate between CreatedDate1 and CreatedDate2
        /// </summary>
		/// <param name="createdDate1"> Created Date</param>
		/// <param name="createdDate2"> Created Date</param>
		/// <returns>List of  Access Token</returns>
		OperationResult FindByCreatedDateBetween(DateTime createdDate1, DateTime createdDate2);

        /// <summary>
        /// Finds all  Access Token with ExpiredDate between ExpiredDate1 and ExpiredDate2
        /// </summary>
		/// <param name="expiredDate1"> Expired Date</param>
		/// <param name="expiredDate2"> Expired Date</param>
		/// <returns>List of  Access Token</returns>
		OperationResult FindByExpiredDateBetween(DateTime expiredDate1, DateTime expiredDate2);

	}
}