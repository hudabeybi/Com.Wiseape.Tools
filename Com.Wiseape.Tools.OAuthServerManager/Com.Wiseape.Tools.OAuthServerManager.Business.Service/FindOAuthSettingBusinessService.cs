using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Framework;
using Com.Wiseape.Utility;
using Com.Wiseape.Factory;
using Com.Wiseape.Tools.Data.Model;
using Com.Wiseape.Tools.OAuthServerManager.Repository.Contract;
using Com.Wiseape.Tools.OAuthServerManager.Business.Contract;

namespace Com.Wiseape.Tools.OAuthServerManager.Business.Service
{
    /// <summary>
    /// Business Service for OAuthSetting module.
    /// </summary>
    public class FindOAuthSettingBusinessService : BaseBusinessService<OAuthSetting>, IFindOAuthSettingBusinessService
    {
        class Keywords
        {
            public static string FindOAuthSetting = "Find.Tools.OAuthServerManager.OAuthSetting";
        }
        
        public FindOAuthSettingBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public FindOAuthSettingBusinessService()
        {
            this.RepoKey = Keywords.FindOAuthSetting;
        }


        /// <summary>
        /// Finds all  O Auth Setting data with setting Key containing specified keyword
        /// </summary>
		/// <param name="settingKey"> Setting Key</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindBySettingKey(string settingKey)
		{
            IFindOAuthSettingRepository repository = (IFindOAuthSettingRepository)RepositoryFactory.Create(Keywords.FindOAuthSetting);
            try
            {
                List<OAuthSetting> res = repository.FindBySettingKey(settingKey);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  O Auth Setting data with setting Value containing specified keyword
        /// </summary>
		/// <param name="settingValue"> Setting Value</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindBySettingValue(string settingValue)
		{
            IFindOAuthSettingRepository repository = (IFindOAuthSettingRepository)RepositoryFactory.Create(Keywords.FindOAuthSetting);
            try
            {
                List<OAuthSetting> res = repository.FindBySettingValue(settingValue);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}



    }
 }