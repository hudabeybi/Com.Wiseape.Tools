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
    /// Interface for AuthenticationCode Service
    /// </summary>
    [ServiceContract]
    public interface IAuthenticationCodeService
    {
    
        /// <summary>
        /// Service to add AuthenticationCode data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="AuthenticationCodeForm">AuthenticationCode data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [OperationContract]
        Stream AddAuthenticationCode(AuthenticationCode authenticationCodeForm);

        /// <summary>
        /// Service to update AuthenticationCode data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="authenticationCodeForm">AuthenticationCode data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [OperationContract]
        Stream UpdateAuthenticationCode(AuthenticationCode authenticationCodeForm);

        /// <summary>
        /// Service to delete AuthenticationCode data from data store. 
        /// The data deleted is defined by idAuthenticationCode.
        /// This is a GET request.
        /// </summary>
        /// <param name="idAuthenticationCode">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>  
        [OperationContract]
        Stream DeleteAuthenticationCode(string idAuthenticationCode);

        /// <summary>
        /// Service to get a AuthenticationCode data from data store. 
        /// The data retrieved is defined by idAuthenticationCode.
        /// This is a GET request.
        /// </summary>
        /// <param name="idAuthenticationCode">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>    
        [OperationContract]
       	Stream GetAuthenticationCode(string idAuthenticationCode);

        /// <summary>
        /// Service to get all the AuthenticationCode data from data store. 
        /// The data items retrieved are those who contain the keyword given. 
        /// This is a GET request.
        /// </summary>
        /// <param name="keyword">the keyword to search</param>
        /// <param name="page">the page of the data navigation</param>
        /// <param name="max">the maximum amount of data to retrieve</param>
        /// <return>JSON string representation of operation result</return>    
		[OperationContract]
        Stream FindAuthenticationCode(string keyword, string page, string max);	
        

        /// <summary>
        /// Finds all  Authentication Code data with authentication Code String containing specified keyword
        /// </summary>
		/// <param name="authenticationCodeString"> Authentication Code String</param>
		/// <returns>List of  Authentication Code</returns>
		[OperationContract]
		Stream FindByAuthenticationCodeString(string authenticationCodeString);

        /// <summary>
        /// Updates  Authentication Code's authentication Code String which has specified idAuthenticationCode
        /// </summary>
		/// <param name="idAuthenticationCode">id Authentication Code</param>
		/// <param name="authenticationCodeString">authentication Code String</param>
		/// <returns>List of  Authentication Code</returns>
		[OperationContract]
		Stream UpdateAuthenticationCodeString(string idAuthenticationCode,string authenticationCodeString);

        /// <summary>
        /// Delete all  Authentication Code data with authentication Code String containing specified keyword
        /// </summary>
		/// <param name="authenticationCodeString"> Authentication Code String</param>
		/// <returns>List of  Authentication Code</returns>
		[OperationContract]
		Stream DeleteByAuthenticationCodeString(string authenticationCodeString);

        /// <summary>
        /// Finds all  Authentication Code data with client I D containing specified keyword
        /// </summary>
		/// <param name="clientID"> Client I D</param>
		/// <returns>List of  Authentication Code</returns>
		[OperationContract]
		Stream FindByClientID(string clientID);

        /// <summary>
        /// Updates  Authentication Code's client I D which has specified idAuthenticationCode
        /// </summary>
		/// <param name="idAuthenticationCode">id Authentication Code</param>
		/// <param name="clientID">client I D</param>
		/// <returns>List of  Authentication Code</returns>
		[OperationContract]
		Stream UpdateClientID(string idAuthenticationCode,string clientID);

        /// <summary>
        /// Delete all  Authentication Code data with client I D containing specified keyword
        /// </summary>
		/// <param name="clientID"> Client I D</param>
		/// <returns>List of  Authentication Code</returns>
		[OperationContract]
		Stream DeleteByClientID(string clientID);

        /// <summary>
        /// Finds all  Authentication Code data with authorization Session I D containing specified keyword
        /// </summary>
		/// <param name="authorizationSessionID"> Authorization Session I D</param>
		/// <returns>List of  Authentication Code</returns>
		[OperationContract]
		Stream FindByAuthorizationSessionID(string authorizationSessionID);

        /// <summary>
        /// Updates  Authentication Code's authorization Session I D which has specified idAuthenticationCode
        /// </summary>
		/// <param name="idAuthenticationCode">id Authentication Code</param>
		/// <param name="authorizationSessionID">authorization Session I D</param>
		/// <returns>List of  Authentication Code</returns>
		[OperationContract]
		Stream UpdateAuthorizationSessionID(string idAuthenticationCode,string authorizationSessionID);

        /// <summary>
        /// Delete all  Authentication Code data with authorization Session I D containing specified keyword
        /// </summary>
		/// <param name="authorizationSessionID"> Authorization Session I D</param>
		/// <returns>List of  Authentication Code</returns>
		[OperationContract]
		Stream DeleteByAuthorizationSessionID(string authorizationSessionID);

        /// <summary>
        /// Finds all  Authentication Code with CreatedDate between CreatedDate1 and CreatedDate2
        /// </summary>
		/// <param name="createdDate1"> Created Date</param>
		/// <param name="createdDate2"> Created Date</param>
		/// <returns>List of  Authentication Code</returns>
		[OperationContract]
		Stream FindByCreatedDateBetween(string createdDate1,string createdDate2);

        /// <summary>
        /// Updates  Authentication Code's created Date which has specified idAuthenticationCode
        /// </summary>
		/// <param name="idAuthenticationCode">id Authentication Code</param>
		/// <param name="createdDate">created Date</param>
		/// <returns>List of  Authentication Code</returns>
		[OperationContract]
		Stream UpdateCreatedDate(string idAuthenticationCode,string createdDate);

        /// <summary>
        /// Delete all  Authentication Code data with created Date containing specified keyword
        /// </summary>
		/// <param name="createdDate"> Created Date</param>
		/// <returns>List of  Authentication Code</returns>
		[OperationContract]
		Stream DeleteByCreatedDate(string createdDate);

        /// <summary>
        /// Finds all  Authentication Code with ExpiredDate between ExpiredDate1 and ExpiredDate2
        /// </summary>
		/// <param name="expiredDate1"> Expired Date</param>
		/// <param name="expiredDate2"> Expired Date</param>
		/// <returns>List of  Authentication Code</returns>
		[OperationContract]
		Stream FindByExpiredDateBetween(string expiredDate1,string expiredDate2);

        /// <summary>
        /// Updates  Authentication Code's expired Date which has specified idAuthenticationCode
        /// </summary>
		/// <param name="idAuthenticationCode">id Authentication Code</param>
		/// <param name="expiredDate">expired Date</param>
		/// <returns>List of  Authentication Code</returns>
		[OperationContract]
		Stream UpdateExpiredDate(string idAuthenticationCode,string expiredDate);

        /// <summary>
        /// Delete all  Authentication Code data with expired Date containing specified keyword
        /// </summary>
		/// <param name="expiredDate"> Expired Date</param>
		/// <returns>List of  Authentication Code</returns>
		[OperationContract]
		Stream DeleteByExpiredDate(string expiredDate);
    
    }
}