using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Utility;
using Com.Wiseape.Tools.Data.Model;


namespace Com.Wiseape.Tools.OAuthServerManager.Business.Contract
{
    public interface IUpdateRefreshTokenBusinessService
    {

        /// <summary>
        /// Updates  Refresh Token's client I D which has specified idRefreshToken
        /// </summary>
		/// <param name="idRefreshToken">id Refresh Token</param>
		/// <param name="clientID">client I D</param>
		/// <returns>List of  Refresh Token</returns>
		OperationResult UpdateClientID(Int64 idRefreshToken, string clientID);

        /// <summary>
        /// Updates  Refresh Token's client Secret which has specified idRefreshToken
        /// </summary>
		/// <param name="idRefreshToken">id Refresh Token</param>
		/// <param name="clientSecret">client Secret</param>
		/// <returns>List of  Refresh Token</returns>
		OperationResult UpdateClientSecret(Int64 idRefreshToken, string clientSecret);

        /// <summary>
        /// Updates  Refresh Token's authentication Code which has specified idRefreshToken
        /// </summary>
		/// <param name="idRefreshToken">id Refresh Token</param>
		/// <param name="authenticationCode">authentication Code</param>
		/// <returns>List of  Refresh Token</returns>
		OperationResult UpdateAuthenticationCode(Int64 idRefreshToken, string authenticationCode);

        /// <summary>
        /// Updates  Refresh Token's refresh Token String which has specified idRefreshToken
        /// </summary>
		/// <param name="idRefreshToken">id Refresh Token</param>
		/// <param name="refreshTokenString">refresh Token String</param>
		/// <returns>List of  Refresh Token</returns>
		OperationResult UpdateRefreshTokenString(Int64 idRefreshToken, string refreshTokenString);

        /// <summary>
        /// Updates  Refresh Token's created Date which has specified idRefreshToken
        /// </summary>
		/// <param name="idRefreshToken">id Refresh Token</param>
		/// <param name="createdDate">created Date</param>
		/// <returns>List of  Refresh Token</returns>
		OperationResult UpdateCreatedDate(Int64 idRefreshToken, DateTime createdDate);

        /// <summary>
        /// Updates  Refresh Token's expired Date which has specified idRefreshToken
        /// </summary>
		/// <param name="idRefreshToken">id Refresh Token</param>
		/// <param name="expiredDate">expired Date</param>
		/// <returns>List of  Refresh Token</returns>
		OperationResult UpdateExpiredDate(Int64 idRefreshToken, DateTime expiredDate);

	}
}