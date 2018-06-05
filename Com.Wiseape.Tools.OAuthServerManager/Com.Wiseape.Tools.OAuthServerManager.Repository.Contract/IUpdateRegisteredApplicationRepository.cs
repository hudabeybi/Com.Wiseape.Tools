using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Tools.Data.Model;



namespace Com.Wiseape.Tools.OAuthServerManager.Repository.Contract
{
    public interface IUpdateRegisteredApplicationRepository
    {

	    /// <summary>
	    /// Updates  Registered Application's id Application, application Name by idApplication
	    /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationName">application Name</param>
		/// <returns>List of  Registered Application</returns>
		void UpdateApplicationName(Int16 idApplication, string applicationName);
	
	    /// <summary>
	    /// Updates  Registered Application's id Application, application Desc by idApplication
	    /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationDesc">application Desc</param>
		/// <returns>List of  Registered Application</returns>
		void UpdateApplicationDesc(Int16 idApplication, string applicationDesc);
	
	    /// <summary>
	    /// Updates  Registered Application's id Application, client I D by idApplication
	    /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="clientID">client I D</param>
		/// <returns>List of  Registered Application</returns>
		void UpdateClientID(Int16 idApplication, string clientID);
	
	    /// <summary>
	    /// Updates  Registered Application's id Application, client Secret by idApplication
	    /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="clientSecret">client Secret</param>
		/// <returns>List of  Registered Application</returns>
		void UpdateClientSecret(Int16 idApplication, string clientSecret);
	
	    /// <summary>
	    /// Updates  Registered Application's id Application, authorization Token Redirect U R I by idApplication
	    /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="authorizationTokenRedirectURI">authorization Token Redirect U R I</param>
		/// <returns>List of  Registered Application</returns>
		void UpdateAuthorizationTokenRedirectURI(Int16 idApplication, string authorizationTokenRedirectURI);
	
	    /// <summary>
	    /// Updates  Registered Application's id Application, access Token Redirect U R I by idApplication
	    /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="accessTokenRedirectURI">access Token Redirect U R I</param>
		/// <returns>List of  Registered Application</returns>
		void UpdateAccessTokenRedirectURI(Int16 idApplication, string accessTokenRedirectURI);
	
	    /// <summary>
	    /// Updates  Registered Application's id Application, authentication Source Connection String by idApplication
	    /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="authenticationSourceConnectionString">authentication Source Connection String</param>
		/// <returns>List of  Registered Application</returns>
		void UpdateAuthenticationSourceConnectionString(Int16 idApplication, string authenticationSourceConnectionString);
	
	    /// <summary>
	    /// Updates  Registered Application's id Application, authentication Url by idApplication
	    /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="authenticationUrl">authentication Url</param>
		/// <returns>List of  Registered Application</returns>
		void UpdateAuthenticationUrl(Int16 idApplication, string authenticationUrl);
	
	    /// <summary>
	    /// Updates  Registered Application's id Application, created Date by idApplication
	    /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="createdDate">created Date</param>
		/// <returns>List of  Registered Application</returns>
		void UpdateCreatedDate(Int16 idApplication, DateTime createdDate);
	
	    /// <summary>
	    /// Updates  Registered Application's id Application, authentication Source Id by idApplication
	    /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="authenticationSourceId">authentication Source Id</param>
		/// <returns>List of  Registered Application</returns>
		void UpdateAuthenticationSourceId(Int16 idApplication, Int16 authenticationSourceId);
	
	    /// <summary>
	    /// Updates  Registered Application's id Application, authentication Source Id, is Active by idApplication
	    /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="authenticationSourceId">authentication Source Id</param>
		/// <param name="isActive">is Active</param>
		/// <returns>List of  Registered Application</returns>
		void UpdateAuthenticationSourceIdAndIsActive(Int16 idApplication, Int16 authenticationSourceId, Int16 isActive);
	
	    /// <summary>
	    /// Updates  Registered Application's id Application, is Active by idApplication
	    /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="isActive">is Active</param>
		/// <returns>List of  Registered Application</returns>
		void UpdateIsActive(Int16 idApplication, Int16 isActive);
	
    }
}

