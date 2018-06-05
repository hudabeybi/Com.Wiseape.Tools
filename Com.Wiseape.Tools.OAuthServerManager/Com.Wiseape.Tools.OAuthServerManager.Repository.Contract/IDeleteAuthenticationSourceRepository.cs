using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Tools.Data.Model;

namespace Com.Wiseape.Tools.OAuthServerManager.Repository.Contract
{
    public interface IDeleteAuthenticationSourceRepository
    {

	   	/// <summary>
	   	/// Delete all  Authentication Source data with authentication Source Name containing specified keyword
	    /// </summary>
		/// <param name="authenticationSourceName"> Authentication Source Name</param>
		/// <returns>List of  Authentication Source</returns>
		void DeleteByAuthenticationSourceName(string authenticationSourceName);
	
	   	/// <summary>
	   	/// Delete all  Authentication Source data with authentication Library containing specified keyword
	    /// </summary>
		/// <param name="authenticationLibrary"> Authentication Library</param>
		/// <returns>List of  Authentication Source</returns>
		void DeleteByAuthenticationLibrary(string authenticationLibrary);
	
	   	/// <summary>
	   	/// Delete all  Authentication Source data with authentication Classname containing specified keyword
	    /// </summary>
		/// <param name="authenticationClassname"> Authentication Classname</param>
		/// <returns>List of  Authentication Source</returns>
		void DeleteByAuthenticationClassname(string authenticationClassname);
	
    }
}

