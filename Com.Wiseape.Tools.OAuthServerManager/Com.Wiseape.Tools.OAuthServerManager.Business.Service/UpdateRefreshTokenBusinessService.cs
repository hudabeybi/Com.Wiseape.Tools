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
    public class UpdateRefreshTokenBusinessService : BaseBusinessService<RefreshToken>, IUpdateRefreshTokenBusinessService
    {
        class Keywords
        {
            public static string UpdateRefreshToken = "Update.Tools.OAuthServerManager.RefreshToken";
        }
        
        public UpdateRefreshTokenBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public UpdateRefreshTokenBusinessService()
        {
            this.RepoKey = Keywords.UpdateRefreshToken;
        }


        /// <summary>
        /// Update  Refresh Token data with id Refresh Token, client I D
        /// </summary>
		/// <param name="idRefreshToken"> Id Refresh Token</param>
		/// <param name="clientID"> Client I D</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateClientID(Int64 idRefreshToken, string clientID)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate ClientID
			ValidationResult validationResult = this.ValidateClientID( idRefreshToken, clientID );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateClientID(idRefreshToken, clientID);
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
		protected virtual ValidationResult ValidateClientID(Int64 idRefreshToken, string clientID)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateRefreshToken'. 
				//The validator factory will create the validator object based on its key.
				IRefreshTokenValidator validator = (IRefreshTokenValidator)ValidatorFactory.Create(Keywords.UpdateRefreshToken);
				
				//Execute validation process
				validationResult = validator.ValidateClientID(idRefreshToken, clientID);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update ClientID
		protected virtual OperationResult _UpdateClientID(Int64 idRefreshToken, string clientID)
		{
			//Create repository based on its Key name : 'Keywords.UpdateRefreshToken'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateRefreshTokenRepository repository = (IUpdateRefreshTokenRepository)RepositoryFactory.Create(Keywords.UpdateRefreshToken);
            try
            {
            	//Execute UpdateClientID
                repository.UpdateClientID(idRefreshToken, clientID);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Refresh Token data with id Refresh Token, client Secret
        /// </summary>
		/// <param name="idRefreshToken"> Id Refresh Token</param>
		/// <param name="clientSecret"> Client Secret</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateClientSecret(Int64 idRefreshToken, string clientSecret)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate ClientSecret
			ValidationResult validationResult = this.ValidateClientSecret( idRefreshToken, clientSecret );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateClientSecret(idRefreshToken, clientSecret);
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
		protected virtual ValidationResult ValidateClientSecret(Int64 idRefreshToken, string clientSecret)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateRefreshToken'. 
				//The validator factory will create the validator object based on its key.
				IRefreshTokenValidator validator = (IRefreshTokenValidator)ValidatorFactory.Create(Keywords.UpdateRefreshToken);
				
				//Execute validation process
				validationResult = validator.ValidateClientSecret(idRefreshToken, clientSecret);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update ClientSecret
		protected virtual OperationResult _UpdateClientSecret(Int64 idRefreshToken, string clientSecret)
		{
			//Create repository based on its Key name : 'Keywords.UpdateRefreshToken'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateRefreshTokenRepository repository = (IUpdateRefreshTokenRepository)RepositoryFactory.Create(Keywords.UpdateRefreshToken);
            try
            {
            	//Execute UpdateClientSecret
                repository.UpdateClientSecret(idRefreshToken, clientSecret);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Refresh Token data with id Refresh Token, authentication Code
        /// </summary>
		/// <param name="idRefreshToken"> Id Refresh Token</param>
		/// <param name="authenticationCode"> Authentication Code</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateAuthenticationCode(Int64 idRefreshToken, string authenticationCode)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate AuthenticationCode
			ValidationResult validationResult = this.ValidateAuthenticationCode( idRefreshToken, authenticationCode );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateAuthenticationCode(idRefreshToken, authenticationCode);
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
		protected virtual ValidationResult ValidateAuthenticationCode(Int64 idRefreshToken, string authenticationCode)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateRefreshToken'. 
				//The validator factory will create the validator object based on its key.
				IRefreshTokenValidator validator = (IRefreshTokenValidator)ValidatorFactory.Create(Keywords.UpdateRefreshToken);
				
				//Execute validation process
				validationResult = validator.ValidateAuthenticationCode(idRefreshToken, authenticationCode);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update AuthenticationCode
		protected virtual OperationResult _UpdateAuthenticationCode(Int64 idRefreshToken, string authenticationCode)
		{
			//Create repository based on its Key name : 'Keywords.UpdateRefreshToken'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateRefreshTokenRepository repository = (IUpdateRefreshTokenRepository)RepositoryFactory.Create(Keywords.UpdateRefreshToken);
            try
            {
            	//Execute UpdateAuthenticationCode
                repository.UpdateAuthenticationCode(idRefreshToken, authenticationCode);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Refresh Token data with id Refresh Token, refresh Token String
        /// </summary>
		/// <param name="idRefreshToken"> Id Refresh Token</param>
		/// <param name="refreshTokenString"> Refresh Token String</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateRefreshTokenString(Int64 idRefreshToken, string refreshTokenString)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate RefreshTokenString
			ValidationResult validationResult = this.ValidateRefreshTokenString( idRefreshToken, refreshTokenString );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateRefreshTokenString(idRefreshToken, refreshTokenString);
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
		protected virtual ValidationResult ValidateRefreshTokenString(Int64 idRefreshToken, string refreshTokenString)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateRefreshToken'. 
				//The validator factory will create the validator object based on its key.
				IRefreshTokenValidator validator = (IRefreshTokenValidator)ValidatorFactory.Create(Keywords.UpdateRefreshToken);
				
				//Execute validation process
				validationResult = validator.ValidateRefreshTokenString(idRefreshToken, refreshTokenString);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update RefreshTokenString
		protected virtual OperationResult _UpdateRefreshTokenString(Int64 idRefreshToken, string refreshTokenString)
		{
			//Create repository based on its Key name : 'Keywords.UpdateRefreshToken'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateRefreshTokenRepository repository = (IUpdateRefreshTokenRepository)RepositoryFactory.Create(Keywords.UpdateRefreshToken);
            try
            {
            	//Execute UpdateRefreshTokenString
                repository.UpdateRefreshTokenString(idRefreshToken, refreshTokenString);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Refresh Token data with id Refresh Token, created Date
        /// </summary>
		/// <param name="idRefreshToken"> Id Refresh Token</param>
		/// <param name="createdDate"> Created Date</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateCreatedDate(Int64 idRefreshToken, DateTime createdDate)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate CreatedDate
			ValidationResult validationResult = this.ValidateCreatedDate( idRefreshToken, createdDate );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateCreatedDate(idRefreshToken, createdDate);
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
		protected virtual ValidationResult ValidateCreatedDate(Int64 idRefreshToken, DateTime createdDate)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateRefreshToken'. 
				//The validator factory will create the validator object based on its key.
				IRefreshTokenValidator validator = (IRefreshTokenValidator)ValidatorFactory.Create(Keywords.UpdateRefreshToken);
				
				//Execute validation process
				validationResult = validator.ValidateCreatedDate(idRefreshToken, createdDate);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update CreatedDate
		protected virtual OperationResult _UpdateCreatedDate(Int64 idRefreshToken, DateTime createdDate)
		{
			//Create repository based on its Key name : 'Keywords.UpdateRefreshToken'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateRefreshTokenRepository repository = (IUpdateRefreshTokenRepository)RepositoryFactory.Create(Keywords.UpdateRefreshToken);
            try
            {
            	//Execute UpdateCreatedDate
                repository.UpdateCreatedDate(idRefreshToken, createdDate);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Refresh Token data with id Refresh Token, expired Date
        /// </summary>
		/// <param name="idRefreshToken"> Id Refresh Token</param>
		/// <param name="expiredDate"> Expired Date</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateExpiredDate(Int64 idRefreshToken, DateTime expiredDate)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate ExpiredDate
			ValidationResult validationResult = this.ValidateExpiredDate( idRefreshToken, expiredDate );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateExpiredDate(idRefreshToken, expiredDate);
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
		protected virtual ValidationResult ValidateExpiredDate(Int64 idRefreshToken, DateTime expiredDate)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateRefreshToken'. 
				//The validator factory will create the validator object based on its key.
				IRefreshTokenValidator validator = (IRefreshTokenValidator)ValidatorFactory.Create(Keywords.UpdateRefreshToken);
				
				//Execute validation process
				validationResult = validator.ValidateExpiredDate(idRefreshToken, expiredDate);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update ExpiredDate
		protected virtual OperationResult _UpdateExpiredDate(Int64 idRefreshToken, DateTime expiredDate)
		{
			//Create repository based on its Key name : 'Keywords.UpdateRefreshToken'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateRefreshTokenRepository repository = (IUpdateRefreshTokenRepository)RepositoryFactory.Create(Keywords.UpdateRefreshToken);
            try
            {
            	//Execute UpdateExpiredDate
                repository.UpdateExpiredDate(idRefreshToken, expiredDate);
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