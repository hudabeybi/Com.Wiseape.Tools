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
    /// Interface for AccessToken Service
    /// </summary>
    [ServiceContract]
    public interface IAccessTokenService
    {
    
        /// <summary>
        /// Service to add AccessToken data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="AccessTokenForm">AccessToken data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [OperationContract]
        Stream AddAccessToken(AccessToken accessTokenForm);

        /// <summary>
        /// Service to update AccessToken data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="accessTokenForm">AccessToken data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [OperationContract]
        Stream UpdateAccessToken(AccessToken accessTokenForm);

        /// <summary>
        /// Service to delete AccessToken data from data store. 
        /// The data deleted is defined by idAccessToken.
        /// This is a GET request.
        /// </summary>
        /// <param name="idAccessToken">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>  
        [OperationContract]
        Stream DeleteAccessToken(string idAccessToken);

        /// <summary>
        /// Service to get a AccessToken data from data store. 
        /// The data retrieved is defined by idAccessToken.
        /// This is a GET request.
        /// </summary>
        /// <param name="idAccessToken">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>    
        [OperationContract]
       	Stream GetAccessToken(string idAccessToken);

        /// <summary>
        /// Service to get all the AccessToken data from data store. 
        /// The data items retrieved are those who contain the keyword given. 
        /// This is a GET request.
        /// </summary>
        /// <param name="keyword">the keyword to search</param>
        /// <param name="page">the page of the data navigation</param>
        /// <param name="max">the maximum amount of data to retrieve</param>
        /// <return>JSON string representation of operation result</return>    
		[OperationContract]
        Stream FindAccessToken(string keyword, string page, string max);	
        

        /// <summary>
        /// Finds all  Access Token data with access Token String containing specified keyword
        /// </summary>
		/// <param name="accessTokenString"> Access Token String</param>
		/// <returns>List of  Access Token</returns>
		[OperationContract]
		Stream FindByAccessTokenString(string accessTokenString);

        /// <summary>
        /// Updates  Access Token's access Token String which has specified idAccessToken
        /// </summary>
		/// <param name="idAccessToken">id Access Token</param>
		/// <param name="accessTokenString">access Token String</param>
		/// <returns>List of  Access Token</returns>
		[OperationContract]
		Stream UpdateAccessTokenString(string idAccessToken,string accessTokenString);

        /// <summary>
        /// Delete all  Access Token data with access Token String containing specified keyword
        /// </summary>
		/// <param name="accessTokenString"> Access Token String</param>
		/// <returns>List of  Access Token</returns>
		[OperationContract]
		Stream DeleteByAccessTokenString(string accessTokenString);

        /// <summary>
        /// Finds all  Access Token data with refresh Token containing specified keyword
        /// </summary>
		/// <param name="refreshToken"> Refresh Token</param>
		/// <returns>List of  Access Token</returns>
		[OperationContract]
		Stream FindByRefreshToken(string refreshToken);

        /// <summary>
        /// Updates  Access Token's refresh Token which has specified idAccessToken
        /// </summary>
		/// <param name="idAccessToken">id Access Token</param>
		/// <param name="refreshToken">refresh Token</param>
		/// <returns>List of  Access Token</returns>
		[OperationContract]
		Stream UpdateRefreshToken(string idAccessToken,string refreshToken);

        /// <summary>
        /// Delete all  Access Token data with refresh Token containing specified keyword
        /// </summary>
		/// <param name="refreshToken"> Refresh Token</param>
		/// <returns>List of  Access Token</returns>
		[OperationContract]
		Stream DeleteByRefreshToken(string refreshToken);

        /// <summary>
        /// Finds all  Access Token data with client I D containing specified keyword
        /// </summary>
		/// <param name="clientID"> Client I D</param>
		/// <returns>List of  Access Token</returns>
		[OperationContract]
		Stream FindByClientID(string clientID);

        /// <summary>
        /// Updates  Access Token's client I D which has specified idAccessToken
        /// </summary>
		/// <param name="idAccessToken">id Access Token</param>
		/// <param name="clientID">client I D</param>
		/// <returns>List of  Access Token</returns>
		[OperationContract]
		Stream UpdateClientID(string idAccessToken,string clientID);

        /// <summary>
        /// Delete all  Access Token data with client I D containing specified keyword
        /// </summary>
		/// <param name="clientID"> Client I D</param>
		/// <returns>List of  Access Token</returns>
		[OperationContract]
		Stream DeleteByClientID(string clientID);

        /// <summary>
        /// Finds all  Access Token data with client Secret containing specified keyword
        /// </summary>
		/// <param name="clientSecret"> Client Secret</param>
		/// <returns>List of  Access Token</returns>
		[OperationContract]
		Stream FindByClientSecret(string clientSecret);

        /// <summary>
        /// Updates  Access Token's client Secret which has specified idAccessToken
        /// </summary>
		/// <param name="idAccessToken">id Access Token</param>
		/// <param name="clientSecret">client Secret</param>
		/// <returns>List of  Access Token</returns>
		[OperationContract]
		Stream UpdateClientSecret(string idAccessToken,string clientSecret);

        /// <summary>
        /// Delete all  Access Token data with client Secret containing specified keyword
        /// </summary>
		/// <param name="clientSecret"> Client Secret</param>
		/// <returns>List of  Access Token</returns>
		[OperationContract]
		Stream DeleteByClientSecret(string clientSecret);

        /// <summary>
        /// Finds all  Access Token with CreatedDate between CreatedDate1 and CreatedDate2
        /// </summary>
		/// <param name="createdDate1"> Created Date</param>
		/// <param name="createdDate2"> Created Date</param>
		/// <returns>List of  Access Token</returns>
		[OperationContract]
		Stream FindByCreatedDateBetween(string createdDate1,string createdDate2);

        /// <summary>
        /// Updates  Access Token's created Date which has specified idAccessToken
        /// </summary>
		/// <param name="idAccessToken">id Access Token</param>
		/// <param name="createdDate">created Date</param>
		/// <returns>List of  Access Token</returns>
		[OperationContract]
		Stream UpdateCreatedDate(string idAccessToken,string createdDate);

        /// <summary>
        /// Delete all  Access Token data with created Date containing specified keyword
        /// </summary>
		/// <param name="createdDate"> Created Date</param>
		/// <returns>List of  Access Token</returns>
		[OperationContract]
		Stream DeleteByCreatedDate(string createdDate);

        /// <summary>
        /// Finds all  Access Token with ExpiredDate between ExpiredDate1 and ExpiredDate2
        /// </summary>
		/// <param name="expiredDate1"> Expired Date</param>
		/// <param name="expiredDate2"> Expired Date</param>
		/// <returns>List of  Access Token</returns>
		[OperationContract]
		Stream FindByExpiredDateBetween(string expiredDate1,string expiredDate2);

        /// <summary>
        /// Updates  Access Token's expired Date which has specified idAccessToken
        /// </summary>
		/// <param name="idAccessToken">id Access Token</param>
		/// <param name="expiredDate">expired Date</param>
		/// <returns>List of  Access Token</returns>
		[OperationContract]
		Stream UpdateExpiredDate(string idAccessToken,string expiredDate);

        /// <summary>
        /// Delete all  Access Token data with expired Date containing specified keyword
        /// </summary>
		/// <param name="expiredDate"> Expired Date</param>
		/// <returns>List of  Access Token</returns>
		[OperationContract]
		Stream DeleteByExpiredDate(string expiredDate);
    
    }
}