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
    /// Business Service for AuthenticationCode module.
    /// </summary>
    public class UpdateAuthenticationCodeBusinessService : BaseBusinessService<AuthenticationCode>, IUpdateAuthenticationCodeBusinessService
    {
        class Keywords
        {
            public static string UpdateAuthenticationCode = "Update.Tools.OAuthServerManager.AuthenticationCode";
        }
        
        public UpdateAuthenticationCodeBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public UpdateAuthenticationCodeBusinessService()
        {
            this.RepoKey = Keywords.UpdateAuthenticationCode;
        }


        /// <summary>
        /// Update  Authentication Code data with id Authentication Code, authentication Code String
        /// </summary>
		/// <param name="idAuthenticationCode"> Id Authentication Code</param>
		/// <param name="authenticationCodeString"> Authentication Code String</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateAuthenticationCodeString(Int64 idAuthenticationCode, string authenticationCodeString)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate AuthenticationCodeString
			ValidationResult validationResult = this.ValidateAuthenticationCodeString( idAuthenticationCode, authenticationCodeString );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateAuthenticationCodeString(idAuthenticationCode, authenticationCodeString);
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
		
		//Validate AuthenticationCodeString
		protected virtual ValidationResult ValidateAuthenticationCodeString(Int64 idAuthenticationCode, string authenticationCodeString)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateAuthenticationCode'. 
				//The validator factory will create the validator object based on its key.
				IAuthenticationCodeValidator validator = (IAuthenticationCodeValidator)ValidatorFactory.Create(Keywords.UpdateAuthenticationCode);
				
				//Execute validation process
				validationResult = validator.ValidateAuthenticationCodeString(idAuthenticationCode, authenticationCodeString);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update AuthenticationCodeString
		protected virtual OperationResult _UpdateAuthenticationCodeString(Int64 idAuthenticationCode, string authenticationCodeString)
		{
			//Create repository based on its Key name : 'Keywords.UpdateAuthenticationCode'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateAuthenticationCodeRepository repository = (IUpdateAuthenticationCodeRepository)RepositoryFactory.Create(Keywords.UpdateAuthenticationCode);
            try
            {
            	//Execute UpdateAuthenticationCodeString
                repository.UpdateAuthenticationCodeString(idAuthenticationCode, authenticationCodeString);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Authentication Code data with id Authentication Code, client I D
        /// </summary>
		/// <param name="idAuthenticationCode"> Id Authentication Code</param>
		/// <param name="clientID"> Client I D</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateClientID(Int64 idAuthenticationCode, string clientID)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate ClientID
			ValidationResult validationResult = this.ValidateClientID( idAuthenticationCode, clientID );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateClientID(idAuthenticationCode, clientID);
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
		
		//Validate ClientID
		protected virtual ValidationResult ValidateClientID(Int64 idAuthenticationCode, string clientID)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateAuthenticationCode'. 
				//The validator factory will create the validator object based on its key.
				IAuthenticationCodeValidator validator = (IAuthenticationCodeValidator)ValidatorFactory.Create(Keywords.UpdateAuthenticationCode);
				
				//Execute validation process
				validationResult = validator.ValidateClientID(idAuthenticationCode, clientID);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update ClientID
		protected virtual OperationResult _UpdateClientID(Int64 idAuthenticationCode, string clientID)
		{
			//Create repository based on its Key name : 'Keywords.UpdateAuthenticationCode'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateAuthenticationCodeRepository repository = (IUpdateAuthenticationCodeRepository)RepositoryFactory.Create(Keywords.UpdateAuthenticationCode);
            try
            {
            	//Execute UpdateClientID
                repository.UpdateClientID(idAuthenticationCode, clientID);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Authentication Code data with id Authentication Code, authorization Session I D
        /// </summary>
		/// <param name="idAuthenticationCode"> Id Authentication Code</param>
		/// <param name="authorizationSessionID"> Authorization Session I D</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateAuthorizationSessionID(Int64 idAuthenticationCode, string authorizationSessionID)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate AuthorizationSessionID
			ValidationResult validationResult = this.ValidateAuthorizationSessionID( idAuthenticationCode, authorizationSessionID );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateAuthorizationSessionID(idAuthenticationCode, authorizationSessionID);
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
		
		//Validate AuthorizationSessionID
		protected virtual ValidationResult ValidateAuthorizationSessionID(Int64 idAuthenticationCode, string authorizationSessionID)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateAuthenticationCode'. 
				//The validator factory will create the validator object based on its key.
				IAuthenticationCodeValidator validator = (IAuthenticationCodeValidator)ValidatorFactory.Create(Keywords.UpdateAuthenticationCode);
				
				//Execute validation process
				validationResult = validator.ValidateAuthorizationSessionID(idAuthenticationCode, authorizationSessionID);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update AuthorizationSessionID
		protected virtual OperationResult _UpdateAuthorizationSessionID(Int64 idAuthenticationCode, string authorizationSessionID)
		{
			//Create repository based on its Key name : 'Keywords.UpdateAuthenticationCode'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateAuthenticationCodeRepository repository = (IUpdateAuthenticationCodeRepository)RepositoryFactory.Create(Keywords.UpdateAuthenticationCode);
            try
            {
            	//Execute UpdateAuthorizationSessionID
                repository.UpdateAuthorizationSessionID(idAuthenticationCode, authorizationSessionID);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Authentication Code data with id Authentication Code, created Date
        /// </summary>
		/// <param name="idAuthenticationCode"> Id Authentication Code</param>
		/// <param name="createdDate"> Created Date</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateCreatedDate(Int64 idAuthenticationCode, DateTime createdDate)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate CreatedDate
			ValidationResult validationResult = this.ValidateCreatedDate( idAuthenticationCode, createdDate );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateCreatedDate(idAuthenticationCode, createdDate);
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
		
		//Validate CreatedDate
		protected virtual ValidationResult ValidateCreatedDate(Int64 idAuthenticationCode, DateTime createdDate)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateAuthenticationCode'. 
				//The validator factory will create the validator object based on its key.
				IAuthenticationCodeValidator validator = (IAuthenticationCodeValidator)ValidatorFactory.Create(Keywords.UpdateAuthenticationCode);
				
				//Execute validation process
				validationResult = validator.ValidateCreatedDate(idAuthenticationCode, createdDate);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update CreatedDate
		protected virtual OperationResult _UpdateCreatedDate(Int64 idAuthenticationCode, DateTime createdDate)
		{
			//Create repository based on its Key name : 'Keywords.UpdateAuthenticationCode'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateAuthenticationCodeRepository repository = (IUpdateAuthenticationCodeRepository)RepositoryFactory.Create(Keywords.UpdateAuthenticationCode);
            try
            {
            	//Execute UpdateCreatedDate
                repository.UpdateCreatedDate(idAuthenticationCode, createdDate);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Authentication Code data with id Authentication Code, expired Date
        /// </summary>
		/// <param name="idAuthenticationCode"> Id Authentication Code</param>
		/// <param name="expiredDate"> Expired Date</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateExpiredDate(Int64 idAuthenticationCode, DateTime expiredDate)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate ExpiredDate
			ValidationResult validationResult = this.ValidateExpiredDate( idAuthenticationCode, expiredDate );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateExpiredDate(idAuthenticationCode, expiredDate);
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
		
		//Validate ExpiredDate
		protected virtual ValidationResult ValidateExpiredDate(Int64 idAuthenticationCode, DateTime expiredDate)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateAuthenticationCode'. 
				//The validator factory will create the validator object based on its key.
				IAuthenticationCodeValidator validator = (IAuthenticationCodeValidator)ValidatorFactory.Create(Keywords.UpdateAuthenticationCode);
				
				//Execute validation process
				validationResult = validator.ValidateExpiredDate(idAuthenticationCode, expiredDate);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update ExpiredDate
		protected virtual OperationResult _UpdateExpiredDate(Int64 idAuthenticationCode, DateTime expiredDate)
		{
			//Create repository based on its Key name : 'Keywords.UpdateAuthenticationCode'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateAuthenticationCodeRepository repository = (IUpdateAuthenticationCodeRepository)RepositoryFactory.Create(Keywords.UpdateAuthenticationCode);
            try
            {
            	//Execute UpdateExpiredDate
                repository.UpdateExpiredDate(idAuthenticationCode, expiredDate);
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