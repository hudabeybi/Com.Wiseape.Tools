using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Utility;
using Com.Wiseape.Tools.Data.Model;


namespace Com.Wiseape.Tools.OAuthServerManager.Business.Contract
{
    public interface IFindRegisteredApplicationBusinessService
    {

        /// <summary>
        /// Finds all  Registered Application data with application Name containing specified keyword
        /// </summary>
		/// <param name="applicationName"> Application Name</param>
		/// <returns>List of  Registered Application</returns>
		OperationResult FindByApplicationName(string applicationName);

        /// <summary>
        /// Finds all  Registered Application data with application Desc containing specified keyword
        /// </summary>
		/// <param name="applicationDesc"> Application Desc</param>
		/// <returns>List of  Registered Application</returns>
		OperationResult FindByApplicationDesc(string applicationDesc);

        /// <summary>
        /// Finds all  Registered Application data with client I D containing specified keyword
        /// </summary>
		/// <param name="clientID"> Client I D</param>
		/// <returns>List of  Registered Application</returns>
		OperationResult FindByClientID(string clientID);

        /// <summary>
        /// Finds all  Registered Application data with client Secret containing specified keyword
        /// </summary>
		/// <param name="clientSecret"> Client Secret</param>
		/// <returns>List of  Registered Application</returns>
		OperationResult FindByClientSecret(string clientSecret);

        /// <summary>
        /// Finds all  Registered Application data with authorization Token Redirect U R I containing specified keyword
        /// </summary>
		/// <param name="authorizationTokenRedirectURI"> Authorization Token Redirect U R I</param>
		/// <returns>List of  Registered Application</returns>
		OperationResult FindByAuthorizationTokenRedirectURI(string authorizationTokenRedirectURI);

        /// <summary>
        /// Finds all  Registered Application data with access Token Redirect U R I containing specified keyword
        /// </summary>
		/// <param name="accessTokenRedirectURI"> Access Token Redirect U R I</param>
		/// <returns>List of  Registered Application</returns>
		OperationResult FindByAccessTokenRedirectURI(string accessTokenRedirectURI);

        /// <summary>
        /// Finds all  Registered Application data with authentication Source Connection String containing specified keyword
        /// </summary>
		/// <param name="authenticationSourceConnectionString"> Authentication Source Connection String</param>
		/// <returns>List of  Registered Application</returns>
		OperationResult FindByAuthenticationSourceConnectionString(string authenticationSourceConnectionString);

        /// <summary>
        /// Finds all  Registered Application data with authentication Url containing specified keyword
        /// </summary>
		/// <param name="authenticationUrl"> Authentication Url</param>
		/// <returns>List of  Registered Application</returns>
		OperationResult FindByAuthenticationUrl(string authenticationUrl);

        /// <summary>
        /// Finds all  Registered Application with CreatedDate between CreatedDate1 and CreatedDate2
        /// </summary>
		/// <param name="createdDate1"> Created Date</param>
		/// <param name="createdDate2"> Created Date</param>
		/// <returns>List of  Registered Application</returns>
		OperationResult FindByCreatedDateBetween(DateTime createdDate1, DateTime createdDate2);

        /// <summary>
        /// Finds all  Registered Application data with specified authentication Source Id 
        /// </summary>
		/// <param name="authenticationSourceId"> Authentication Source Id</param>
		/// <returns>List of  Registered Application</returns>
		OperationResult FindByAuthenticationSourceId(Int16 authenticationSourceId);

        /// <summary>
        /// Finds all  Registered Application data with specified authentication Source Id, is Active 
        /// </summary>
		/// <param name="authenticationSourceId"> Authentication Source Id</param>
		/// <param name="isActive"> Is Active</param>
		/// <returns>List of  Registered Application</returns>
		OperationResult FindByAuthenticationSourceIdAndIsActive(Int16 authenticationSourceId, Int16 isActive);

        /// <summary>
        /// Finds all  Registered Application data with specified is Active 
        /// </summary>
		/// <param name="isActive"> Is Active</param>
		/// <returns>List of  Registered Application</returns>
		OperationResult FindByIsActive(Int16 isActive);

	}
}