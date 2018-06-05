using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Tools.Data.Model;

namespace Com.Wiseape.Tools.OAuthServerManager.Repository.Contract
{
    public interface IDeleteRegisteredApplicationRepository
    {

	   	/// <summary>
	   	/// Delete all  Registered Application data with application Name containing specified keyword
	    /// </summary>
		/// <param name="applicationName"> Application Name</param>
		/// <returns>List of  Registered Application</returns>
		void DeleteByApplicationName(string applicationName);
	
	   	/// <summary>
	   	/// Delete all  Registered Application data with application Desc containing specified keyword
	    /// </summary>
		/// <param name="applicationDesc"> Application Desc</param>
		/// <returns>List of  Registered Application</returns>
		void DeleteByApplicationDesc(string applicationDesc);
	
	   	/// <summary>
	   	/// Delete all  Registered Application data with client I D containing specified keyword
	    /// </summary>
		/// <param name="clientID"> Client I D</param>
		/// <returns>List of  Registered Application</returns>
		void DeleteByClientID(string clientID);
	
	   	/// <summary>
	   	/// Delete all  Registered Application data with client Secret containing specified keyword
	    /// </summary>
		/// <param name="clientSecret"> Client Secret</param>
		/// <returns>List of  Registered Application</returns>
		void DeleteByClientSecret(string clientSecret);
	
	   	/// <summary>
	   	/// Delete all  Registered Application data with authorization Token Redirect U R I containing specified keyword
	    /// </summary>
		/// <param name="authorizationTokenRedirectURI"> Authorization Token Redirect U R I</param>
		/// <returns>List of  Registered Application</returns>
		void DeleteByAuthorizationTokenRedirectURI(string authorizationTokenRedirectURI);
	
	   	/// <summary>
	   	/// Delete all  Registered Application data with access Token Redirect U R I containing specified keyword
	    /// </summary>
		/// <param name="accessTokenRedirectURI"> Access Token Redirect U R I</param>
		/// <returns>List of  Registered Application</returns>
		void DeleteByAccessTokenRedirectURI(string accessTokenRedirectURI);
	
	   	/// <summary>
	   	/// Delete all  Registered Application data with authentication Source Connection String containing specified keyword
	    /// </summary>
		/// <param name="authenticationSourceConnectionString"> Authentication Source Connection String</param>
		/// <returns>List of  Registered Application</returns>
		void DeleteByAuthenticationSourceConnectionString(string authenticationSourceConnectionString);
	
	   	/// <summary>
	   	/// Delete all  Registered Application data with authentication Url containing specified keyword
	    /// </summary>
		/// <param name="authenticationUrl"> Authentication Url</param>
		/// <returns>List of  Registered Application</returns>
		void DeleteByAuthenticationUrl(string authenticationUrl);
	
	   	/// <summary>
	   	/// Delete all  Registered Application data with created Date containing specified keyword
	    /// </summary>
		/// <param name="createdDate"> Created Date</param>
		/// <returns>List of  Registered Application</returns>
		void DeleteByCreatedDate(DateTime createdDate);
	
	   	/// <summary>
	    /// Delete all  Registered Application data with specified authentication Source Id 
	    /// </summary>
		/// <param name="authenticationSourceId"> Authentication Source Id</param>
		/// <returns>List of  Registered Application</returns>
		void DeleteByAuthenticationSourceId(Int16 authenticationSourceId);
	
	   	/// <summary>
	    /// Delete all  Registered Application data with specified authentication Source Id, is Active 
	    /// </summary>
		/// <param name="authenticationSourceId"> Authentication Source Id</param>
		/// <param name="isActive"> Is Active</param>
		/// <returns>List of  Registered Application</returns>
		void DeleteByAuthenticationSourceIdAndIsActive(Int16 authenticationSourceId, Int16 isActive);
	
	   	/// <summary>
	    /// Delete all  Registered Application data with specified is Active 
	    /// </summary>
		/// <param name="isActive"> Is Active</param>
		/// <returns>List of  Registered Application</returns>
		void DeleteByIsActive(Int16 isActive);
	
    }
}

