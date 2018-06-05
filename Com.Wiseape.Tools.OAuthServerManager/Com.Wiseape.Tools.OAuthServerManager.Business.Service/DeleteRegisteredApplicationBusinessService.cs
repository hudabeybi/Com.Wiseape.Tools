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
    /// Business Service for RegisteredApplication module.
    /// </summary>
    public class DeleteRegisteredApplicationBusinessService : BaseBusinessService<RegisteredApplication>, IDeleteRegisteredApplicationBusinessService
    {
        class Keywords
        {
            public static string DeleteRegisteredApplication = "Delete.Tools.OAuthServerManager.RegisteredApplication";
        }
        
        public DeleteRegisteredApplicationBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public DeleteRegisteredApplicationBusinessService()
        {
            this.RepoKey = Keywords.DeleteRegisteredApplication;
        }

        /// <summary>
        /// Delete  Registered Application data by application Name
        /// </summary>
		/// <param name="applicationName"> Application Name</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByApplicationName(string applicationName)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate ApplicationName
			ValidationResult validationResult = this.ValidateApplicationName( applicationName );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByApplicationName(applicationName);
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
		
		//Validate ApplicationName
		protected virtual ValidationResult ValidateApplicationName(string applicationName)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateRegisteredApplication'. 
				//The validator factory will create the validator object based on its key.
				IRegisteredApplicationValidator validator = (IRegisteredApplicationValidator)ValidatorFactory.Create(Keywords.DeleteRegisteredApplication);
				
				//Execute validation process
				validationResult = validator.ValidateApplicationName(applicationName);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete ApplicationName
		protected virtual OperationResult _DeleteByApplicationName(string applicationName)
		{
			//Create repository based on its Key name : 'Keywords.DeleteRegisteredApplication'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteRegisteredApplicationRepository repository = (IDeleteRegisteredApplicationRepository)RepositoryFactory.Create(Keywords.DeleteRegisteredApplication);
            try
            {
            	//Execute DeleteByApplicationName
                repository.DeleteByApplicationName(applicationName);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  Registered Application data by application Desc
        /// </summary>
		/// <param name="applicationDesc"> Application Desc</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByApplicationDesc(string applicationDesc)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate ApplicationDesc
			ValidationResult validationResult = this.ValidateApplicationDesc( applicationDesc );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByApplicationDesc(applicationDesc);
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
		
		//Validate ApplicationDesc
		protected virtual ValidationResult ValidateApplicationDesc(string applicationDesc)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateRegisteredApplication'. 
				//The validator factory will create the validator object based on its key.
				IRegisteredApplicationValidator validator = (IRegisteredApplicationValidator)ValidatorFactory.Create(Keywords.DeleteRegisteredApplication);
				
				//Execute validation process
				validationResult = validator.ValidateApplicationDesc(applicationDesc);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete ApplicationDesc
		protected virtual OperationResult _DeleteByApplicationDesc(string applicationDesc)
		{
			//Create repository based on its Key name : 'Keywords.DeleteRegisteredApplication'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteRegisteredApplicationRepository repository = (IDeleteRegisteredApplicationRepository)RepositoryFactory.Create(Keywords.DeleteRegisteredApplication);
            try
            {
            	//Execute DeleteByApplicationDesc
                repository.DeleteByApplicationDesc(applicationDesc);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  Registered Application data by client I D
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
				//Create Validator based on its Key name : 'Keywords.UpdateRegisteredApplication'. 
				//The validator factory will create the validator object based on its key.
				IRegisteredApplicationValidator validator = (IRegisteredApplicationValidator)ValidatorFactory.Create(Keywords.DeleteRegisteredApplication);
				
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
			//Create repository based on its Key name : 'Keywords.DeleteRegisteredApplication'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteRegisteredApplicationRepository repository = (IDeleteRegisteredApplicationRepository)RepositoryFactory.Create(Keywords.DeleteRegisteredApplication);
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
        /// Delete  Registered Application data by client Secret
        /// </summary>
		/// <param name="clientSecret"> Client Secret</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByClientSecret(string clientSecret)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate ClientSecret
			ValidationResult validationResult = this.ValidateClientSecret( clientSecret );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByClientSecret(clientSecret);
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
		
		//Validate ClientSecret
		protected virtual ValidationResult ValidateClientSecret(string clientSecret)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateRegisteredApplication'. 
				//The validator factory will create the validator object based on its key.
				IRegisteredApplicationValidator validator = (IRegisteredApplicationValidator)ValidatorFactory.Create(Keywords.DeleteRegisteredApplication);
				
				//Execute validation process
				validationResult = validator.ValidateClientSecret(clientSecret);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete ClientSecret
		protected virtual OperationResult _DeleteByClientSecret(string clientSecret)
		{
			//Create repository based on its Key name : 'Keywords.DeleteRegisteredApplication'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteRegisteredApplicationRepository repository = (IDeleteRegisteredApplicationRepository)RepositoryFactory.Create(Keywords.DeleteRegisteredApplication);
            try
            {
            	//Execute DeleteByClientSecret
                repository.DeleteByClientSecret(clientSecret);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  Registered Application data by authorization Token Redirect U R I
        /// </summary>
		/// <param name="authorizationTokenRedirectURI"> Authorization Token Redirect U R I</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByAuthorizationTokenRedirectURI(string authorizationTokenRedirectURI)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate AuthorizationTokenRedirectURI
			ValidationResult validationResult = this.ValidateAuthorizationTokenRedirectURI( authorizationTokenRedirectURI );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByAuthorizationTokenRedirectURI(authorizationTokenRedirectURI);
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
		
		//Validate AuthorizationTokenRedirectURI
		protected virtual ValidationResult ValidateAuthorizationTokenRedirectURI(string authorizationTokenRedirectURI)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateRegisteredApplication'. 
				//The validator factory will create the validator object based on its key.
				IRegisteredApplicationValidator validator = (IRegisteredApplicationValidator)ValidatorFactory.Create(Keywords.DeleteRegisteredApplication);
				
				//Execute validation process
				validationResult = validator.ValidateAuthorizationTokenRedirectURI(authorizationTokenRedirectURI);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete AuthorizationTokenRedirectURI
		protected virtual OperationResult _DeleteByAuthorizationTokenRedirectURI(string authorizationTokenRedirectURI)
		{
			//Create repository based on its Key name : 'Keywords.DeleteRegisteredApplication'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteRegisteredApplicationRepository repository = (IDeleteRegisteredApplicationRepository)RepositoryFactory.Create(Keywords.DeleteRegisteredApplication);
            try
            {
            	//Execute DeleteByAuthorizationTokenRedirectURI
                repository.DeleteByAuthorizationTokenRedirectURI(authorizationTokenRedirectURI);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  Registered Application data by access Token Redirect U R I
        /// </summary>
		/// <param name="accessTokenRedirectURI"> Access Token Redirect U R I</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByAccessTokenRedirectURI(string accessTokenRedirectURI)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate AccessTokenRedirectURI
			ValidationResult validationResult = this.ValidateAccessTokenRedirectURI( accessTokenRedirectURI );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByAccessTokenRedirectURI(accessTokenRedirectURI);
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
		
		//Validate AccessTokenRedirectURI
		protected virtual ValidationResult ValidateAccessTokenRedirectURI(string accessTokenRedirectURI)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateRegisteredApplication'. 
				//The validator factory will create the validator object based on its key.
				IRegisteredApplicationValidator validator = (IRegisteredApplicationValidator)ValidatorFactory.Create(Keywords.DeleteRegisteredApplication);
				
				//Execute validation process
				validationResult = validator.ValidateAccessTokenRedirectURI(accessTokenRedirectURI);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete AccessTokenRedirectURI
		protected virtual OperationResult _DeleteByAccessTokenRedirectURI(string accessTokenRedirectURI)
		{
			//Create repository based on its Key name : 'Keywords.DeleteRegisteredApplication'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteRegisteredApplicationRepository repository = (IDeleteRegisteredApplicationRepository)RepositoryFactory.Create(Keywords.DeleteRegisteredApplication);
            try
            {
            	//Execute DeleteByAccessTokenRedirectURI
                repository.DeleteByAccessTokenRedirectURI(accessTokenRedirectURI);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  Registered Application data by authentication Source Connection String
        /// </summary>
		/// <param name="authenticationSourceConnectionString"> Authentication Source Connection String</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByAuthenticationSourceConnectionString(string authenticationSourceConnectionString)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate AuthenticationSourceConnectionString
			ValidationResult validationResult = this.ValidateAuthenticationSourceConnectionString( authenticationSourceConnectionString );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByAuthenticationSourceConnectionString(authenticationSourceConnectionString);
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
		
		//Validate AuthenticationSourceConnectionString
		protected virtual ValidationResult ValidateAuthenticationSourceConnectionString(string authenticationSourceConnectionString)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateRegisteredApplication'. 
				//The validator factory will create the validator object based on its key.
				IRegisteredApplicationValidator validator = (IRegisteredApplicationValidator)ValidatorFactory.Create(Keywords.DeleteRegisteredApplication);
				
				//Execute validation process
				validationResult = validator.ValidateAuthenticationSourceConnectionString(authenticationSourceConnectionString);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete AuthenticationSourceConnectionString
		protected virtual OperationResult _DeleteByAuthenticationSourceConnectionString(string authenticationSourceConnectionString)
		{
			//Create repository based on its Key name : 'Keywords.DeleteRegisteredApplication'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteRegisteredApplicationRepository repository = (IDeleteRegisteredApplicationRepository)RepositoryFactory.Create(Keywords.DeleteRegisteredApplication);
            try
            {
            	//Execute DeleteByAuthenticationSourceConnectionString
                repository.DeleteByAuthenticationSourceConnectionString(authenticationSourceConnectionString);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  Registered Application data by authentication Url
        /// </summary>
		/// <param name="authenticationUrl"> Authentication Url</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByAuthenticationUrl(string authenticationUrl)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate AuthenticationUrl
			ValidationResult validationResult = this.ValidateAuthenticationUrl( authenticationUrl );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByAuthenticationUrl(authenticationUrl);
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
		
		//Validate AuthenticationUrl
		protected virtual ValidationResult ValidateAuthenticationUrl(string authenticationUrl)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateRegisteredApplication'. 
				//The validator factory will create the validator object based on its key.
				IRegisteredApplicationValidator validator = (IRegisteredApplicationValidator)ValidatorFactory.Create(Keywords.DeleteRegisteredApplication);
				
				//Execute validation process
				validationResult = validator.ValidateAuthenticationUrl(authenticationUrl);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete AuthenticationUrl
		protected virtual OperationResult _DeleteByAuthenticationUrl(string authenticationUrl)
		{
			//Create repository based on its Key name : 'Keywords.DeleteRegisteredApplication'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteRegisteredApplicationRepository repository = (IDeleteRegisteredApplicationRepository)RepositoryFactory.Create(Keywords.DeleteRegisteredApplication);
            try
            {
            	//Execute DeleteByAuthenticationUrl
                repository.DeleteByAuthenticationUrl(authenticationUrl);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  Registered Application data by created Date
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
				//Create Validator based on its Key name : 'Keywords.UpdateRegisteredApplication'. 
				//The validator factory will create the validator object based on its key.
				IRegisteredApplicationValidator validator = (IRegisteredApplicationValidator)ValidatorFactory.Create(Keywords.DeleteRegisteredApplication);
				
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
			//Create repository based on its Key name : 'Keywords.DeleteRegisteredApplication'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteRegisteredApplicationRepository repository = (IDeleteRegisteredApplicationRepository)RepositoryFactory.Create(Keywords.DeleteRegisteredApplication);
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
        /// Delete  Registered Application data by authentication Source Id
        /// </summary>
		/// <param name="authenticationSourceId"> Authentication Source Id</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByAuthenticationSourceId(Int16 authenticationSourceId)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate 
			ValidationResult validationResult = this.ValidateAuthenticationSourceId( authenticationSourceId );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByAuthenticationSourceId(authenticationSourceId);
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
		
		//Validate 
		protected virtual ValidationResult ValidateAuthenticationSourceId(Int16 authenticationSourceId)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateRegisteredApplication'. 
				//The validator factory will create the validator object based on its key.
				IRegisteredApplicationValidator validator = (IRegisteredApplicationValidator)ValidatorFactory.Create(Keywords.DeleteRegisteredApplication);
				
				//Execute validation process
				validationResult = validator.ValidateAuthenticationSourceId(authenticationSourceId);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete 
		protected virtual OperationResult _DeleteByAuthenticationSourceId(Int16 authenticationSourceId)
		{
			//Create repository based on its Key name : 'Keywords.DeleteRegisteredApplication'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteRegisteredApplicationRepository repository = (IDeleteRegisteredApplicationRepository)RepositoryFactory.Create(Keywords.DeleteRegisteredApplication);
            try
            {
            	//Execute DeleteByAuthenticationSourceId
                repository.DeleteByAuthenticationSourceId(authenticationSourceId);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  Registered Application data by authentication Source Id, is Active
        /// </summary>
		/// <param name="authenticationSourceId"> Authentication Source Id</param>
		/// <param name="isActive"> Is Active</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByAuthenticationSourceIdAndIsActive(Int16 authenticationSourceId, Int16 isActive)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate 
			ValidationResult validationResult = this.ValidateAuthenticationSourceIdAndIsActive( authenticationSourceId, isActive );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByAuthenticationSourceIdAndIsActive(authenticationSourceId, isActive);
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
		
		//Validate 
		protected virtual ValidationResult ValidateAuthenticationSourceIdAndIsActive(Int16 authenticationSourceId, Int16 isActive)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateRegisteredApplication'. 
				//The validator factory will create the validator object based on its key.
				IRegisteredApplicationValidator validator = (IRegisteredApplicationValidator)ValidatorFactory.Create(Keywords.DeleteRegisteredApplication);
				
				//Execute validation process
				validationResult = validator.ValidateAuthenticationSourceIdAndIsActive(authenticationSourceId, isActive);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete 
		protected virtual OperationResult _DeleteByAuthenticationSourceIdAndIsActive(Int16 authenticationSourceId, Int16 isActive)
		{
			//Create repository based on its Key name : 'Keywords.DeleteRegisteredApplication'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteRegisteredApplicationRepository repository = (IDeleteRegisteredApplicationRepository)RepositoryFactory.Create(Keywords.DeleteRegisteredApplication);
            try
            {
            	//Execute DeleteByAuthenticationSourceIdAndIsActive
                repository.DeleteByAuthenticationSourceIdAndIsActive(authenticationSourceId, isActive);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  Registered Application data by is Active
        /// </summary>
		/// <param name="isActive"> Is Active</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByIsActive(Int16 isActive)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate 
			ValidationResult validationResult = this.ValidateIsActive( isActive );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByIsActive(isActive);
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
		
		//Validate 
		protected virtual ValidationResult ValidateIsActive(Int16 isActive)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateRegisteredApplication'. 
				//The validator factory will create the validator object based on its key.
				IRegisteredApplicationValidator validator = (IRegisteredApplicationValidator)ValidatorFactory.Create(Keywords.DeleteRegisteredApplication);
				
				//Execute validation process
				validationResult = validator.ValidateIsActive(isActive);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete 
		protected virtual OperationResult _DeleteByIsActive(Int16 isActive)
		{
			//Create repository based on its Key name : 'Keywords.DeleteRegisteredApplication'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteRegisteredApplicationRepository repository = (IDeleteRegisteredApplicationRepository)RepositoryFactory.Create(Keywords.DeleteRegisteredApplication);
            try
            {
            	//Execute DeleteByIsActive
                repository.DeleteByIsActive(isActive);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}


    }
 }