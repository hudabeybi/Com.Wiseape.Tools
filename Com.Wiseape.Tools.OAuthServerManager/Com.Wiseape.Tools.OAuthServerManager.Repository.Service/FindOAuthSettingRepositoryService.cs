using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Framework;
using Com.Wiseape.Tools.Data.Model;
using Com.Wiseape.Tools.Data.Context;
using Com.Wiseape.Tools.OAuthServerManager.Repository.Contract;

namespace Com.Wiseape.Tools.OAuthServerManager.Repository.Service
{
    /// <summary>
    /// Repository for OAuthSetting data.
    /// </summary>
    public class FindOAuthSettingRepository : BaseRepository<OAuthSetting>, IFindOAuthSettingRepository
    {
        class Keywords
        {
            public static string FindOAuthSetting = "Find.Tools.OAuthServerManager.OAuthSetting";
        }

        /// <summary>
        /// Constructor for OAuthSettingRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public FindOAuthSettingRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public FindOAuthSettingRepository()
        {
            this.DataContextKey = Keywords.FindOAuthSetting;
        }

//------------------- Find by keywords --------------------------------------------------------

        /// <summary>
        /// Finds all  O Auth Setting data with setting Key containing specified keyword
        /// </summary>
		/// <param name="settingKey"> Setting Key</param>
		/// <returns>List of  O Auth Setting</returns>
        public List<OAuthSetting> FindBySettingKey(string settingKey)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.OAuthSettings
                       where
							o.SettingKey.Contains(settingKey) 						
						select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  O Auth Setting data with setting Value containing specified keyword
        /// </summary>
		/// <param name="settingValue"> Setting Value</param>
		/// <returns>List of  O Auth Setting</returns>
        public List<OAuthSetting> FindBySettingValue(string settingValue)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.OAuthSettings
                       where
							o.SettingValue.Contains(settingValue) 						
						select o;
            return list.ToList();
        }


//----------------------  find by dates -----------------------------------------------


//-----------------------  Find by Foreign keys ---------------------------------------




    }
}
