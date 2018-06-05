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
    public class UpdateAuthenticationSessionBusinessService : BaseBusinessService<AuthenticationSession>, IUpdateAuthenticationSessionBusinessService
    {
        class Keywords
        {
            public static string UpdateAuthenticationSession = "Update.Tools.OAuthServerManager.AuthenticationSession";
        }
        
        public UpdateAuthenticationSessionBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public UpdateAuthenticationSessionBusinessService()
        {
            this.RepoKey = Keywords.UpdateAuthenticationSession;
        }


        /// <summary>
        /// Update  Authentication Session data with id Authentication Session, authentication Session String
        /// </summary>
		/// <param name="idAuthenticationSession"> Id Authentication Session</param>
		/// <param name="authenticationSessionString"> Authentication Session String</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateAuthenticationSessionString(Int64 idAuthenticationSession, string authenticationSessionString)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate AuthenticationSessionString
			ValidationResult validationResult = this.ValidateAuthenticationSessionString( idAuthenticationSession, authenticationSessionString );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateAuthenticationSessionString(idAuthenticationSession, authenticationSessionString);
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
		protected virtual ValidationResult ValidateAuthenticationSessionString(Int64 idAuthenticationSession, string authenticationSessionString)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateAuthenticationSession'. 
				//The validator factory will create the validator object based on its key.
				IAuthenticationSessionValidator validator = (IAuthenticationSessionValidator)ValidatorFactory.Create(Keywords.UpdateAuthenticationSession);
				
				//Execute validation process
				validationResult = validator.ValidateAuthenticationSessionString(idAuthenticationSession, authenticationSessionString);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update AuthenticationSessionString
		protected virtual OperationResult _UpdateAuthenticationSessionString(Int64 idAuthenticationSession, string authenticationSessionString)
		{
			//Create repository based on its Key name : 'Keywords.UpdateAuthenticationSession'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateAuthenticationSessionRepository repository = (IUpdateAuthenticationSessionRepository)RepositoryFactory.Create(Keywords.UpdateAuthenticationSession);
            try
            {
            	//Execute UpdateAuthenticationSessionString
                repository.UpdateAuthenticationSessionString(idAuthenticationSession, authenticationSessionString);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Authentication Session data with id Authentication Session, client I D
        /// </summary>
		/// <param name="idAuthenticationSession"> Id Authentication Session</param>
		/// <param name="clientID"> Client I D</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateClientID(Int64 idAuthenticationSession, string clientID)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate ClientID
			ValidationResult validationResult = this.ValidateClientID( idAuthenticationSession, clientID );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateClientID(idAuthenticationSession, clientID);
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
		protected virtual ValidationResult ValidateClientID(Int64 idAuthenticationSession, string clientID)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateAuthenticationSession'. 
				//The validator factory will create the validator object based on its key.
				IAuthenticationSessionValidator validator = (IAuthenticationSessionValidator)ValidatorFactory.Create(Keywords.UpdateAuthenticationSession);
				
				//Execute validation process
				validationResult = validator.ValidateClientID(idAuthenticationSession, clientID);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update ClientID
		protected virtual OperationResult _UpdateClientID(Int64 idAuthenticationSession, string clientID)
		{
			//Create repository based on its Key name : 'Keywords.UpdateAuthenticationSession'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateAuthenticationSessionRepository repository = (IUpdateAuthenticationSessionRepository)RepositoryFactory.Create(Keywords.UpdateAuthenticationSession);
            try
            {
            	//Execute UpdateClientID
                repository.UpdateClientID(idAuthenticationSession, clientID);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Authentication Session data with id Authentication Session, session Created Date
        /// </summary>
		/// <param name="idAuthenticationSession"> Id Authentication Session</param>
		/// <param name="sessionCreatedDate"> Session Created Date</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateSessionCreatedDate(Int64 idAuthenticationSession, DateTime sessionCreatedDate)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate SessionCreatedDate
			ValidationResult validationResult = this.ValidateSessionCreatedDate( idAuthenticationSession, sessionCreatedDate );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateSessionCreatedDate(idAuthenticationSession, sessionCreatedDate);
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
		protected virtual ValidationResult ValidateSessionCreatedDate(Int64 idAuthenticationSession, DateTime sessionCreatedDate)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateAuthenticationSession'. 
				//The validator factory will create the validator object based on its key.
				IAuthenticationSessionValidator validator = (IAuthenticationSessionValidator)ValidatorFactory.Create(Keywords.UpdateAuthenticationSession);
				
				//Execute validation process
				validationResult = validator.ValidateSessionCreatedDate(idAuthenticationSession, sessionCreatedDate);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update SessionCreatedDate
		protected virtual OperationResult _UpdateSessionCreatedDate(Int64 idAuthenticationSession, DateTime sessionCreatedDate)
		{
			//Create repository based on its Key name : 'Keywords.UpdateAuthenticationSession'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateAuthenticationSessionRepository repository = (IUpdateAuthenticationSessionRepository)RepositoryFactory.Create(Keywords.UpdateAuthenticationSession);
            try
            {
            	//Execute UpdateSessionCreatedDate
                repository.UpdateSessionCreatedDate(idAuthenticationSession, sessionCreatedDate);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Authentication Session data with id Authentication Session, session Expired Date
        /// </summary>
		/// <param name="idAuthenticationSession"> Id Authentication Session</param>
		/// <param name="sessionExpiredDate"> Session Expired Date</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateSessionExpiredDate(Int64 idAuthenticationSession, DateTime sessionExpiredDate)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate SessionExpiredDate
			ValidationResult validationResult = this.ValidateSessionExpiredDate( idAuthenticationSession, sessionExpiredDate );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateSessionExpiredDate(idAuthenticationSession, sessionExpiredDate);
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
		protected virtual ValidationResult ValidateSessionExpiredDate(Int64 idAuthenticationSession, DateTime sessionExpiredDate)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateAuthenticationSession'. 
				//The validator factory will create the validator object based on its key.
				IAuthenticationSessionValidator validator = (IAuthenticationSessionValidator)ValidatorFactory.Create(Keywords.UpdateAuthenticationSession);
				
				//Execute validation process
				validationResult = validator.ValidateSessionExpiredDate(idAuthenticationSession, sessionExpiredDate);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update SessionExpiredDate
		protected virtual OperationResult _UpdateSessionExpiredDate(Int64 idAuthenticationSession, DateTime sessionExpiredDate)
		{
			//Create repository based on its Key name : 'Keywords.UpdateAuthenticationSession'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateAuthenticationSessionRepository repository = (IUpdateAuthenticationSessionRepository)RepositoryFactory.Create(Keywords.UpdateAuthenticationSession);
            try
            {
            	//Execute UpdateSessionExpiredDate
                repository.UpdateSessionExpiredDate(idAuthenticationSession, sessionExpiredDate);
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