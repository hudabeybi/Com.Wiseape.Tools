using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Tools.Data.Model;



namespace Com.Wiseape.Tools.OAuthServerManager.Repository.Contract
{
    public interface IFindOAuthSettingRepository
    {

        /// <summary>
        /// Finds all  O Auth Setting data with setting Key containing specified keyword
        /// </summary>
		/// <param name="settingKey"> Setting Key</param>
		/// <returns>List of  O Auth Setting</returns>
		List<OAuthSetting> FindBySettingKey(string settingKey);

        /// <summary>
        /// Finds all  O Auth Setting data with setting Value containing specified keyword
        /// </summary>
		/// <param name="settingValue"> Setting Value</param>
		/// <returns>List of  O Auth Setting</returns>
		List<OAuthSetting> FindBySettingValue(string settingValue);

    }
}

