using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Framework;
using Com.Wiseape.Tools.Data.Model;
using Com.Wiseape.Tools.Data.Context;
using Com.Wiseape.Tools.OAuthServerManager.Repository.Contract;

namespace Com.Wiseape.Tools.OAuthServerManager.Repository.Service
{
    /// <summary>
    /// Repository for RegisteredApplication data.
    /// </summary>
    public class FindRegisteredApplicationRepository : BaseRepository<RegisteredApplication>, IFindRegisteredApplicationRepository
    {
        class Keywords
        {
            public static string FindRegisteredApplication = "Find.Tools.OAuthServerManager.RegisteredApplication";
        }

        /// <summary>
        /// Constructor for RegisteredApplicationRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public FindRegisteredApplicationRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public FindRegisteredApplicationRepository()
        {
            this.DataContextKey = Keywords.FindRegisteredApplication;
        }

//------------------- Find by keywords --------------------------------------------------------

        /// <summary>
        /// Finds all  Registered Application data with application Name containing specified keyword
        /// </summary>
		/// <param name="applicationName"> Application Name</param>
		/// <returns>List of  Registered Application</returns>
        public List<RegisteredApplication> FindByApplicationName(string applicationName)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.RegisteredApplications
                       where
							o.ApplicationName.Contains(applicationName) 						
						select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  Registered Application data with application Desc containing specified keyword
        /// </summary>
		/// <param name="applicationDesc"> Application Desc</param>
		/// <returns>List of  Registered Application</returns>
        public List<RegisteredApplication> FindByApplicationDesc(string applicationDesc)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.RegisteredApplications
                       where
							o.ApplicationDesc.Contains(applicationDesc) 						
						select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  Registered Application data with client I D containing specified keyword
        /// </summary>
		/// <param name="clientID"> Client I D</param>
		/// <returns>List of  Registered Application</returns>
        public List<RegisteredApplication> FindByClientID(string clientID)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.RegisteredApplications
                       where
							o.ClientID.Contains(clientID) 						
						select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  Registered Application data with client Secret containing specified keyword
        /// </summary>
		/// <param name="clientSecret"> Client Secret</param>
		/// <returns>List of  Registered Application</returns>
        public List<RegisteredApplication> FindByClientSecret(string clientSecret)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.RegisteredApplications
                       where
							o.ClientSecret.Contains(clientSecret) 						
						select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  Registered Application data with authorization Token Redirect U R I containing specified keyword
        /// </summary>
		/// <param name="authorizationTokenRedirectURI"> Authorization Token Redirect U R I</param>
		/// <returns>List of  Registered Application</returns>
        public List<RegisteredApplication> FindByAuthorizationTokenRedirectURI(string authorizationTokenRedirectURI)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.RegisteredApplications
                       where
							o.AuthorizationTokenRedirectURI.Contains(authorizationTokenRedirectURI) 						
						select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  Registered Application data with access Token Redirect U R I containing specified keyword
        /// </summary>
		/// <param name="accessTokenRedirectURI"> Access Token Redirect U R I</param>
		/// <returns>List of  Registered Application</returns>
        public List<RegisteredApplication> FindByAccessTokenRedirectURI(string accessTokenRedirectURI)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.RegisteredApplications
                       where
							o.AccessTokenRedirectURI.Contains(accessTokenRedirectURI) 						
						select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  Registered Application data with authentication Source Connection String containing specified keyword
        /// </summary>
		/// <param name="authenticationSourceConnectionString"> Authentication Source Connection String</param>
		/// <returns>List of  Registered Application</returns>
        public List<RegisteredApplication> FindByAuthenticationSourceConnectionString(string authenticationSourceConnectionString)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.RegisteredApplications
                       where
							o.AuthenticationSourceConnectionString.Contains(authenticationSourceConnectionString) 						
						select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  Registered Application data with authentication Url containing specified keyword
        /// </summary>
		/// <param name="authenticationUrl"> Authentication Url</param>
		/// <returns>List of  Registered Application</returns>
        public List<RegisteredApplication> FindByAuthenticationUrl(string authenticationUrl)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.RegisteredApplications
                       where
							o.AuthenticationUrl.Contains(authenticationUrl) 						
						select o;
            return list.ToList();
        }


//----------------------  find by dates -----------------------------------------------

        /// <summary>
        /// Finds all  Registered Application with CreatedDate between CreatedDate1 and CreatedDate2
        /// </summary>
		/// <param name="createdDate1"> Created Date</param>
		/// <param name="createdDate2"> Created Date</param>
		/// <returns>List of  Registered Application</returns>
        public List<RegisteredApplication> FindByCreatedDateBetween(DateTime createdDate1, DateTime createdDate2)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.RegisteredApplications
                       where
                            o.CreatedDate >= createdDate1 &&
                            o.CreatedDate <= createdDate2
                       select o;
            return list.ToList();
        }


//-----------------------  Find by Foreign keys ---------------------------------------

        /// <summary>
        /// Finds all  Registered Application data with specified authentication Source Id 
        /// </summary>
		/// <param name="authenticationSourceId"> Authentication Source Id</param>
		/// <returns>List of  Registered Application</returns>
        public List<RegisteredApplication> FindByAuthenticationSourceId(Int16 authenticationSourceId)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.RegisteredApplications
                       where
							o.AuthenticationSourceId == authenticationSourceId  						
						select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  Registered Application data with specified authentication Source Id, is Active 
        /// </summary>
		/// <param name="authenticationSourceId"> Authentication Source Id</param>
		/// <param name="isActive"> Is Active</param>
		/// <returns>List of  Registered Application</returns>
        public List<RegisteredApplication> FindByAuthenticationSourceIdAndIsActive(Int16 authenticationSourceId, Int16 isActive)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.RegisteredApplications
                       where
							o.AuthenticationSourceId == authenticationSourceId && 
							o.IsActive == isActive  						
						select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  Registered Application data with specified is Active 
        /// </summary>
		/// <param name="isActive"> Is Active</param>
		/// <returns>List of  Registered Application</returns>
        public List<RegisteredApplication> FindByIsActive(Int16 isActive)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.RegisteredApplications
                       where
							o.IsActive == isActive  						
						select o;
            return list.ToList();
        }




    }
}
