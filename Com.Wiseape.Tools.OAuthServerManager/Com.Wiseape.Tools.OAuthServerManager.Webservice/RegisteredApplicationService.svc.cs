using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Web;
using System.ServiceModel.Activation;
using Com.Wiseape.Framework;
using Com.Wiseape.Utility;
using Com.Wiseape.Factory;
using Com.Wiseape.Tools.Data.Model;
using Com.Wiseape.Tools.OAuthServerManager.Business.Contract;


namespace Com.Wiseape.Tools.OAuthServerManager.Webservice
{
	[AspNetCompatibilityRequirements(
            RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class RegisteredApplicationService : IRegisteredApplicationService
    {

        class Keywords
        {
            public static string RegisteredApplication = "Tools.OAuthServerManager.RegisteredApplication";
            public static string FindRegisteredApplication = "Find.Tools.OAuthServerManager.RegisteredApplication";
            public static string AddRegisteredApplication = "Add.Tools.OAuthServerManager.RegisteredApplication";
            public static string UpdateRegisteredApplication = "Update.Tools.OAuthServerManager.RegisteredApplication";
            public static string DeleteRegisteredApplication = "Delete.Tools.OAuthServerManager.RegisteredApplication";
        }

        /// <summary>
        /// Service to add RegisteredApplication data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="RegisteredApplicationForm">RegisteredApplication data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [WebInvoke(Method = "POST",
                    ResponseFormat = WebMessageFormat.Json,
                    RequestFormat = WebMessageFormat.Json,
                    UriTemplate = "registeredapplication/add")]
        public Stream AddRegisteredApplication(RegisteredApplication registeredApplicationForm)
        {
            BaseBusinessService<RegisteredApplication> businessService = (BaseBusinessService<RegisteredApplication>)BusinessFactory.Create(Keywords.AddRegisteredApplication);
            OperationResult result = businessService.Add(registeredApplicationForm);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to update RegisteredApplication data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="registeredApplicationForm">RegisteredApplication data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [WebInvoke(Method = "POST",
                    ResponseFormat = WebMessageFormat.Json,
                    RequestFormat = WebMessageFormat.Json,
                    UriTemplate = "registeredapplication/update")]
        public Stream UpdateRegisteredApplication(RegisteredApplication registeredApplicationForm)
        {
            BaseBusinessService<RegisteredApplication> businessService = (BaseBusinessService<RegisteredApplication>)BusinessFactory.Create(Keywords.UpdateRegisteredApplication);
            OperationResult result = businessService.Update(registeredApplicationForm);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to delete RegisteredApplication data from data store. 
        /// The data deleted is defined by idApplication.
        /// This is a GET request.
        /// </summary>
        /// <param name="idApplication">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>  
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "registeredapplication/delete/{idApplication}")]
        public Stream DeleteRegisteredApplication(string idApplication)
        {
            BaseBusinessService<RegisteredApplication> businessService = (BaseBusinessService<RegisteredApplication>)BusinessFactory.Create(Keywords.DeleteRegisteredApplication);
            OperationResult result = businessService.Delete(idApplication);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to get a RegisteredApplication data from data store. 
        /// The data retrieved is defined by idApplication.
        /// This is a GET request.
        /// </summary>
        /// <param name="idApplication">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>    
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "registeredapplication/get/{idApplication}")]
        public Stream GetRegisteredApplication(string idApplication)
        {
            BaseBusinessService<RegisteredApplication> businessService = (BaseBusinessService<RegisteredApplication>)BusinessFactory.Create(Keywords.FindRegisteredApplication);
            OperationResult result = businessService.Get(idApplication);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to get all the RegisteredApplication data from data store. 
        /// The data items retrieved are those who contain the keyword given. 
        /// This is a GET request.
        /// </summary>
        /// <param name="keyword">the keyword to search</param>
        /// <param name="page">the page of the data navigation</param>
        /// <param name="max">the maximum amount of data to retrieve</param>
        /// <return>JSON string representation of operation result</return>    
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "registeredapplication/find/{keyword}/{page}/{max}")]
        public Stream FindRegisteredApplication(string keyword, string page, string max)
        {
            BaseBusinessService<RegisteredApplication> businessService = (BaseBusinessService<RegisteredApplication>)BusinessFactory.Create(Keywords.FindRegisteredApplication);

            SelectParam selectParam = new SelectParam();
            selectParam.Keyword = keyword;
            if (keyword.ToLower() == "all")
                selectParam.Keyword = "";
            OperationResult result = businessService.FindAll(selectParam, Convert.ToInt16(page), Convert.ToInt16(max) );

            return result.ToJsonStream();
        }	
        

        /// <summary>
        /// Finds all  Registered Application data with application Name containing specified keyword
        /// </summary>
		/// <param name="applicationName"> Application Name</param>
		/// <returns>List of  Registered Application</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "registeredapplication/find-by-application-name/{applicationName}")]
        public Stream FindByApplicationName(string applicationName)
        {
            IFindRegisteredApplicationBusinessService businessService = (IFindRegisteredApplicationBusinessService)BusinessFactory.Create(Keywords.FindRegisteredApplication);
            OperationResult result = businessService.FindByApplicationName(Convert.ToString(applicationName));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Registered Application's application Name which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationName">application Name</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "registeredapplication/update-application-name/{idApplication}/{applicationName}")]
        public Stream UpdateApplicationName(string idApplication,string applicationName)
        {
            IUpdateRegisteredApplicationBusinessService businessService = (IUpdateRegisteredApplicationBusinessService)BusinessFactory.Create(Keywords.UpdateRegisteredApplication);
            OperationResult result = businessService.UpdateApplicationName(Convert.ToInt16(idApplication),Convert.ToString(applicationName) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Registered Application data with application Name containing specified keyword
        /// </summary>
		/// <param name="applicationName"> Application Name</param>
		/// <returns>List of  Registered Application</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "registeredapplication/delete-by-application-name/{applicationName}")]
        public Stream DeleteByApplicationName(string applicationName)
        {
            IDeleteRegisteredApplicationBusinessService businessService = (IDeleteRegisteredApplicationBusinessService)BusinessFactory.Create(Keywords.DeleteRegisteredApplication);
            OperationResult result = businessService.DeleteByApplicationName(Convert.ToString(applicationName) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Registered Application data with application Desc containing specified keyword
        /// </summary>
		/// <param name="applicationDesc"> Application Desc</param>
		/// <returns>List of  Registered Application</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "registeredapplication/find-by-application-desc/{applicationDesc}")]
        public Stream FindByApplicationDesc(string applicationDesc)
        {
            IFindRegisteredApplicationBusinessService businessService = (IFindRegisteredApplicationBusinessService)BusinessFactory.Create(Keywords.FindRegisteredApplication);
            OperationResult result = businessService.FindByApplicationDesc(Convert.ToString(applicationDesc));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Registered Application's application Desc which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationDesc">application Desc</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "registeredapplication/update-application-desc/{idApplication}/{applicationDesc}")]
        public Stream UpdateApplicationDesc(string idApplication,string applicationDesc)
        {
            IUpdateRegisteredApplicationBusinessService businessService = (IUpdateRegisteredApplicationBusinessService)BusinessFactory.Create(Keywords.UpdateRegisteredApplication);
            OperationResult result = businessService.UpdateApplicationDesc(Convert.ToInt16(idApplication),Convert.ToString(applicationDesc) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Registered Application data with application Desc containing specified keyword
        /// </summary>
		/// <param name="applicationDesc"> Application Desc</param>
		/// <returns>List of  Registered Application</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "registeredapplication/delete-by-application-desc/{applicationDesc}")]
        public Stream DeleteByApplicationDesc(string applicationDesc)
        {
            IDeleteRegisteredApplicationBusinessService businessService = (IDeleteRegisteredApplicationBusinessService)BusinessFactory.Create(Keywords.DeleteRegisteredApplication);
            OperationResult result = businessService.DeleteByApplicationDesc(Convert.ToString(applicationDesc) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Registered Application data with client I D containing specified keyword
        /// </summary>
		/// <param name="clientID"> Client I D</param>
		/// <returns>List of  Registered Application</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "registeredapplication/find-by-client-i-d/{clientID}")]
        public Stream FindByClientID(string clientID)
        {
            IFindRegisteredApplicationBusinessService businessService = (IFindRegisteredApplicationBusinessService)BusinessFactory.Create(Keywords.FindRegisteredApplication);
            OperationResult result = businessService.FindByClientID(Convert.ToString(clientID));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Registered Application's client I D which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="clientID">client I D</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "registeredapplication/update-client-i-d/{idApplication}/{clientID}")]
        public Stream UpdateClientID(string idApplication,string clientID)
        {
            IUpdateRegisteredApplicationBusinessService businessService = (IUpdateRegisteredApplicationBusinessService)BusinessFactory.Create(Keywords.UpdateRegisteredApplication);
            OperationResult result = businessService.UpdateClientID(Convert.ToInt16(idApplication),Convert.ToString(clientID) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Registered Application data with client I D containing specified keyword
        /// </summary>
		/// <param name="clientID"> Client I D</param>
		/// <returns>List of  Registered Application</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "registeredapplication/delete-by-client-i-d/{clientID}")]
        public Stream DeleteByClientID(string clientID)
        {
            IDeleteRegisteredApplicationBusinessService businessService = (IDeleteRegisteredApplicationBusinessService)BusinessFactory.Create(Keywords.DeleteRegisteredApplication);
            OperationResult result = businessService.DeleteByClientID(Convert.ToString(clientID) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Registered Application data with client Secret containing specified keyword
        /// </summary>
		/// <param name="clientSecret"> Client Secret</param>
		/// <returns>List of  Registered Application</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "registeredapplication/find-by-client-secret/{clientSecret}")]
        public Stream FindByClientSecret(string clientSecret)
        {
            IFindRegisteredApplicationBusinessService businessService = (IFindRegisteredApplicationBusinessService)BusinessFactory.Create(Keywords.FindRegisteredApplication);
            OperationResult result = businessService.FindByClientSecret(Convert.ToString(clientSecret));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Registered Application's client Secret which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="clientSecret">client Secret</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "registeredapplication/update-client-secret/{idApplication}/{clientSecret}")]
        public Stream UpdateClientSecret(string idApplication,string clientSecret)
        {
            IUpdateRegisteredApplicationBusinessService businessService = (IUpdateRegisteredApplicationBusinessService)BusinessFactory.Create(Keywords.UpdateRegisteredApplication);
            OperationResult result = businessService.UpdateClientSecret(Convert.ToInt16(idApplication),Convert.ToString(clientSecret) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Registered Application data with client Secret containing specified keyword
        /// </summary>
		/// <param name="clientSecret"> Client Secret</param>
		/// <returns>List of  Registered Application</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "registeredapplication/delete-by-client-secret/{clientSecret}")]
        public Stream DeleteByClientSecret(string clientSecret)
        {
            IDeleteRegisteredApplicationBusinessService businessService = (IDeleteRegisteredApplicationBusinessService)BusinessFactory.Create(Keywords.DeleteRegisteredApplication);
            OperationResult result = businessService.DeleteByClientSecret(Convert.ToString(clientSecret) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Registered Application data with authorization Token Redirect U R I containing specified keyword
        /// </summary>
		/// <param name="authorizationTokenRedirectURI"> Authorization Token Redirect U R I</param>
		/// <returns>List of  Registered Application</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "registeredapplication/find-by-authorization-token-redirect-u-r-i/{authorizationTokenRedirectURI}")]
        public Stream FindByAuthorizationTokenRedirectURI(string authorizationTokenRedirectURI)
        {
            IFindRegisteredApplicationBusinessService businessService = (IFindRegisteredApplicationBusinessService)BusinessFactory.Create(Keywords.FindRegisteredApplication);
            OperationResult result = businessService.FindByAuthorizationTokenRedirectURI(Convert.ToString(authorizationTokenRedirectURI));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Registered Application's authorization Token Redirect U R I which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="authorizationTokenRedirectURI">authorization Token Redirect U R I</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "registeredapplication/update-authorization-token-redirect-u-r-i/{idApplication}/{authorizationTokenRedirectURI}")]
        public Stream UpdateAuthorizationTokenRedirectURI(string idApplication,string authorizationTokenRedirectURI)
        {
            IUpdateRegisteredApplicationBusinessService businessService = (IUpdateRegisteredApplicationBusinessService)BusinessFactory.Create(Keywords.UpdateRegisteredApplication);
            OperationResult result = businessService.UpdateAuthorizationTokenRedirectURI(Convert.ToInt16(idApplication),Convert.ToString(authorizationTokenRedirectURI) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Registered Application data with authorization Token Redirect U R I containing specified keyword
        /// </summary>
		/// <param name="authorizationTokenRedirectURI"> Authorization Token Redirect U R I</param>
		/// <returns>List of  Registered Application</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "registeredapplication/delete-by-authorization-token-redirect-u-r-i/{authorizationTokenRedirectURI}")]
        public Stream DeleteByAuthorizationTokenRedirectURI(string authorizationTokenRedirectURI)
        {
            IDeleteRegisteredApplicationBusinessService businessService = (IDeleteRegisteredApplicationBusinessService)BusinessFactory.Create(Keywords.DeleteRegisteredApplication);
            OperationResult result = businessService.DeleteByAuthorizationTokenRedirectURI(Convert.ToString(authorizationTokenRedirectURI) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Registered Application data with access Token Redirect U R I containing specified keyword
        /// </summary>
		/// <param name="accessTokenRedirectURI"> Access Token Redirect U R I</param>
		/// <returns>List of  Registered Application</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "registeredapplication/find-by-access-token-redirect-u-r-i/{accessTokenRedirectURI}")]
        public Stream FindByAccessTokenRedirectURI(string accessTokenRedirectURI)
        {
            IFindRegisteredApplicationBusinessService businessService = (IFindRegisteredApplicationBusinessService)BusinessFactory.Create(Keywords.FindRegisteredApplication);
            OperationResult result = businessService.FindByAccessTokenRedirectURI(Convert.ToString(accessTokenRedirectURI));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Registered Application's access Token Redirect U R I which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="accessTokenRedirectURI">access Token Redirect U R I</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "registeredapplication/update-access-token-redirect-u-r-i/{idApplication}/{accessTokenRedirectURI}")]
        public Stream UpdateAccessTokenRedirectURI(string idApplication,string accessTokenRedirectURI)
        {
            IUpdateRegisteredApplicationBusinessService businessService = (IUpdateRegisteredApplicationBusinessService)BusinessFactory.Create(Keywords.UpdateRegisteredApplication);
            OperationResult result = businessService.UpdateAccessTokenRedirectURI(Convert.ToInt16(idApplication),Convert.ToString(accessTokenRedirectURI) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Registered Application data with access Token Redirect U R I containing specified keyword
        /// </summary>
		/// <param name="accessTokenRedirectURI"> Access Token Redirect U R I</param>
		/// <returns>List of  Registered Application</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "registeredapplication/delete-by-access-token-redirect-u-r-i/{accessTokenRedirectURI}")]
        public Stream DeleteByAccessTokenRedirectURI(string accessTokenRedirectURI)
        {
            IDeleteRegisteredApplicationBusinessService businessService = (IDeleteRegisteredApplicationBusinessService)BusinessFactory.Create(Keywords.DeleteRegisteredApplication);
            OperationResult result = businessService.DeleteByAccessTokenRedirectURI(Convert.ToString(accessTokenRedirectURI) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Registered Application data with authentication Source Connection String containing specified keyword
        /// </summary>
		/// <param name="authenticationSourceConnectionString"> Authentication Source Connection String</param>
		/// <returns>List of  Registered Application</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "registeredapplication/find-by-authentication-source-connection-string/{authenticationSourceConnectionString}")]
        public Stream FindByAuthenticationSourceConnectionString(string authenticationSourceConnectionString)
        {
            IFindRegisteredApplicationBusinessService businessService = (IFindRegisteredApplicationBusinessService)BusinessFactory.Create(Keywords.FindRegisteredApplication);
            OperationResult result = businessService.FindByAuthenticationSourceConnectionString(Convert.ToString(authenticationSourceConnectionString));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Registered Application's authentication Source Connection String which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="authenticationSourceConnectionString">authentication Source Connection String</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "registeredapplication/update-authentication-source-connection-string/{idApplication}/{authenticationSourceConnectionString}")]
        public Stream UpdateAuthenticationSourceConnectionString(string idApplication,string authenticationSourceConnectionString)
        {
            IUpdateRegisteredApplicationBusinessService businessService = (IUpdateRegisteredApplicationBusinessService)BusinessFactory.Create(Keywords.UpdateRegisteredApplication);
            OperationResult result = businessService.UpdateAuthenticationSourceConnectionString(Convert.ToInt16(idApplication),Convert.ToString(authenticationSourceConnectionString) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Registered Application data with authentication Source Connection String containing specified keyword
        /// </summary>
		/// <param name="authenticationSourceConnectionString"> Authentication Source Connection String</param>
		/// <returns>List of  Registered Application</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "registeredapplication/delete-by-authentication-source-connection-string/{authenticationSourceConnectionString}")]
        public Stream DeleteByAuthenticationSourceConnectionString(string authenticationSourceConnectionString)
        {
            IDeleteRegisteredApplicationBusinessService businessService = (IDeleteRegisteredApplicationBusinessService)BusinessFactory.Create(Keywords.DeleteRegisteredApplication);
            OperationResult result = businessService.DeleteByAuthenticationSourceConnectionString(Convert.ToString(authenticationSourceConnectionString) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Registered Application data with authentication Url containing specified keyword
        /// </summary>
		/// <param name="authenticationUrl"> Authentication Url</param>
		/// <returns>List of  Registered Application</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "registeredapplication/find-by-authentication-url/{authenticationUrl}")]
        public Stream FindByAuthenticationUrl(string authenticationUrl)
        {
            IFindRegisteredApplicationBusinessService businessService = (IFindRegisteredApplicationBusinessService)BusinessFactory.Create(Keywords.FindRegisteredApplication);
            OperationResult result = businessService.FindByAuthenticationUrl(Convert.ToString(authenticationUrl));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Registered Application's authentication Url which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="authenticationUrl">authentication Url</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "registeredapplication/update-authentication-url/{idApplication}/{authenticationUrl}")]
        public Stream UpdateAuthenticationUrl(string idApplication,string authenticationUrl)
        {
            IUpdateRegisteredApplicationBusinessService businessService = (IUpdateRegisteredApplicationBusinessService)BusinessFactory.Create(Keywords.UpdateRegisteredApplication);
            OperationResult result = businessService.UpdateAuthenticationUrl(Convert.ToInt16(idApplication),Convert.ToString(authenticationUrl) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Registered Application data with authentication Url containing specified keyword
        /// </summary>
		/// <param name="authenticationUrl"> Authentication Url</param>
		/// <returns>List of  Registered Application</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "registeredapplication/delete-by-authentication-url/{authenticationUrl}")]
        public Stream DeleteByAuthenticationUrl(string authenticationUrl)
        {
            IDeleteRegisteredApplicationBusinessService businessService = (IDeleteRegisteredApplicationBusinessService)BusinessFactory.Create(Keywords.DeleteRegisteredApplication);
            OperationResult result = businessService.DeleteByAuthenticationUrl(Convert.ToString(authenticationUrl) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Registered Application with CreatedDate between CreatedDate1 and CreatedDate2
        /// </summary>
		/// <param name="createdDate1"> Created Date</param>
		/// <param name="createdDate2"> Created Date</param>
		/// <returns>List of  Registered Application</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "registeredapplication/find-by-created-date-between/{createdDate1}/{createdDate2}")]
        public Stream FindByCreatedDateBetween(string createdDate1,string createdDate2)
        {
            IFindRegisteredApplicationBusinessService businessService = (IFindRegisteredApplicationBusinessService)BusinessFactory.Create(Keywords.FindRegisteredApplication);
            OperationResult result = businessService.FindByCreatedDateBetween(Convert.ToDateTime(createdDate1),Convert.ToDateTime(createdDate2) );
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Registered Application's created Date which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="createdDate">created Date</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "registeredapplication/update-created-date/{idApplication}/{createdDate}")]
        public Stream UpdateCreatedDate(string idApplication,string createdDate)
        {
            IUpdateRegisteredApplicationBusinessService businessService = (IUpdateRegisteredApplicationBusinessService)BusinessFactory.Create(Keywords.UpdateRegisteredApplication);
            OperationResult result = businessService.UpdateCreatedDate(Convert.ToInt16(idApplication),Convert.ToDateTime(createdDate) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Registered Application data with created Date containing specified keyword
        /// </summary>
		/// <param name="createdDate"> Created Date</param>
		/// <returns>List of  Registered Application</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "registeredapplication/delete-by-created-date/{createdDate}")]
        public Stream DeleteByCreatedDate(string createdDate)
        {
            IDeleteRegisteredApplicationBusinessService businessService = (IDeleteRegisteredApplicationBusinessService)BusinessFactory.Create(Keywords.DeleteRegisteredApplication);
            OperationResult result = businessService.DeleteByCreatedDate(Convert.ToDateTime(createdDate) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Registered Application data with specified authentication Source Id 
        /// </summary>
		/// <param name="authenticationSourceId"> Authentication Source Id</param>
		/// <returns>List of  Registered Application</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "registeredapplication/find-by-authentication-source-id/{authenticationSourceId}")]
        public Stream FindByAuthenticationSourceId(string authenticationSourceId)
        {
            IFindRegisteredApplicationBusinessService businessService = (IFindRegisteredApplicationBusinessService)BusinessFactory.Create(Keywords.FindRegisteredApplication);
            OperationResult result = businessService.FindByAuthenticationSourceId(Convert.ToInt16(authenticationSourceId) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Updates  Registered Application's authentication Source Id which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="authenticationSourceId">authentication Source Id</param>
		/// <returns>List of  Registered Application</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "registeredapplication/update-authentication-source-id/{idApplication}/{authenticationSourceId}")]
        public Stream UpdateAuthenticationSourceId(string idApplication,string authenticationSourceId)
        {
            IUpdateRegisteredApplicationBusinessService businessService = (IUpdateRegisteredApplicationBusinessService)BusinessFactory.Create(Keywords.UpdateRegisteredApplication);
            OperationResult result = businessService.UpdateAuthenticationSourceId(Convert.ToInt16(idApplication),Convert.ToInt16(authenticationSourceId) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Registered Application data with specified authentication Source Id 
        /// </summary>
		/// <param name="authenticationSourceId"> Authentication Source Id</param>
		/// <returns>List of  Registered Application</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "registeredapplication/delete-by-authentication-source-id/{authenticationSourceId}")]
        public Stream DeleteByAuthenticationSourceId(string authenticationSourceId)
        {
            IDeleteRegisteredApplicationBusinessService businessService = (IDeleteRegisteredApplicationBusinessService)BusinessFactory.Create(Keywords.DeleteRegisteredApplication);
            OperationResult result = businessService.DeleteByAuthenticationSourceId(Convert.ToInt16(authenticationSourceId) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Registered Application data with specified authentication Source Id, is Active 
        /// </summary>
		/// <param name="authenticationSourceId"> Authentication Source Id</param>
		/// <param name="isActive"> Is Active</param>
		/// <returns>List of  Registered Application</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "registeredapplication/find-by-authentication-source-id-and-is-active/{authenticationSourceId}/{isActive}")]
        public Stream FindByAuthenticationSourceIdAndIsActive(string authenticationSourceId,string isActive)
        {
            IFindRegisteredApplicationBusinessService businessService = (IFindRegisteredApplicationBusinessService)BusinessFactory.Create(Keywords.FindRegisteredApplication);
            OperationResult result = businessService.FindByAuthenticationSourceIdAndIsActive(Convert.ToInt16(authenticationSourceId),Convert.ToInt16(isActive) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Updates  Registered Application's authentication Source Id, is Active which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="authenticationSourceId">authentication Source Id</param>
		/// <param name="isActive">is Active</param>
		/// <returns>List of  Registered Application</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "registeredapplication/update-authentication-source-id-and-is-active/{idApplication}/{authenticationSourceId}/{isActive}")]
        public Stream UpdateAuthenticationSourceIdAndIsActive(string idApplication,string authenticationSourceId,string isActive)
        {
            IUpdateRegisteredApplicationBusinessService businessService = (IUpdateRegisteredApplicationBusinessService)BusinessFactory.Create(Keywords.UpdateRegisteredApplication);
            OperationResult result = businessService.UpdateAuthenticationSourceIdAndIsActive(Convert.ToInt16(idApplication),Convert.ToInt16(authenticationSourceId),Convert.ToInt16(isActive) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Registered Application data with specified authentication Source Id, is Active 
        /// </summary>
		/// <param name="authenticationSourceId"> Authentication Source Id</param>
		/// <param name="isActive"> Is Active</param>
		/// <returns>List of  Registered Application</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "registeredapplication/delete-by-authentication-source-id-and-is-active/{authenticationSourceId}/{isActive}")]
        public Stream DeleteByAuthenticationSourceIdAndIsActive(string authenticationSourceId,string isActive)
        {
            IDeleteRegisteredApplicationBusinessService businessService = (IDeleteRegisteredApplicationBusinessService)BusinessFactory.Create(Keywords.DeleteRegisteredApplication);
            OperationResult result = businessService.DeleteByAuthenticationSourceIdAndIsActive(Convert.ToInt16(authenticationSourceId),Convert.ToInt16(isActive) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Registered Application data with specified is Active 
        /// </summary>
		/// <param name="isActive"> Is Active</param>
		/// <returns>List of  Registered Application</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "registeredapplication/find-by-is-active/{isActive}")]
        public Stream FindByIsActive(string isActive)
        {
            IFindRegisteredApplicationBusinessService businessService = (IFindRegisteredApplicationBusinessService)BusinessFactory.Create(Keywords.FindRegisteredApplication);
            OperationResult result = businessService.FindByIsActive(Convert.ToInt16(isActive) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Updates  Registered Application's is Active which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="isActive">is Active</param>
		/// <returns>List of  Registered Application</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "registeredapplication/update-is-active/{idApplication}/{isActive}")]
        public Stream UpdateIsActive(string idApplication,string isActive)
        {
            IUpdateRegisteredApplicationBusinessService businessService = (IUpdateRegisteredApplicationBusinessService)BusinessFactory.Create(Keywords.UpdateRegisteredApplication);
            OperationResult result = businessService.UpdateIsActive(Convert.ToInt16(idApplication),Convert.ToInt16(isActive) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Registered Application data with specified is Active 
        /// </summary>
		/// <param name="isActive"> Is Active</param>
		/// <returns>List of  Registered Application</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "registeredapplication/delete-by-is-active/{isActive}")]
        public Stream DeleteByIsActive(string isActive)
        {
            IDeleteRegisteredApplicationBusinessService businessService = (IDeleteRegisteredApplicationBusinessService)BusinessFactory.Create(Keywords.DeleteRegisteredApplication);
            OperationResult result = businessService.DeleteByIsActive(Convert.ToInt16(isActive) );
            return result.ToJsonStream();
        }	
		
 
	}
}