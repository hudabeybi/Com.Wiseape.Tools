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
    public class UpdateRegisteredApplicationBusinessService : BaseBusinessService<RegisteredApplication>, IUpdateRegisteredApplicationBusinessService
    {
        class Keywords
        {
            public static string UpdateRegisteredApplication = "Update.Tools.OAuthServerManager.RegisteredApplication";
        }
        
        public UpdateRegisteredApplicationBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public UpdateRegisteredApplicationBusinessService()
        {
            this.RepoKey = Keywords.UpdateRegisteredApplication;
        }


        /// <summary>
        /// Update  Registered Application data with id Application, application Name
        /// </summary>
		/// <param name="idApplication"> Id Application</param>
		/// <param name="applicationName"> Application Name</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateApplicationName(Int16 idApplication, string applicationName)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate ApplicationName
			ValidationResult validationResult = this.ValidateApplicationName( idApplication, applicationName );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateApplicationName(idApplication, applicationName);
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
		protected virtual ValidationResult ValidateApplicationName(Int16 idApplication, string applicationName)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateRegisteredApplication'. 
				//The validator factory will create the validator object based on its key.
				IRegisteredApplicationValidator validator = (IRegisteredApplicationValidator)ValidatorFactory.Create(Keywords.UpdateRegisteredApplication);
				
				//Execute validation process
				validationResult = validator.ValidateApplicationName(idApplication, applicationName);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update ApplicationName
		protected virtual OperationResult _UpdateApplicationName(Int16 idApplication, string applicationName)
		{
			//Create repository based on its Key name : 'Keywords.UpdateRegisteredApplication'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateRegisteredApplicationRepository repository = (IUpdateRegisteredApplicationRepository)RepositoryFactory.Create(Keywords.UpdateRegisteredApplication);
            try
            {
            	//Execute UpdateApplicationName
                repository.UpdateApplicationName(idApplication, applicationName);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Registered Application data with id Application, application Desc
        /// </summary>
		/// <param name="idApplication"> Id Application</param>
		/// <param name="applicationDesc"> Application Desc</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateApplicationDesc(Int16 idApplication, string applicationDesc)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate ApplicationDesc
			ValidationResult validationResult = this.ValidateApplicationDesc( idApplication, applicationDesc );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateApplicationDesc(idApplication, applicationDesc);
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
		protected virtual ValidationResult ValidateApplicationDesc(Int16 idApplication, string applicationDesc)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateRegisteredApplication'. 
				//The validator factory will create the validator object based on its key.
				IRegisteredApplicationValidator validator = (IRegisteredApplicationValidator)ValidatorFactory.Create(Keywords.UpdateRegisteredApplication);
				
				//Execute validation process
				validationResult = validator.ValidateApplicationDesc(idApplication, applicationDesc);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update ApplicationDesc
		protected virtual OperationResult _UpdateApplicationDesc(Int16 idApplication, string applicationDesc)
		{
			//Create repository based on its Key name : 'Keywords.UpdateRegisteredApplication'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateRegisteredApplicationRepository repository = (IUpdateRegisteredApplicationRepository)RepositoryFactory.Create(Keywords.UpdateRegisteredApplication);
            try
            {
            	//Execute UpdateApplicationDesc
                repository.UpdateApplicationDesc(idApplication, applicationDesc);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Registered Application data with id Application, client I D
        /// </summary>
		/// <param name="idApplication"> Id Application</param>
		/// <param name="clientID"> Client I D</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateClientID(Int16 idApplication, string clientID)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate ClientID
			ValidationResult validationResult = this.ValidateClientID( idApplication, clientID );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateClientID(idApplication, clientID);
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
		protected virtual ValidationResult ValidateClientID(Int16 idApplication, string clientID)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateRegisteredApplication'. 
				//The validator factory will create the validator object based on its key.
				IRegisteredApplicationValidator validator = (IRegisteredApplicationValidator)ValidatorFactory.Create(Keywords.UpdateRegisteredApplication);
				
				//Execute validation process
				validationResult = validator.ValidateClientID(idApplication, clientID);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update ClientID
		protected virtual OperationResult _UpdateClientID(Int16 idApplication, string clientID)
		{
			//Create repository based on its Key name : 'Keywords.UpdateRegisteredApplication'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateRegisteredApplicationRepository repository = (IUpdateRegisteredApplicationRepository)RepositoryFactory.Create(Keywords.UpdateRegisteredApplication);
            try
            {
            	//Execute UpdateClientID
                repository.UpdateClientID(idApplication, clientID);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Registered Application data with id Application, client Secret
        /// </summary>
		/// <param name="idApplication"> Id Application</param>
		/// <param name="clientSecret"> Client Secret</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateClientSecret(Int16 idApplication, string clientSecret)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate ClientSecret
			ValidationResult validationResult = this.ValidateClientSecret( idApplication, clientSecret );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateClientSecret(idApplication, clientSecret);
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
		protected virtual ValidationResult ValidateClientSecret(Int16 idApplication, string clientSecret)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateRegisteredApplication'. 
				//The validator factory will create the validator object based on its key.
				IRegisteredApplicationValidator validator = (IRegisteredApplicationValidator)ValidatorFactory.Create(Keywords.UpdateRegisteredApplication);
				
				//Execute validation process
				validationResult = validator.ValidateClientSecret(idApplication, clientSecret);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update ClientSecret
		protected virtual OperationResult _UpdateClientSecret(Int16 idApplication, string clientSecret)
		{
			//Create repository based on its Key name : 'Keywords.UpdateRegisteredApplication'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateRegisteredApplicationRepository repository = (IUpdateRegisteredApplicationRepository)RepositoryFactory.Create(Keywords.UpdateRegisteredApplication);
            try
            {
            	//Execute UpdateClientSecret
                repository.UpdateClientSecret(idApplication, clientSecret);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Registered Application data with id Application, authorization Token Redirect U R I
        /// </summary>
		/// <param name="idApplication"> Id Application</param>
		/// <param name="authorizationTokenRedirectURI"> Authorization Token Redirect U R I</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateAuthorizationTokenRedirectURI(Int16 idApplication, string authorizationTokenRedirectURI)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate AuthorizationTokenRedirectURI
			ValidationResult validationResult = this.ValidateAuthorizationTokenRedirectURI( idApplication, authorizationTokenRedirectURI );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateAuthorizationTokenRedirectURI(idApplication, authorizationTokenRedirectURI);
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
		protected virtual ValidationResult ValidateAuthorizationTokenRedirectURI(Int16 idApplication, string authorizationTokenRedirectURI)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateRegisteredApplication'. 
				//The validator factory will create the validator object based on its key.
				IRegisteredApplicationValidator validator = (IRegisteredApplicationValidator)ValidatorFactory.Create(Keywords.UpdateRegisteredApplication);
				
				//Execute validation process
				validationResult = validator.ValidateAuthorizationTokenRedirectURI(idApplication, authorizationTokenRedirectURI);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update AuthorizationTokenRedirectURI
		protected virtual OperationResult _UpdateAuthorizationTokenRedirectURI(Int16 idApplication, string authorizationTokenRedirectURI)
		{
			//Create repository based on its Key name : 'Keywords.UpdateRegisteredApplication'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateRegisteredApplicationRepository repository = (IUpdateRegisteredApplicationRepository)RepositoryFactory.Create(Keywords.UpdateRegisteredApplication);
            try
            {
            	//Execute UpdateAuthorizationTokenRedirectURI
                repository.UpdateAuthorizationTokenRedirectURI(idApplication, authorizationTokenRedirectURI);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Registered Application data with id Application, access Token Redirect U R I
        /// </summary>
		/// <param name="idApplication"> Id Application</param>
		/// <param name="accessTokenRedirectURI"> Access Token Redirect U R I</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateAccessTokenRedirectURI(Int16 idApplication, string accessTokenRedirectURI)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate AccessTokenRedirectURI
			ValidationResult validationResult = this.ValidateAccessTokenRedirectURI( idApplication, accessTokenRedirectURI );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateAccessTokenRedirectURI(idApplication, accessTokenRedirectURI);
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
		protected virtual ValidationResult ValidateAccessTokenRedirectURI(Int16 idApplication, string accessTokenRedirectURI)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateRegisteredApplication'. 
				//The validator factory will create the validator object based on its key.
				IRegisteredApplicationValidator validator = (IRegisteredApplicationValidator)ValidatorFactory.Create(Keywords.UpdateRegisteredApplication);
				
				//Execute validation process
				validationResult = validator.ValidateAccessTokenRedirectURI(idApplication, accessTokenRedirectURI);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update AccessTokenRedirectURI
		protected virtual OperationResult _UpdateAccessTokenRedirectURI(Int16 idApplication, string accessTokenRedirectURI)
		{
			//Create repository based on its Key name : 'Keywords.UpdateRegisteredApplication'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateRegisteredApplicationRepository repository = (IUpdateRegisteredApplicationRepository)RepositoryFactory.Create(Keywords.UpdateRegisteredApplication);
            try
            {
            	//Execute UpdateAccessTokenRedirectURI
                repository.UpdateAccessTokenRedirectURI(idApplication, accessTokenRedirectURI);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Registered Application data with id Application, authentication Source Connection String
        /// </summary>
		/// <param name="idApplication"> Id Application</param>
		/// <param name="authenticationSourceConnectionString"> Authentication Source Connection String</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateAuthenticationSourceConnectionString(Int16 idApplication, string authenticationSourceConnectionString)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate AuthenticationSourceConnectionString
			ValidationResult validationResult = this.ValidateAuthenticationSourceConnectionString( idApplication, authenticationSourceConnectionString );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateAuthenticationSourceConnectionString(idApplication, authenticationSourceConnectionString);
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
		protected virtual ValidationResult ValidateAuthenticationSourceConnectionString(Int16 idApplication, string authenticationSourceConnectionString)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateRegisteredApplication'. 
				//The validator factory will create the validator object based on its key.
				IRegisteredApplicationValidator validator = (IRegisteredApplicationValidator)ValidatorFactory.Create(Keywords.UpdateRegisteredApplication);
				
				//Execute validation process
				validationResult = validator.ValidateAuthenticationSourceConnectionString(idApplication, authenticationSourceConnectionString);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update AuthenticationSourceConnectionString
		protected virtual OperationResult _UpdateAuthenticationSourceConnectionString(Int16 idApplication, string authenticationSourceConnectionString)
		{
			//Create repository based on its Key name : 'Keywords.UpdateRegisteredApplication'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateRegisteredApplicationRepository repository = (IUpdateRegisteredApplicationRepository)RepositoryFactory.Create(Keywords.UpdateRegisteredApplication);
            try
            {
            	//Execute UpdateAuthenticationSourceConnectionString
                repository.UpdateAuthenticationSourceConnectionString(idApplication, authenticationSourceConnectionString);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Registered Application data with id Application, authentication Url
        /// </summary>
		/// <param name="idApplication"> Id Application</param>
		/// <param name="authenticationUrl"> Authentication Url</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateAuthenticationUrl(Int16 idApplication, string authenticationUrl)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate AuthenticationUrl
			ValidationResult validationResult = this.ValidateAuthenticationUrl( idApplication, authenticationUrl );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateAuthenticationUrl(idApplication, authenticationUrl);
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
		protected virtual ValidationResult ValidateAuthenticationUrl(Int16 idApplication, string authenticationUrl)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateRegisteredApplication'. 
				//The validator factory will create the validator object based on its key.
				IRegisteredApplicationValidator validator = (IRegisteredApplicationValidator)ValidatorFactory.Create(Keywords.UpdateRegisteredApplication);
				
				//Execute validation process
				validationResult = validator.ValidateAuthenticationUrl(idApplication, authenticationUrl);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update AuthenticationUrl
		protected virtual OperationResult _UpdateAuthenticationUrl(Int16 idApplication, string authenticationUrl)
		{
			//Create repository based on its Key name : 'Keywords.UpdateRegisteredApplication'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateRegisteredApplicationRepository repository = (IUpdateRegisteredApplicationRepository)RepositoryFactory.Create(Keywords.UpdateRegisteredApplication);
            try
            {
            	//Execute UpdateAuthenticationUrl
                repository.UpdateAuthenticationUrl(idApplication, authenticationUrl);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Registered Application data with id Application, created Date
        /// </summary>
		/// <param name="idApplication"> Id Application</param>
		/// <param name="createdDate"> Created Date</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateCreatedDate(Int16 idApplication, DateTime createdDate)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate CreatedDate
			ValidationResult validationResult = this.ValidateCreatedDate( idApplication, createdDate );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateCreatedDate(idApplication, createdDate);
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
		protected virtual ValidationResult ValidateCreatedDate(Int16 idApplication, DateTime createdDate)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateRegisteredApplication'. 
				//The validator factory will create the validator object based on its key.
				IRegisteredApplicationValidator validator = (IRegisteredApplicationValidator)ValidatorFactory.Create(Keywords.UpdateRegisteredApplication);
				
				//Execute validation process
				validationResult = validator.ValidateCreatedDate(idApplication, createdDate);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update CreatedDate
		protected virtual OperationResult _UpdateCreatedDate(Int16 idApplication, DateTime createdDate)
		{
			//Create repository based on its Key name : 'Keywords.UpdateRegisteredApplication'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateRegisteredApplicationRepository repository = (IUpdateRegisteredApplicationRepository)RepositoryFactory.Create(Keywords.UpdateRegisteredApplication);
            try
            {
            	//Execute UpdateCreatedDate
                repository.UpdateCreatedDate(idApplication, createdDate);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Registered Application data with id Application, authentication Source Id
        /// </summary>
		/// <param name="idApplication"> Id Application</param>
		/// <param name="authenticationSourceId"> Authentication Source Id</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateAuthenticationSourceId(Int16 idApplication, Int16 authenticationSourceId)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate 
			ValidationResult validationResult = this.ValidateAuthenticationSourceId( idApplication, authenticationSourceId );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateAuthenticationSourceId(idApplication, authenticationSourceId);
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
		protected virtual ValidationResult ValidateAuthenticationSourceId(Int16 idApplication, Int16 authenticationSourceId)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateRegisteredApplication'. 
				//The validator factory will create the validator object based on its key.
				IRegisteredApplicationValidator validator = (IRegisteredApplicationValidator)ValidatorFactory.Create(Keywords.UpdateRegisteredApplication);
				
				//Execute validation process
				validationResult = validator.ValidateAuthenticationSourceId(idApplication, authenticationSourceId);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update 
		protected virtual OperationResult _UpdateAuthenticationSourceId(Int16 idApplication, Int16 authenticationSourceId)
		{
			//Create repository based on its Key name : 'Keywords.UpdateRegisteredApplication'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateRegisteredApplicationRepository repository = (IUpdateRegisteredApplicationRepository)RepositoryFactory.Create(Keywords.UpdateRegisteredApplication);
            try
            {
            	//Execute UpdateAuthenticationSourceId
                repository.UpdateAuthenticationSourceId(idApplication, authenticationSourceId);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Registered Application data with id Application, authentication Source Id, is Active
        /// </summary>
		/// <param name="idApplication"> Id Application</param>
		/// <param name="authenticationSourceId"> Authentication Source Id</param>
		/// <param name="isActive"> Is Active</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateAuthenticationSourceIdAndIsActive(Int16 idApplication, Int16 authenticationSourceId, Int16 isActive)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate 
			ValidationResult validationResult = this.ValidateAuthenticationSourceIdAndIsActive( idApplication, authenticationSourceId, isActive );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateAuthenticationSourceIdAndIsActive(idApplication, authenticationSourceId, isActive);
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
		protected virtual ValidationResult ValidateAuthenticationSourceIdAndIsActive(Int16 idApplication, Int16 authenticationSourceId, Int16 isActive)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateRegisteredApplication'. 
				//The validator factory will create the validator object based on its key.
				IRegisteredApplicationValidator validator = (IRegisteredApplicationValidator)ValidatorFactory.Create(Keywords.UpdateRegisteredApplication);
				
				//Execute validation process
				validationResult = validator.ValidateAuthenticationSourceIdAndIsActive(idApplication, authenticationSourceId, isActive);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update 
		protected virtual OperationResult _UpdateAuthenticationSourceIdAndIsActive(Int16 idApplication, Int16 authenticationSourceId, Int16 isActive)
		{
			//Create repository based on its Key name : 'Keywords.UpdateRegisteredApplication'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateRegisteredApplicationRepository repository = (IUpdateRegisteredApplicationRepository)RepositoryFactory.Create(Keywords.UpdateRegisteredApplication);
            try
            {
            	//Execute UpdateAuthenticationSourceIdAndIsActive
                repository.UpdateAuthenticationSourceIdAndIsActive(idApplication, authenticationSourceId, isActive);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Registered Application data with id Application, is Active
        /// </summary>
		/// <param name="idApplication"> Id Application</param>
		/// <param name="isActive"> Is Active</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateIsActive(Int16 idApplication, Int16 isActive)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate 
			ValidationResult validationResult = this.ValidateIsActive( idApplication, isActive );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateIsActive(idApplication, isActive);
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
		protected virtual ValidationResult ValidateIsActive(Int16 idApplication, Int16 isActive)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateRegisteredApplication'. 
				//The validator factory will create the validator object based on its key.
				IRegisteredApplicationValidator validator = (IRegisteredApplicationValidator)ValidatorFactory.Create(Keywords.UpdateRegisteredApplication);
				
				//Execute validation process
				validationResult = validator.ValidateIsActive(idApplication, isActive);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update 
		protected virtual OperationResult _UpdateIsActive(Int16 idApplication, Int16 isActive)
		{
			//Create repository based on its Key name : 'Keywords.UpdateRegisteredApplication'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateRegisteredApplicationRepository repository = (IUpdateRegisteredApplicationRepository)RepositoryFactory.Create(Keywords.UpdateRegisteredApplication);
            try
            {
            	//Execute UpdateIsActive
                repository.UpdateIsActive(idApplication, isActive);
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