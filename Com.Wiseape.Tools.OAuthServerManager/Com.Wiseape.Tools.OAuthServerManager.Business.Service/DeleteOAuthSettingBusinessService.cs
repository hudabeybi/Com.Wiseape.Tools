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
using Com.Wiseape.Tools.OAuthServerManager.View.Contract.Validator;

namespace Com.Wiseape.Tools.OAuthServerManager.Business.Service
{
    /// <summary>
    /// Business Service for OAuthSetting module.
    /// </summary>
    public class DeleteOAuthSettingBusinessService : BaseBusinessService<OAuthSetting>, IDeleteOAuthSettingBusinessService
    {
        class Keywords
        {
            public static string DeleteOAuthSetting = "Delete.Tools.OAuthServerManager.OAuthSetting";
        }
        
        public DeleteOAuthSettingBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public DeleteOAuthSettingBusinessService()
        {
            this.RepoKey = Keywords.DeleteOAuthSetting;
        }

        /// <summary>
        /// Delete  O Auth Setting data by setting Key
        /// </summary>
		/// <param name="settingKey"> Setting Key</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteBySettingKey(string settingKey)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate SettingKey
			ValidationResult validationResult = this.ValidateSettingKey( settingKey );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteBySettingKey(settingKey);
			}
			else
			{
				//Don't execute update, return validation result
				operationResult.Result = false;
				operationResult.Data = validationResult;
			}
			
			//Return result
			return operationResult;		
		}
		
		//Validate SettingKey
		protected virtual ValidationResult ValidateSettingKey(string settingKey)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateOAuthSetting'. 
				//The validator factory will create the validator object based on its key.
				IOAuthSettingValidator validator = (IOAuthSettingValidator)ValidatorFactory.Create(Keywords.DeleteOAuthSetting);
				
				//Execute validation process
				validationResult = validator.ValidateSettingKey(settingKey);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete SettingKey
		protected virtual OperationResult _DeleteBySettingKey(string settingKey)
		{
			//Create repository based on its Key name : 'Keywords.DeleteOAuthSetting'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteOAuthSettingRepository repository = (IDeleteOAuthSettingRepository)RepositoryFactory.Create(Keywords.DeleteOAuthSetting);
            try
            {
            	//Execute DeleteBySettingKey
                repository.DeleteBySettingKey(settingKey);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  O Auth Setting data by setting Value
        /// </summary>
		/// <param name="settingValue"> Setting Value</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteBySettingValue(string settingValue)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate SettingValue
			ValidationResult validationResult = this.ValidateSettingValue( settingValue );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteBySettingValue(settingValue);
			}
			else
			{
				//Don't execute update, return validation result
				operationResult.Result = false;
				operationResult.Data = validationResult;
			}
			
			//Return result
			return operationResult;		
		}
		
		//Validate SettingValue
		protected virtual ValidationResult ValidateSettingValue(string settingValue)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateOAuthSetting'. 
				//The validator factory will create the validator object based on its key.
				IOAuthSettingValidator validator = (IOAuthSettingValidator)ValidatorFactory.Create(Keywords.DeleteOAuthSetting);
				
				//Execute validation process
				validationResult = validator.ValidateSettingValue(settingValue);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete SettingValue
		protected virtual OperationResult _DeleteBySettingValue(string settingValue)
		{
			//Create repository based on its Key name : 'Keywords.DeleteOAuthSetting'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteOAuthSettingRepository repository = (IDeleteOAuthSettingRepository)RepositoryFactory.Create(Keywords.DeleteOAuthSetting);
            try
            {
            	//Execute DeleteBySettingValue
                repository.DeleteBySettingValue(settingValue);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}


    }
 }