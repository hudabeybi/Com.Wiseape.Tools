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
    /// Repository for AuthenticationSession data.
    /// </summary>
    public class DeleteAuthenticationSessionRepository : BaseRepository<AuthenticationSession>, IDeleteAuthenticationSessionRepository
    {
        class Keywords
        {
            public static string DeleteAuthenticationSession = "Delete.Tools.OAuthServerManager.AuthenticationSession";
        }

        /// <summary>
        /// Constructor for DeleteAuthenticationSessionRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public DeleteAuthenticationSessionRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public DeleteAuthenticationSessionRepository()
        {
            this.DataContextKey = Keywords.DeleteAuthenticationSession;
        }

//------------------- Delete by keywords --------------------------------------------------------

        /// <summary>
        /// Delete all  Authentication Session data with authentication Session String containing specified keyword
        /// </summary>
		/// <param name="authenticationSessionString"> Authentication Session String</param>
		/// <returns>List of  Authentication Session</returns>
        public void DeleteByAuthenticationSessionString(string authenticationSessionString)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.AuthenticationSessions
                       where
							o.AuthenticationSessionString.Contains(authenticationSessionString) 						
						select o;
			dataContext.AuthenticationSessions.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  Authentication Session data with client I D containing specified keyword
        /// </summary>
		/// <param name="clientID"> Client I D</param>
		/// <returns>List of  Authentication Session</returns>
        public void DeleteByClientID(string clientID)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.AuthenticationSessions
                       where
							o.ClientID.Contains(clientID) 						
						select o;
			dataContext.AuthenticationSessions.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  Authentication Session data with session Created Date containing specified keyword
        /// </summary>
		/// <param name="sessionCreatedDate"> Session Created Date</param>
		/// <returns>List of  Authentication Session</returns>
        public void DeleteBySessionCreatedDate(DateTime sessionCreatedDate)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.AuthenticationSessions
                       where
							o.SessionCreatedDate.Equals(sessionCreatedDate) 						
						select o;
			dataContext.AuthenticationSessions.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  Authentication Session data with session Expired Date containing specified keyword
        /// </summary>
		/// <param name="sessionExpiredDate"> Session Expired Date</param>
		/// <returns>List of  Authentication Session</returns>
        public void DeleteBySessionExpiredDate(DateTime sessionExpiredDate)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.AuthenticationSessions
                       where
							o.SessionExpiredDate.Equals(sessionExpiredDate) 						
						select o;
			dataContext.AuthenticationSessions.RemoveRange(list);
            dataContext.SaveChanges();
        }


//-----------------------  Delete by Foreign keys ---------------------------------------


    }
}
