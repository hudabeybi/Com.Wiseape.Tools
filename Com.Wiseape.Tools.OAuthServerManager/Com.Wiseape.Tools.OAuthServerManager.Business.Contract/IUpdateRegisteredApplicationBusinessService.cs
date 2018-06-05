using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Utility;
using Com.Wiseape.Tools.Data.Model;


namespace Com.Wiseape.Tools.OAuthServerManager.Business.Contract
{
    public interface IUpdateRegisteredApplicationBusinessService
    {

        /// <summary>
        /// Updates  Registered Application's application Name which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationName">application Name</param>
		/// <returns>List of  Registered Application</returns>
		OperationResult UpdateApplicationName(Int16 idApplication, string applicationName);

        /// <summary>
        /// Updates  Registered Application's application Desc which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationDesc">application Desc</param>
		/// <returns>List of  Registered Application</returns>
		OperationResult UpdateApplicationDesc(Int16 idApplication, string applicationDesc);

        /// <summary>
        /// Updates  Registered Application's client I D which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="clientID">client I D</param>
		/// <returns>List of  Registered Application</returns>
		OperationResult UpdateClientID(Int16 idApplication, string clientID);

        /// <summary>
        /// Updates  Registered Application's client Secret which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="clientSecret">client Secret</param>
		/// <returns>List of  Registered Application</returns>
		OperationResult UpdateClientSecret(Int16 idApplication, string clientSecret);

        /// <summary>
        /// Updates  Registered Application's authorization Token Redirect U R I which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="authorizationTokenRedirectURI">authorization Token Redirect U R I</param>
		/// <returns>List of  Registered Application</returns>
		OperationResult UpdateAuthorizationTokenRedirectURI(Int16 idApplication, string authorizationTokenRedirectURI);

        /// <summary>
        /// Updates  Registered Application's access Token Redirect U R I which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="accessTokenRedirectURI">access Token Redirect U R I</param>
		/// <returns>List of  Registered Application</returns>
		OperationResult UpdateAccessTokenRedirectURI(Int16 idApplication, string accessTokenRedirectURI);

        /// <summary>
        /// Updates  Registered Application's authentication Source Connection String which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="authenticationSourceConnectionString">authentication Source Connection String</param>
		/// <returns>List of  Registered Application</returns>
		OperationResult UpdateAuthenticationSourceConnectionString(Int16 idApplication, string authenticationSourceConnectionString);

        /// <summary>
        /// Updates  Registered Application's authentication Url which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="authenticationUrl">authentication Url</param>
		/// <returns>List of  Registered Application</returns>
		OperationResult UpdateAuthenticationUrl(Int16 idApplication, string authenticationUrl);

        /// <summary>
        /// Updates  Registered Application's created Date which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="createdDate">created Date</param>
		/// <returns>List of  Registered Application</returns>
		OperationResult UpdateCreatedDate(Int16 idApplication, DateTime createdDate);

        /// <summary>
        /// Updates  Registered Application's authentication Source Id which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="authenticationSourceId">authentication Source Id</param>
		/// <returns>List of  Registered Application</returns>
		OperationResult UpdateAuthenticationSourceId(Int16 idApplication, Int16 authenticationSourceId);

        /// <summary>
        /// Updates  Registered Application's authentication Source Id, is Active which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="authenticationSourceId">authentication Source Id</param>
		/// <param name="isActive">is Active</param>
		/// <returns>List of  Registered Application</returns>
		OperationResult UpdateAuthenticationSourceIdAndIsActive(Int16 idApplication, Int16 authenticationSourceId, Int16 isActive);

        /// <summary>
        /// Updates  Registered Application's is Active which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="isActive">is Active</param>
		/// <returns>List of  Registered Application</returns>
		OperationResult UpdateIsActive(Int16 idApplication, Int16 isActive);

	}
}