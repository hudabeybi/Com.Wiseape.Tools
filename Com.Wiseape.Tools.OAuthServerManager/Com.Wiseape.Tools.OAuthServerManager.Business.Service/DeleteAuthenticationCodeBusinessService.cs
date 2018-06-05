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
    public class DeleteAuthenticationCodeBusinessService : BaseBusinessService<AuthenticationCode>, IDeleteAuthenticationCodeBusinessService
    {
        class Keywords
        {
            public static string DeleteAuthenticationCode = "Delete.Tools.OAuthServerManager.AuthenticationCode";
        }
        
        public DeleteAuthenticationCodeBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public DeleteAuthenticationCodeBusinessService()
        {
            this.RepoKey = Keywords.DeleteAuthenticationCode;
        }

        /// <summary>
        /// Delete  Authentication Code data by authentication Code String
        /// </summary>
		/// <param name="authenticationCodeString"> Authentication Code String</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByAuthenticationCodeString(string authenticationCodeString)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate AuthenticationCodeString
			ValidationResult validationResult = this.ValidateAuthenticationCodeString( authenticationCodeString );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByAuthenticationCodeString(authenticationCodeString);
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
		protected virtual ValidationResult ValidateAuthenticationCodeString(string authenticationCodeString)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateAuthenticationCode'. 
				//The validator factory will create the validator object based on its key.
				IAuthenticationCodeValidator validator = (IAuthenticationCodeValidator)ValidatorFactory.Create(Keywords.DeleteAuthenticationCode);
				
				//Execute validation process
				validationResult = validator.ValidateAuthenticationCodeString(authenticationCodeString);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete AuthenticationCodeString
		protected virtual OperationResult _DeleteByAuthenticationCodeString(string authenticationCodeString)
		{
			//Create repository based on its Key name : 'Keywords.DeleteAuthenticationCode'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteAuthenticationCodeRepository repository = (IDeleteAuthenticationCodeRepository)RepositoryFactory.Create(Keywords.DeleteAuthenticationCode);
            try
            {
            	//Execute DeleteByAuthenticationCodeString
                repository.DeleteByAuthenticationCodeString(authenticationCodeString);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  Authentication Code data by client I D
        /// </summary>
		/// <param name="clientID"> Client I D</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByClientID(string clientID)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate ClientID
			ValidationResult validationResult = this.ValidateClientID( clientID );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByClientID(clientID);
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
		protected virtual ValidationResult ValidateClientID(string clientID)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateAuthenticationCode'. 
				//The validator factory will create the validator object based on its key.
				IAuthenticationCodeValidator validator = (IAuthenticationCodeValidator)ValidatorFactory.Create(Keywords.DeleteAuthenticationCode);
				
				//Execute validation process
				validationResult = validator.ValidateClientID(clientID);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete ClientID
		protected virtual OperationResult _DeleteByClientID(string clientID)
		{
			//Create repository based on its Key name : 'Keywords.DeleteAuthenticationCode'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteAuthenticationCodeRepository repository = (IDeleteAuthenticationCodeRepository)RepositoryFactory.Create(Keywords.DeleteAuthenticationCode);
            try
            {
            	//Execute DeleteByClientID
                repository.DeleteByClientID(clientID);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  Authentication Code data by authorization Session I D
        /// </summary>
		/// <param name="authorizationSessionID"> Authorization Session I D</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByAuthorizationSessionID(string authorizationSessionID)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate AuthorizationSessionID
			ValidationResult validationResult = this.ValidateAuthorizationSessionID( authorizationSessionID );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByAuthorizationSessionID(authorizationSessionID);
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
		protected virtual ValidationResult ValidateAuthorizationSessionID(string authorizationSessionID)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateAuthenticationCode'. 
				//The validator factory will create the validator object based on its key.
				IAuthenticationCodeValidator validator = (IAuthenticationCodeValidator)ValidatorFactory.Create(Keywords.DeleteAuthenticationCode);
				
				//Execute validation process
				validationResult = validator.ValidateAuthorizationSessionID(authorizationSessionID);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete AuthorizationSessionID
		protected virtual OperationResult _DeleteByAuthorizationSessionID(string authorizationSessionID)
		{
			//Create repository based on its Key name : 'Keywords.DeleteAuthenticationCode'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteAuthenticationCodeRepository repository = (IDeleteAuthenticationCodeRepository)RepositoryFactory.Create(Keywords.DeleteAuthenticationCode);
            try
            {
            	//Execute DeleteByAuthorizationSessionID
                repository.DeleteByAuthorizationSessionID(authorizationSessionID);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  Authentication Code data by created Date
        /// </summary>
		/// <param name="createdDate"> Created Date</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByCreatedDate(DateTime createdDate)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate CreatedDate
			ValidationResult validationResult = this.ValidateCreatedDate( createdDate );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByCreatedDate(createdDate);
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
		protected virtual ValidationResult ValidateCreatedDate(DateTime createdDate)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateAuthenticationCode'. 
				//The validator factory will create the validator object based on its key.
				IAuthenticationCodeValidator validator = (IAuthenticationCodeValidator)ValidatorFactory.Create(Keywords.DeleteAuthenticationCode);
				
				//Execute validation process
				validationResult = validator.ValidateCreatedDate(createdDate);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete CreatedDate
		protected virtual OperationResult _DeleteByCreatedDate(DateTime createdDate)
		{
			//Create repository based on its Key name : 'Keywords.DeleteAuthenticationCode'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteAuthenticationCodeRepository repository = (IDeleteAuthenticationCodeRepository)RepositoryFactory.Create(Keywords.DeleteAuthenticationCode);
            try
            {
            	//Execute DeleteByCreatedDate
                repository.DeleteByCreatedDate(createdDate);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  Authentication Code data by expired Date
        /// </summary>
		/// <param name="expiredDate"> Expired Date</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByExpiredDate(DateTime expiredDate)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate ExpiredDate
			ValidationResult validationResult = this.ValidateExpiredDate( expiredDate );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByExpiredDate(expiredDate);
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
		protected virtual ValidationResult ValidateExpiredDate(DateTime expiredDate)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateAuthenticationCode'. 
				//The validator factory will create the validator object based on its key.
				IAuthenticationCodeValidator validator = (IAuthenticationCodeValidator)ValidatorFactory.Create(Keywords.DeleteAuthenticationCode);
				
				//Execute validation process
				validationResult = validator.ValidateExpiredDate(expiredDate);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete ExpiredDate
		protected virtual OperationResult _DeleteByExpiredDate(DateTime expiredDate)
		{
			//Create repository based on its Key name : 'Keywords.DeleteAuthenticationCode'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteAuthenticationCodeRepository repository = (IDeleteAuthenticationCodeRepository)RepositoryFactory.Create(Keywords.DeleteAuthenticationCode);
            try
            {
            	//Execute DeleteByExpiredDate
                repository.DeleteByExpiredDate(expiredDate);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}


    }
 }