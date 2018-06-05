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
    /// Business Service for RegisteredApplication module.
    /// </summary>
    public class FindRegisteredApplicationBusinessService : BaseBusinessService<RegisteredApplication>, IFindRegisteredApplicationBusinessService
    {
        class Keywords
        {
            public static string FindRegisteredApplication = "Find.Tools.OAuthServerManager.RegisteredApplication";
        }
        
        public FindRegisteredApplicationBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public FindRegisteredApplicationBusinessService()
        {
            this.RepoKey = Keywords.FindRegisteredApplication;
        }


        /// <summary>
        /// Finds all  Registered Application data with application Name containing specified keyword
        /// </summary>
		/// <param name="applicationName"> Application Name</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByApplicationName(string applicationName)
		{
            IFindRegisteredApplicationRepository repository = (IFindRegisteredApplicationRepository)RepositoryFactory.Create(Keywords.FindRegisteredApplication);
            try
            {
                List<RegisteredApplication> res = repository.FindByApplicationName(applicationName);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Registered Application data with application Desc containing specified keyword
        /// </summary>
		/// <param name="applicationDesc"> Application Desc</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByApplicationDesc(string applicationDesc)
		{
            IFindRegisteredApplicationRepository repository = (IFindRegisteredApplicationRepository)RepositoryFactory.Create(Keywords.FindRegisteredApplication);
            try
            {
                List<RegisteredApplication> res = repository.FindByApplicationDesc(applicationDesc);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Registered Application data with client I D containing specified keyword
        /// </summary>
		/// <param name="clientID"> Client I D</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByClientID(string clientID)
		{
            IFindRegisteredApplicationRepository repository = (IFindRegisteredApplicationRepository)RepositoryFactory.Create(Keywords.FindRegisteredApplication);
            try
            {
                List<RegisteredApplication> res = repository.FindByClientID(clientID);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Registered Application data with client Secret containing specified keyword
        /// </summary>
		/// <param name="clientSecret"> Client Secret</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByClientSecret(string clientSecret)
		{
            IFindRegisteredApplicationRepository repository = (IFindRegisteredApplicationRepository)RepositoryFactory.Create(Keywords.FindRegisteredApplication);
            try
            {
                List<RegisteredApplication> res = repository.FindByClientSecret(clientSecret);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Registered Application data with authorization Token Redirect U R I containing specified keyword
        /// </summary>
		/// <param name="authorizationTokenRedirectURI"> Authorization Token Redirect U R I</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByAuthorizationTokenRedirectURI(string authorizationTokenRedirectURI)
		{
            IFindRegisteredApplicationRepository repository = (IFindRegisteredApplicationRepository)RepositoryFactory.Create(Keywords.FindRegisteredApplication);
            try
            {
                List<RegisteredApplication> res = repository.FindByAuthorizationTokenRedirectURI(authorizationTokenRedirectURI);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Registered Application data with access Token Redirect U R I containing specified keyword
        /// </summary>
		/// <param name="accessTokenRedirectURI"> Access Token Redirect U R I</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByAccessTokenRedirectURI(string accessTokenRedirectURI)
		{
            IFindRegisteredApplicationRepository repository = (IFindRegisteredApplicationRepository)RepositoryFactory.Create(Keywords.FindRegisteredApplication);
            try
            {
                List<RegisteredApplication> res = repository.FindByAccessTokenRedirectURI(accessTokenRedirectURI);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Registered Application data with authentication Source Connection String containing specified keyword
        /// </summary>
		/// <param name="authenticationSourceConnectionString"> Authentication Source Connection String</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByAuthenticationSourceConnectionString(string authenticationSourceConnectionString)
		{
            IFindRegisteredApplicationRepository repository = (IFindRegisteredApplicationRepository)RepositoryFactory.Create(Keywords.FindRegisteredApplication);
            try
            {
                List<RegisteredApplication> res = repository.FindByAuthenticationSourceConnectionString(authenticationSourceConnectionString);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Registered Application data with authentication Url containing specified keyword
        /// </summary>
		/// <param name="authenticationUrl"> Authentication Url</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByAuthenticationUrl(string authenticationUrl)
		{
            IFindRegisteredApplicationRepository repository = (IFindRegisteredApplicationRepository)RepositoryFactory.Create(Keywords.FindRegisteredApplication);
            try
            {
                List<RegisteredApplication> res = repository.FindByAuthenticationUrl(authenticationUrl);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Registered Application data with created Date1, created Date2 containing specified keyword
        /// </summary>
		/// <param name="createdDate1"> Created Date</param>
		/// <param name="createdDate2"> Created Date</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByCreatedDateBetween(DateTime createdDate1, DateTime createdDate2)
		{
            IFindRegisteredApplicationRepository repository = (IFindRegisteredApplicationRepository)RepositoryFactory.Create(Keywords.FindRegisteredApplication);
            try
            {
                List<RegisteredApplication> res = repository.FindByCreatedDateBetween(createdDate1, createdDate2);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Registered Application data with authentication Source Id containing specified keyword
        /// </summary>
		/// <param name="authenticationSourceId"> Authentication Source Id</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByAuthenticationSourceId(Int16 authenticationSourceId)
		{
            IFindRegisteredApplicationRepository repository = (IFindRegisteredApplicationRepository)RepositoryFactory.Create(Keywords.FindRegisteredApplication);
            try
            {
                List<RegisteredApplication> res = repository.FindByAuthenticationSourceId(authenticationSourceId);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Registered Application data with authentication Source Id, is Active containing specified keyword
        /// </summary>
		/// <param name="authenticationSourceId"> Authentication Source Id</param>
		/// <param name="isActive"> Is Active</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByAuthenticationSourceIdAndIsActive(Int16 authenticationSourceId, Int16 isActive)
		{
            IFindRegisteredApplicationRepository repository = (IFindRegisteredApplicationRepository)RepositoryFactory.Create(Keywords.FindRegisteredApplication);
            try
            {
                List<RegisteredApplication> res = repository.FindByAuthenticationSourceIdAndIsActive(authenticationSourceId, isActive);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Registered Application data with is Active containing specified keyword
        /// </summary>
		/// <param name="isActive"> Is Active</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByIsActive(Int16 isActive)
		{
            IFindRegisteredApplicationRepository repository = (IFindRegisteredApplicationRepository)RepositoryFactory.Create(Keywords.FindRegisteredApplication);
            try
            {
                List<RegisteredApplication> res = repository.FindByIsActive(isActive);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}



    }
 }