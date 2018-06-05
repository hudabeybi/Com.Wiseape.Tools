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
    /// Repository for UpdateRegisteredApplication data.
    /// </summary>
    public class UpdateRegisteredApplicationRepository : BaseRepository<RegisteredApplication>, IUpdateRegisteredApplicationRepository
    {
        class Keywords
        {
            public static string UpdateRegisteredApplication = "Update.Tools.OAuthServerManager.RegisteredApplication";
        }

        /// <summary>
        /// Constructor for RegisteredApplicationRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public UpdateRegisteredApplicationRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public UpdateRegisteredApplicationRepository()
        {
            this.DataContextKey = Keywords.UpdateRegisteredApplication;
        }


//-------------------------- Update columns by Primary key -----------------------------------------

        /// <summary>
        /// Updates  Registered Application's id Application, application Name by idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationName">application Name</param>
		/// <returns>List of  Registered Application</returns>
        public void UpdateApplicationName(Int16 idApplication, string applicationName)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.RegisteredApplications
                       where
                       		o.IdApplication == idApplication
                       	select o;
           	list.ToList().ForEach(o => {
      			o.ApplicationName = applicationName;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Registered Application's id Application, application Desc by idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationDesc">application Desc</param>
		/// <returns>List of  Registered Application</returns>
        public void UpdateApplicationDesc(Int16 idApplication, string applicationDesc)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.RegisteredApplications
                       where
                       		o.IdApplication == idApplication
                       	select o;
           	list.ToList().ForEach(o => {
      			o.ApplicationDesc = applicationDesc;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Registered Application's id Application, client I D by idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="clientID">client I D</param>
		/// <returns>List of  Registered Application</returns>
        public void UpdateClientID(Int16 idApplication, string clientID)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.RegisteredApplications
                       where
                       		o.IdApplication == idApplication
                       	select o;
           	list.ToList().ForEach(o => {
      			o.ClientID = clientID;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Registered Application's id Application, client Secret by idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="clientSecret">client Secret</param>
		/// <returns>List of  Registered Application</returns>
        public void UpdateClientSecret(Int16 idApplication, string clientSecret)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.RegisteredApplications
                       where
                       		o.IdApplication == idApplication
                       	select o;
           	list.ToList().ForEach(o => {
      			o.ClientSecret = clientSecret;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Registered Application's id Application, authorization Token Redirect U R I by idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="authorizationTokenRedirectURI">authorization Token Redirect U R I</param>
		/// <returns>List of  Registered Application</returns>
        public void UpdateAuthorizationTokenRedirectURI(Int16 idApplication, string authorizationTokenRedirectURI)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.RegisteredApplications
                       where
                       		o.IdApplication == idApplication
                       	select o;
           	list.ToList().ForEach(o => {
      			o.AuthorizationTokenRedirectURI = authorizationTokenRedirectURI;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Registered Application's id Application, access Token Redirect U R I by idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="accessTokenRedirectURI">access Token Redirect U R I</param>
		/// <returns>List of  Registered Application</returns>
        public void UpdateAccessTokenRedirectURI(Int16 idApplication, string accessTokenRedirectURI)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.RegisteredApplications
                       where
                       		o.IdApplication == idApplication
                       	select o;
           	list.ToList().ForEach(o => {
      			o.AccessTokenRedirectURI = accessTokenRedirectURI;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Registered Application's id Application, authentication Source Connection String by idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="authenticationSourceConnectionString">authentication Source Connection String</param>
		/// <returns>List of  Registered Application</returns>
        public void UpdateAuthenticationSourceConnectionString(Int16 idApplication, string authenticationSourceConnectionString)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.RegisteredApplications
                       where
                       		o.IdApplication == idApplication
                       	select o;
           	list.ToList().ForEach(o => {
      			o.AuthenticationSourceConnectionString = authenticationSourceConnectionString;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Registered Application's id Application, authentication Url by idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="authenticationUrl">authentication Url</param>
		/// <returns>List of  Registered Application</returns>
        public void UpdateAuthenticationUrl(Int16 idApplication, string authenticationUrl)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.RegisteredApplications
                       where
                       		o.IdApplication == idApplication
                       	select o;
           	list.ToList().ForEach(o => {
      			o.AuthenticationUrl = authenticationUrl;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Registered Application's id Application, created Date by idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="createdDate">created Date</param>
		/// <returns>List of  Registered Application</returns>
        public void UpdateCreatedDate(Int16 idApplication, DateTime createdDate)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.RegisteredApplications
                       where
                       		o.IdApplication == idApplication
                       	select o;
           	list.ToList().ForEach(o => {
      			o.CreatedDate = createdDate;	
            });
            dataContext.SaveChanges();
        }


//-------------------------- Update foreign keys -----------------------------------------

        /// <summary>
        /// Updates  Registered Application's id Application, authentication Source Id by idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="authenticationSourceId">authentication Source Id</param>
		/// <returns>List of  Registered Application</returns>
        public void UpdateAuthenticationSourceId(Int16 idApplication, Int16 authenticationSourceId)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.RegisteredApplications
                       where
                       		o.IdApplication == idApplication
                       	select o;
           	list.ToList().ForEach(o => {
      			o.AuthenticationSourceId = authenticationSourceId;
	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Registered Application's id Application, authentication Source Id, is Active by idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="authenticationSourceId">authentication Source Id</param>
		/// <param name="isActive">is Active</param>
		/// <returns>List of  Registered Application</returns>
        public void UpdateAuthenticationSourceIdAndIsActive(Int16 idApplication, Int16 authenticationSourceId, Int16 isActive)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.RegisteredApplications
                       where
                       		o.IdApplication == idApplication
                       	select o;
           	list.ToList().ForEach(o => {
      			o.AuthenticationSourceId = authenticationSourceId;
     			o.IsActive = isActive;
	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Registered Application's id Application, is Active by idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="isActive">is Active</param>
		/// <returns>List of  Registered Application</returns>
        public void UpdateIsActive(Int16 idApplication, Int16 isActive)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.RegisteredApplications
                       where
                       		o.IdApplication == idApplication
                       	select o;
           	list.ToList().ForEach(o => {
      			o.IsActive = isActive;
	
            });
            dataContext.SaveChanges();
        }


    }
}
