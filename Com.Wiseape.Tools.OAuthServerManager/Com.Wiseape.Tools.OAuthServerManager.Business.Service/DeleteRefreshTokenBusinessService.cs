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
    /// Business Service for RefreshToken module.
    /// </summary>
    public class DeleteRefreshTokenBusinessService : BaseBusinessService<RefreshToken>, IDeleteRefreshTokenBusinessService
    {
        class Keywords
        {
            public static string DeleteRefreshToken = "Delete.Tools.OAuthServerManager.RefreshToken";
        }
        
        public DeleteRefreshTokenBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public DeleteRefreshTokenBusinessService()
        {
            this.RepoKey = Keywords.DeleteRefreshToken;
        }

        /// <summary>
        /// Delete  Refresh Token data by client I D
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
				//Create Validator based on its Key name : 'Keywords.UpdateRefreshToken'. 
				//The validator factory will create the validator object based on its key.
				IRefreshTokenValidator validator = (IRefreshTokenValidator)ValidatorFactory.Create(Keywords.DeleteRefreshToken);
				
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
			//Create repository based on its Key name : 'Keywords.DeleteRefreshToken'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteRefreshTokenRepository repository = (IDeleteRefreshTokenRepository)RepositoryFactory.Create(Keywords.DeleteRefreshToken);
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
        /// Delete  Refresh Token data by client Secret
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
				//Create Validator based on its Key name : 'Keywords.UpdateRefreshToken'. 
				//The validator factory will create the validator object based on its key.
				IRefreshTokenValidator validator = (IRefreshTokenValidator)ValidatorFactory.Create(Keywords.DeleteRefreshToken);
				
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
			//Create repository based on its Key name : 'Keywords.DeleteRefreshToken'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteRefreshTokenRepository repository = (IDeleteRefreshTokenRepository)RepositoryFactory.Create(Keywords.DeleteRefreshToken);
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
        /// Delete  Refresh Token data by authentication Code
        /// </summary>
		/// <param name="authenticationCode"> Authentication Code</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByAuthenticationCode(string authenticationCode)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate AuthenticationCode
			ValidationResult validationResult = this.ValidateAuthenticationCode( authenticationCode );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByAuthenticationCode(authenticationCode);
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
		
		//Validate AuthenticationCode
		protected virtual ValidationResult ValidateAuthenticationCode(string authenticationCode)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateRefreshToken'. 
				//The validator factory will create the validator object based on its key.
				IRefreshTokenValidator validator = (IRefreshTokenValidator)ValidatorFactory.Create(Keywords.DeleteRefreshToken);
				
				//Execute validation process
				validationResult = validator.ValidateAuthenticationCode(authenticationCode);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete AuthenticationCode
		protected virtual OperationResult _DeleteByAuthenticationCode(string authenticationCode)
		{
			//Create repository based on its Key name : 'Keywords.DeleteRefreshToken'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteRefreshTokenRepository repository = (IDeleteRefreshTokenRepository)RepositoryFactory.Create(Keywords.DeleteRefreshToken);
            try
            {
            	//Execute DeleteByAuthenticationCode
                repository.DeleteByAuthenticationCode(authenticationCode);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  Refresh Token data by refresh Token String
        /// </summary>
		/// <param name="refreshTokenString"> Refresh Token String</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByRefreshTokenString(string refreshTokenString)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate RefreshTokenString
			ValidationResult validationResult = this.ValidateRefreshTokenString( refreshTokenString );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByRefreshTokenString(refreshTokenString);
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
		
		//Validate RefreshTokenString
		protected virtual ValidationResult ValidateRefreshTokenString(string refreshTokenString)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateRefreshToken'. 
				//The validator factory will create the validator object based on its key.
				IRefreshTokenValidator validator = (IRefreshTokenValidator)ValidatorFactory.Create(Keywords.DeleteRefreshToken);
				
				//Execute validation process
				validationResult = validator.ValidateRefreshTokenString(refreshTokenString);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete RefreshTokenString
		protected virtual OperationResult _DeleteByRefreshTokenString(string refreshTokenString)
		{
			//Create repository based on its Key name : 'Keywords.DeleteRefreshToken'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteRefreshTokenRepository repository = (IDeleteRefreshTokenRepository)RepositoryFactory.Create(Keywords.DeleteRefreshToken);
            try
            {
            	//Execute DeleteByRefreshTokenString
                repository.DeleteByRefreshTokenString(refreshTokenString);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  Refresh Token data by created Date
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
				//Create Validator based on its Key name : 'Keywords.UpdateRefreshToken'. 
				//The validator factory will create the validator object based on its key.
				IRefreshTokenValidator validator = (IRefreshTokenValidator)ValidatorFactory.Create(Keywords.DeleteRefreshToken);
				
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
			//Create repository based on its Key name : 'Keywords.DeleteRefreshToken'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteRefreshTokenRepository repository = (IDeleteRefreshTokenRepository)RepositoryFactory.Create(Keywords.DeleteRefreshToken);
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
        /// Delete  Refresh Token data by expired Date
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
				//Create Validator based on its Key name : 'Keywords.UpdateRefreshToken'. 
				//The validator factory will create the validator object based on its key.
				IRefreshTokenValidator validator = (IRefreshTokenValidator)ValidatorFactory.Create(Keywords.DeleteRefreshToken);
				
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
			//Create repository based on its Key name : 'Keywords.DeleteRefreshToken'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteRefreshTokenRepository repository = (IDeleteRefreshTokenRepository)RepositoryFactory.Create(Keywords.DeleteRefreshToken);
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