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
    /// Interface for OAuthSetting Service
    /// </summary>
    [ServiceContract]
    public interface IOAuthSettingService
    {
    
        /// <summary>
        /// Service to add OAuthSetting data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="OAuthSettingForm">OAuthSetting data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [OperationContract]
        Stream AddOAuthSetting(OAuthSetting oAuthSettingForm);

        /// <summary>
        /// Service to update OAuthSetting data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="oAuthSettingForm">OAuthSetting data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [OperationContract]
        Stream UpdateOAuthSetting(OAuthSetting oAuthSettingForm);

        /// <summary>
        /// Service to delete OAuthSetting data from data store. 
        /// The data deleted is defined by idOAuthSetting.
        /// This is a GET request.
        /// </summary>
        /// <param name="idOAuthSetting">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>  
        [OperationContract]
        Stream DeleteOAuthSetting(string idOAuthSetting);

        /// <summary>
        /// Service to get a OAuthSetting data from data store. 
        /// The data retrieved is defined by idOAuthSetting.
        /// This is a GET request.
        /// </summary>
        /// <param name="idOAuthSetting">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>    
        [OperationContract]
       	Stream GetOAuthSetting(string idOAuthSetting);

        /// <summary>
        /// Service to get all the OAuthSetting data from data store. 
        /// The data items retrieved are those who contain the keyword given. 
        /// This is a GET request.
        /// </summary>
        /// <param name="keyword">the keyword to search</param>
        /// <param name="page">the page of the data navigation</param>
        /// <param name="max">the maximum amount of data to retrieve</param>
        /// <return>JSON string representation of operation result</return>    
		[OperationContract]
        Stream FindOAuthSetting(string keyword, string page, string max);	
        

        /// <summary>
        /// Finds all  O Auth Setting data with setting Key containing specified keyword
        /// </summary>
		/// <param name="settingKey"> Setting Key</param>
		/// <returns>List of  O Auth Setting</returns>
		[OperationContract]
		Stream FindBySettingKey(string settingKey);

        /// <summary>
        /// Updates  O Auth Setting's setting Key which has specified idOAuthSetting
        /// </summary>
		/// <param name="idOAuthSetting">id O Auth Setting</param>
		/// <param name="settingKey">setting Key</param>
		/// <returns>List of  O Auth Setting</returns>
		[OperationContract]
		Stream UpdateSettingKey(string idOAuthSetting,string settingKey);

        /// <summary>
        /// Delete all  O Auth Setting data with setting Key containing specified keyword
        /// </summary>
		/// <param name="settingKey"> Setting Key</param>
		/// <returns>List of  O Auth Setting</returns>
		[OperationContract]
		Stream DeleteBySettingKey(string settingKey);

        /// <summary>
        /// Finds all  O Auth Setting data with setting Value containing specified keyword
        /// </summary>
		/// <param name="settingValue"> Setting Value</param>
		/// <returns>List of  O Auth Setting</returns>
		[OperationContract]
		Stream FindBySettingValue(string settingValue);

        /// <summary>
        /// Updates  O Auth Setting's setting Value which has specified idOAuthSetting
        /// </summary>
		/// <param name="idOAuthSetting">id O Auth Setting</param>
		/// <param name="settingValue">setting Value</param>
		/// <returns>List of  O Auth Setting</returns>
		[OperationContract]
		Stream UpdateSettingValue(string idOAuthSetting,string settingValue);

        /// <summary>
        /// Delete all  O Auth Setting data with setting Value containing specified keyword
        /// </summary>
		/// <param name="settingValue"> Setting Value</param>
		/// <returns>List of  O Auth Setting</returns>
		[OperationContract]
		Stream DeleteBySettingValue(string settingValue);
    
    }
}