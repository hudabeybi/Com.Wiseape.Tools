using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Utility;
using Com.Wiseape.Tools.Data.Model;


namespace Com.Wiseape.Tools.OAuthServerManager.Business.Contract
{
    public interface IDeleteRegisteredApplicationBusinessService
    {

        /// <summary>
        /// Delete all  Registered Application data with application Name containing specified keyword
        /// </summary>
		/// <param name="applicationName"> Application Name</param>
		/// <returns>List of  Registered Application</returns>
		OperationResult DeleteByApplicationName(string applicationName);

        /// <summary>
        /// Delete all  Registered Application data with application Desc containing specified keyword
        /// </summary>
		/// <param name="applicationDesc"> Application Desc</param>
		/// <returns>List of  Registered Application</returns>
		OperationResult DeleteByApplicationDesc(string applicationDesc);

        /// <summary>
        /// Delete all  Registered Application data with client I D containing specified keyword
        /// </summary>
		/// <param name="clientID"> Client I D</param>
		/// <returns>List of  Registered Application</returns>
		OperationResult DeleteByClientID(string clientID);

        /// <summary>
        /// Delete all  Registered Application data with client Secret containing specified keyword
        /// </summary>
		/// <param name="clientSecret"> Client Secret</param>
		/// <returns>List of  Registered Application</returns>
		OperationResult DeleteByClientSecret(string clientSecret);

        /// <summary>
        /// Delete all  Registered Application data with authorization Token Redirect U R I containing specified keyword
        /// </summary>
		/// <param name="authorizationTokenRedirectURI"> Authorization Token Redirect U R I</param>
		/// <returns>List of  Registered Application</returns>
		OperationResult DeleteByAuthorizationTokenRedirectURI(string authorizationTokenRedirectURI);

        /// <summary>
        /// Delete all  Registered Application data with access Token Redirect U R I containing specified keyword
        /// </summary>
		/// <param name="accessTokenRedirectURI"> Access Token Redirect U R I</param>
		/// <returns>List of  Registered Application</returns>
		OperationResult DeleteByAccessTokenRedirectURI(string accessTokenRedirectURI);

        /// <summary>
        /// Delete all  Registered Application data with authentication Source Connection String containing specified keyword
        /// </summary>
		/// <param name="authenticationSourceConnectionString"> Authentication Source Connection String</param>
		/// <returns>List of  Registered Application</returns>
		OperationResult DeleteByAuthenticationSourceConnectionString(string authenticationSourceConnectionString);

        /// <summary>
        /// Delete all  Registered Application data with authentication Url containing specified keyword
        /// </summary>
		/// <param name="authenticationUrl"> Authentication Url</param>
		/// <returns>List of  Registered Application</returns>
		OperationResult DeleteByAuthenticationUrl(string authenticationUrl);

        /// <summary>
        /// Delete all  Registered Application data with created Date containing specified keyword
        /// </summary>
		/// <param name="createdDate"> Created Date</param>
		/// <returns>List of  Registered Application</returns>
		OperationResult DeleteByCreatedDate(DateTime createdDate);

        /// <summary>
        /// Delete all  Registered Application data with specified authentication Source Id 
        /// </summary>
		/// <param name="authenticationSourceId"> Authentication Source Id</param>
		/// <returns>List of  Registered Application</returns>
		OperationResult DeleteByAuthenticationSourceId(Int16 authenticationSourceId);

        /// <summary>
        /// Delete all  Registered Application data with specified authentication Source Id, is Active 
        /// </summary>
		/// <param name="authenticationSourceId"> Authentication Source Id</param>
		/// <param name="isActive"> Is Active</param>
		/// <returns>List of  Registered Application</returns>
		OperationResult DeleteByAuthenticationSourceIdAndIsActive(Int16 authenticationSourceId, Int16 isActive);

        /// <summary>
        /// Delete all  Registered Application data with specified is Active 
        /// </summary>
		/// <param name="isActive"> Is Active</param>
		/// <returns>List of  Registered Application</returns>
		OperationResult DeleteByIsActive(Int16 isActive);

	}
}