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
    public class DeleteAccessTokenBusinessService : BaseBusinessService<AccessToken>, IDeleteAccessTokenBusinessService
    {
        class Keywords
        {
            public static string DeleteAccessToken = "Delete.Tools.OAuthServerManager.AccessToken";
        }
        
        public DeleteAccessTokenBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public DeleteAccessTokenBusinessService()
        {
            this.RepoKey = Keywords.DeleteAccessToken;
        }

        /// <summary>
        /// Delete  Access Token data by access Token String
        /// </summary>
		/// <param name="accessTokenString"> Access Token String</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByAccessTokenString(string accessTokenString)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate AccessTokenString
			ValidationResult validationResult = this.ValidateAccessTokenString( accessTokenString );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByAccessTokenString(accessTokenString);
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
		protected virtual ValidationResult ValidateAccessTokenString(string accessTokenString)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateAccessToken'. 
				//The validator factory will create the validator object based on its key.
				IAccessTokenValidator validator = (IAccessTokenValidator)ValidatorFactory.Create(Keywords.DeleteAccessToken);
				
				//Execute validation process
				validationResult = validator.ValidateAccessTokenString(accessTokenString);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete AccessTokenString
		protected virtual OperationResult _DeleteByAccessTokenString(string accessTokenString)
		{
			//Create repository based on its Key name : 'Keywords.DeleteAccessToken'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteAccessTokenRepository repository = (IDeleteAccessTokenRepository)RepositoryFactory.Create(Keywords.DeleteAccessToken);
            try
            {
            	//Execute DeleteByAccessTokenString
                repository.DeleteByAccessTokenString(accessTokenString);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  Access Token data by refresh Token
        /// </summary>
		/// <param name="refreshToken"> Refresh Token</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByRefreshToken(string refreshToken)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate RefreshToken
			ValidationResult validationResult = this.ValidateRefreshToken( refreshToken );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByRefreshToken(refreshToken);
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
		protected virtual ValidationResult ValidateRefreshToken(string refreshToken)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateAccessToken'. 
				//The validator factory will create the validator object based on its key.
				IAccessTokenValidator validator = (IAccessTokenValidator)ValidatorFactory.Create(Keywords.DeleteAccessToken);
				
				//Execute validation process
				validationResult = validator.ValidateRefreshToken(refreshToken);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete RefreshToken
		protected virtual OperationResult _DeleteByRefreshToken(string refreshToken)
		{
			//Create repository based on its Key name : 'Keywords.DeleteAccessToken'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteAccessTokenRepository repository = (IDeleteAccessTokenRepository)RepositoryFactory.Create(Keywords.DeleteAccessToken);
            try
            {
            	//Execute DeleteByRefreshToken
                repository.DeleteByRefreshToken(refreshToken);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  Access Token data by client I D
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
				//Create Validator based on its Key name : 'Keywords.UpdateAccessToken'. 
				//The validator factory will create the validator object based on its key.
				IAccessTokenValidator validator = (IAccessTokenValidator)ValidatorFactory.Create(Keywords.DeleteAccessToken);
				
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
			//Create repository based on its Key name : 'Keywords.DeleteAccessToken'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteAccessTokenRepository repository = (IDeleteAccessTokenRepository)RepositoryFactory.Create(Keywords.DeleteAccessToken);
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
        /// Delete  Access Token data by client Secret
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
				//Create Validator based on its Key name : 'Keywords.UpdateAccessToken'. 
				//The validator factory will create the validator object based on its key.
				IAccessTokenValidator validator = (IAccessTokenValidator)ValidatorFactory.Create(Keywords.DeleteAccessToken);
				
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
			//Create repository based on its Key name : 'Keywords.DeleteAccessToken'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteAccessTokenRepository repository = (IDeleteAccessTokenRepository)RepositoryFactory.Create(Keywords.DeleteAccessToken);
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
        /// Delete  Access Token data by created Date
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
				//Create Validator based on its Key name : 'Keywords.UpdateAccessToken'. 
				//The validator factory will create the validator object based on its key.
				IAccessTokenValidator validator = (IAccessTokenValidator)ValidatorFactory.Create(Keywords.DeleteAccessToken);
				
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
			//Create repository based on its Key name : 'Keywords.DeleteAccessToken'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteAccessTokenRepository repository = (IDeleteAccessTokenRepository)RepositoryFactory.Create(Keywords.DeleteAccessToken);
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
        /// Delete  Access Token data by expired Date
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
				//Create Validator based on its Key name : 'Keywords.UpdateAccessToken'. 
				//The validator factory will create the validator object based on its key.
				IAccessTokenValidator validator = (IAccessTokenValidator)ValidatorFactory.Create(Keywords.DeleteAccessToken);
				
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
			//Create repository based on its Key name : 'Keywords.DeleteAccessToken'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteAccessTokenRepository repository = (IDeleteAccessTokenRepository)RepositoryFactory.Create(Keywords.DeleteAccessToken);
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