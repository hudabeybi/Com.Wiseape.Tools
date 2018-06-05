using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Tools.Data.Model;

namespace Com.Wiseape.Tools.OAuthServerManager.Repository.Contract
{
    public interface IDeleteAuthenticationCodeRepository
    {

	   	/// <summary>
	   	/// Delete all  Authentication Code data with authentication Code String containing specified keyword
	    /// </summary>
		/// <param name="authenticationCodeString"> Authentication Code String</param>
		/// <returns>List of  Authentication Code</returns>
		void DeleteByAuthenticationCodeString(string authenticationCodeString);
	
	   	/// <summary>
	   	/// Delete all  Authentication Code data with client I D containing specified keyword
	    /// </summary>
		/// <param name="clientID"> Client I D</param>
		/// <returns>List of  Authentication Code</returns>
		void DeleteByClientID(string clientID);
	
	   	/// <summary>
	   	/// Delete all  Authentication Code data with authorization Session I D containing specified keyword
	    /// </summary>
		/// <param name="authorizationSessionID"> Authorization Session I D</param>
		/// <returns>List of  Authentication Code</returns>
		void DeleteByAuthorizationSessionID(string authorizationSessionID);
	
	   	/// <summary>
	   	/// Delete all  Authentication Code data with created Date containing specified keyword
	    /// </summary>
		/// <param name="createdDate"> Created Date</param>
		/// <returns>List of  Authentication Code</returns>
		void DeleteByCreatedDate(DateTime createdDate);
	
	   	/// <summary>
	   	/// Delete all  Authentication Code data with expired Date containing specified keyword
	    /// </summary>
		/// <param name="expiredDate"> Expired Date</param>
		/// <returns>List of  Authentication Code</returns>
		void DeleteByExpiredDate(DateTime expiredDate);
	
    }
}

