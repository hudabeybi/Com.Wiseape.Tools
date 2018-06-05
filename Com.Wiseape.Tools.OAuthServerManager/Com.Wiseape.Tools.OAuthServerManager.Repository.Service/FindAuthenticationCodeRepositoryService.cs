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
    /// Repository for AuthenticationCode data.
    /// </summary>
    public class FindAuthenticationCodeRepository : BaseRepository<AuthenticationCode>, IFindAuthenticationCodeRepository
    {
        class Keywords
        {
            public static string FindAuthenticationCode = "Find.Tools.OAuthServerManager.AuthenticationCode";
        }

        /// <summary>
        /// Constructor for AuthenticationCodeRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public FindAuthenticationCodeRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public FindAuthenticationCodeRepository()
        {
            this.DataContextKey = Keywords.FindAuthenticationCode;
        }

//------------------- Find by keywords --------------------------------------------------------

        /// <summary>
        /// Finds all  Authentication Code data with authentication Code String containing specified keyword
        /// </summary>
		/// <param name="authenticationCodeString"> Authentication Code String</param>
		/// <returns>List of  Authentication Code</returns>
        public List<AuthenticationCode> FindByAuthenticationCodeString(string authenticationCodeString)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.AuthenticationCodes
                       where
							o.AuthenticationCodeString.Contains(authenticationCodeString) 						
						select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  Authentication Code data with client I D containing specified keyword
        /// </summary>
		/// <param name="clientID"> Client I D</param>
		/// <returns>List of  Authentication Code</returns>
        public List<AuthenticationCode> FindByClientID(string clientID)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.AuthenticationCodes
                       where
							o.ClientID.Contains(clientID) 						
						select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  Authentication Code data with authorization Session I D containing specified keyword
        /// </summary>
		/// <param name="authorizationSessionID"> Authorization Session I D</param>
		/// <returns>List of  Authentication Code</returns>
        public List<AuthenticationCode> FindByAuthorizationSessionID(string authorizationSessionID)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.AuthenticationCodes
                       where
							o.AuthorizationSessionID.Contains(authorizationSessionID) 						
						select o;
            return list.ToList();
        }


//----------------------  find by dates -----------------------------------------------

        /// <summary>
        /// Finds all  Authentication Code with CreatedDate between CreatedDate1 and CreatedDate2
        /// </summary>
		/// <param name="createdDate1"> Created Date</param>
		/// <param name="createdDate2"> Created Date</param>
		/// <returns>List of  Authentication Code</returns>
        public List<AuthenticationCode> FindByCreatedDateBetween(DateTime createdDate1, DateTime createdDate2)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.AuthenticationCodes
                       where
                            o.CreatedDate >= createdDate1 &&
                            o.CreatedDate <= createdDate2
                       select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  Authentication Code with ExpiredDate between ExpiredDate1 and ExpiredDate2
        /// </summary>
		/// <param name="expiredDate1"> Expired Date</param>
		/// <param name="expiredDate2"> Expired Date</param>
		/// <returns>List of  Authentication Code</returns>
        public List<AuthenticationCode> FindByExpiredDateBetween(DateTime expiredDate1, DateTime expiredDate2)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.AuthenticationCodes
                       where
                            o.ExpiredDate >= expiredDate1 &&
                            o.ExpiredDate <= expiredDate2
                       select o;
            return list.ToList();
        }


//-----------------------  Find by Foreign keys ---------------------------------------




    }
}
