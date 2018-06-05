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
    public class AccessTokenService : IAccessTokenService
    {

        class Keywords
        {
            public static string AccessToken = "Tools.OAuthServerManager.AccessToken";
            public static string FindAccessToken = "Find.Tools.OAuthServerManager.AccessToken";
            public static string AddAccessToken = "Add.Tools.OAuthServerManager.AccessToken";
            public static string UpdateAccessToken = "Update.Tools.OAuthServerManager.AccessToken";
            public static string DeleteAccessToken = "Delete.Tools.OAuthServerManager.AccessToken";
        }

        /// <summary>
        /// Service to add AccessToken data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="AccessTokenForm">AccessToken data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [WebInvoke(Method = "POST",
                    ResponseFormat = WebMessageFormat.Json,
                    RequestFormat = WebMessageFormat.Json,
                    UriTemplate = "accesstoken/add")]
        public Stream AddAccessToken(AccessToken accessTokenForm)
        {
            BaseBusinessService<AccessToken> businessService = (BaseBusinessService<AccessToken>)BusinessFactory.Create(Keywords.AddAccessToken);
            OperationResult result = businessService.Add(accessTokenForm);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to update AccessToken data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="accessTokenForm">AccessToken data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [WebInvoke(Method = "POST",
                    ResponseFormat = WebMessageFormat.Json,
                    RequestFormat = WebMessageFormat.Json,
                    UriTemplate = "accesstoken/update")]
        public Stream UpdateAccessToken(AccessToken accessTokenForm)
        {
            BaseBusinessService<AccessToken> businessService = (BaseBusinessService<AccessToken>)BusinessFactory.Create(Keywords.UpdateAccessToken);
            OperationResult result = businessService.Update(accessTokenForm);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to delete AccessToken data from data store. 
        /// The data deleted is defined by idAccessToken.
        /// This is a GET request.
        /// </summary>
        /// <param name="idAccessToken">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>  
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "accesstoken/delete/{idAccessToken}")]
        public Stream DeleteAccessToken(string idAccessToken)
        {
            BaseBusinessService<AccessToken> businessService = (BaseBusinessService<AccessToken>)BusinessFactory.Create(Keywords.DeleteAccessToken);
            OperationResult result = businessService.Delete(idAccessToken);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to get a AccessToken data from data store. 
        /// The data retrieved is defined by idAccessToken.
        /// This is a GET request.
        /// </summary>
        /// <param name="idAccessToken">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>    
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "accesstoken/get/{idAccessToken}")]
        public Stream GetAccessToken(string idAccessToken)
        {
            BaseBusinessService<AccessToken> businessService = (BaseBusinessService<AccessToken>)BusinessFactory.Create(Keywords.FindAccessToken);
            OperationResult result = businessService.Get(idAccessToken);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to get all the AccessToken data from data store. 
        /// The data items retrieved are those who contain the keyword given. 
        /// This is a GET request.
        /// </summary>
        /// <param name="keyword">the keyword to search</param>
        /// <param name="page">the page of the data navigation</param>
        /// <param name="max">the maximum amount of data to retrieve</param>
        /// <return>JSON string representation of operation result</return>    
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "accesstoken/find/{keyword}/{page}/{max}")]
        public Stream FindAccessToken(string keyword, string page, string max)
        {
            BaseBusinessService<AccessToken> businessService = (BaseBusinessService<AccessToken>)BusinessFactory.Create(Keywords.FindAccessToken);

            SelectParam selectParam = new SelectParam();
            selectParam.Keyword = keyword;
            if (keyword.ToLower() == "all")
                selectParam.Keyword = "";
            OperationResult result = businessService.FindAll(selectParam, Convert.ToInt16(page), Convert.ToInt16(max) );

            return result.ToJsonStream();
        }	
        

        /// <summary>
        /// Finds all  Access Token data with access Token String containing specified keyword
        /// </summary>
		/// <param name="accessTokenString"> Access Token String</param>
		/// <returns>List of  Access Token</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "accesstoken/find-by-access-token-string/{accessTokenString}")]
        public Stream FindByAccessTokenString(string accessTokenString)
        {
            IFindAccessTokenBusinessService businessService = (IFindAccessTokenBusinessService)BusinessFactory.Create(Keywords.FindAccessToken);
            OperationResult result = businessService.FindByAccessTokenString(Convert.ToString(accessTokenString));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Access Token's access Token String which has specified idAccessToken
        /// </summary>
		/// <param name="idAccessToken">id Access Token</param>
		/// <param name="accessTokenString">access Token String</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "accesstoken/update-access-token-string/{idAccessToken}/{accessTokenString}")]
        public Stream UpdateAccessTokenString(string idAccessToken,string accessTokenString)
        {
            IUpdateAccessTokenBusinessService businessService = (IUpdateAccessTokenBusinessService)BusinessFactory.Create(Keywords.UpdateAccessToken);
            OperationResult result = businessService.UpdateAccessTokenString(Convert.ToInt64(idAccessToken),Convert.ToString(accessTokenString) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Access Token data with access Token String containing specified keyword
        /// </summary>
		/// <param name="accessTokenString"> Access Token String</param>
		/// <returns>List of  Access Token</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "accesstoken/delete-by-access-token-string/{accessTokenString}")]
        public Stream DeleteByAccessTokenString(string accessTokenString)
        {
            IDeleteAccessTokenBusinessService businessService = (IDeleteAccessTokenBusinessService)BusinessFactory.Create(Keywords.DeleteAccessToken);
            OperationResult result = businessService.DeleteByAccessTokenString(Convert.ToString(accessTokenString) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Access Token data with refresh Token containing specified keyword
        /// </summary>
		/// <param name="refreshToken"> Refresh Token</param>
		/// <returns>List of  Access Token</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "accesstoken/find-by-refresh-token/{refreshToken}")]
        public Stream FindByRefreshToken(string refreshToken)
        {
            IFindAccessTokenBusinessService businessService = (IFindAccessTokenBusinessService)BusinessFactory.Create(Keywords.FindAccessToken);
            OperationResult result = businessService.FindByRefreshToken(Convert.ToString(refreshToken));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Access Token's refresh Token which has specified idAccessToken
        /// </summary>
		/// <param name="idAccessToken">id Access Token</param>
		/// <param name="refreshToken">refresh Token</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "accesstoken/update-refresh-token/{idAccessToken}/{refreshToken}")]
        public Stream UpdateRefreshToken(string idAccessToken,string refreshToken)
        {
            IUpdateAccessTokenBusinessService businessService = (IUpdateAccessTokenBusinessService)BusinessFactory.Create(Keywords.UpdateAccessToken);
            OperationResult result = businessService.UpdateRefreshToken(Convert.ToInt64(idAccessToken),Convert.ToString(refreshToken) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Access Token data with refresh Token containing specified keyword
        /// </summary>
		/// <param name="refreshToken"> Refresh Token</param>
		/// <returns>List of  Access Token</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "accesstoken/delete-by-refresh-token/{refreshToken}")]
        public Stream DeleteByRefreshToken(string refreshToken)
        {
            IDeleteAccessTokenBusinessService businessService = (IDeleteAccessTokenBusinessService)BusinessFactory.Create(Keywords.DeleteAccessToken);
            OperationResult result = businessService.DeleteByRefreshToken(Convert.ToString(refreshToken) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Access Token data with client I D containing specified keyword
        /// </summary>
		/// <param name="clientID"> Client I D</param>
		/// <returns>List of  Access Token</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "accesstoken/find-by-client-i-d/{clientID}")]
        public Stream FindByClientID(string clientID)
        {
            IFindAccessTokenBusinessService businessService = (IFindAccessTokenBusinessService)BusinessFactory.Create(Keywords.FindAccessToken);
            OperationResult result = businessService.FindByClientID(Convert.ToString(clientID));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Access Token's client I D which has specified idAccessToken
        /// </summary>
		/// <param name="idAccessToken">id Access Token</param>
		/// <param name="clientID">client I D</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "accesstoken/update-client-i-d/{idAccessToken}/{clientID}")]
        public Stream UpdateClientID(string idAccessToken,string clientID)
        {
            IUpdateAccessTokenBusinessService businessService = (IUpdateAccessTokenBusinessService)BusinessFactory.Create(Keywords.UpdateAccessToken);
            OperationResult result = businessService.UpdateClientID(Convert.ToInt64(idAccessToken),Convert.ToString(clientID) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Access Token data with client I D containing specified keyword
        /// </summary>
		/// <param name="clientID"> Client I D</param>
		/// <returns>List of  Access Token</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "accesstoken/delete-by-client-i-d/{clientID}")]
        public Stream DeleteByClientID(string clientID)
        {
            IDeleteAccessTokenBusinessService businessService = (IDeleteAccessTokenBusinessService)BusinessFactory.Create(Keywords.DeleteAccessToken);
            OperationResult result = businessService.DeleteByClientID(Convert.ToString(clientID) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Access Token data with client Secret containing specified keyword
        /// </summary>
		/// <param name="clientSecret"> Client Secret</param>
		/// <returns>List of  Access Token</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "accesstoken/find-by-client-secret/{clientSecret}")]
        public Stream FindByClientSecret(string clientSecret)
        {
            IFindAccessTokenBusinessService businessService = (IFindAccessTokenBusinessService)BusinessFactory.Create(Keywords.FindAccessToken);
            OperationResult result = businessService.FindByClientSecret(Convert.ToString(clientSecret));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Access Token's client Secret which has specified idAccessToken
        /// </summary>
		/// <param name="idAccessToken">id Access Token</param>
		/// <param name="clientSecret">client Secret</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "accesstoken/update-client-secret/{idAccessToken}/{clientSecret}")]
        public Stream UpdateClientSecret(string idAccessToken,string clientSecret)
        {
            IUpdateAccessTokenBusinessService businessService = (IUpdateAccessTokenBusinessService)BusinessFactory.Create(Keywords.UpdateAccessToken);
            OperationResult result = businessService.UpdateClientSecret(Convert.ToInt64(idAccessToken),Convert.ToString(clientSecret) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Access Token data with client Secret containing specified keyword
        /// </summary>
		/// <param name="clientSecret"> Client Secret</param>
		/// <returns>List of  Access Token</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "accesstoken/delete-by-client-secret/{clientSecret}")]
        public Stream DeleteByClientSecret(string clientSecret)
        {
            IDeleteAccessTokenBusinessService businessService = (IDeleteAccessTokenBusinessService)BusinessFactory.Create(Keywords.DeleteAccessToken);
            OperationResult result = businessService.DeleteByClientSecret(Convert.ToString(clientSecret) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Access Token with CreatedDate between CreatedDate1 and CreatedDate2
        /// </summary>
		/// <param name="createdDate1"> Created Date</param>
		/// <param name="createdDate2"> Created Date</param>
		/// <returns>List of  Access Token</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "accesstoken/find-by-created-date-between/{createdDate1}/{createdDate2}")]
        public Stream FindByCreatedDateBetween(string createdDate1,string createdDate2)
        {
            IFindAccessTokenBusinessService businessService = (IFindAccessTokenBusinessService)BusinessFactory.Create(Keywords.FindAccessToken);
            OperationResult result = businessService.FindByCreatedDateBetween(Convert.ToDateTime(createdDate1),Convert.ToDateTime(createdDate2) );
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Access Token's created Date which has specified idAccessToken
        /// </summary>
		/// <param name="idAccessToken">id Access Token</param>
		/// <param name="createdDate">created Date</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "accesstoken/update-created-date/{idAccessToken}/{createdDate}")]
        public Stream UpdateCreatedDate(string idAccessToken,string createdDate)
        {
            IUpdateAccessTokenBusinessService businessService = (IUpdateAccessTokenBusinessService)BusinessFactory.Create(Keywords.UpdateAccessToken);
            OperationResult result = businessService.UpdateCreatedDate(Convert.ToInt64(idAccessToken),Convert.ToDateTime(createdDate) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Access Token data with created Date containing specified keyword
        /// </summary>
		/// <param name="createdDate"> Created Date</param>
		/// <returns>List of  Access Token</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "accesstoken/delete-by-created-date/{createdDate}")]
        public Stream DeleteByCreatedDate(string createdDate)
        {
            IDeleteAccessTokenBusinessService businessService = (IDeleteAccessTokenBusinessService)BusinessFactory.Create(Keywords.DeleteAccessToken);
            OperationResult result = businessService.DeleteByCreatedDate(Convert.ToDateTime(createdDate) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Access Token with ExpiredDate between ExpiredDate1 and ExpiredDate2
        /// </summary>
		/// <param name="expiredDate1"> Expired Date</param>
		/// <param name="expiredDate2"> Expired Date</param>
		/// <returns>List of  Access Token</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "accesstoken/find-by-expired-date-between/{expiredDate1}/{expiredDate2}")]
        public Stream FindByExpiredDateBetween(string expiredDate1,string expiredDate2)
        {
            IFindAccessTokenBusinessService businessService = (IFindAccessTokenBusinessService)BusinessFactory.Create(Keywords.FindAccessToken);
            OperationResult result = businessService.FindByExpiredDateBetween(Convert.ToDateTime(expiredDate1),Convert.ToDateTime(expiredDate2) );
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Access Token's expired Date which has specified idAccessToken
        /// </summary>
		/// <param name="idAccessToken">id Access Token</param>
		/// <param name="expiredDate">expired Date</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "accesstoken/update-expired-date/{idAccessToken}/{expiredDate}")]
        public Stream UpdateExpiredDate(string idAccessToken,string expiredDate)
        {
            IUpdateAccessTokenBusinessService businessService = (IUpdateAccessTokenBusinessService)BusinessFactory.Create(Keywords.UpdateAccessToken);
            OperationResult result = businessService.UpdateExpiredDate(Convert.ToInt64(idAccessToken),Convert.ToDateTime(expiredDate) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Access Token data with expired Date containing specified keyword
        /// </summary>
		/// <param name="expiredDate"> Expired Date</param>
		/// <returns>List of  Access Token</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "accesstoken/delete-by-expired-date/{expiredDate}")]
        public Stream DeleteByExpiredDate(string expiredDate)
        {
            IDeleteAccessTokenBusinessService businessService = (IDeleteAccessTokenBusinessService)BusinessFactory.Create(Keywords.DeleteAccessToken);
            OperationResult result = businessService.DeleteByExpiredDate(Convert.ToDateTime(expiredDate) );
            return result.ToJsonStream();
        }	
		
 
	}
}