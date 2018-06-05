using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Utility;
using Com.Wiseape.Tools.Data.Model;


namespace Com.Wiseape.Tools.OAuthServerManager.Business.Contract
{
    public interface IUpdateAccessTokenBusinessService
    {

        /// <summary>
        /// Updates  Access Token's access Token String which has specified idAccessToken
        /// </summary>
		/// <param name="idAccessToken">id Access Token</param>
		/// <param name="accessTokenString">access Token String</param>
		/// <returns>List of  Access Token</returns>
		OperationResult UpdateAccessTokenString(Int64 idAccessToken, string accessTokenString);

        /// <summary>
        /// Updates  Access Token's refresh Token which has specified idAccessToken
        /// </summary>
		/// <param name="idAccessToken">id Access Token</param>
		/// <param name="refreshToken">refresh Token</param>
		/// <returns>List of  Access Token</returns>
		OperationResult UpdateRefreshToken(Int64 idAccessToken, string refreshToken);

        /// <summary>
        /// Updates  Access Token's client I D which has specified idAccessToken
        /// </summary>
		/// <param name="idAccessToken">id Access Token</param>
		/// <param name="clientID">client I D</param>
		/// <returns>List of  Access Token</returns>
		OperationResult UpdateClientID(Int64 idAccessToken, string clientID);

        /// <summary>
        /// Updates  Access Token's client Secret which has specified idAccessToken
        /// </summary>
		/// <param name="idAccessToken">id Access Token</param>
		/// <param name="clientSecret">client Secret</param>
		/// <returns>List of  Access Token</returns>
		OperationResult UpdateClientSecret(Int64 idAccessToken, string clientSecret);

        /// <summary>
        /// Updates  Access Token's created Date which has specified idAccessToken
        /// </summary>
		/// <param name="idAccessToken">id Access Token</param>
		/// <param name="createdDate">created Date</param>
		/// <returns>List of  Access Token</returns>
		OperationResult UpdateCreatedDate(Int64 idAccessToken, DateTime createdDate);

        /// <summary>
        /// Updates  Access Token's expired Date which has specified idAccessToken
        /// </summary>
		/// <param name="idAccessToken">id Access Token</param>
		/// <param name="expiredDate">expired Date</param>
		/// <returns>List of  Access Token</returns>
		OperationResult UpdateExpiredDate(Int64 idAccessToken, DateTime expiredDate);

	}
}