using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Tools.Data.Model;



namespace Com.Wiseape.Tools.OAuthServerManager.Repository.Contract
{
    public interface IUpdateOAuthSettingRepository
    {

	    /// <summary>
	    /// Updates  O Auth Setting's id O Auth Setting, setting Key by idOAuthSetting
	    /// </summary>
		/// <param name="idOAuthSetting">id O Auth Setting</param>
		/// <param name="settingKey">setting Key</param>
		/// <returns>List of  O Auth Setting</returns>
		void UpdateSettingKey(Int16 idOAuthSetting, string settingKey);
	
	    /// <summary>
	    /// Updates  O Auth Setting's id O Auth Setting, setting Value by idOAuthSetting
	    /// </summary>
		/// <param name="idOAuthSetting">id O Auth Setting</param>
		/// <param name="settingValue">setting Value</param>
		/// <returns>List of  O Auth Setting</returns>
		void UpdateSettingValue(Int16 idOAuthSetting, string settingValue);
	
    }
}

