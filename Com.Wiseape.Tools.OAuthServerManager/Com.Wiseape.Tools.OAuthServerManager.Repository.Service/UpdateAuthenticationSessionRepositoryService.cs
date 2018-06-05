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
    /// Repository for UpdateAuthenticationSession data.
    /// </summary>
    public class UpdateAuthenticationSessionRepository : BaseRepository<AuthenticationSession>, IUpdateAuthenticationSessionRepository
    {
        class Keywords
        {
            public static string UpdateAuthenticationSession = "Update.Tools.OAuthServerManager.AuthenticationSession";
        }

        /// <summary>
        /// Constructor for AuthenticationSessionRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public UpdateAuthenticationSessionRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public UpdateAuthenticationSessionRepository()
        {
            this.DataContextKey = Keywords.UpdateAuthenticationSession;
        }


//-------------------------- Update columns by Primary key -----------------------------------------

        /// <summary>
        /// Updates  Authentication Session's id Authentication Session, authentication Session String by idAuthenticationSession
        /// </summary>
		/// <param name="idAuthenticationSession">id Authentication Session</param>
		/// <param name="authenticationSessionString">authentication Session String</param>
		/// <returns>List of  Authentication Session</returns>
        public void UpdateAuthenticationSessionString(Int64 idAuthenticationSession, string authenticationSessionString)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.AuthenticationSessions
                       where
                       		o.IdAuthenticationSession == idAuthenticationSession
                       	select o;
           	list.ToList().ForEach(o => {
      			o.AuthenticationSessionString = authenticationSessionString;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Authentication Session's id Authentication Session, client I D by idAuthenticationSession
        /// </summary>
		/// <param name="idAuthenticationSession">id Authentication Session</param>
		/// <param name="clientID">client I D</param>
		/// <returns>List of  Authentication Session</returns>
        public void UpdateClientID(Int64 idAuthenticationSession, string clientID)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.AuthenticationSessions
                       where
                       		o.IdAuthenticationSession == idAuthenticationSession
                       	select o;
           	list.ToList().ForEach(o => {
      			o.ClientID = clientID;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Authentication Session's id Authentication Session, session Created Date by idAuthenticationSession
        /// </summary>
		/// <param name="idAuthenticationSession">id Authentication Session</param>
		/// <param name="sessionCreatedDate">session Created Date</param>
		/// <returns>List of  Authentication Session</returns>
        public void UpdateSessionCreatedDate(Int64 idAuthenticationSession, DateTime sessionCreatedDate)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.AuthenticationSessions
                       where
                       		o.IdAuthenticationSession == idAuthenticationSession
                       	select o;
           	list.ToList().ForEach(o => {
      			o.SessionCreatedDate = sessionCreatedDate;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Authentication Session's id Authentication Session, session Expired Date by idAuthenticationSession
        /// </summary>
		/// <param name="idAuthenticationSession">id Authentication Session</param>
		/// <param name="sessionExpiredDate">session Expired Date</param>
		/// <returns>List of  Authentication Session</returns>
        public void UpdateSessionExpiredDate(Int64 idAuthenticationSession, DateTime sessionExpiredDate)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.AuthenticationSessions
                       where
                       		o.IdAuthenticationSession == idAuthenticationSession
                       	select o;
           	list.ToList().ForEach(o => {
      			o.SessionExpiredDate = sessionExpiredDate;	
            });
            dataContext.SaveChanges();
        }


//-------------------------- Update foreign keys -----------------------------------------


    }
}
