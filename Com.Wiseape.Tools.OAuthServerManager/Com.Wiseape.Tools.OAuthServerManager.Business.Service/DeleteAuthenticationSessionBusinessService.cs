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
    /// Business Service for AuthenticationSession module.
    /// </summary>
    public class DeleteAuthenticationSessionBusinessService : BaseBusinessService<AuthenticationSession>, IDeleteAuthenticationSessionBusinessService
    {
        class Keywords
        {
            public static string DeleteAuthenticationSession = "Delete.Tools.OAuthServerManager.AuthenticationSession";
        }
        
        public DeleteAuthenticationSessionBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public DeleteAuthenticationSessionBusinessService()
        {
            this.RepoKey = Keywords.DeleteAuthenticationSession;
        }

        /// <summary>
        /// Delete  Authentication Session data by authentication Session String
        /// </summary>
		/// <param name="authenticationSessionString"> Authentication Session String</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByAuthenticationSessionString(string authenticationSessionString)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate AuthenticationSessionString
			ValidationResult validationResult = this.ValidateAuthenticationSessionString( authenticationSessionString );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByAuthenticationSessionString(authenticationSessionString);
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
		
		//Validate AuthenticationSessionString
		protected virtual ValidationResult ValidateAuthenticationSessionString(string authenticationSessionString)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateAuthenticationSession'. 
				//The validator factory will create the validator object based on its key.
				IAuthenticationSessionValidator validator = (IAuthenticationSessionValidator)ValidatorFactory.Create(Keywords.DeleteAuthenticationSession);
				
				//Execute validation process
				validationResult = validator.ValidateAuthenticationSessionString(authenticationSessionString);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete AuthenticationSessionString
		protected virtual OperationResult _DeleteByAuthenticationSessionString(string authenticationSessionString)
		{
			//Create repository based on its Key name : 'Keywords.DeleteAuthenticationSession'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteAuthenticationSessionRepository repository = (IDeleteAuthenticationSessionRepository)RepositoryFactory.Create(Keywords.DeleteAuthenticationSession);
            try
            {
            	//Execute DeleteByAuthenticationSessionString
                repository.DeleteByAuthenticationSessionString(authenticationSessionString);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  Authentication Session data by client I D
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
				//Create Validator based on its Key name : 'Keywords.UpdateAuthenticationSession'. 
				//The validator factory will create the validator object based on its key.
				IAuthenticationSessionValidator validator = (IAuthenticationSessionValidator)ValidatorFactory.Create(Keywords.DeleteAuthenticationSession);
				
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
			//Create repository based on its Key name : 'Keywords.DeleteAuthenticationSession'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteAuthenticationSessionRepository repository = (IDeleteAuthenticationSessionRepository)RepositoryFactory.Create(Keywords.DeleteAuthenticationSession);
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
        /// Delete  Authentication Session data by session Created Date
        /// </summary>
		/// <param name="sessionCreatedDate"> Session Created Date</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteBySessionCreatedDate(DateTime sessionCreatedDate)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate SessionCreatedDate
			ValidationResult validationResult = this.ValidateSessionCreatedDate( sessionCreatedDate );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteBySessionCreatedDate(sessionCreatedDate);
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
		
		//Validate SessionCreatedDate
		protected virtual ValidationResult ValidateSessionCreatedDate(DateTime sessionCreatedDate)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateAuthenticationSession'. 
				//The validator factory will create the validator object based on its key.
				IAuthenticationSessionValidator validator = (IAuthenticationSessionValidator)ValidatorFactory.Create(Keywords.DeleteAuthenticationSession);
				
				//Execute validation process
				validationResult = validator.ValidateSessionCreatedDate(sessionCreatedDate);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete SessionCreatedDate
		protected virtual OperationResult _DeleteBySessionCreatedDate(DateTime sessionCreatedDate)
		{
			//Create repository based on its Key name : 'Keywords.DeleteAuthenticationSession'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteAuthenticationSessionRepository repository = (IDeleteAuthenticationSessionRepository)RepositoryFactory.Create(Keywords.DeleteAuthenticationSession);
            try
            {
            	//Execute DeleteBySessionCreatedDate
                repository.DeleteBySessionCreatedDate(sessionCreatedDate);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  Authentication Session data by session Expired Date
        /// </summary>
		/// <param name="sessionExpiredDate"> Session Expired Date</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteBySessionExpiredDate(DateTime sessionExpiredDate)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate SessionExpiredDate
			ValidationResult validationResult = this.ValidateSessionExpiredDate( sessionExpiredDate );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteBySessionExpiredDate(sessionExpiredDate);
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
		
		//Validate SessionExpiredDate
		protected virtual ValidationResult ValidateSessionExpiredDate(DateTime sessionExpiredDate)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateAuthenticationSession'. 
				//The validator factory will create the validator object based on its key.
				IAuthenticationSessionValidator validator = (IAuthenticationSessionValidator)ValidatorFactory.Create(Keywords.DeleteAuthenticationSession);
				
				//Execute validation process
				validationResult = validator.ValidateSessionExpiredDate(sessionExpiredDate);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete SessionExpiredDate
		protected virtual OperationResult _DeleteBySessionExpiredDate(DateTime sessionExpiredDate)
		{
			//Create repository based on its Key name : 'Keywords.DeleteAuthenticationSession'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteAuthenticationSessionRepository repository = (IDeleteAuthenticationSessionRepository)RepositoryFactory.Create(Keywords.DeleteAuthenticationSession);
            try
            {
            	//Execute DeleteBySessionExpiredDate
                repository.DeleteBySessionExpiredDate(sessionExpiredDate);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}


    }
 }