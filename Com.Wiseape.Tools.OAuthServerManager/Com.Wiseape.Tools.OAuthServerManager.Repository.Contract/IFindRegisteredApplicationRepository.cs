using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Tools.Data.Model;



namespace Com.Wiseape.Tools.OAuthServerManager.Repository.Contract
{
    public interface IFindRegisteredApplicationRepository
    {

        /// <summary>
        /// Finds all  Registered Application data with application Name containing specified keyword
        /// </summary>
		/// <param name="applicationName"> Application Name</param>
		/// <returns>List of  Registered Application</returns>
		List<RegisteredApplication> FindByApplicationName(string applicationName);

        /// <summary>
        /// Finds all  Registered Application data with application Desc containing specified keyword
        /// </summary>
		/// <param name="applicationDesc"> Application Desc</param>
		/// <returns>List of  Registered Application</returns>
		List<RegisteredApplication> FindByApplicationDesc(string applicationDesc);

        /// <summary>
        /// Finds all  Registered Application data with client I D containing specified keyword
        /// </summary>
		/// <param name="clientID"> Client I D</param>
		/// <returns>List of  Registered Application</returns>
		List<RegisteredApplication> FindByClientID(string clientID);

        /// <summary>
        /// Finds all  Registered Application data with client Secret containing specified keyword
        /// </summary>
		/// <param name="clientSecret"> Client Secret</param>
		/// <returns>List of  Registered Application</returns>
		List<RegisteredApplication> FindByClientSecret(string clientSecret);

        /// <summary>
        /// Finds all  Registered Application data with authorization Token Redirect U R I containing specified keyword
        /// </summary>
		/// <param name="authorizationTokenRedirectURI"> Authorization Token Redirect U R I</param>
		/// <returns>List of  Registered Application</returns>
		List<RegisteredApplication> FindByAuthorizationTokenRedirectURI(string authorizationTokenRedirectURI);

        /// <summary>
        /// Finds all  Registered Application data with access Token Redirect U R I containing specified keyword
        /// </summary>
		/// <param name="accessTokenRedirectURI"> Access Token Redirect U R I</param>
		/// <returns>List of  Registered Application</returns>
		List<RegisteredApplication> FindByAccessTokenRedirectURI(string accessTokenRedirectURI);

        /// <summary>
        /// Finds all  Registered Application data with authentication Source Connection String containing specified keyword
        /// </summary>
		/// <param name="authenticationSourceConnectionString"> Authentication Source Connection String</param>
		/// <returns>List of  Registered Application</returns>
		List<RegisteredApplication> FindByAuthenticationSourceConnectionString(string authenticationSourceConnectionString);

        /// <summary>
        /// Finds all  Registered Application data with authentication Url containing specified keyword
        /// </summary>
		/// <param name="authenticationUrl"> Authentication Url</param>
		/// <returns>List of  Registered Application</returns>
		List<RegisteredApplication> FindByAuthenticationUrl(string authenticationUrl);

        /// <summary>
        /// Finds all  Registered Application data with created Date1, created Date2 containing specified keyword
        /// </summary>
		/// <param name="createdDate1"> Created Date</param>
		/// <param name="createdDate2"> Created Date</param>
		/// <returns>List of  Registered Application</returns>
		List<RegisteredApplication> FindByCreatedDateBetween(DateTime createdDate1, DateTime createdDate2);

        /// <summary>
        /// Finds all  Registered Application data with authentication Source Id containing specified keyword
        /// </summary>
		/// <param name="authenticationSourceId"> Authentication Source Id</param>
		/// <returns>List of  Registered Application</returns>
		List<RegisteredApplication> FindByAuthenticationSourceId(Int16 authenticationSourceId);

        /// <summary>
        /// Finds all  Registered Application data with authentication Source Id, is Active containing specified keyword
        /// </summary>
		/// <param name="authenticationSourceId"> Authentication Source Id</param>
		/// <param name="isActive"> Is Active</param>
		/// <returns>List of  Registered Application</returns>
		List<RegisteredApplication> FindByAuthenticationSourceIdAndIsActive(Int16 authenticationSourceId, Int16 isActive);

        /// <summary>
        /// Finds all  Registered Application data with is Active containing specified keyword
        /// </summary>
		/// <param name="isActive"> Is Active</param>
		/// <returns>List of  Registered Application</returns>
		List<RegisteredApplication> FindByIsActive(Int16 isActive);

    }
}

