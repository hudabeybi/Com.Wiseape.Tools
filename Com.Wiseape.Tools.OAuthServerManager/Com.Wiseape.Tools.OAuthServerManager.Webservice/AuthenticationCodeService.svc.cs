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
    public class AuthenticationCodeService : IAuthenticationCodeService
    {

        class Keywords
        {
            public static string AuthenticationCode = "Tools.OAuthServerManager.AuthenticationCode";
            public static string FindAuthenticationCode = "Find.Tools.OAuthServerManager.AuthenticationCode";
            public static string AddAuthenticationCode = "Add.Tools.OAuthServerManager.AuthenticationCode";
            public static string UpdateAuthenticationCode = "Update.Tools.OAuthServerManager.AuthenticationCode";
            public static string DeleteAuthenticationCode = "Delete.Tools.OAuthServerManager.AuthenticationCode";
        }

        /// <summary>
        /// Service to add AuthenticationCode data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="AuthenticationCodeForm">AuthenticationCode data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [WebInvoke(Method = "POST",
                    ResponseFormat = WebMessageFormat.Json,
                    RequestFormat = WebMessageFormat.Json,
                    UriTemplate = "authenticationcode/add")]
        public Stream AddAuthenticationCode(AuthenticationCode authenticationCodeForm)
        {
            BaseBusinessService<AuthenticationCode> businessService = (BaseBusinessService<AuthenticationCode>)BusinessFactory.Create(Keywords.AddAuthenticationCode);
            OperationResult result = businessService.Add(authenticationCodeForm);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to update AuthenticationCode data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="authenticationCodeForm">AuthenticationCode data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [WebInvoke(Method = "POST",
                    ResponseFormat = WebMessageFormat.Json,
                    RequestFormat = WebMessageFormat.Json,
                    UriTemplate = "authenticationcode/update")]
        public Stream UpdateAuthenticationCode(AuthenticationCode authenticationCodeForm)
        {
            BaseBusinessService<AuthenticationCode> businessService = (BaseBusinessService<AuthenticationCode>)BusinessFactory.Create(Keywords.UpdateAuthenticationCode);
            OperationResult result = businessService.Update(authenticationCodeForm);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to delete AuthenticationCode data from data store. 
        /// The data deleted is defined by idAuthenticationCode.
        /// This is a GET request.
        /// </summary>
        /// <param name="idAuthenticationCode">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>  
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "authenticationcode/delete/{idAuthenticationCode}")]
        public Stream DeleteAuthenticationCode(string idAuthenticationCode)
        {
            BaseBusinessService<AuthenticationCode> businessService = (BaseBusinessService<AuthenticationCode>)BusinessFactory.Create(Keywords.DeleteAuthenticationCode);
            OperationResult result = businessService.Delete(idAuthenticationCode);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to get a AuthenticationCode data from data store. 
        /// The data retrieved is defined by idAuthenticationCode.
        /// This is a GET request.
        /// </summary>
        /// <param name="idAuthenticationCode">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>    
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "authenticationcode/get/{idAuthenticationCode}")]
        public Stream GetAuthenticationCode(string idAuthenticationCode)
        {
            BaseBusinessService<AuthenticationCode> businessService = (BaseBusinessService<AuthenticationCode>)BusinessFactory.Create(Keywords.FindAuthenticationCode);
            OperationResult result = businessService.Get(idAuthenticationCode);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to get all the AuthenticationCode data from data store. 
        /// The data items retrieved are those who contain the keyword given. 
        /// This is a GET request.
        /// </summary>
        /// <param name="keyword">the keyword to search</param>
        /// <param name="page">the page of the data navigation</param>
        /// <param name="max">the maximum amount of data to retrieve</param>
        /// <return>JSON string representation of operation result</return>    
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "authenticationcode/find/{keyword}/{page}/{max}")]
        public Stream FindAuthenticationCode(string keyword, string page, string max)
        {
            BaseBusinessService<AuthenticationCode> businessService = (BaseBusinessService<AuthenticationCode>)BusinessFactory.Create(Keywords.FindAuthenticationCode);

            SelectParam selectParam = new SelectParam();
            selectParam.Keyword = keyword;
            if (keyword.ToLower() == "all")
                selectParam.Keyword = "";
            OperationResult result = businessService.FindAll(selectParam, Convert.ToInt16(page), Convert.ToInt16(max) );

            return result.ToJsonStream();
        }	
        

        /// <summary>
        /// Finds all  Authentication Code data with authentication Code String containing specified keyword
        /// </summary>
		/// <param name="authenticationCodeString"> Authentication Code String</param>
		/// <returns>List of  Authentication Code</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "authenticationcode/find-by-authentication-code-string/{authenticationCodeString}")]
        public Stream FindByAuthenticationCodeString(string authenticationCodeString)
        {
            IFindAuthenticationCodeBusinessService businessService = (IFindAuthenticationCodeBusinessService)BusinessFactory.Create(Keywords.FindAuthenticationCode);
            OperationResult result = businessService.FindByAuthenticationCodeString(Convert.ToString(authenticationCodeString));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Authentication Code's authentication Code String which has specified idAuthenticationCode
        /// </summary>
		/// <param name="idAuthenticationCode">id Authentication Code</param>
		/// <param name="authenticationCodeString">authentication Code String</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "authenticationcode/update-authentication-code-string/{idAuthenticationCode}/{authenticationCodeString}")]
        public Stream UpdateAuthenticationCodeString(string idAuthenticationCode,string authenticationCodeString)
        {
            IUpdateAuthenticationCodeBusinessService businessService = (IUpdateAuthenticationCodeBusinessService)BusinessFactory.Create(Keywords.UpdateAuthenticationCode);
            OperationResult result = businessService.UpdateAuthenticationCodeString(Convert.ToInt64(idAuthenticationCode),Convert.ToString(authenticationCodeString) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Authentication Code data with authentication Code String containing specified keyword
        /// </summary>
		/// <param name="authenticationCodeString"> Authentication Code String</param>
		/// <returns>List of  Authentication Code</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "authenticationcode/delete-by-authentication-code-string/{authenticationCodeString}")]
        public Stream DeleteByAuthenticationCodeString(string authenticationCodeString)
        {
            IDeleteAuthenticationCodeBusinessService businessService = (IDeleteAuthenticationCodeBusinessService)BusinessFactory.Create(Keywords.DeleteAuthenticationCode);
            OperationResult result = businessService.DeleteByAuthenticationCodeString(Convert.ToString(authenticationCodeString) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Authentication Code data with client I D containing specified keyword
        /// </summary>
		/// <param name="clientID"> Client I D</param>
		/// <returns>List of  Authentication Code</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "authenticationcode/find-by-client-i-d/{clientID}")]
        public Stream FindByClientID(string clientID)
        {
            IFindAuthenticationCodeBusinessService businessService = (IFindAuthenticationCodeBusinessService)BusinessFactory.Create(Keywords.FindAuthenticationCode);
            OperationResult result = businessService.FindByClientID(Convert.ToString(clientID));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Authentication Code's client I D which has specified idAuthenticationCode
        /// </summary>
		/// <param name="idAuthenticationCode">id Authentication Code</param>
		/// <param name="clientID">client I D</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "authenticationcode/update-client-i-d/{idAuthenticationCode}/{clientID}")]
        public Stream UpdateClientID(string idAuthenticationCode,string clientID)
        {
            IUpdateAuthenticationCodeBusinessService businessService = (IUpdateAuthenticationCodeBusinessService)BusinessFactory.Create(Keywords.UpdateAuthenticationCode);
            OperationResult result = businessService.UpdateClientID(Convert.ToInt64(idAuthenticationCode),Convert.ToString(clientID) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Authentication Code data with client I D containing specified keyword
        /// </summary>
		/// <param name="clientID"> Client I D</param>
		/// <returns>List of  Authentication Code</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "authenticationcode/delete-by-client-i-d/{clientID}")]
        public Stream DeleteByClientID(string clientID)
        {
            IDeleteAuthenticationCodeBusinessService businessService = (IDeleteAuthenticationCodeBusinessService)BusinessFactory.Create(Keywords.DeleteAuthenticationCode);
            OperationResult result = businessService.DeleteByClientID(Convert.ToString(clientID) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Authentication Code data with authorization Session I D containing specified keyword
        /// </summary>
		/// <param name="authorizationSessionID"> Authorization Session I D</param>
		/// <returns>List of  Authentication Code</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "authenticationcode/find-by-authorization-session-i-d/{authorizationSessionID}")]
        public Stream FindByAuthorizationSessionID(string authorizationSessionID)
        {
            IFindAuthenticationCodeBusinessService businessService = (IFindAuthenticationCodeBusinessService)BusinessFactory.Create(Keywords.FindAuthenticationCode);
            OperationResult result = businessService.FindByAuthorizationSessionID(Convert.ToString(authorizationSessionID));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Authentication Code's authorization Session I D which has specified idAuthenticationCode
        /// </summary>
		/// <param name="idAuthenticationCode">id Authentication Code</param>
		/// <param name="authorizationSessionID">authorization Session I D</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "authenticationcode/update-authorization-session-i-d/{idAuthenticationCode}/{authorizationSessionID}")]
        public Stream UpdateAuthorizationSessionID(string idAuthenticationCode,string authorizationSessionID)
        {
            IUpdateAuthenticationCodeBusinessService businessService = (IUpdateAuthenticationCodeBusinessService)BusinessFactory.Create(Keywords.UpdateAuthenticationCode);
            OperationResult result = businessService.UpdateAuthorizationSessionID(Convert.ToInt64(idAuthenticationCode),Convert.ToString(authorizationSessionID) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Authentication Code data with authorization Session I D containing specified keyword
        /// </summary>
		/// <param name="authorizationSessionID"> Authorization Session I D</param>
		/// <returns>List of  Authentication Code</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "authenticationcode/delete-by-authorization-session-i-d/{authorizationSessionID}")]
        public Stream DeleteByAuthorizationSessionID(string authorizationSessionID)
        {
            IDeleteAuthenticationCodeBusinessService businessService = (IDeleteAuthenticationCodeBusinessService)BusinessFactory.Create(Keywords.DeleteAuthenticationCode);
            OperationResult result = businessService.DeleteByAuthorizationSessionID(Convert.ToString(authorizationSessionID) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Authentication Code with CreatedDate between CreatedDate1 and CreatedDate2
        /// </summary>
		/// <param name="createdDate1"> Created Date</param>
		/// <param name="createdDate2"> Created Date</param>
		/// <returns>List of  Authentication Code</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "authenticationcode/find-by-created-date-between/{createdDate1}/{createdDate2}")]
        public Stream FindByCreatedDateBetween(string createdDate1,string createdDate2)
        {
            IFindAuthenticationCodeBusinessService businessService = (IFindAuthenticationCodeBusinessService)BusinessFactory.Create(Keywords.FindAuthenticationCode);
            OperationResult result = businessService.FindByCreatedDateBetween(Convert.ToDateTime(createdDate1),Convert.ToDateTime(createdDate2) );
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Authentication Code's created Date which has specified idAuthenticationCode
        /// </summary>
		/// <param name="idAuthenticationCode">id Authentication Code</param>
		/// <param name="createdDate">created Date</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "authenticationcode/update-created-date/{idAuthenticationCode}/{createdDate}")]
        public Stream UpdateCreatedDate(string idAuthenticationCode,string createdDate)
        {
            IUpdateAuthenticationCodeBusinessService businessService = (IUpdateAuthenticationCodeBusinessService)BusinessFactory.Create(Keywords.UpdateAuthenticationCode);
            OperationResult result = businessService.UpdateCreatedDate(Convert.ToInt64(idAuthenticationCode),Convert.ToDateTime(createdDate) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Authentication Code data with created Date containing specified keyword
        /// </summary>
		/// <param name="createdDate"> Created Date</param>
		/// <returns>List of  Authentication Code</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "authenticationcode/delete-by-created-date/{createdDate}")]
        public Stream DeleteByCreatedDate(string createdDate)
        {
            IDeleteAuthenticationCodeBusinessService businessService = (IDeleteAuthenticationCodeBusinessService)BusinessFactory.Create(Keywords.DeleteAuthenticationCode);
            OperationResult result = businessService.DeleteByCreatedDate(Convert.ToDateTime(createdDate) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Authentication Code with ExpiredDate between ExpiredDate1 and ExpiredDate2
        /// </summary>
		/// <param name="expiredDate1"> Expired Date</param>
		/// <param name="expiredDate2"> Expired Date</param>
		/// <returns>List of  Authentication Code</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "authenticationcode/find-by-expired-date-between/{expiredDate1}/{expiredDate2}")]
        public Stream FindByExpiredDateBetween(string expiredDate1,string expiredDate2)
        {
            IFindAuthenticationCodeBusinessService businessService = (IFindAuthenticationCodeBusinessService)BusinessFactory.Create(Keywords.FindAuthenticationCode);
            OperationResult result = businessService.FindByExpiredDateBetween(Convert.ToDateTime(expiredDate1),Convert.ToDateTime(expiredDate2) );
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Authentication Code's expired Date which has specified idAuthenticationCode
        /// </summary>
		/// <param name="idAuthenticationCode">id Authentication Code</param>
		/// <param name="expiredDate">expired Date</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "authenticationcode/update-expired-date/{idAuthenticationCode}/{expiredDate}")]
        public Stream UpdateExpiredDate(string idAuthenticationCode,string expiredDate)
        {
            IUpdateAuthenticationCodeBusinessService businessService = (IUpdateAuthenticationCodeBusinessService)BusinessFactory.Create(Keywords.UpdateAuthenticationCode);
            OperationResult result = businessService.UpdateExpiredDate(Convert.ToInt64(idAuthenticationCode),Convert.ToDateTime(expiredDate) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Authentication Code data with expired Date containing specified keyword
        /// </summary>
		/// <param name="expiredDate"> Expired Date</param>
		/// <returns>List of  Authentication Code</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "authenticationcode/delete-by-expired-date/{expiredDate}")]
        public Stream DeleteByExpiredDate(string expiredDate)
        {
            IDeleteAuthenticationCodeBusinessService businessService = (IDeleteAuthenticationCodeBusinessService)BusinessFactory.Create(Keywords.DeleteAuthenticationCode);
            OperationResult result = businessService.DeleteByExpiredDate(Convert.ToDateTime(expiredDate) );
            return result.ToJsonStream();
        }	
		
 
	}
}