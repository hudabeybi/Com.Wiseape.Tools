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

namespace Com.Wiseape.Tools.OAuthServerManager.Business.Service
{
    /// <summary>
    /// Business Service for RefreshToken module.
    /// </summary>
    public class FindRefreshTokenBusinessService : BaseBusinessService<RefreshToken>, IFindRefreshTokenBusinessService
    {
        class Keywords
        {
            public static string FindRefreshToken = "Find.Tools.OAuthServerManager.RefreshToken";
        }
        
        public FindRefreshTokenBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public FindRefreshTokenBusinessService()
        {
            this.RepoKey = Keywords.FindRefreshToken;
        }


        /// <summary>
        /// Finds all  Refresh Token data with client I D containing specified keyword
        /// </summary>
		/// <param name="clientID"> Client I D</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByClientID(string clientID)
		{
            IFindRefreshTokenRepository repository = (IFindRefreshTokenRepository)RepositoryFactory.Create(Keywords.FindRefreshToken);
            try
            {
                List<RefreshToken> res = repository.FindByClientID(clientID);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Refresh Token data with client Secret containing specified keyword
        /// </summary>
		/// <param name="clientSecret"> Client Secret</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByClientSecret(string clientSecret)
		{
            IFindRefreshTokenRepository repository = (IFindRefreshTokenRepository)RepositoryFactory.Create(Keywords.FindRefreshToken);
            try
            {
                List<RefreshToken> res = repository.FindByClientSecret(clientSecret);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Refresh Token data with authentication Code containing specified keyword
        /// </summary>
		/// <param name="authenticationCode"> Authentication Code</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByAuthenticationCode(string authenticationCode)
		{
            IFindRefreshTokenRepository repository = (IFindRefreshTokenRepository)RepositoryFactory.Create(Keywords.FindRefreshToken);
            try
            {
                List<RefreshToken> res = repository.FindByAuthenticationCode(authenticationCode);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Refresh Token data with refresh Token String containing specified keyword
        /// </summary>
		/// <param name="refreshTokenString"> Refresh Token String</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByRefreshTokenString(string refreshTokenString)
		{
            IFindRefreshTokenRepository repository = (IFindRefreshTokenRepository)RepositoryFactory.Create(Keywords.FindRefreshToken);
            try
            {
                List<RefreshToken> res = repository.FindByRefreshTokenString(refreshTokenString);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Refresh Token data with created Date1, created Date2 containing specified keyword
        /// </summary>
		/// <param name="createdDate1"> Created Date</param>
		/// <param name="createdDate2"> Created Date</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByCreatedDateBetween(DateTime createdDate1, DateTime createdDate2)
		{
            IFindRefreshTokenRepository repository = (IFindRefreshTokenRepository)RepositoryFactory.Create(Keywords.FindRefreshToken);
            try
            {
                List<RefreshToken> res = repository.FindByCreatedDateBetween(createdDate1, createdDate2);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Refresh Token data with expired Date1, expired Date2 containing specified keyword
        /// </summary>
		/// <param name="expiredDate1"> Expired Date</param>
		/// <param name="expiredDate2"> Expired Date</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByExpiredDateBetween(DateTime expiredDate1, DateTime expiredDate2)
		{
            IFindRefreshTokenRepository repository = (IFindRefreshTokenRepository)RepositoryFactory.Create(Keywords.FindRefreshToken);
            try
            {
                List<RefreshToken> res = repository.FindByExpiredDateBetween(expiredDate1, expiredDate2);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}



    }
 }