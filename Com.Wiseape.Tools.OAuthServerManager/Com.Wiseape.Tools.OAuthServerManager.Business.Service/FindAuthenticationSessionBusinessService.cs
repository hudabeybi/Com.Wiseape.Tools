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
    /// Business Service for AuthenticationSession module.
    /// </summary>
    public class FindAuthenticationSessionBusinessService : BaseBusinessService<AuthenticationSession>, IFindAuthenticationSessionBusinessService
    {
        class Keywords
        {
            public static string FindAuthenticationSession = "Find.Tools.OAuthServerManager.AuthenticationSession";
        }
        
        public FindAuthenticationSessionBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public FindAuthenticationSessionBusinessService()
        {
            this.RepoKey = Keywords.FindAuthenticationSession;
        }


        /// <summary>
        /// Finds all  Authentication Session data with authentication Session String containing specified keyword
        /// </summary>
		/// <param name="authenticationSessionString"> Authentication Session String</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByAuthenticationSessionString(string authenticationSessionString)
		{
            IFindAuthenticationSessionRepository repository = (IFindAuthenticationSessionRepository)RepositoryFactory.Create(Keywords.FindAuthenticationSession);
            try
            {
                List<AuthenticationSession> res = repository.FindByAuthenticationSessionString(authenticationSessionString);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Authentication Session data with client I D containing specified keyword
        /// </summary>
		/// <param name="clientID"> Client I D</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByClientID(string clientID)
		{
            IFindAuthenticationSessionRepository repository = (IFindAuthenticationSessionRepository)RepositoryFactory.Create(Keywords.FindAuthenticationSession);
            try
            {
                List<AuthenticationSession> res = repository.FindByClientID(clientID);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Authentication Session data with session Created Date1, session Created Date2 containing specified keyword
        /// </summary>
		/// <param name="sessionCreatedDate1"> Session Created Date</param>
		/// <param name="sessionCreatedDate2"> Session Created Date</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindBySessionCreatedDateBetween(DateTime sessionCreatedDate1, DateTime sessionCreatedDate2)
		{
            IFindAuthenticationSessionRepository repository = (IFindAuthenticationSessionRepository)RepositoryFactory.Create(Keywords.FindAuthenticationSession);
            try
            {
                List<AuthenticationSession> res = repository.FindBySessionCreatedDateBetween(sessionCreatedDate1, sessionCreatedDate2);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Authentication Session data with session Expired Date1, session Expired Date2 containing specified keyword
        /// </summary>
		/// <param name="sessionExpiredDate1"> Session Expired Date</param>
		/// <param name="sessionExpiredDate2"> Session Expired Date</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindBySessionExpiredDateBetween(DateTime sessionExpiredDate1, DateTime sessionExpiredDate2)
		{
            IFindAuthenticationSessionRepository repository = (IFindAuthenticationSessionRepository)RepositoryFactory.Create(Keywords.FindAuthenticationSession);
            try
            {
                List<AuthenticationSession> res = repository.FindBySessionExpiredDateBetween(sessionExpiredDate1, sessionExpiredDate2);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}



    }
 }