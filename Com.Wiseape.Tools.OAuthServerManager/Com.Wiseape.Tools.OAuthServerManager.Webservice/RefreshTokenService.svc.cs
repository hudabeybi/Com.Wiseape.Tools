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
    public class RefreshTokenService : IRefreshTokenService
    {

        class Keywords
        {
            public static string RefreshToken = "Tools.OAuthServerManager.RefreshToken";
            public static string FindRefreshToken = "Find.Tools.OAuthServerManager.RefreshToken";
            public static string AddRefreshToken = "Add.Tools.OAuthServerManager.RefreshToken";
            public static string UpdateRefreshToken = "Update.Tools.OAuthServerManager.RefreshToken";
            public static string DeleteRefreshToken = "Delete.Tools.OAuthServerManager.RefreshToken";
        }

        /// <summary>
        /// Service to add RefreshToken data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="RefreshTokenForm">RefreshToken data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [WebInvoke(Method = "POST",
                    ResponseFormat = WebMessageFormat.Json,
                    RequestFormat = WebMessageFormat.Json,
                    UriTemplate = "refreshtoken/add")]
        public Stream AddRefreshToken(RefreshToken refreshTokenForm)
        {
            BaseBusinessService<RefreshToken> businessService = (BaseBusinessService<RefreshToken>)BusinessFactory.Create(Keywords.AddRefreshToken);
            OperationResult result = businessService.Add(refreshTokenForm);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to update RefreshToken data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="refreshTokenForm">RefreshToken data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [WebInvoke(Method = "POST",
                    ResponseFormat = WebMessageFormat.Json,
                    RequestFormat = WebMessageFormat.Json,
                    UriTemplate = "refreshtoken/update")]
        public Stream UpdateRefreshToken(RefreshToken refreshTokenForm)
        {
            BaseBusinessService<RefreshToken> businessService = (BaseBusinessService<RefreshToken>)BusinessFactory.Create(Keywords.UpdateRefreshToken);
            OperationResult result = businessService.Update(refreshTokenForm);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to delete RefreshToken data from data store. 
        /// The data deleted is defined by idRefreshToken.
        /// This is a GET request.
        /// </summary>
        /// <param name="idRefreshToken">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>  
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "refreshtoken/delete/{idRefreshToken}")]
        public Stream DeleteRefreshToken(string idRefreshToken)
        {
            BaseBusinessService<RefreshToken> businessService = (BaseBusinessService<RefreshToken>)BusinessFactory.Create(Keywords.DeleteRefreshToken);
            OperationResult result = businessService.Delete(idRefreshToken);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to get a RefreshToken data from data store. 
        /// The data retrieved is defined by idRefreshToken.
        /// This is a GET request.
        /// </summary>
        /// <param name="idRefreshToken">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>    
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "refreshtoken/get/{idRefreshToken}")]
        public Stream GetRefreshToken(string idRefreshToken)
        {
            BaseBusinessService<RefreshToken> businessService = (BaseBusinessService<RefreshToken>)BusinessFactory.Create(Keywords.FindRefreshToken);
            OperationResult result = businessService.Get(idRefreshToken);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to get all the RefreshToken data from data store. 
        /// The data items retrieved are those who contain the keyword given. 
        /// This is a GET request.
        /// </summary>
        /// <param name="keyword">the keyword to search</param>
        /// <param name="page">the page of the data navigation</param>
        /// <param name="max">the maximum amount of data to retrieve</param>
        /// <return>JSON string representation of operation result</return>    
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "refreshtoken/find/{keyword}/{page}/{max}")]
        public Stream FindRefreshToken(string keyword, string page, string max)
        {
            BaseBusinessService<RefreshToken> businessService = (BaseBusinessService<RefreshToken>)BusinessFactory.Create(Keywords.FindRefreshToken);

            SelectParam selectParam = new SelectParam();
            selectParam.Keyword = keyword;
            if (keyword.ToLower() == "all")
                selectParam.Keyword = "";
            OperationResult result = businessService.FindAll(selectParam, Convert.ToInt16(page), Convert.ToInt16(max) );

            return result.ToJsonStream();
        }	
        

        /// <summary>
        /// Finds all  Refresh Token data with client I D containing specified keyword
        /// </summary>
		/// <param name="clientID"> Client I D</param>
		/// <returns>List of  Refresh Token</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "refreshtoken/find-by-client-i-d/{clientID}")]
        public Stream FindByClientID(string clientID)
        {
            IFindRefreshTokenBusinessService businessService = (IFindRefreshTokenBusinessService)BusinessFactory.Create(Keywords.FindRefreshToken);
            OperationResult result = businessService.FindByClientID(Convert.ToString(clientID));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Refresh Token's client I D which has specified idRefreshToken
        /// </summary>
		/// <param name="idRefreshToken">id Refresh Token</param>
		/// <param name="clientID">client I D</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "refreshtoken/update-client-i-d/{idRefreshToken}/{clientID}")]
        public Stream UpdateClientID(string idRefreshToken,string clientID)
        {
            IUpdateRefreshTokenBusinessService businessService = (IUpdateRefreshTokenBusinessService)BusinessFactory.Create(Keywords.UpdateRefreshToken);
            OperationResult result = businessService.UpdateClientID(Convert.ToInt64(idRefreshToken),Convert.ToString(clientID) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Refresh Token data with client I D containing specified keyword
        /// </summary>
		/// <param name="clientID"> Client I D</param>
		/// <returns>List of  Refresh Token</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "refreshtoken/delete-by-client-i-d/{clientID}")]
        public Stream DeleteByClientID(string clientID)
        {
            IDeleteRefreshTokenBusinessService businessService = (IDeleteRefreshTokenBusinessService)BusinessFactory.Create(Keywords.DeleteRefreshToken);
            OperationResult result = businessService.DeleteByClientID(Convert.ToString(clientID) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Refresh Token data with client Secret containing specified keyword
        /// </summary>
		/// <param name="clientSecret"> Client Secret</param>
		/// <returns>List of  Refresh Token</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "refreshtoken/find-by-client-secret/{clientSecret}")]
        public Stream FindByClientSecret(string clientSecret)
        {
            IFindRefreshTokenBusinessService businessService = (IFindRefreshTokenBusinessService)BusinessFactory.Create(Keywords.FindRefreshToken);
            OperationResult result = businessService.FindByClientSecret(Convert.ToString(clientSecret));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Refresh Token's client Secret which has specified idRefreshToken
        /// </summary>
		/// <param name="idRefreshToken">id Refresh Token</param>
		/// <param name="clientSecret">client Secret</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "refreshtoken/update-client-secret/{idRefreshToken}/{clientSecret}")]
        public Stream UpdateClientSecret(string idRefreshToken,string clientSecret)
        {
            IUpdateRefreshTokenBusinessService businessService = (IUpdateRefreshTokenBusinessService)BusinessFactory.Create(Keywords.UpdateRefreshToken);
            OperationResult result = businessService.UpdateClientSecret(Convert.ToInt64(idRefreshToken),Convert.ToString(clientSecret) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Refresh Token data with client Secret containing specified keyword
        /// </summary>
		/// <param name="clientSecret"> Client Secret</param>
		/// <returns>List of  Refresh Token</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "refreshtoken/delete-by-client-secret/{clientSecret}")]
        public Stream DeleteByClientSecret(string clientSecret)
        {
            IDeleteRefreshTokenBusinessService businessService = (IDeleteRefreshTokenBusinessService)BusinessFactory.Create(Keywords.DeleteRefreshToken);
            OperationResult result = businessService.DeleteByClientSecret(Convert.ToString(clientSecret) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Refresh Token data with authentication Code containing specified keyword
        /// </summary>
		/// <param name="authenticationCode"> Authentication Code</param>
		/// <returns>List of  Refresh Token</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "refreshtoken/find-by-authentication-code/{authenticationCode}")]
        public Stream FindByAuthenticationCode(string authenticationCode)
        {
            IFindRefreshTokenBusinessService businessService = (IFindRefreshTokenBusinessService)BusinessFactory.Create(Keywords.FindRefreshToken);
            OperationResult result = businessService.FindByAuthenticationCode(Convert.ToString(authenticationCode));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Refresh Token's authentication Code which has specified idRefreshToken
        /// </summary>
		/// <param name="idRefreshToken">id Refresh Token</param>
		/// <param name="authenticationCode">authentication Code</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "refreshtoken/update-authentication-code/{idRefreshToken}/{authenticationCode}")]
        public Stream UpdateAuthenticationCode(string idRefreshToken,string authenticationCode)
        {
            IUpdateRefreshTokenBusinessService businessService = (IUpdateRefreshTokenBusinessService)BusinessFactory.Create(Keywords.UpdateRefreshToken);
            OperationResult result = businessService.UpdateAuthenticationCode(Convert.ToInt64(idRefreshToken),Convert.ToString(authenticationCode) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Refresh Token data with authentication Code containing specified keyword
        /// </summary>
		/// <param name="authenticationCode"> Authentication Code</param>
		/// <returns>List of  Refresh Token</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "refreshtoken/delete-by-authentication-code/{authenticationCode}")]
        public Stream DeleteByAuthenticationCode(string authenticationCode)
        {
            IDeleteRefreshTokenBusinessService businessService = (IDeleteRefreshTokenBusinessService)BusinessFactory.Create(Keywords.DeleteRefreshToken);
            OperationResult result = businessService.DeleteByAuthenticationCode(Convert.ToString(authenticationCode) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Refresh Token data with refresh Token String containing specified keyword
        /// </summary>
		/// <param name="refreshTokenString"> Refresh Token String</param>
		/// <returns>List of  Refresh Token</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "refreshtoken/find-by-refresh-token-string/{refreshTokenString}")]
        public Stream FindByRefreshTokenString(string refreshTokenString)
        {
            IFindRefreshTokenBusinessService businessService = (IFindRefreshTokenBusinessService)BusinessFactory.Create(Keywords.FindRefreshToken);
            OperationResult result = businessService.FindByRefreshTokenString(Convert.ToString(refreshTokenString));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Refresh Token's refresh Token String which has specified idRefreshToken
        /// </summary>
		/// <param name="idRefreshToken">id Refresh Token</param>
		/// <param name="refreshTokenString">refresh Token String</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "refreshtoken/update-refresh-token-string/{idRefreshToken}/{refreshTokenString}")]
        public Stream UpdateRefreshTokenString(string idRefreshToken,string refreshTokenString)
        {
            IUpdateRefreshTokenBusinessService businessService = (IUpdateRefreshTokenBusinessService)BusinessFactory.Create(Keywords.UpdateRefreshToken);
            OperationResult result = businessService.UpdateRefreshTokenString(Convert.ToInt64(idRefreshToken),Convert.ToString(refreshTokenString) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Refresh Token data with refresh Token String containing specified keyword
        /// </summary>
		/// <param name="refreshTokenString"> Refresh Token String</param>
		/// <returns>List of  Refresh Token</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "refreshtoken/delete-by-refresh-token-string/{refreshTokenString}")]
        public Stream DeleteByRefreshTokenString(string refreshTokenString)
        {
            IDeleteRefreshTokenBusinessService businessService = (IDeleteRefreshTokenBusinessService)BusinessFactory.Create(Keywords.DeleteRefreshToken);
            OperationResult result = businessService.DeleteByRefreshTokenString(Convert.ToString(refreshTokenString) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Refresh Token with CreatedDate between CreatedDate1 and CreatedDate2
        /// </summary>
		/// <param name="createdDate1"> Created Date</param>
		/// <param name="createdDate2"> Created Date</param>
		/// <returns>List of  Refresh Token</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "refreshtoken/find-by-created-date-between/{createdDate1}/{createdDate2}")]
        public Stream FindByCreatedDateBetween(string createdDate1,string createdDate2)
        {
            IFindRefreshTokenBusinessService businessService = (IFindRefreshTokenBusinessService)BusinessFactory.Create(Keywords.FindRefreshToken);
            OperationResult result = businessService.FindByCreatedDateBetween(Convert.ToDateTime(createdDate1),Convert.ToDateTime(createdDate2) );
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Refresh Token's created Date which has specified idRefreshToken
        /// </summary>
		/// <param name="idRefreshToken">id Refresh Token</param>
		/// <param name="createdDate">created Date</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "refreshtoken/update-created-date/{idRefreshToken}/{createdDate}")]
        public Stream UpdateCreatedDate(string idRefreshToken,string createdDate)
        {
            IUpdateRefreshTokenBusinessService businessService = (IUpdateRefreshTokenBusinessService)BusinessFactory.Create(Keywords.UpdateRefreshToken);
            OperationResult result = businessService.UpdateCreatedDate(Convert.ToInt64(idRefreshToken),Convert.ToDateTime(createdDate) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Refresh Token data with created Date containing specified keyword
        /// </summary>
		/// <param name="createdDate"> Created Date</param>
		/// <returns>List of  Refresh Token</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "refreshtoken/delete-by-created-date/{createdDate}")]
        public Stream DeleteByCreatedDate(string createdDate)
        {
            IDeleteRefreshTokenBusinessService businessService = (IDeleteRefreshTokenBusinessService)BusinessFactory.Create(Keywords.DeleteRefreshToken);
            OperationResult result = businessService.DeleteByCreatedDate(Convert.ToDateTime(createdDate) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Refresh Token with ExpiredDate between ExpiredDate1 and ExpiredDate2
        /// </summary>
		/// <param name="expiredDate1"> Expired Date</param>
		/// <param name="expiredDate2"> Expired Date</param>
		/// <returns>List of  Refresh Token</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "refreshtoken/find-by-expired-date-between/{expiredDate1}/{expiredDate2}")]
        public Stream FindByExpiredDateBetween(string expiredDate1,string expiredDate2)
        {
            IFindRefreshTokenBusinessService businessService = (IFindRefreshTokenBusinessService)BusinessFactory.Create(Keywords.FindRefreshToken);
            OperationResult result = businessService.FindByExpiredDateBetween(Convert.ToDateTime(expiredDate1),Convert.ToDateTime(expiredDate2) );
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Refresh Token's expired Date which has specified idRefreshToken
        /// </summary>
		/// <param name="idRefreshToken">id Refresh Token</param>
		/// <param name="expiredDate">expired Date</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "refreshtoken/update-expired-date/{idRefreshToken}/{expiredDate}")]
        public Stream UpdateExpiredDate(string idRefreshToken,string expiredDate)
        {
            IUpdateRefreshTokenBusinessService businessService = (IUpdateRefreshTokenBusinessService)BusinessFactory.Create(Keywords.UpdateRefreshToken);
            OperationResult result = businessService.UpdateExpiredDate(Convert.ToInt64(idRefreshToken),Convert.ToDateTime(expiredDate) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Refresh Token data with expired Date containing specified keyword
        /// </summary>
		/// <param name="expiredDate"> Expired Date</param>
		/// <returns>List of  Refresh Token</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "refreshtoken/delete-by-expired-date/{expiredDate}")]
        public Stream DeleteByExpiredDate(string expiredDate)
        {
            IDeleteRefreshTokenBusinessService businessService = (IDeleteRefreshTokenBusinessService)BusinessFactory.Create(Keywords.DeleteRefreshToken);
            OperationResult result = businessService.DeleteByExpiredDate(Convert.ToDateTime(expiredDate) );
            return result.ToJsonStream();
        }	
		
 
	}
}