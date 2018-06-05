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
    /// Business Service for AccessToken module.
    /// </summary>
    public class FindAccessTokenBusinessService : BaseBusinessService<AccessToken>, IFindAccessTokenBusinessService
    {
        class Keywords
        {
            public static string FindAccessToken = "Find.Tools.OAuthServerManager.AccessToken";
        }
        
        public FindAccessTokenBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public FindAccessTokenBusinessService()
        {
            this.RepoKey = Keywords.FindAccessToken;
        }


        /// <summary>
        /// Finds all  Access Token data with access Token String containing specified keyword
        /// </summary>
		/// <param name="accessTokenString"> Access Token String</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByAccessTokenString(string accessTokenString)
		{
            IFindAccessTokenRepository repository = (IFindAccessTokenRepository)RepositoryFactory.Create(Keywords.FindAccessToken);
            try
            {
                List<AccessToken> res = repository.FindByAccessTokenString(accessTokenString);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Access Token data with refresh Token containing specified keyword
        /// </summary>
		/// <param name="refreshToken"> Refresh Token</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByRefreshToken(string refreshToken)
		{
            IFindAccessTokenRepository repository = (IFindAccessTokenRepository)RepositoryFactory.Create(Keywords.FindAccessToken);
            try
            {
                List<AccessToken> res = repository.FindByRefreshToken(refreshToken);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Access Token data with client I D containing specified keyword
        /// </summary>
		/// <param name="clientID"> Client I D</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByClientID(string clientID)
		{
            IFindAccessTokenRepository repository = (IFindAccessTokenRepository)RepositoryFactory.Create(Keywords.FindAccessToken);
            try
            {
                List<AccessToken> res = repository.FindByClientID(clientID);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Access Token data with client Secret containing specified keyword
        /// </summary>
		/// <param name="clientSecret"> Client Secret</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByClientSecret(string clientSecret)
		{
            IFindAccessTokenRepository repository = (IFindAccessTokenRepository)RepositoryFactory.Create(Keywords.FindAccessToken);
            try
            {
                List<AccessToken> res = repository.FindByClientSecret(clientSecret);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Access Token data with created Date1, created Date2 containing specified keyword
        /// </summary>
		/// <param name="createdDate1"> Created Date</param>
		/// <param name="createdDate2"> Created Date</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByCreatedDateBetween(DateTime createdDate1, DateTime createdDate2)
		{
            IFindAccessTokenRepository repository = (IFindAccessTokenRepository)RepositoryFactory.Create(Keywords.FindAccessToken);
            try
            {
                List<AccessToken> res = repository.FindByCreatedDateBetween(createdDate1, createdDate2);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Access Token data with expired Date1, expired Date2 containing specified keyword
        /// </summary>
		/// <param name="expiredDate1"> Expired Date</param>
		/// <param name="expiredDate2"> Expired Date</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByExpiredDateBetween(DateTime expiredDate1, DateTime expiredDate2)
		{
            IFindAccessTokenRepository repository = (IFindAccessTokenRepository)RepositoryFactory.Create(Keywords.FindAccessToken);
            try
            {
                List<AccessToken> res = repository.FindByExpiredDateBetween(expiredDate1, expiredDate2);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}



    }
 }