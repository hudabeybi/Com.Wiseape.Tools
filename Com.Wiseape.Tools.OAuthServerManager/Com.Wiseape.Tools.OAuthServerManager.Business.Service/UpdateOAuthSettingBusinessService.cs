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
    public class UpdateOAuthSettingBusinessService : BaseBusinessService<OAuthSetting>, IUpdateOAuthSettingBusinessService
    {
        class Keywords
        {
            public static string UpdateOAuthSetting = "Update.Tools.OAuthServerManager.OAuthSetting";
        }
        
        public UpdateOAuthSettingBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public UpdateOAuthSettingBusinessService()
        {
            this.RepoKey = Keywords.UpdateOAuthSetting;
        }


        /// <summary>
        /// Update  O Auth Setting data with id O Auth Setting, setting Key
        /// </summary>
		/// <param name="idOAuthSetting"> Id O Auth Setting</param>
		/// <param name="settingKey"> Setting Key</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateSettingKey(Int16 idOAuthSetting, string settingKey)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate SettingKey
			ValidationResult validationResult = this.ValidateSettingKey( idOAuthSetting, settingKey );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateSettingKey(idOAuthSetting, settingKey);
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
		protected virtual ValidationResult ValidateSettingKey(Int16 idOAuthSetting, string settingKey)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateOAuthSetting'. 
				//The validator factory will create the validator object based on its key.
				IOAuthSettingValidator validator = (IOAuthSettingValidator)ValidatorFactory.Create(Keywords.UpdateOAuthSetting);
				
				//Execute validation process
				validationResult = validator.ValidateSettingKey(idOAuthSetting, settingKey);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update SettingKey
		protected virtual OperationResult _UpdateSettingKey(Int16 idOAuthSetting, string settingKey)
		{
			//Create repository based on its Key name : 'Keywords.UpdateOAuthSetting'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateOAuthSettingRepository repository = (IUpdateOAuthSettingRepository)RepositoryFactory.Create(Keywords.UpdateOAuthSetting);
            try
            {
            	//Execute UpdateSettingKey
                repository.UpdateSettingKey(idOAuthSetting, settingKey);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  O Auth Setting data with id O Auth Setting, setting Value
        /// </summary>
		/// <param name="idOAuthSetting"> Id O Auth Setting</param>
		/// <param name="settingValue"> Setting Value</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateSettingValue(Int16 idOAuthSetting, string settingValue)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate SettingValue
			ValidationResult validationResult = this.ValidateSettingValue( idOAuthSetting, settingValue );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateSettingValue(idOAuthSetting, settingValue);
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
		protected virtual ValidationResult ValidateSettingValue(Int16 idOAuthSetting, string settingValue)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateOAuthSetting'. 
				//The validator factory will create the validator object based on its key.
				IOAuthSettingValidator validator = (IOAuthSettingValidator)ValidatorFactory.Create(Keywords.UpdateOAuthSetting);
				
				//Execute validation process
				validationResult = validator.ValidateSettingValue(idOAuthSetting, settingValue);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update SettingValue
		protected virtual OperationResult _UpdateSettingValue(Int16 idOAuthSetting, string settingValue)
		{
			//Create repository based on its Key name : 'Keywords.UpdateOAuthSetting'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateOAuthSettingRepository repository = (IUpdateOAuthSettingRepository)RepositoryFactory.Create(Keywords.UpdateOAuthSetting);
            try
            {
            	//Execute UpdateSettingValue
                repository.UpdateSettingValue(idOAuthSetting, settingValue);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}


    }
 }