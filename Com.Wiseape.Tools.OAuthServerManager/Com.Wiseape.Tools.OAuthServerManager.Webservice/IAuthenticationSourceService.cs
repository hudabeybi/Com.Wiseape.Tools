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
    /// Interface for AuthenticationSource Service
    /// </summary>
    [ServiceContract]
    public interface IAuthenticationSourceService
    {
    
        /// <summary>
        /// Service to add AuthenticationSource data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="AuthenticationSourceForm">AuthenticationSource data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [OperationContract]
        Stream AddAuthenticationSource(AuthenticationSource authenticationSourceForm);

        /// <summary>
        /// Service to update AuthenticationSource data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="authenticationSourceForm">AuthenticationSource data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [OperationContract]
        Stream UpdateAuthenticationSource(AuthenticationSource authenticationSourceForm);

        /// <summary>
        /// Service to delete AuthenticationSource data from data store. 
        /// The data deleted is defined by idAuthenticationSource.
        /// This is a GET request.
        /// </summary>
        /// <param name="idAuthenticationSource">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>  
        [OperationContract]
        Stream DeleteAuthenticationSource(string idAuthenticationSource);

        /// <summary>
        /// Service to get a AuthenticationSource data from data store. 
        /// The data retrieved is defined by idAuthenticationSource.
        /// This is a GET request.
        /// </summary>
        /// <param name="idAuthenticationSource">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>    
        [OperationContract]
       	Stream GetAuthenticationSource(string idAuthenticationSource);

        /// <summary>
        /// Service to get all the AuthenticationSource data from data store. 
        /// The data items retrieved are those who contain the keyword given. 
        /// This is a GET request.
        /// </summary>
        /// <param name="keyword">the keyword to search</param>
        /// <param name="page">the page of the data navigation</param>
        /// <param name="max">the maximum amount of data to retrieve</param>
        /// <return>JSON string representation of operation result</return>    
		[OperationContract]
        Stream FindAuthenticationSource(string keyword, string page, string max);	
        

        /// <summary>
        /// Finds all  Authentication Source data with authentication Source Name containing specified keyword
        /// </summary>
		/// <param name="authenticationSourceName"> Authentication Source Name</param>
		/// <returns>List of  Authentication Source</returns>
		[OperationContract]
		Stream FindByAuthenticationSourceName(string authenticationSourceName);

        /// <summary>
        /// Updates  Authentication Source's authentication Source Name which has specified idAuthenticationSource
        /// </summary>
		/// <param name="idAuthenticationSource">id Authentication Source</param>
		/// <param name="authenticationSourceName">authentication Source Name</param>
		/// <returns>List of  Authentication Source</returns>
		[OperationContract]
		Stream UpdateAuthenticationSourceName(string idAuthenticationSource,string authenticationSourceName);

        /// <summary>
        /// Delete all  Authentication Source data with authentication Source Name containing specified keyword
        /// </summary>
		/// <param name="authenticationSourceName"> Authentication Source Name</param>
		/// <returns>List of  Authentication Source</returns>
		[OperationContract]
		Stream DeleteByAuthenticationSourceName(string authenticationSourceName);

        /// <summary>
        /// Finds all  Authentication Source data with authentication Library containing specified keyword
        /// </summary>
		/// <param name="authenticationLibrary"> Authentication Library</param>
		/// <returns>List of  Authentication Source</returns>
		[OperationContract]
		Stream FindByAuthenticationLibrary(string authenticationLibrary);

        /// <summary>
        /// Updates  Authentication Source's authentication Library which has specified idAuthenticationSource
        /// </summary>
		/// <param name="idAuthenticationSource">id Authentication Source</param>
		/// <param name="authenticationLibrary">authentication Library</param>
		/// <returns>List of  Authentication Source</returns>
		[OperationContract]
		Stream UpdateAuthenticationLibrary(string idAuthenticationSource,string authenticationLibrary);

        /// <summary>
        /// Delete all  Authentication Source data with authentication Library containing specified keyword
        /// </summary>
		/// <param name="authenticationLibrary"> Authentication Library</param>
		/// <returns>List of  Authentication Source</returns>
		[OperationContract]
		Stream DeleteByAuthenticationLibrary(string authenticationLibrary);

        /// <summary>
        /// Finds all  Authentication Source data with authentication Classname containing specified keyword
        /// </summary>
		/// <param name="authenticationClassname"> Authentication Classname</param>
		/// <returns>List of  Authentication Source</returns>
		[OperationContract]
		Stream FindByAuthenticationClassname(string authenticationClassname);

        /// <summary>
        /// Updates  Authentication Source's authentication Classname which has specified idAuthenticationSource
        /// </summary>
		/// <param name="idAuthenticationSource">id Authentication Source</param>
		/// <param name="authenticationClassname">authentication Classname</param>
		/// <returns>List of  Authentication Source</returns>
		[OperationContract]
		Stream UpdateAuthenticationClassname(string idAuthenticationSource,string authenticationClassname);

        /// <summary>
        /// Delete all  Authentication Source data with authentication Classname containing specified keyword
        /// </summary>
		/// <param name="authenticationClassname"> Authentication Classname</param>
		/// <returns>List of  Authentication Source</returns>
		[OperationContract]
		Stream DeleteByAuthenticationClassname(string authenticationClassname);
    
    }
}