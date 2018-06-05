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
    public class DeleteRegisteredApplicationRepository : BaseRepository<RegisteredApplication>, IDeleteRegisteredApplicationRepository
    {
        class Keywords
        {
            public static string DeleteRegisteredApplication = "Delete.Tools.OAuthServerManager.RegisteredApplication";
        }

        /// <summary>
        /// Constructor for DeleteRegisteredApplicationRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public DeleteRegisteredApplicationRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public DeleteRegisteredApplicationRepository()
        {
            this.DataContextKey = Keywords.DeleteRegisteredApplication;
        }

//------------------- Delete by keywords --------------------------------------------------------

        /// <summary>
        /// Delete all  Registered Application data with application Name containing specified keyword
        /// </summary>
		/// <param name="applicationName"> Application Name</param>
		/// <returns>List of  Registered Application</returns>
        public void DeleteByApplicationName(string applicationName)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.RegisteredApplications
                       where
							o.ApplicationName.Contains(applicationName) 						
						select o;
			dataContext.RegisteredApplications.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  Registered Application data with application Desc containing specified keyword
        /// </summary>
		/// <param name="applicationDesc"> Application Desc</param>
		/// <returns>List of  Registered Application</returns>
        public void DeleteByApplicationDesc(string applicationDesc)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.RegisteredApplications
                       where
							o.ApplicationDesc.Contains(applicationDesc) 						
						select o;
			dataContext.RegisteredApplications.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  Registered Application data with client I D containing specified keyword
        /// </summary>
		/// <param name="clientID"> Client I D</param>
		/// <returns>List of  Registered Application</returns>
        public void DeleteByClientID(string clientID)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.RegisteredApplications
                       where
							o.ClientID.Contains(clientID) 						
						select o;
			dataContext.RegisteredApplications.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  Registered Application data with client Secret containing specified keyword
        /// </summary>
		/// <param name="clientSecret"> Client Secret</param>
		/// <returns>List of  Registered Application</returns>
        public void DeleteByClientSecret(string clientSecret)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.RegisteredApplications
                       where
							o.ClientSecret.Contains(clientSecret) 						
						select o;
			dataContext.RegisteredApplications.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  Registered Application data with authorization Token Redirect U R I containing specified keyword
        /// </summary>
		/// <param name="authorizationTokenRedirectURI"> Authorization Token Redirect U R I</param>
		/// <returns>List of  Registered Application</returns>
        public void DeleteByAuthorizationTokenRedirectURI(string authorizationTokenRedirectURI)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.RegisteredApplications
                       where
							o.AuthorizationTokenRedirectURI.Contains(authorizationTokenRedirectURI) 						
						select o;
			dataContext.RegisteredApplications.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  Registered Application data with access Token Redirect U R I containing specified keyword
        /// </summary>
		/// <param name="accessTokenRedirectURI"> Access Token Redirect U R I</param>
		/// <returns>List of  Registered Application</returns>
        public void DeleteByAccessTokenRedirectURI(string accessTokenRedirectURI)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.RegisteredApplications
                       where
							o.AccessTokenRedirectURI.Contains(accessTokenRedirectURI) 						
						select o;
			dataContext.RegisteredApplications.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  Registered Application data with authentication Source Connection String containing specified keyword
        /// </summary>
		/// <param name="authenticationSourceConnectionString"> Authentication Source Connection String</param>
		/// <returns>List of  Registered Application</returns>
        public void DeleteByAuthenticationSourceConnectionString(string authenticationSourceConnectionString)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.RegisteredApplications
                       where
							o.AuthenticationSourceConnectionString.Contains(authenticationSourceConnectionString) 						
						select o;
			dataContext.RegisteredApplications.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  Registered Application data with authentication Url containing specified keyword
        /// </summary>
		/// <param name="authenticationUrl"> Authentication Url</param>
		/// <returns>List of  Registered Application</returns>
        public void DeleteByAuthenticationUrl(string authenticationUrl)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.RegisteredApplications
                       where
							o.AuthenticationUrl.Contains(authenticationUrl) 						
						select o;
			dataContext.RegisteredApplications.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  Registered Application data with created Date containing specified keyword
        /// </summary>
		/// <param name="createdDate"> Created Date</param>
		/// <returns>List of  Registered Application</returns>
        public void DeleteByCreatedDate(DateTime createdDate)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.RegisteredApplications
                       where
							o.CreatedDate.Equals(createdDate) 						
						select o;
			dataContext.RegisteredApplications.RemoveRange(list);
            dataContext.SaveChanges();
        }


//-----------------------  Delete by Foreign keys ---------------------------------------

        /// <summary>
        /// Delete all  Registered Application data with specified authentication Source Id 
        /// </summary>
		/// <param name="authenticationSourceId"> Authentication Source Id</param>
		/// <returns>List of  Registered Application</returns>
        public void DeleteByAuthenticationSourceId(Int16 authenticationSourceId)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.RegisteredApplications
                       where
							o.AuthenticationSourceId == authenticationSourceId  						
						select o;
            dataContext.RegisteredApplications.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  Registered Application data with specified authentication Source Id, is Active 
        /// </summary>
		/// <param name="authenticationSourceId"> Authentication Source Id</param>
		/// <param name="isActive"> Is Active</param>
		/// <returns>List of  Registered Application</returns>
        public void DeleteByAuthenticationSourceIdAndIsActive(Int16 authenticationSourceId, Int16 isActive)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.RegisteredApplications
                       where
							o.AuthenticationSourceId == authenticationSourceId && 
							o.IsActive == isActive  						
						select o;
            dataContext.RegisteredApplications.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  Registered Application data with specified is Active 
        /// </summary>
		/// <param name="isActive"> Is Active</param>
		/// <returns>List of  Registered Application</returns>
        public void DeleteByIsActive(Int16 isActive)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.RegisteredApplications
                       where
							o.IsActive == isActive  						
						select o;
            dataContext.RegisteredApplications.RemoveRange(list);
            dataContext.SaveChanges();
        }


    }
}
