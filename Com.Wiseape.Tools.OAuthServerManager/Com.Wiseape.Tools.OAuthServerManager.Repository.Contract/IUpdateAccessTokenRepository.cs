using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Tools.Data.Model;



namespace Com.Wiseape.Tools.OAuthServerManager.Repository.Contract
{
    public interface IUpdateAccessTokenRepository
    {

	    /// <summary>
	    /// Updates  Access Token's id Access Token, access Token String by idAccessToken
	    /// </summary>
		/// <param name="idAccessToken">id Access Token</param>
		/// <param name="accessTokenString">access Token String</param>
		/// <returns>List of  Access Token</returns>
		void UpdateAccessTokenString(Int64 idAccessToken, string accessTokenString);
	
	    /// <summary>
	    /// Updates  Access Token's id Access Token, refresh Token by idAccessToken
	    /// </summary>
		/// <param name="idAccessToken">id Access Token</param>
		/// <param name="refreshToken">refresh Token</param>
		/// <returns>List of  Access Token</returns>
		void UpdateRefreshToken(Int64 idAccessToken, string refreshToken);
	
	    /// <summary>
	    /// Updates  Access Token's id Access Token, client I D by idAccessToken
	    /// </summary>
		/// <param name="idAccessToken">id Access Token</param>
		/// <param name="clientID">client I D</param>
		/// <returns>List of  Access Token</returns>
		void UpdateClientID(Int64 idAccessToken, string clientID);
	
	    /// <summary>
	    /// Updates  Access Token's id Access Token, client Secret by idAccessToken
	    /// </summary>
		/// <param name="idAccessToken">id Access Token</param>
		/// <param name="clientSecret">client Secret</param>
		/// <returns>List of  Access Token</returns>
		void UpdateClientSecret(Int64 idAccessToken, string clientSecret);
	
	    /// <summary>
	    /// Updates  Access Token's id Access Token, created Date by idAccessToken
	    /// </summary>
		/// <param name="idAccessToken">id Access Token</param>
		/// <param name="createdDate">created Date</param>
		/// <returns>List of  Access Token</returns>
		void UpdateCreatedDate(Int64 idAccessToken, DateTime createdDate);
	
	    /// <summary>
	    /// Updates  Access Token's id Access Token, expired Date by idAccessToken
	    /// </summary>
		/// <param name="idAccessToken">id Access Token</param>
		/// <param name="expiredDate">expired Date</param>
		/// <returns>List of  Access Token</returns>
		void UpdateExpiredDate(Int64 idAccessToken, DateTime expiredDate);
	
    }
}

