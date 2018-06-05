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
    public class FindAuthenticationSessionRepository : BaseRepository<AuthenticationSession>, IFindAuthenticationSessionRepository
    {
        class Keywords
        {
            public static string FindAuthenticationSession = "Find.Tools.OAuthServerManager.AuthenticationSession";
        }

        /// <summary>
        /// Constructor for AuthenticationSessionRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public FindAuthenticationSessionRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public FindAuthenticationSessionRepository()
        {
            this.DataContextKey = Keywords.FindAuthenticationSession;
        }

//------------------- Find by keywords --------------------------------------------------------

        /// <summary>
        /// Finds all  Authentication Session data with authentication Session String containing specified keyword
        /// </summary>
		/// <param name="authenticationSessionString"> Authentication Session String</param>
		/// <returns>List of  Authentication Session</returns>
        public List<AuthenticationSession> FindByAuthenticationSessionString(string authenticationSessionString)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.AuthenticationSessions
                       where
							o.AuthenticationSessionString.Contains(authenticationSessionString) 						
						select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  Authentication Session data with client I D containing specified keyword
        /// </summary>
		/// <param name="clientID"> Client I D</param>
		/// <returns>List of  Authentication Session</returns>
        public List<AuthenticationSession> FindByClientID(string clientID)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.AuthenticationSessions
                       where
							o.ClientID.Contains(clientID) 						
						select o;
            return list.ToList();
        }


//----------------------  find by dates -----------------------------------------------

        /// <summary>
        /// Finds all  Authentication Session with SessionCreatedDate between SessionCreatedDate1 and SessionCreatedDate2
        /// </summary>
		/// <param name="sessionCreatedDate1"> Session Created Date</param>
		/// <param name="sessionCreatedDate2"> Session Created Date</param>
		/// <returns>List of  Authentication Session</returns>
        public List<AuthenticationSession> FindBySessionCreatedDateBetween(DateTime sessionCreatedDate1, DateTime sessionCreatedDate2)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.AuthenticationSessions
                       where
                            o.SessionCreatedDate >= sessionCreatedDate1 &&
                            o.SessionCreatedDate <= sessionCreatedDate2
                       select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  Authentication Session with SessionExpiredDate between SessionExpiredDate1 and SessionExpiredDate2
        /// </summary>
		/// <param name="sessionExpiredDate1"> Session Expired Date</param>
		/// <param name="sessionExpiredDate2"> Session Expired Date</param>
		/// <returns>List of  Authentication Session</returns>
        public List<AuthenticationSession> FindBySessionExpiredDateBetween(DateTime sessionExpiredDate1, DateTime sessionExpiredDate2)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.AuthenticationSessions
                       where
                            o.SessionExpiredDate >= sessionExpiredDate1 &&
                            o.SessionExpiredDate <= sessionExpiredDate2
                       select o;
            return list.ToList();
        }


//-----------------------  Find by Foreign keys ---------------------------------------




    }
}
