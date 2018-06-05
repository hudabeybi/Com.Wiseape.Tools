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
    public class AuthenticationSessionService : IAuthenticationSessionService
    {

        class Keywords
        {
            public static string AuthenticationSession = "Tools.OAuthServerManager.AuthenticationSession";
            public static string FindAuthenticationSession = "Find.Tools.OAuthServerManager.AuthenticationSession";
            public static string AddAuthenticationSession = "Add.Tools.OAuthServerManager.AuthenticationSession";
            public static string UpdateAuthenticationSession = "Update.Tools.OAuthServerManager.AuthenticationSession";
            public static string DeleteAuthenticationSession = "Delete.Tools.OAuthServerManager.AuthenticationSession";
        }

        /// <summary>
        /// Service to add AuthenticationSession data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="AuthenticationSessionForm">AuthenticationSession data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [WebInvoke(Method = "POST",
                    ResponseFormat = WebMessageFormat.Json,
                    RequestFormat = WebMessageFormat.Json,
                    UriTemplate = "authenticationsession/add")]
        public Stream AddAuthenticationSession(AuthenticationSession authenticationSessionForm)
        {
            BaseBusinessService<AuthenticationSession> businessService = (BaseBusinessService<AuthenticationSession>)BusinessFactory.Create(Keywords.AddAuthenticationSession);
            OperationResult result = businessService.Add(authenticationSessionForm);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to update AuthenticationSession data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="authenticationSessionForm">AuthenticationSession data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [WebInvoke(Method = "POST",
                    ResponseFormat = WebMessageFormat.Json,
                    RequestFormat = WebMessageFormat.Json,
                    UriTemplate = "authenticationsession/update")]
        public Stream UpdateAuthenticationSession(AuthenticationSession authenticationSessionForm)
        {
            BaseBusinessService<AuthenticationSession> businessService = (BaseBusinessService<AuthenticationSession>)BusinessFactory.Create(Keywords.UpdateAuthenticationSession);
            OperationResult result = businessService.Update(authenticationSessionForm);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to delete AuthenticationSession data from data store. 
        /// The data deleted is defined by idAuthenticationSession.
        /// This is a GET request.
        /// </summary>
        /// <param name="idAuthenticationSession">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>  
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "authenticationsession/delete/{idAuthenticationSession}")]
        public Stream DeleteAuthenticationSession(string idAuthenticationSession)
        {
            BaseBusinessService<AuthenticationSession> businessService = (BaseBusinessService<AuthenticationSession>)BusinessFactory.Create(Keywords.DeleteAuthenticationSession);
            OperationResult result = businessService.Delete(idAuthenticationSession);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to get a AuthenticationSession data from data store. 
        /// The data retrieved is defined by idAuthenticationSession.
        /// This is a GET request.
        /// </summary>
        /// <param name="idAuthenticationSession">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>    
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "authenticationsession/get/{idAuthenticationSession}")]
        public Stream GetAuthenticationSession(string idAuthenticationSession)
        {
            BaseBusinessService<AuthenticationSession> businessService = (BaseBusinessService<AuthenticationSession>)BusinessFactory.Create(Keywords.FindAuthenticationSession);
            OperationResult result = businessService.Get(idAuthenticationSession);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to get all the AuthenticationSession data from data store. 
        /// The data items retrieved are those who contain the keyword given. 
        /// This is a GET request.
        /// </summary>
        /// <param name="keyword">the keyword to search</param>
        /// <param name="page">the page of the data navigation</param>
        /// <param name="max">the maximum amount of data to retrieve</param>
        /// <return>JSON string representation of operation result</return>    
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "authenticationsession/find/{keyword}/{page}/{max}")]
        public Stream FindAuthenticationSession(string keyword, string page, string max)
        {
            BaseBusinessService<AuthenticationSession> businessService = (BaseBusinessService<AuthenticationSession>)BusinessFactory.Create(Keywords.FindAuthenticationSession);

            SelectParam selectParam = new SelectParam();
            selectParam.Keyword = keyword;
            if (keyword.ToLower() == "all")
                selectParam.Keyword = "";
            OperationResult result = businessService.FindAll(selectParam, Convert.ToInt16(page), Convert.ToInt16(max) );

            return result.ToJsonStream();
        }	
        

        /// <summary>
        /// Finds all  Authentication Session data with authentication Session String containing specified keyword
        /// </summary>
		/// <param name="authenticationSessionString"> Authentication Session String</param>
		/// <returns>List of  Authentication Session</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "authenticationsession/find-by-authentication-session-string/{authenticationSessionString}")]
        public Stream FindByAuthenticationSessionString(string authenticationSessionString)
        {
            IFindAuthenticationSessionBusinessService businessService = (IFindAuthenticationSessionBusinessService)BusinessFactory.Create(Keywords.FindAuthenticationSession);
            OperationResult result = businessService.FindByAuthenticationSessionString(Convert.ToString(authenticationSessionString));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Authentication Session's authentication Session String which has specified idAuthenticationSession
        /// </summary>
		/// <param name="idAuthenticationSession">id Authentication Session</param>
		/// <param name="authenticationSessionString">authentication Session String</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "authenticationsession/update-authentication-session-string/{idAuthenticationSession}/{authenticationSessionString}")]
        public Stream UpdateAuthenticationSessionString(string idAuthenticationSession,string authenticationSessionString)
        {
            IUpdateAuthenticationSessionBusinessService businessService = (IUpdateAuthenticationSessionBusinessService)BusinessFactory.Create(Keywords.UpdateAuthenticationSession);
            OperationResult result = businessService.UpdateAuthenticationSessionString(Convert.ToInt64(idAuthenticationSession),Convert.ToString(authenticationSessionString) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Authentication Session data with authentication Session String containing specified keyword
        /// </summary>
		/// <param name="authenticationSessionString"> Authentication Session String</param>
		/// <returns>List of  Authentication Session</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "authenticationsession/delete-by-authentication-session-string/{authenticationSessionString}")]
        public Stream DeleteByAuthenticationSessionString(string authenticationSessionString)
        {
            IDeleteAuthenticationSessionBusinessService businessService = (IDeleteAuthenticationSessionBusinessService)BusinessFactory.Create(Keywords.DeleteAuthenticationSession);
            OperationResult result = businessService.DeleteByAuthenticationSessionString(Convert.ToString(authenticationSessionString) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Authentication Session data with client I D containing specified keyword
        /// </summary>
		/// <param name="clientID"> Client I D</param>
		/// <returns>List of  Authentication Session</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "authenticationsession/find-by-client-i-d/{clientID}")]
        public Stream FindByClientID(string clientID)
        {
            IFindAuthenticationSessionBusinessService businessService = (IFindAuthenticationSessionBusinessService)BusinessFactory.Create(Keywords.FindAuthenticationSession);
            OperationResult result = businessService.FindByClientID(Convert.ToString(clientID));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Authentication Session's client I D which has specified idAuthenticationSession
        /// </summary>
		/// <param name="idAuthenticationSession">id Authentication Session</param>
		/// <param name="clientID">client I D</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "authenticationsession/update-client-i-d/{idAuthenticationSession}/{clientID}")]
        public Stream UpdateClientID(string idAuthenticationSession,string clientID)
        {
            IUpdateAuthenticationSessionBusinessService businessService = (IUpdateAuthenticationSessionBusinessService)BusinessFactory.Create(Keywords.UpdateAuthenticationSession);
            OperationResult result = businessService.UpdateClientID(Convert.ToInt64(idAuthenticationSession),Convert.ToString(clientID) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Authentication Session data with client I D containing specified keyword
        /// </summary>
		/// <param name="clientID"> Client I D</param>
		/// <returns>List of  Authentication Session</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "authenticationsession/delete-by-client-i-d/{clientID}")]
        public Stream DeleteByClientID(string clientID)
        {
            IDeleteAuthenticationSessionBusinessService businessService = (IDeleteAuthenticationSessionBusinessService)BusinessFactory.Create(Keywords.DeleteAuthenticationSession);
            OperationResult result = businessService.DeleteByClientID(Convert.ToString(clientID) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Authentication Session with SessionCreatedDate between SessionCreatedDate1 and SessionCreatedDate2
        /// </summary>
		/// <param name="sessionCreatedDate1"> Session Created Date</param>
		/// <param name="sessionCreatedDate2"> Session Created Date</param>
		/// <returns>List of  Authentication Session</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "authenticationsession/find-by-session-created-date-between/{sessionCreatedDate1}/{sessionCreatedDate2}")]
        public Stream FindBySessionCreatedDateBetween(string sessionCreatedDate1,string sessionCreatedDate2)
        {
            IFindAuthenticationSessionBusinessService businessService = (IFindAuthenticationSessionBusinessService)BusinessFactory.Create(Keywords.FindAuthenticationSession);
            OperationResult result = businessService.FindBySessionCreatedDateBetween(Convert.ToDateTime(sessionCreatedDate1),Convert.ToDateTime(sessionCreatedDate2) );
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Authentication Session's session Created Date which has specified idAuthenticationSession
        /// </summary>
		/// <param name="idAuthenticationSession">id Authentication Session</param>
		/// <param name="sessionCreatedDate">session Created Date</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "authenticationsession/update-session-created-date/{idAuthenticationSession}/{sessionCreatedDate}")]
        public Stream UpdateSessionCreatedDate(string idAuthenticationSession,string sessionCreatedDate)
        {
            IUpdateAuthenticationSessionBusinessService businessService = (IUpdateAuthenticationSessionBusinessService)BusinessFactory.Create(Keywords.UpdateAuthenticationSession);
            OperationResult result = businessService.UpdateSessionCreatedDate(Convert.ToInt64(idAuthenticationSession),Convert.ToDateTime(sessionCreatedDate) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Authentication Session data with session Created Date containing specified keyword
        /// </summary>
		/// <param name="sessionCreatedDate"> Session Created Date</param>
		/// <returns>List of  Authentication Session</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "authenticationsession/delete-by-session-created-date/{sessionCreatedDate}")]
        public Stream DeleteBySessionCreatedDate(string sessionCreatedDate)
        {
            IDeleteAuthenticationSessionBusinessService businessService = (IDeleteAuthenticationSessionBusinessService)BusinessFactory.Create(Keywords.DeleteAuthenticationSession);
            OperationResult result = businessService.DeleteBySessionCreatedDate(Convert.ToDateTime(sessionCreatedDate) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Authentication Session with SessionExpiredDate between SessionExpiredDate1 and SessionExpiredDate2
        /// </summary>
		/// <param name="sessionExpiredDate1"> Session Expired Date</param>
		/// <param name="sessionExpiredDate2"> Session Expired Date</param>
		/// <returns>List of  Authentication Session</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "authenticationsession/find-by-session-expired-date-between/{sessionExpiredDate1}/{sessionExpiredDate2}")]
        public Stream FindBySessionExpiredDateBetween(string sessionExpiredDate1,string sessionExpiredDate2)
        {
            IFindAuthenticationSessionBusinessService businessService = (IFindAuthenticationSessionBusinessService)BusinessFactory.Create(Keywords.FindAuthenticationSession);
            OperationResult result = businessService.FindBySessionExpiredDateBetween(Convert.ToDateTime(sessionExpiredDate1),Convert.ToDateTime(sessionExpiredDate2) );
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Authentication Session's session Expired Date which has specified idAuthenticationSession
        /// </summary>
		/// <param name="idAuthenticationSession">id Authentication Session</param>
		/// <param name="sessionExpiredDate">session Expired Date</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "authenticationsession/update-session-expired-date/{idAuthenticationSession}/{sessionExpiredDate}")]
        public Stream UpdateSessionExpiredDate(string idAuthenticationSession,string sessionExpiredDate)
        {
            IUpdateAuthenticationSessionBusinessService businessService = (IUpdateAuthenticationSessionBusinessService)BusinessFactory.Create(Keywords.UpdateAuthenticationSession);
            OperationResult result = businessService.UpdateSessionExpiredDate(Convert.ToInt64(idAuthenticationSession),Convert.ToDateTime(sessionExpiredDate) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Authentication Session data with session Expired Date containing specified keyword
        /// </summary>
		/// <param name="sessionExpiredDate"> Session Expired Date</param>
		/// <returns>List of  Authentication Session</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "authenticationsession/delete-by-session-expired-date/{sessionExpiredDate}")]
        public Stream DeleteBySessionExpiredDate(string sessionExpiredDate)
        {
            IDeleteAuthenticationSessionBusinessService businessService = (IDeleteAuthenticationSessionBusinessService)BusinessFactory.Create(Keywords.DeleteAuthenticationSession);
            OperationResult result = businessService.DeleteBySessionExpiredDate(Convert.ToDateTime(sessionExpiredDate) );
            return result.ToJsonStream();
        }	
		
 
	}
}