using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Tools.Data.Model;
using Com.Wiseape.Tools.OAuthServerManager.Business.Contract;

using System.ServiceModel;

namespace Com.Wiseape.Tools.OAuthServerManager.Webservice
{
    /// <summary>
    /// Interface for RegisteredApplication Service
    /// </summary>
    [ServiceContract]
    public interface IRegisteredApplicationService
    {
    
        /// <summary>
        /// Service to add RegisteredApplication data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="RegisteredApplicationForm">RegisteredApplication data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [OperationContract]
        Stream AddRegisteredApplication(RegisteredApplication registeredApplicationForm);

        /// <summary>
        /// Service to update RegisteredApplication data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="registeredApplicationForm">RegisteredApplication data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [OperationContract]
        Stream UpdateRegisteredApplication(RegisteredApplication registeredApplicationForm);

        /// <summary>
        /// Service to delete RegisteredApplication data from data store. 
        /// The data deleted is defined by idApplication.
        /// This is a GET request.
        /// </summary>
        /// <param name="idApplication">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>  
        [OperationContract]
        Stream DeleteRegisteredApplication(string idApplication);

        /// <summary>
        /// Service to get a RegisteredApplication data from data store. 
        /// The data retrieved is defined by idApplication.
        /// This is a GET request.
        /// </summary>
        /// <param name="idApplication">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>    
        [OperationContract]
       	Stream GetRegisteredApplication(string idApplication);

        /// <summary>
        /// Service to get all the RegisteredApplication data from data store. 
        /// The data items retrieved are those who contain the keyword given. 
        /// This is a GET request.
        /// </summary>
        /// <param name="keyword">the keyword to search</param>
        /// <param name="page">the page of the data navigation</param>
        /// <param name="max">the maximum amount of data to retrieve</param>
        /// <return>JSON string representation of operation result</return>    
		[OperationContract]
        Stream FindRegisteredApplication(string keyword, string page, string max);	
        

        /// <summary>
        /// Finds all  Registered Application data with application Name containing specified keyword
        /// </summary>
		/// <param name="applicationName"> Application Name</param>
		/// <returns>List of  Registered Application</returns>
		[OperationContract]
		Stream FindByApplicationName(string applicationName);

        /// <summary>
        /// Updates  Registered Application's application Name which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationName">application Name</param>
		/// <returns>List of  Registered Application</returns>
		[OperationContract]
		Stream UpdateApplicationName(string idApplication,string applicationName);

        /// <summary>
        /// Delete all  Registered Application data with application Name containing specified keyword
        /// </summary>
		/// <param name="applicationName"> Application Name</param>
		/// <returns>List of  Registered Application</returns>
		[OperationContract]
		Stream DeleteByApplicationName(string applicationName);

        /// <summary>
        /// Finds all  Registered Application data with application Desc containing specified keyword
        /// </summary>
		/// <param name="applicationDesc"> Application Desc</param>
		/// <returns>List of  Registered Application</returns>
		[OperationContract]
		Stream FindByApplicationDesc(string applicationDesc);

        /// <summary>
        /// Updates  Registered Application's application Desc which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationDesc">application Desc</param>
		/// <returns>List of  Registered Application</returns>
		[OperationContract]
		Stream UpdateApplicationDesc(string idApplication,string applicationDesc);

        /// <summary>
        /// Delete all  Registered Application data with application Desc containing specified keyword
        /// </summary>
		/// <param name="applicationDesc"> Application Desc</param>
		/// <returns>List of  Registered Application</returns>
		[OperationContract]
		Stream DeleteByApplicationDesc(string applicationDesc);

        /// <summary>
        /// Finds all  Registered Application data with client I D containing specified keyword
        /// </summary>
		/// <param name="clientID"> Client I D</param>
		/// <returns>List of  Registered Application</returns>
		[OperationContract]
		Stream FindByClientID(string clientID);

        /// <summary>
        /// Updates  Registered Application's client I D which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="clientID">client I D</param>
		/// <returns>List of  Registered Application</returns>
		[OperationContract]
		Stream UpdateClientID(string idApplication,string clientID);

        /// <summary>
        /// Delete all  Registered Application data with client I D containing specified keyword
        /// </summary>
		/// <param name="clientID"> Client I D</param>
		/// <returns>List of  Registered Application</returns>
		[OperationContract]
		Stream DeleteByClientID(string clientID);

