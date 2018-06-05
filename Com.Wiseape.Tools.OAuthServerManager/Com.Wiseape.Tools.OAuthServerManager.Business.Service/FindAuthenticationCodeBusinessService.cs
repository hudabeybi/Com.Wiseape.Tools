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
    /// Business Service for AuthenticationCode module.
    /// </summary>
    public class FindAuthenticationCodeBusinessService : BaseBusinessService<AuthenticationCode>, IFindAuthenticationCodeBusinessService
    {
        class Keywords
        {
            public static string FindAuthenticationCode = "Find.Tools.OAuthServerManager.AuthenticationCode";
        }
        
        public FindAuthenticationCodeBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public FindAuthenticationCodeBusinessService()
        {
            this.RepoKey = Keywords.FindAuthenticationCode;
        }


        /// <summary>
        /// Finds all  Authentication Code data with authentication Code String containing specified keyword
        /// </summary>
		/// <param name="authenticationCodeString"> Authentication Code String</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByAuthenticationCodeString(string authenticationCodeString)
		{
            IFindAuthenticationCodeRepository repository = (IFindAuthenticationCodeRepository)RepositoryFactory.Create(Keywords.FindAuthenticationCode);
            try
            {
                List<AuthenticationCode> res = repository.FindByAuthenticationCodeString(authenticationCodeString);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Authentication Code data with client I D containing specified keyword
        /// </summary>
		/// <param name="clientID"> Client I D</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByClientID(string clientID)
		{
            IFindAuthenticationCodeRepository repository = (IFindAuthenticationCodeRepository)RepositoryFactory.Create(Keywords.FindAuthenticationCode);
            try
            {
                List<AuthenticationCode> res = repository.FindByClientID(clientID);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Authentication Code data with authorization Session I D containing specified keyword
        /// </summary>
		/// <param name="authorizationSessionID"> Authorization Session I D</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByAuthorizationSessionID(string authorizationSessionID)
		{
            IFindAuthenticationCodeRepository repository = (IFindAuthenticationCodeRepository)RepositoryFactory.Create(Keywords.FindAuthenticationCode);
            try
            {
                List<AuthenticationCode> res = repository.FindByAuthorizationSessionID(authorizationSessionID);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Authentication Code data with created Date1, created Date2 containing specified keyword
        /// </summary>
		/// <param name="createdDate1"> Created Date</param>
		/// <param name="createdDate2"> Created Date</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByCreatedDateBetween(DateTime createdDate1, DateTime createdDate2)
		{
            IFindAuthenticationCodeRepository repository = (IFindAuthenticationCodeRepository)RepositoryFactory.Create(Keywords.FindAuthenticationCode);
            try
            {
                List<AuthenticationCode> res = repository.FindByCreatedDateBetween(createdDate1, createdDate2);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Authentication Code data with expired Date1, expired Date2 containing specified keyword
        /// </summary>
		/// <param name="expiredDate1"> Expired Date</param>
		/// <param name="expiredDate2"> Expired Date</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByExpiredDateBetween(DateTime expiredDate1, DateTime expiredDate2)
		{
            IFindAuthenticationCodeRepository repository = (IFindAuthenticationCodeRepository)RepositoryFactory.Create(Keywords.FindAuthenticationCode);
            try
            {
                List<AuthenticationCode> res = repository.FindByExpiredDateBetween(expiredDate1, expiredDate2);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}



    }
 }