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
    public class DeleteOAuthSettingRepository : BaseRepository<OAuthSetting>, IDeleteOAuthSettingRepository
    {
        class Keywords
        {
            public static string DeleteOAuthSetting = "Delete.Tools.OAuthServerManager.OAuthSetting";
        }

        /// <summary>
        /// Constructor for DeleteOAuthSettingRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public DeleteOAuthSettingRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public DeleteOAuthSettingRepository()
        {
            this.DataContextKey = Keywords.DeleteOAuthSetting;
        }

//------------------- Delete by keywords --------------------------------------------------------

        /// <summary>
        /// Delete all  O Auth Setting data with setting Key containing specified keyword
        /// </summary>
		/// <param name="settingKey"> Setting Key</param>
		/// <returns>List of  O Auth Setting</returns>
        public void DeleteBySettingKey(string settingKey)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.OAuthSettings
                       where
							o.SettingKey.Contains(settingKey) 						
						select o;
			dataContext.OAuthSettings.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  O Auth Setting data with setting Value containing specified keyword
        /// </summary>
		/// <param name="settingValue"> Setting Value</param>
		/// <returns>List of  O Auth Setting</returns>
        public void DeleteBySettingValue(string settingValue)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.OAuthSettings
                       where
							o.SettingValue.Contains(settingValue) 						
						select o;
			dataContext.OAuthSettings.RemoveRange(list);
            dataContext.SaveChanges();
        }


//-----------------------  Delete by Foreign keys ---------------------------------------


    }
}
