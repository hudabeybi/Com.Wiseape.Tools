using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Tools.Data.Model;

namespace Com.Wiseape.Tools.OAuthServerManager.Repository.Contract
{
    public interface IDeleteRefreshTokenRepository
    {

	   	/// <summary>
	   	/// Delete all  Refresh Token data with client I D containing specified keyword
	    /// </summary>
		/// <param name="clientID"> Client I D</param>
		/// <returns>List of  Refresh Token</returns>
		void DeleteByClientID(string clientID);
	
	   	/// <summary>
	   	/// Delete all  Refresh Token data with client Secret containing specified keyword
	    /// </summary>
		/// <param name="clientSecret"> Client Secret</param>
		/// <returns>List of  Refresh Token</returns>
		void DeleteByClientSecret(string clientSecret);
	
	   	/// <summary>
	   	/// Delete all  Refresh Token data with authentication Code containing specified keyword
	    /// </summary>
		/// <param name="authenticationCode"> Authentication Code</param>
		/// <returns>List of  Refresh Token</returns>
		void DeleteByAuthenticationCode(string authenticationCode);
	
	   	/// <summary>
	   	/// Delete all  Refresh Token data with refresh Token String containing specified keyword
	    /// </summary>
		/// <param name="refreshTokenString"> Refresh Token String</param>
		/// <returns>List of  Refresh Token</returns>
		void DeleteByRefreshTokenString(string refreshTokenString);
	
	   	/// <summary>
	   	/// Delete all  Refresh Token data with created Date containing specified keyword
	    /// </summary>
		/// <param name="createdDate"> Created Date</param>
		/// <returns>List of  Refresh Token</returns>
		void DeleteByCreatedDate(DateTime createdDate);
	
	   	/// <summary>
	   	/// Delete all  Refresh Token data with expired Date containing specified keyword
	    /// </summary>
		/// <param name="expiredDate"> Expired Date</param>
		/// <returns>List of  Refresh Token</returns>
		void DeleteByExpiredDate(DateTime expiredDate);
	
    }
}

