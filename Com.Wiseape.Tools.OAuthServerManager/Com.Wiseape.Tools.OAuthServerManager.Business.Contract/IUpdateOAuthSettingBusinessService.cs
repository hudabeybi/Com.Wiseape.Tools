using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Utility;
using Com.Wiseape.Tools.Data.Model;


namespace Com.Wiseape.Tools.OAuthServerManager.Business.Contract
{
    public interface IUpdateOAuthSettingBusinessService
    {

        /// <summary>
        /// Updates  O Auth Setting's setting Key which has specified idOAuthSetting
        /// </summary>
		/// <param name="idOAuthSetting">id O Auth Setting</param>
		/// <param name="settingKey">setting Key</param>
		/// <returns>List of  O Auth Setting</returns>
		OperationResult UpdateSettingKey(Int16 idOAuthSetting, string settingKey);

        /// <summary>
        /// Updates  O Auth Setting's setting Value which has specified idOAuthSetting
        /// </summary>
		/// <param name="idOAuthSetting">id O Auth Setting</param>
		/// <param name="settingValue">setting Value</param>
		/// <returns>List of  O Auth Setting</returns>
		OperationResult UpdateSettingValue(Int16 idOAuthSetting, string settingValue);

	}
}