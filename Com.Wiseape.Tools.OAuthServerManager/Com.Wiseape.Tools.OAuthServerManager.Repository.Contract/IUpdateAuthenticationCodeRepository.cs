using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Tools.Data.Model;



namespace Com.Wiseape.Tools.OAuthServerManager.Repository.Contract
{
    public interface IUpdateAuthenticationCodeRepository
    {

	    /// <summary>
	    /// Updates  Authentication Code's id Authentication Code, authentication Code String by idAuthenticationCode
	    /// </summary>
		/// <param name="idAuthenticationCode">id Authentication Code</param>
		/// <param name="authenticationCodeString">authentication Code String</param>
		/// <returns>List of  Authentication Code</returns>
		void UpdateAuthenticationCodeString(Int64 idAuthenticationCode, string authenticationCodeString);
	
	    /// <summary>
	    /// Updates  Authentication Code's id Authentication Code, client I D by idAuthenticationCode
	    /// </summary>
		/// <param name="idAuthenticationCode">id Authentication Code</param>
		/// <param name="clientID">client I D</param>
		/// <returns>List of  Authentication Code</returns>
		void UpdateClientID(Int64 idAuthenticationCode, string clientID);
	
	    /// <summary>
	    /// Updates  Authentication Code's id Authentication Code, authorization Session I D by idAuthenticationCode
	    /// </summary>
		/// <param name="idAuthenticationCode">id Authentication Code</param>
		/// <param name="authorizationSessionID">authorization Session I D</param>
		/// <returns>List of  Authentication Code</returns>
		void UpdateAuthorizationSessionID(Int64 idAuthenticationCode, string authorizationSessionID);
	
	    /// <summary>
	    /// Updates  Authentication Code's id Authentication Code, created Date by idAuthenticationCode
	    /// </summary>
		/// <param name="idAuthenticationCode">id Authentication Code</param>
		/// <param name="createdDate">created Date</param>
		/// <returns>List of  Authentication Code</returns>
		void UpdateCreatedDate(Int64 idAuthenticationCode, DateTime createdDate);
	
	    /// <summary>
	    /// Updates  Authentication Code's id Authentication Code, expired Date by idAuthenticationCode
	    /// </summary>
		/// <param name="idAuthenticationCode">id Authentication Code</param>
		/// <param name="expiredDate">expired Date</param>
		/// <returns>List of  Authentication Code</returns>
		void UpdateExpiredDate(Int64 idAuthenticationCode, DateTime expiredDate);
	
    }
}

