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
    public class OAuthSettingService : IOAuthSettingService
    {

        class Keywords
        {
            public static string OAuthSetting = "Tools.OAuthServerManager.OAuthSetting";
            public static string FindOAuthSetting = "Find.Tools.OAuthServerManager.OAuthSetting";
            public static string AddOAuthSetting = "Add.Tools.OAuthServerManager.OAuthSetting";
            public static string UpdateOAuthSetting = "Update.Tools.OAuthServerManager.OAuthSetting";
            public static string DeleteOAuthSetting = "Delete.Tools.OAuthServerManager.OAuthSetting";
        }

        /// <summary>
        /// Service to add OAuthSetting data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="OAuthSettingForm">OAuthSetting data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [WebInvoke(Method = "POST",
                    ResponseFormat = WebMessageFormat.Json,
                    RequestFormat = WebMessageFormat.Json,
                    UriTemplate = "oauthsetting/add")]
        public Stream AddOAuthSetting(OAuthSetting oAuthSettingForm)
        {
            BaseBusinessService<OAuthSetting> businessService = (BaseBusinessService<OAuthSetting>)BusinessFactory.Create(Keywords.AddOAuthSetting);
            OperationResult result = businessService.Add(oAuthSettingForm);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to update OAuthSetting data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="oAuthSettingForm">OAuthSetting data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [WebInvoke(Method = "POST",
                    ResponseFormat = WebMessageFormat.Json,
                    RequestFormat = WebMessageFormat.Json,
                    UriTemplate = "oauthsetting/update")]
        public Stream UpdateOAuthSetting(OAuthSetting oAuthSettingForm)
        {
            BaseBusinessService<OAuthSetting> businessService = (BaseBusinessService<OAuthSetting>)BusinessFactory.Create(Keywords.UpdateOAuthSetting);
            OperationResult result = businessService.Update(oAuthSettingForm);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to delete OAuthSetting data from data store. 
        /// The data deleted is defined by idOAuthSetting.
        /// This is a GET request.
        /// </summary>
        /// <param name="idOAuthSetting">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>  
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "oauthsetting/delete/{idOAuthSetting}")]
        public Stream DeleteOAuthSetting(string idOAuthSetting)
        {
            BaseBusinessService<OAuthSetting> businessService = (BaseBusinessService<OAuthSetting>)BusinessFactory.Create(Keywords.DeleteOAuthSetting);
            OperationResult result = businessService.Delete(idOAuthSetting);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to get a OAuthSetting data from data store. 
        /// The data retrieved is defined by idOAuthSetting.
        /// This is a GET request.
        /// </summary>
        /// <param name="idOAuthSetting">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>    
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "oauthsetting/get/{idOAuthSetting}")]
        public Stream GetOAuthSetting(string idOAuthSetting)
        {
            BaseBusinessService<OAuthSetting> businessService = (BaseBusinessService<OAuthSetting>)BusinessFactory.Create(Keywords.FindOAuthSetting);
            OperationResult result = businessService.Get(idOAuthSetting);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to get all the OAuthSetting data from data store. 
        /// The data items retrieved are those who contain the keyword given. 
        /// This is a GET request.
        /// </summary>
        /// <param name="keyword">the keyword to search</param>
        /// <param name="page">the page of the data navigation</param>
        /// <param name="max">the maximum amount of data to retrieve</param>
        /// <return>JSON string representation of operation result</return>    
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "oauthsetting/find/{keyword}/{page}/{max}")]
        public Stream FindOAuthSetting(string keyword, string page, string max)
        {
            BaseBusinessService<OAuthSetting> businessService = (BaseBusinessService<OAuthSetting>)BusinessFactory.Create(Keywords.FindOAuthSetting);

            SelectParam selectParam = new SelectParam();
            selectParam.Keyword = keyword;
            if (keyword.ToLower() == "all")
                selectParam.Keyword = "";
            OperationResult result = businessService.FindAll(selectParam, Convert.ToInt16(page), Convert.ToInt16(max) );

            return result.ToJsonStream();
        }	
        

        /// <summary>
        /// Finds all  O Auth Setting data with setting Key containing specified keyword
        /// </summary>
		/// <param name="settingKey"> Setting Key</param>
		/// <returns>List of  O Auth Setting</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "oauthsetting/find-by-setting-key/{settingKey}")]
        public Stream FindBySettingKey(string settingKey)
        {
            IFindOAuthSettingBusinessService businessService = (IFindOAuthSettingBusinessService)BusinessFactory.Create(Keywords.FindOAuthSetting);
            OperationResult result = businessService.FindBySettingKey(Convert.ToString(settingKey));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  O Auth Setting's setting Key which has specified idOAuthSetting
        /// </summary>
		/// <param name="idOAuthSetting">id O Auth Setting</param>
		/// <param name="settingKey">setting Key</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "oauthsetting/update-setting-key/{idOAuthSetting}/{settingKey}")]
        public Stream UpdateSettingKey(string idOAuthSetting,string settingKey)
        {
            IUpdateOAuthSettingBusinessService businessService = (IUpdateOAuthSettingBusinessService)BusinessFactory.Create(Keywords.UpdateOAuthSetting);
            OperationResult result = businessService.UpdateSettingKey(Convert.ToInt16(idOAuthSetting),Convert.ToString(settingKey) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  O Auth Setting data with setting Key containing specified keyword
        /// </summary>
		/// <param name="settingKey"> Setting Key</param>
		/// <returns>List of  O Auth Setting</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "oauthsetting/delete-by-setting-key/{settingKey}")]
        public Stream DeleteBySettingKey(string settingKey)
        {
            IDeleteOAuthSettingBusinessService businessService = (IDeleteOAuthSettingBusinessService)BusinessFactory.Create(Keywords.DeleteOAuthSetting);
            OperationResult result = businessService.DeleteBySettingKey(Convert.ToString(settingKey) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  O Auth Setting data with setting Value containing specified keyword
        /// </summary>
		/// <param name="settingValue"> Setting Value</param>
		/// <returns>List of  O Auth Setting</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "oauthsetting/find-by-setting-value/{settingValue}")]
        public Stream FindBySettingValue(string settingValue)
        {
            IFindOAuthSettingBusinessService businessService = (IFindOAuthSettingBusinessService)BusinessFactory.Create(Keywords.FindOAuthSetting);
            OperationResult result = businessService.FindBySettingValue(Convert.ToString(settingValue));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  O Auth Setting's setting Value which has specified idOAuthSetting
        /// </summary>
		/// <param name="idOAuthSetting">id O Auth Setting</param>
		/// <param name="settingValue">setting Value</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "oauthsetting/update-setting-value/{idOAuthSetting}/{settingValue}")]
        public Stream UpdateSettingValue(string idOAuthSetting,string settingValue)
        {
            IUpdateOAuthSettingBusinessService businessService = (IUpdateOAuthSettingBusinessService)BusinessFactory.Create(Keywords.UpdateOAuthSetting);
            OperationResult result = businessService.UpdateSettingValue(Convert.ToInt16(idOAuthSetting),Convert.ToString(settingValue) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  O Auth Setting data with setting Value containing specified keyword
        /// </summary>
		/// <param name="settingValue"> Setting Value</param>
		/// <returns>List of  O Auth Setting</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "oauthsetting/delete-by-setting-value/{settingValue}")]
        public Stream DeleteBySettingValue(string settingValue)
        {
            IDeleteOAuthSettingBusinessService businessService = (IDeleteOAuthSettingBusinessService)BusinessFactory.Create(Keywords.DeleteOAuthSetting);
            OperationResult result = businessService.DeleteBySettingValue(Convert.ToString(settingValue) );
            return result.ToJsonStream();
        }	
		
 
	}
}