        /// <summary>
        /// Finds all  Registered Application data with client Secret containing specified keyword
        /// </summary>
		/// <param name="clientSecret"> Client Secret</param>
		/// <returns>List of  Registered Application</returns>
		[OperationContract]
		Stream FindByClientSecret(string clientSecret);

        /// <summary>
        /// Updates  Registered Application's client Secret which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="clientSecret">client Secret</param>
		/// <returns>List of  Registered Application</returns>
		[OperationContract]
		Stream UpdateClientSecret(string idApplication,string clientSecret);

        /// <summary>
        /// Delete all  Registered Application data with client Secret containing specified keyword
        /// </summary>
		/// <param name="clientSecret"> Client Secret</param>
		/// <returns>List of  Registered Application</returns>
		[OperationContract]
		Stream DeleteByClientSecret(string clientSecret);

        /// <summary>
        /// Finds all  Registered Application data with authorization Token Redirect U R I containing specified keyword
        /// </summary>
		/// <param name="authorizationTokenRedirectURI"> Authorization Token Redirect U R I</param>
		/// <returns>List of  Registered Application</returns>
		[OperationContract]
		Stream FindByAuthorizationTokenRedirectURI(string authorizationTokenRedirectURI);

        /// <summary>
        /// Updates  Registered Application's authorization Token Redirect U R I which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="authorizationTokenRedirectURI">authorization Token Redirect U R I</param>
		/// <returns>List of  Registered Application</returns>
		[OperationContract]
		Stream UpdateAuthorizationTokenRedirectURI(string idApplication,string authorizationTokenRedirectURI);

        /// <summary>
        /// Delete all  Registered Application data with authorization Token Redirect U R I containing specified keyword
        /// </summary>
		/// <param name="authorizationTokenRedirectURI"> Authorization Token Redirect U R I</param>
		/// <returns>List of  Registered Application</returns>
		[OperationContract]
		Stream DeleteByAuthorizationTokenRedirectURI(string authorizationTokenRedirectURI);

        /// <summary>
        /// Finds all  Registered Application data with access Token Redirect U R I containing specified keyword
        /// </summary>
		/// <param name="accessTokenRedirectURI"> Access Token Redirect U R I</param>
		/// <returns>List of  Registered Application</returns>
		[OperationContract]
		Stream FindByAccessTokenRedirectURI(string accessTokenRedirectURI);

        /// <summary>
        /// Updates  Registered Application's access Token Redirect U R I which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="accessTokenRedirectURI">access Token Redirect U R I</param>
		/// <returns>List of  Registered Application</returns>
		[OperationContract]
		Stream UpdateAccessTokenRedirectURI(string idApplication,string accessTokenRedirectURI);

        /// <summary>
        /// Delete all  Registered Application data with access Token Redirect U R I containing specified keyword
        /// </summary>
		/// <param name="accessTokenRedirectURI"> Access Token Redirect U R I</param>
		/// <returns>List of  Registered Application</returns>
		[OperationContract]
		Stream DeleteByAccessTokenRedirectURI(string accessTokenRedirectURI);

        /// <summary>
        /// Finds all  Registered Application data with authentication Source Connection String containing specified keyword
        /// </summary>
		/// <param name="authenticationSourceConnectionString"> Authentication Source Connection String</param>
		/// <returns>List of  Registered Application</returns>
		[OperationContract]
		Stream FindByAuthenticationSourceConnectionString(string authenticationSourceConnectionString);

        /// <summary>
        /// Updates  Registered Application's authentication Source Connection String which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="authenticationSourceConnectionString">authentication Source Connection String</param>
		/// <returns>List of  Registered Application</returns>
		[OperationContract]
		Stream UpdateAuthenticationSourceConnectionString(string idApplication,string authenticationSourceConnectionString);

        /// <summary>
        /// Delete all  Registered Application data with authentication Source Connection String containing specified keyword
        /// </summary>
		/// <param name="authenticationSourceConnectionString"> Authentication Source Connection String</param>
		/// <returns>List of  Registered Application</returns>
		[OperationContract]
		Stream DeleteByAuthenticationSourceConnectionString(string authenticationSourceConnectionString);

        /// <summary>
        /// Finds all  Registered Application data with authentication Url containing specified keyword
        /// </summary>
		/// <param name="authenticationUrl"> Authentication Url</param>
		/// <returns>List of  Registered Application</returns>
		[OperationContract]
		Stream FindByAuthenticationUrl(string authenticationUrl);

