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
    /// Business Service for AuthenticationSource module.
    /// </summary>
    public class DeleteAuthenticationSourceBusinessService : BaseBusinessService<AuthenticationSource>, IDeleteAuthenticationSourceBusinessService
    {
        class Keywords
        {
            public static string DeleteAuthenticationSource = "Delete.Tools.OAuthServerManager.AuthenticationSource";
        }
        
        public DeleteAuthenticationSourceBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public DeleteAuthenticationSourceBusinessService()
        {
            this.RepoKey = Keywords.DeleteAuthenticationSource;
        }

        /// <summary>
        /// Delete  Authentication Source data by authentication Source Name
        /// </summary>
		/// <param name="authenticationSourceName"> Authentication Source Name</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByAuthenticationSourceName(string authenticationSourceName)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate AuthenticationSourceName
			ValidationResult validationResult = this.ValidateAuthenticationSourceName( authenticationSourceName );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByAuthenticationSourceName(authenticationSourceName);
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
		
		//Validate AuthenticationSourceName
		protected virtual ValidationResult ValidateAuthenticationSourceName(string authenticationSourceName)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateAuthenticationSource'. 
				//The validator factory will create the validator object based on its key.
				IAuthenticationSourceValidator validator = (IAuthenticationSourceValidator)ValidatorFactory.Create(Keywords.DeleteAuthenticationSource);
				
				//Execute validation process
				validationResult = validator.ValidateAuthenticationSourceName(authenticationSourceName);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete AuthenticationSourceName
		protected virtual OperationResult _DeleteByAuthenticationSourceName(string authenticationSourceName)
		{
			//Create repository based on its Key name : 'Keywords.DeleteAuthenticationSource'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteAuthenticationSourceRepository repository = (IDeleteAuthenticationSourceRepository)RepositoryFactory.Create(Keywords.DeleteAuthenticationSource);
            try
            {
            	//Execute DeleteByAuthenticationSourceName
                repository.DeleteByAuthenticationSourceName(authenticationSourceName);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  Authentication Source data by authentication Library
        /// </summary>
		/// <param name="authenticationLibrary"> Authentication Library</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByAuthenticationLibrary(string authenticationLibrary)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate AuthenticationLibrary
			ValidationResult validationResult = this.ValidateAuthenticationLibrary( authenticationLibrary );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByAuthenticationLibrary(authenticationLibrary);
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
		
		//Validate AuthenticationLibrary
		protected virtual ValidationResult ValidateAuthenticationLibrary(string authenticationLibrary)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateAuthenticationSource'. 
				//The validator factory will create the validator object based on its key.
				IAuthenticationSourceValidator validator = (IAuthenticationSourceValidator)ValidatorFactory.Create(Keywords.DeleteAuthenticationSource);
				
				//Execute validation process
				validationResult = validator.ValidateAuthenticationLibrary(authenticationLibrary);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete AuthenticationLibrary
		protected virtual OperationResult _DeleteByAuthenticationLibrary(string authenticationLibrary)
		{
			//Create repository based on its Key name : 'Keywords.DeleteAuthenticationSource'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteAuthenticationSourceRepository repository = (IDeleteAuthenticationSourceRepository)RepositoryFactory.Create(Keywords.DeleteAuthenticationSource);
            try
            {
            	//Execute DeleteByAuthenticationLibrary
                repository.DeleteByAuthenticationLibrary(authenticationLibrary);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  Authentication Source data by authentication Classname
        /// </summary>
		/// <param name="authenticationClassname"> Authentication Classname</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByAuthenticationClassname(string authenticationClassname)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate AuthenticationClassname
			ValidationResult validationResult = this.ValidateAuthenticationClassname( authenticationClassname );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByAuthenticationClassname(authenticationClassname);
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
		
		//Validate AuthenticationClassname
		protected virtual ValidationResult ValidateAuthenticationClassname(string authenticationClassname)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateAuthenticationSource'. 
				//The validator factory will create the validator object based on its key.
				IAuthenticationSourceValidator validator = (IAuthenticationSourceValidator)ValidatorFactory.Create(Keywords.DeleteAuthenticationSource);
				
				//Execute validation process
				validationResult = validator.ValidateAuthenticationClassname(authenticationClassname);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete AuthenticationClassname
		protected virtual OperationResult _DeleteByAuthenticationClassname(string authenticationClassname)
		{
			//Create repository based on its Key name : 'Keywords.DeleteAuthenticationSource'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteAuthenticationSourceRepository repository = (IDeleteAuthenticationSourceRepository)RepositoryFactory.Create(Keywords.DeleteAuthenticationSource);
            try
            {
            	//Execute DeleteByAuthenticationClassname
                repository.DeleteByAuthenticationClassname(authenticationClassname);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}


    }
 }