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
    /// Repository for UpdateOAuthSetting data.
    /// </summary>
    public class UpdateOAuthSettingRepository : BaseRepository<OAuthSetting>, IUpdateOAuthSettingRepository
    {
        class Keywords
        {
            public static string UpdateOAuthSetting = "Update.Tools.OAuthServerManager.OAuthSetting";
        }

        /// <summary>
        /// Constructor for OAuthSettingRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public UpdateOAuthSettingRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public UpdateOAuthSettingRepository()
        {
            this.DataContextKey = Keywords.UpdateOAuthSetting;
        }


//-------------------------- Update columns by Primary key -----------------------------------------

        /// <summary>
        /// Updates  O Auth Setting's id O Auth Setting, setting Key by idOAuthSetting
        /// </summary>
		/// <param name="idOAuthSetting">id O Auth Setting</param>
		/// <param name="settingKey">setting Key</param>
		/// <returns>List of  O Auth Setting</returns>
        public void UpdateSettingKey(Int16 idOAuthSetting, string settingKey)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.OAuthSettings
                       where
                       		o.IdOAuthSetting == idOAuthSetting
                       	select o;
           	list.ToList().ForEach(o => {
      			o.SettingKey = settingKey;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  O Auth Setting's id O Auth Setting, setting Value by idOAuthSetting
        /// </summary>
		/// <param name="idOAuthSetting">id O Auth Setting</param>
		/// <param name="settingValue">setting Value</param>
		/// <returns>List of  O Auth Setting</returns>
        public void UpdateSettingValue(Int16 idOAuthSetting, string settingValue)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.OAuthSettings
                       where
                       		o.IdOAuthSetting == idOAuthSetting
                       	select o;
           	list.ToList().ForEach(o => {
      			o.SettingValue = settingValue;	
            });
            dataContext.SaveChanges();
        }


//-------------------------- Update foreign keys -----------------------------------------


    }
}