        /// <summary>
        /// Updates  Registered Application's authentication Url which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="authenticationUrl">authentication Url</param>
		/// <returns>List of  Registered Application</returns>
		[OperationContract]
		Stream UpdateAuthenticationUrl(string idApplication,string authenticationUrl);

        /// <summary>
        /// Delete all  Registered Application data with authentication Url containing specified keyword
        /// </summary>
		/// <param name="authenticationUrl"> Authentication Url</param>
		/// <returns>List of  Registered Application</returns>
		[OperationContract]
		Stream DeleteByAuthenticationUrl(string authenticationUrl);

        /// <summary>
        /// Finds all  Registered Application with CreatedDate between CreatedDate1 and CreatedDate2
        /// </summary>
		/// <param name="createdDate1"> Created Date</param>
		/// <param name="createdDate2"> Created Date</param>
		/// <returns>List of  Registered Application</returns>
		[OperationContract]
		Stream FindByCreatedDateBetween(string createdDate1,string createdDate2);

        /// <summary>
        /// Updates  Registered Application's created Date which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="createdDate">created Date</param>
		/// <returns>List of  Registered Application</returns>
		[OperationContract]
		Stream UpdateCreatedDate(string idApplication,string createdDate);

        /// <summary>
        /// Delete all  Registered Application data with created Date containing specified keyword
        /// </summary>
		/// <param name="createdDate"> Created Date</param>
		/// <returns>List of  Registered Application</returns>
		[OperationContract]
		Stream DeleteByCreatedDate(string createdDate);

        /// <summary>
        /// Finds all  Registered Application data with specified authentication Source Id 
        /// </summary>
		/// <param name="authenticationSourceId"> Authentication Source Id</param>
		/// <returns>List of  Registered Application</returns>
		[OperationContract]
		Stream FindByAuthenticationSourceId(string authenticationSourceId);

        /// <summary>
        /// Updates  Registered Application's authentication Source Id which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="authenticationSourceId">authentication Source Id</param>
		/// <returns>List of  Registered Application</returns>
		[OperationContract]
		Stream UpdateAuthenticationSourceId(string idApplication,string authenticationSourceId);

        /// <summary>
        /// Delete all  Registered Application data with specified authentication Source Id 
        /// </summary>
		/// <param name="authenticationSourceId"> Authentication Source Id</param>
		/// <returns>List of  Registered Application</returns>
		[OperationContract]
		Stream DeleteByAuthenticationSourceId(string authenticationSourceId);

        /// <summary>
        /// Finds all  Registered Application data with specified authentication Source Id, is Active 
        /// </summary>
		/// <param name="authenticationSourceId"> Authentication Source Id</param>
		/// <param name="isActive"> Is Active</param>
		/// <returns>List of  Registered Application</returns>
		[OperationContract]
		Stream FindByAuthenticationSourceIdAndIsActive(string authenticationSourceId,string isActive);

        /// <summary>
        /// Updates  Registered Application's authentication Source Id, is Active which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="authenticationSourceId">authentication Source Id</param>
		/// <param name="isActive">is Active</param>
		/// <returns>List of  Registered Application</returns>
		[OperationContract]
		Stream UpdateAuthenticationSourceIdAndIsActive(string idApplication,string authenticationSourceId,string isActive);

        /// <summary>
        /// Delete all  Registered Application data with specified authentication Source Id, is Active 
        /// </summary>
		/// <param name="authenticationSourceId"> Authentication Source Id</param>
		/// <param name="isActive"> Is Active</param>
		/// <returns>List of  Registered Application</returns>
		[OperationContract]
		Stream DeleteByAuthenticationSourceIdAndIsActive(string authenticationSourceId,string isActive);

        /// <summary>
        /// Finds all  Registered Application data with specified is Active 
        /// </summary>
		/// <param name="isActive"> Is Active</param>
		/// <returns>List of  Registered Application</returns>
		[OperationContract]
		Stream FindByIsActive(string isActive);

        /// <summary>
        /// Updates  Registered Application's is Active which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="isActive">is Active</param>
		/// <returns>List of  Registered Application</returns>
		[OperationContract]
		Stream UpdateIsActive(string idApplication,string isActive);

        /// <summary>
        /// Delete all  Registered Application data with specified is Active 
        /// </summary>
		/// <param name="isActive"> Is Active</param>
		/// <returns>List of  Registered Application</returns>
		[OperationContract]
		Stream DeleteByIsActive(string isActive);
    
    }
}