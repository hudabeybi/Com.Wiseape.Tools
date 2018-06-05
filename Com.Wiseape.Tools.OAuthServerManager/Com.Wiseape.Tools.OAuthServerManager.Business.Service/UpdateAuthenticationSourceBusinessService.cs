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
    public class UpdateAuthenticationSourceBusinessService : BaseBusinessService<AuthenticationSource>, IUpdateAuthenticationSourceBusinessService
    {
        class Keywords
        {
            public static string UpdateAuthenticationSource = "Update.Tools.OAuthServerManager.AuthenticationSource";
        }
        
        public UpdateAuthenticationSourceBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public UpdateAuthenticationSourceBusinessService()
        {
            this.RepoKey = Keywords.UpdateAuthenticationSource;
        }


        /// <summary>
        /// Update  Authentication Source data with id Authentication Source, authentication Source Name
        /// </summary>
		/// <param name="idAuthenticationSource"> Id Authentication Source</param>
		/// <param name="authenticationSourceName"> Authentication Source Name</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateAuthenticationSourceName(Int16 idAuthenticationSource, string authenticationSourceName)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate AuthenticationSourceName
			ValidationResult validationResult = this.ValidateAuthenticationSourceName( idAuthenticationSource, authenticationSourceName );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateAuthenticationSourceName(idAuthenticationSource, authenticationSourceName);
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
		protected virtual ValidationResult ValidateAuthenticationSourceName(Int16 idAuthenticationSource, string authenticationSourceName)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateAuthenticationSource'. 
				//The validator factory will create the validator object based on its key.
				IAuthenticationSourceValidator validator = (IAuthenticationSourceValidator)ValidatorFactory.Create(Keywords.UpdateAuthenticationSource);
				
				//Execute validation process
				validationResult = validator.ValidateAuthenticationSourceName(idAuthenticationSource, authenticationSourceName);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update AuthenticationSourceName
		protected virtual OperationResult _UpdateAuthenticationSourceName(Int16 idAuthenticationSource, string authenticationSourceName)
		{
			//Create repository based on its Key name : 'Keywords.UpdateAuthenticationSource'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateAuthenticationSourceRepository repository = (IUpdateAuthenticationSourceRepository)RepositoryFactory.Create(Keywords.UpdateAuthenticationSource);
            try
            {
            	//Execute UpdateAuthenticationSourceName
                repository.UpdateAuthenticationSourceName(idAuthenticationSource, authenticationSourceName);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Authentication Source data with id Authentication Source, authentication Library
        /// </summary>
		/// <param name="idAuthenticationSource"> Id Authentication Source</param>
		/// <param name="authenticationLibrary"> Authentication Library</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateAuthenticationLibrary(Int16 idAuthenticationSource, string authenticationLibrary)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate AuthenticationLibrary
			ValidationResult validationResult = this.ValidateAuthenticationLibrary( idAuthenticationSource, authenticationLibrary );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateAuthenticationLibrary(idAuthenticationSource, authenticationLibrary);
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
		protected virtual ValidationResult ValidateAuthenticationLibrary(Int16 idAuthenticationSource, string authenticationLibrary)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateAuthenticationSource'. 
				//The validator factory will create the validator object based on its key.
				IAuthenticationSourceValidator validator = (IAuthenticationSourceValidator)ValidatorFactory.Create(Keywords.UpdateAuthenticationSource);
				
				//Execute validation process
				validationResult = validator.ValidateAuthenticationLibrary(idAuthenticationSource, authenticationLibrary);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update AuthenticationLibrary
		protected virtual OperationResult _UpdateAuthenticationLibrary(Int16 idAuthenticationSource, string authenticationLibrary)
		{
			//Create repository based on its Key name : 'Keywords.UpdateAuthenticationSource'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateAuthenticationSourceRepository repository = (IUpdateAuthenticationSourceRepository)RepositoryFactory.Create(Keywords.UpdateAuthenticationSource);
            try
            {
            	//Execute UpdateAuthenticationLibrary
                repository.UpdateAuthenticationLibrary(idAuthenticationSource, authenticationLibrary);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Authentication Source data with id Authentication Source, authentication Classname
        /// </summary>
		/// <param name="idAuthenticationSource"> Id Authentication Source</param>
		/// <param name="authenticationClassname"> Authentication Classname</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateAuthenticationClassname(Int16 idAuthenticationSource, string authenticationClassname)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate AuthenticationClassname
			ValidationResult validationResult = this.ValidateAuthenticationClassname( idAuthenticationSource, authenticationClassname );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateAuthenticationClassname(idAuthenticationSource, authenticationClassname);
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
		protected virtual ValidationResult ValidateAuthenticationClassname(Int16 idAuthenticationSource, string authenticationClassname)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateAuthenticationSource'. 
				//The validator factory will create the validator object based on its key.
				IAuthenticationSourceValidator validator = (IAuthenticationSourceValidator)ValidatorFactory.Create(Keywords.UpdateAuthenticationSource);
				
				//Execute validation process
				validationResult = validator.ValidateAuthenticationClassname(idAuthenticationSource, authenticationClassname);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update AuthenticationClassname
		protected virtual OperationResult _UpdateAuthenticationClassname(Int16 idAuthenticationSource, string authenticationClassname)
		{
			//Create repository based on its Key name : 'Keywords.UpdateAuthenticationSource'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateAuthenticationSourceRepository repository = (IUpdateAuthenticationSourceRepository)RepositoryFactory.Create(Keywords.UpdateAuthenticationSource);
            try
            {
            	//Execute UpdateAuthenticationClassname
                repository.UpdateAuthenticationClassname(idAuthenticationSource, authenticationClassname);
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