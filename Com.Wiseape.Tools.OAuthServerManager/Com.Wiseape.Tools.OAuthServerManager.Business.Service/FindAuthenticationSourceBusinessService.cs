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
    /// Business Service for AuthenticationSource module.
    /// </summary>
    public class FindAuthenticationSourceBusinessService : BaseBusinessService<AuthenticationSource>, IFindAuthenticationSourceBusinessService
    {
        class Keywords
        {
            public static string FindAuthenticationSource = "Find.Tools.OAuthServerManager.AuthenticationSource";
        }
        
        public FindAuthenticationSourceBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public FindAuthenticationSourceBusinessService()
        {
            this.RepoKey = Keywords.FindAuthenticationSource;
        }


        /// <summary>
        /// Finds all  Authentication Source data with authentication Source Name containing specified keyword
        /// </summary>
		/// <param name="authenticationSourceName"> Authentication Source Name</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByAuthenticationSourceName(string authenticationSourceName)
		{
            IFindAuthenticationSourceRepository repository = (IFindAuthenticationSourceRepository)RepositoryFactory.Create(Keywords.FindAuthenticationSource);
            try
            {
                List<AuthenticationSource> res = repository.FindByAuthenticationSourceName(authenticationSourceName);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Authentication Source data with authentication Library containing specified keyword
        /// </summary>
		/// <param name="authenticationLibrary"> Authentication Library</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByAuthenticationLibrary(string authenticationLibrary)
		{
            IFindAuthenticationSourceRepository repository = (IFindAuthenticationSourceRepository)RepositoryFactory.Create(Keywords.FindAuthenticationSource);
            try
            {
                List<AuthenticationSource> res = repository.FindByAuthenticationLibrary(authenticationLibrary);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Authentication Source data with authentication Classname containing specified keyword
        /// </summary>
		/// <param name="authenticationClassname"> Authentication Classname</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByAuthenticationClassname(string authenticationClassname)
		{
            IFindAuthenticationSourceRepository repository = (IFindAuthenticationSourceRepository)RepositoryFactory.Create(Keywords.FindAuthenticationSource);
            try
            {
                List<AuthenticationSource> res = repository.FindByAuthenticationClassname(authenticationClassname);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}



    }
 }