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
    /// Business Service for AccessToken module.
    /// </summary>
    public class UpdateAccessTokenBusinessService : BaseBusinessService<AccessToken>, IUpdateAccessTokenBusinessService
    {
        class Keywords
        {
            public static string UpdateAccessToken = "Update.Tools.OAuthServerManager.AccessToken";
        }
        
        public UpdateAccessTokenBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public UpdateAccessTokenBusinessService()
        {
            this.RepoKey = Keywords.UpdateAccessToken;
        }


        /// <summary>
        /// Update  Access Token data with id Access Token, access Token String
        /// </summary>
		/// <param name="idAccessToken"> Id Access Token</param>
		/// <param name="accessTokenString"> Access Token String</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateAccessTokenString(Int64 idAccessToken, string accessTokenString)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate AccessTokenString
			ValidationResult validationResult = this.ValidateAccessTokenString( idAccessToken, accessTokenString );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateAccessTokenString(idAccessToken, accessTokenString);
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
		
		//Validate AccessTokenString
		protected virtual ValidationResult ValidateAccessTokenString(Int64 idAccessToken, string accessTokenString)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateAccessToken'. 
				//The validator factory will create the validator object based on its key.
				IAccessTokenValidator validator = (IAccessTokenValidator)ValidatorFactory.Create(Keywords.UpdateAccessToken);
				
				//Execute validation process
				validationResult = validator.ValidateAccessTokenString(idAccessToken, accessTokenString);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update AccessTokenString
		protected virtual OperationResult _UpdateAccessTokenString(Int64 idAccessToken, string accessTokenString)
		{
			//Create repository based on its Key name : 'Keywords.UpdateAccessToken'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateAccessTokenRepository repository = (IUpdateAccessTokenRepository)RepositoryFactory.Create(Keywords.UpdateAccessToken);
            try
            {
            	//Execute UpdateAccessTokenString
                repository.UpdateAccessTokenString(idAccessToken, accessTokenString);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Access Token data with id Access Token, refresh Token
        /// </summary>
		/// <param name="idAccessToken"> Id Access Token</param>
		/// <param name="refreshToken"> Refresh Token</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateRefreshToken(Int64 idAccessToken, string refreshToken)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate RefreshToken
			ValidationResult validationResult = this.ValidateRefreshToken( idAccessToken, refreshToken );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateRefreshToken(idAccessToken, refreshToken);
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
		
		//Validate RefreshToken
		protected virtual ValidationResult ValidateRefreshToken(Int64 idAccessToken, string refreshToken)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateAccessToken'. 
				//The validator factory will create the validator object based on its key.
				IAccessTokenValidator validator = (IAccessTokenValidator)ValidatorFactory.Create(Keywords.UpdateAccessToken);
				
				//Execute validation process
				validationResult = validator.ValidateRefreshToken(idAccessToken, refreshToken);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update RefreshToken
		protected virtual OperationResult _UpdateRefreshToken(Int64 idAccessToken, string refreshToken)
		{
			//Create repository based on its Key name : 'Keywords.UpdateAccessToken'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateAccessTokenRepository repository = (IUpdateAccessTokenRepository)RepositoryFactory.Create(Keywords.UpdateAccessToken);
            try
            {
            	//Execute UpdateRefreshToken
                repository.UpdateRefreshToken(idAccessToken, refreshToken);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Access Token data with id Access Token, client I D
        /// </summary>
		/// <param name="idAccessToken"> Id Access Token</param>
		/// <param name="clientID"> Client I D</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateClientID(Int64 idAccessToken, string clientID)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate ClientID
			ValidationResult validationResult = this.ValidateClientID( idAccessToken, clientID );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateClientID(idAccessToken, clientID);
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
		protected virtual ValidationResult ValidateClientID(Int64 idAccessToken, string clientID)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateAccessToken'. 
				//The validator factory will create the validator object based on its key.
				IAccessTokenValidator validator = (IAccessTokenValidator)ValidatorFactory.Create(Keywords.UpdateAccessToken);
				
				//Execute validation process
				validationResult = validator.ValidateClientID(idAccessToken, clientID);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update ClientID
		protected virtual OperationResult _UpdateClientID(Int64 idAccessToken, string clientID)
		{
			//Create repository based on its Key name : 'Keywords.UpdateAccessToken'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateAccessTokenRepository repository = (IUpdateAccessTokenRepository)RepositoryFactory.Create(Keywords.UpdateAccessToken);
            try
            {
            	//Execute UpdateClientID
                repository.UpdateClientID(idAccessToken, clientID);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Access Token data with id Access Token, client Secret
        /// </summary>
		/// <param name="idAccessToken"> Id Access Token</param>
		/// <param name="clientSecret"> Client Secret</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateClientSecret(Int64 idAccessToken, string clientSecret)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate ClientSecret
			ValidationResult validationResult = this.ValidateClientSecret( idAccessToken, clientSecret );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateClientSecret(idAccessToken, clientSecret);
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
		protected virtual ValidationResult ValidateClientSecret(Int64 idAccessToken, string clientSecret)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateAccessToken'. 
				//The validator factory will create the validator object based on its key.
				IAccessTokenValidator validator = (IAccessTokenValidator)ValidatorFactory.Create(Keywords.UpdateAccessToken);
				
				//Execute validation process
				validationResult = validator.ValidateClientSecret(idAccessToken, clientSecret);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update ClientSecret
		protected virtual OperationResult _UpdateClientSecret(Int64 idAccessToken, string clientSecret)
		{
			//Create repository based on its Key name : 'Keywords.UpdateAccessToken'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateAccessTokenRepository repository = (IUpdateAccessTokenRepository)RepositoryFactory.Create(Keywords.UpdateAccessToken);
            try
            {
            	//Execute UpdateClientSecret
                repository.UpdateClientSecret(idAccessToken, clientSecret);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Access Token data with id Access Token, created Date
        /// </summary>
		/// <param name="idAccessToken"> Id Access Token</param>
		/// <param name="createdDate"> Created Date</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateCreatedDate(Int64 idAccessToken, DateTime createdDate)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate CreatedDate
			ValidationResult validationResult = this.ValidateCreatedDate( idAccessToken, createdDate );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateCreatedDate(idAccessToken, createdDate);
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
		protected virtual ValidationResult ValidateCreatedDate(Int64 idAccessToken, DateTime createdDate)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateAccessToken'. 
				//The validator factory will create the validator object based on its key.
				IAccessTokenValidator validator = (IAccessTokenValidator)ValidatorFactory.Create(Keywords.UpdateAccessToken);
				
				//Execute validation process
				validationResult = validator.ValidateCreatedDate(idAccessToken, createdDate);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update CreatedDate
		protected virtual OperationResult _UpdateCreatedDate(Int64 idAccessToken, DateTime createdDate)
		{
			//Create repository based on its Key name : 'Keywords.UpdateAccessToken'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateAccessTokenRepository repository = (IUpdateAccessTokenRepository)RepositoryFactory.Create(Keywords.UpdateAccessToken);
            try
            {
            	//Execute UpdateCreatedDate
                repository.UpdateCreatedDate(idAccessToken, createdDate);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Access Token data with id Access Token, expired Date
        /// </summary>
		/// <param name="idAccessToken"> Id Access Token</param>
		/// <param name="expiredDate"> Expired Date</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateExpiredDate(Int64 idAccessToken, DateTime expiredDate)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate ExpiredDate
			ValidationResult validationResult = this.ValidateExpiredDate( idAccessToken, expiredDate );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateExpiredDate(idAccessToken, expiredDate);
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
		protected virtual ValidationResult ValidateExpiredDate(Int64 idAccessToken, DateTime expiredDate)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateAccessToken'. 
				//The validator factory will create the validator object based on its key.
				IAccessTokenValidator validator = (IAccessTokenValidator)ValidatorFactory.Create(Keywords.UpdateAccessToken);
				
				//Execute validation process
				validationResult = validator.ValidateExpiredDate(idAccessToken, expiredDate);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update ExpiredDate
		protected virtual OperationResult _UpdateExpiredDate(Int64 idAccessToken, DateTime expiredDate)
		{
			//Create repository based on its Key name : 'Keywords.UpdateAccessToken'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateAccessTokenRepository repository = (IUpdateAccessTokenRepository)RepositoryFactory.Create(Keywords.UpdateAccessToken);
            try
            {
            	//Execute UpdateExpiredDate
                repository.UpdateExpiredDate(idAccessToken, expiredDate);
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