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
    /// Interface for AuthenticationSession Service
    /// </summary>
    [ServiceContract]
    public interface IAuthenticationSessionService
    {
    
        /// <summary>
        /// Service to add AuthenticationSession data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="AuthenticationSessionForm">AuthenticationSession data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [OperationContract]
        Stream AddAuthenticationSession(AuthenticationSession authenticationSessionForm);

        /// <summary>
        /// Service to update AuthenticationSession data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="authenticationSessionForm">AuthenticationSession data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [OperationContract]
        Stream UpdateAuthenticationSession(AuthenticationSession authenticationSessionForm);

        /// <summary>
        /// Service to delete AuthenticationSession data from data store. 
        /// The data deleted is defined by idAuthenticationSession.
        /// This is a GET request.
        /// </summary>
        /// <param name="idAuthenticationSession">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>  
        [OperationContract]
        Stream DeleteAuthenticationSession(string idAuthenticationSession);

        /// <summary>
        /// Service to get a AuthenticationSession data from data store. 
        /// The data retrieved is defined by idAuthenticationSession.
        /// This is a GET request.
        /// </summary>
        /// <param name="idAuthenticationSession">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>    
        [OperationContract]
       	Stream GetAuthenticationSession(string idAuthenticationSession);

        /// <summary>
        /// Service to get all the AuthenticationSession data from data store. 
        /// The data items retrieved are those who contain the keyword given. 
        /// This is a GET request.
        /// </summary>
        /// <param name="keyword">the keyword to search</param>
        /// <param name="page">the page of the data navigation</param>
        /// <param name="max">the maximum amount of data to retrieve</param>
        /// <return>JSON string representation of operation result</return>    
		[OperationContract]
        Stream FindAuthenticationSession(string keyword, string page, string max);	
        

        /// <summary>
        /// Finds all  Authentication Session data with authentication Session String containing specified keyword
        /// </summary>
		/// <param name="authenticationSessionString"> Authentication Session String</param>
		/// <returns>List of  Authentication Session</returns>
		[OperationContract]
		Stream FindByAuthenticationSessionString(string authenticationSessionString);

        /// <summary>
        /// Updates  Authentication Session's authentication Session String which has specified idAuthenticationSession
        /// </summary>
		/// <param name="idAuthenticationSession">id Authentication Session</param>
		/// <param name="authenticationSessionString">authentication Session String</param>
		/// <returns>List of  Authentication Session</returns>
		[OperationContract]
		Stream UpdateAuthenticationSessionString(string idAuthenticationSession,string authenticationSessionString);

        /// <summary>
        /// Delete all  Authentication Session data with authentication Session String containing specified keyword
        /// </summary>
		/// <param name="authenticationSessionString"> Authentication Session String</param>
		/// <returns>List of  Authentication Session</returns>
		[OperationContract]
		Stream DeleteByAuthenticationSessionString(string authenticationSessionString);

        /// <summary>
        /// Finds all  Authentication Session data with client I D containing specified keyword
        /// </summary>
		/// <param name="clientID"> Client I D</param>
		/// <returns>List of  Authentication Session</returns>
		[OperationContract]
		Stream FindByClientID(string clientID);

        /// <summary>
        /// Updates  Authentication Session's client I D which has specified idAuthenticationSession
        /// </summary>
		/// <param name="idAuthenticationSession">id Authentication Session</param>
		/// <param name="clientID">client I D</param>
		/// <returns>List of  Authentication Session</returns>
		[OperationContract]
		Stream UpdateClientID(string idAuthenticationSession,string clientID);

        /// <summary>
        /// Delete all  Authentication Session data with client I D containing specified keyword
        /// </summary>
		/// <param name="clientID"> Client I D</param>
		/// <returns>List of  Authentication Session</returns>
		[OperationContract]
		Stream DeleteByClientID(string clientID);

        /// <summary>
        /// Finds all  Authentication Session with SessionCreatedDate between SessionCreatedDate1 and SessionCreatedDate2
        /// </summary>
		/// <param name="sessionCreatedDate1"> Session Created Date</param>
		/// <param name="sessionCreatedDate2"> Session Created Date</param>
		/// <returns>List of  Authentication Session</returns>
		[OperationContract]
		Stream FindBySessionCreatedDateBetween(string sessionCreatedDate1,string sessionCreatedDate2);

        /// <summary>
        /// Updates  Authentication Session's session Created Date which has specified idAuthenticationSession
        /// </summary>
		/// <param name="idAuthenticationSession">id Authentication Session</param>
		/// <param name="sessionCreatedDate">session Created Date</param>
		/// <returns>List of  Authentication Session</returns>
		[OperationContract]
		Stream UpdateSessionCreatedDate(string idAuthenticationSession,string sessionCreatedDate);

        /// <summary>
        /// Delete all  Authentication Session data with session Created Date containing specified keyword
        /// </summary>
		/// <param name="sessionCreatedDate"> Session Created Date</param>
		/// <returns>List of  Authentication Session</returns>
		[OperationContract]
		Stream DeleteBySessionCreatedDate(string sessionCreatedDate);

        /// <summary>
        /// Finds all  Authentication Session with SessionExpiredDate between SessionExpiredDate1 and SessionExpiredDate2
        /// </summary>
		/// <param name="sessionExpiredDate1"> Session Expired Date</param>
		/// <param name="sessionExpiredDate2"> Session Expired Date</param>
		/// <returns>List of  Authentication Session</returns>
		[OperationContract]
		Stream FindBySessionExpiredDateBetween(string sessionExpiredDate1,string sessionExpiredDate2);

        /// <summary>
        /// Updates  Authentication Session's session Expired Date which has specified idAuthenticationSession
        /// </summary>
		/// <param name="idAuthenticationSession">id Authentication Session</param>
		/// <param name="sessionExpiredDate">session Expired Date</param>
		/// <returns>List of  Authentication Session</returns>
		[OperationContract]
		Stream UpdateSessionExpiredDate(string idAuthenticationSession,string sessionExpiredDate);

        /// <summary>
        /// Delete all  Authentication Session data with session Expired Date containing specified keyword
        /// </summary>
		/// <param name="sessionExpiredDate"> Session Expired Date</param>
		/// <returns>List of  Authentication Session</returns>
		[OperationContract]
		Stream DeleteBySessionExpiredDate(string sessionExpiredDate);
    
    }
}