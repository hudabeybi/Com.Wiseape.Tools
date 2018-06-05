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
    /// Interface for RefreshToken Service
    /// </summary>
    [ServiceContract]
    public interface IRefreshTokenService
    {
    
        /// <summary>
        /// Service to add RefreshToken data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="RefreshTokenForm">RefreshToken data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [OperationContract]
        Stream AddRefreshToken(RefreshToken refreshTokenForm);

        /// <summary>
        /// Service to update RefreshToken data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="refreshTokenForm">RefreshToken data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [OperationContract]
        Stream UpdateRefreshToken(RefreshToken refreshTokenForm);

        /// <summary>
        /// Service to delete RefreshToken data from data store. 
        /// The data deleted is defined by idRefreshToken.
        /// This is a GET request.
        /// </summary>
        /// <param name="idRefreshToken">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>  
        [OperationContract]
        Stream DeleteRefreshToken(string idRefreshToken);

        /// <summary>
        /// Service to get a RefreshToken data from data store. 
        /// The data retrieved is defined by idRefreshToken.
        /// This is a GET request.
        /// </summary>
        /// <param name="idRefreshToken">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>    
        [OperationContract]
       	Stream GetRefreshToken(string idRefreshToken);

        /// <summary>
        /// Service to get all the RefreshToken data from data store. 
        /// The data items retrieved are those who contain the keyword given. 
        /// This is a GET request.
        /// </summary>
        /// <param name="keyword">the keyword to search</param>
        /// <param name="page">the page of the data navigation</param>
        /// <param name="max">the maximum amount of data to retrieve</param>
        /// <return>JSON string representation of operation result</return>    
		[OperationContract]
        Stream FindRefreshToken(string keyword, string page, string max);	
        

        /// <summary>
        /// Finds all  Refresh Token data with client I D containing specified keyword
        /// </summary>
		/// <param name="clientID"> Client I D</param>
		/// <returns>List of  Refresh Token</returns>
		[OperationContract]
		Stream FindByClientID(string clientID);

        /// <summary>
        /// Updates  Refresh Token's client I D which has specified idRefreshToken
        /// </summary>
		/// <param name="idRefreshToken">id Refresh Token</param>
		/// <param name="clientID">client I D</param>
		/// <returns>List of  Refresh Token</returns>
		[OperationContract]
		Stream UpdateClientID(string idRefreshToken,string clientID);

        /// <summary>
        /// Delete all  Refresh Token data with client I D containing specified keyword
        /// </summary>
		/// <param name="clientID"> Client I D</param>
		/// <returns>List of  Refresh Token</returns>
		[OperationContract]
		Stream DeleteByClientID(string clientID);

        /// <summary>
        /// Finds all  Refresh Token data with client Secret containing specified keyword
        /// </summary>
		/// <param name="clientSecret"> Client Secret</param>
		/// <returns>List of  Refresh Token</returns>
		[OperationContract]
		Stream FindByClientSecret(string clientSecret);

        /// <summary>
        /// Updates  Refresh Token's client Secret which has specified idRefreshToken
        /// </summary>
		/// <param name="idRefreshToken">id Refresh Token</param>
		/// <param name="clientSecret">client Secret</param>
		/// <returns>List of  Refresh Token</returns>
		[OperationContract]
		Stream UpdateClientSecret(string idRefreshToken,string clientSecret);

        /// <summary>
        /// Delete all  Refresh Token data with client Secret containing specified keyword
        /// </summary>
		/// <param name="clientSecret"> Client Secret</param>
		/// <returns>List of  Refresh Token</returns>
		[OperationContract]
		Stream DeleteByClientSecret(string clientSecret);

        /// <summary>
        /// Finds all  Refresh Token data with authentication Code containing specified keyword
        /// </summary>
		/// <param name="authenticationCode"> Authentication Code</param>
		/// <returns>List of  Refresh Token</returns>
		[OperationContract]
		Stream FindByAuthenticationCode(string authenticationCode);

        /// <summary>
        /// Updates  Refresh Token's authentication Code which has specified idRefreshToken
        /// </summary>
		/// <param name="idRefreshToken">id Refresh Token</param>
		/// <param name="authenticationCode">authentication Code</param>
		/// <returns>List of  Refresh Token</returns>
		[OperationContract]
		Stream UpdateAuthenticationCode(string idRefreshToken,string authenticationCode);

        /// <summary>
        /// Delete all  Refresh Token data with authentication Code containing specified keyword
        /// </summary>
		/// <param name="authenticationCode"> Authentication Code</param>
		/// <returns>List of  Refresh Token</returns>
		[OperationContract]
		Stream DeleteByAuthenticationCode(string authenticationCode);

        /// <summary>
        /// Finds all  Refresh Token data with refresh Token String containing specified keyword
        /// </summary>
		/// <param name="refreshTokenString"> Refresh Token String</param>
		/// <returns>List of  Refresh Token</returns>
		[OperationContract]
		Stream FindByRefreshTokenString(string refreshTokenString);

        /// <summary>
        /// Updates  Refresh Token's refresh Token String which has specified idRefreshToken
        /// </summary>
		/// <param name="idRefreshToken">id Refresh Token</param>
		/// <param name="refreshTokenString">refresh Token String</param>
		/// <returns>List of  Refresh Token</returns>
		[OperationContract]
		Stream UpdateRefreshTokenString(string idRefreshToken,string refreshTokenString);

        /// <summary>
        /// Delete all  Refresh Token data with refresh Token String containing specified keyword
        /// </summary>
		/// <param name="refreshTokenString"> Refresh Token String</param>
		/// <returns>List of  Refresh Token</returns>
		[OperationContract]
		Stream DeleteByRefreshTokenString(string refreshTokenString);

        /// <summary>
        /// Finds all  Refresh Token with CreatedDate between CreatedDate1 and CreatedDate2
        /// </summary>
		/// <param name="createdDate1"> Created Date</param>
		/// <param name="createdDate2"> Created Date</param>
		/// <returns>List of  Refresh Token</returns>
		[OperationContract]
		Stream FindByCreatedDateBetween(string createdDate1,string createdDate2);

        /// <summary>
        /// Updates  Refresh Token's created Date which has specified idRefreshToken
        /// </summary>
		/// <param name="idRefreshToken">id Refresh Token</param>
		/// <param name="createdDate">created Date</param>
		/// <returns>List of  Refresh Token</returns>
		[OperationContract]
		Stream UpdateCreatedDate(string idRefreshToken,string createdDate);

        /// <summary>
        /// Delete all  Refresh Token data with created Date containing specified keyword
        /// </summary>
		/// <param name="createdDate"> Created Date</param>
		/// <returns>List of  Refresh Token</returns>
		[OperationContract]
		Stream DeleteByCreatedDate(string createdDate);

        /// <summary>
        /// Finds all  Refresh Token with ExpiredDate between ExpiredDate1 and ExpiredDate2
        /// </summary>
		/// <param name="expiredDate1"> Expired Date</param>
		/// <param name="expiredDate2"> Expired Date</param>
		/// <returns>List of  Refresh Token</returns>
		[OperationContract]
		Stream FindByExpiredDateBetween(string expiredDate1,string expiredDate2);

        /// <summary>
        /// Updates  Refresh Token's expired Date which has specified idRefreshToken
        /// </summary>
		/// <param name="idRefreshToken">id Refresh Token</param>
		/// <param name="expiredDate">expired Date</param>
		/// <returns>List of  Refresh Token</returns>
		[OperationContract]
		Stream UpdateExpiredDate(string idRefreshToken,string expiredDate);

        /// <summary>
        /// Delete all  Refresh Token data with expired Date containing specified keyword
        /// </summary>
		/// <param name="expiredDate"> Expired Date</param>
		/// <returns>List of  Refresh Token</returns>
		[OperationContract]
		Stream DeleteByExpiredDate(string expiredDate);
    
    }
}