using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Tools.Data.Model;



namespace Com.Wiseape.Tools.OAuthServerManager.Repository.Contract
{
    public interface IUpdateRefreshTokenRepository
    {

	    /// <summary>
	    /// Updates  Refresh Token's id Refresh Token, client I D by idRefreshToken
	    /// </summary>
		/// <param name="idRefreshToken">id Refresh Token</param>
		/// <param name="clientID">client I D</param>
		/// <returns>List of  Refresh Token</returns>
		void UpdateClientID(Int64 idRefreshToken, string clientID);
	
	    /// <summary>
	    /// Updates  Refresh Token's id Refresh Token, client Secret by idRefreshToken
	    /// </summary>
		/// <param name="idRefreshToken">id Refresh Token</param>
		/// <param name="clientSecret">client Secret</param>
		/// <returns>List of  Refresh Token</returns>
		void UpdateClientSecret(Int64 idRefreshToken, string clientSecret);
	
	    /// <summary>
	    /// Updates  Refresh Token's id Refresh Token, authentication Code by idRefreshToken
	    /// </summary>
		/// <param name="idRefreshToken">id Refresh Token</param>
		/// <param name="authenticationCode">authentication Code</param>
		/// <returns>List of  Refresh Token</returns>
		void UpdateAuthenticationCode(Int64 idRefreshToken, string authenticationCode);
	
	    /// <summary>
	    /// Updates  Refresh Token's id Refresh Token, refresh Token String by idRefreshToken
	    /// </summary>
		/// <param name="idRefreshToken">id Refresh Token</param>
		/// <param name="refreshTokenString">refresh Token String</param>
		/// <returns>List of  Refresh Token</returns>
		void UpdateRefreshTokenString(Int64 idRefreshToken, string refreshTokenString);
	
	    /// <summary>
	    /// Updates  Refresh Token's id Refresh Token, created Date by idRefreshToken
	    /// </summary>
		/// <param name="idRefreshToken">id Refresh Token</param>
		/// <param name="createdDate">created Date</param>
		/// <returns>List of  Refresh Token</returns>
		void UpdateCreatedDate(Int64 idRefreshToken, DateTime createdDate);
	
	    /// <summary>
	    /// Updates  Refresh Token's id Refresh Token, expired Date by idRefreshToken
	    /// </summary>
		/// <param name="idRefreshToken">id Refresh Token</param>
		/// <param name="expiredDate">expired Date</param>
		/// <returns>List of  Refresh Token</returns>
		void UpdateExpiredDate(Int64 idRefreshToken, DateTime expiredDate);
	
    }
}

