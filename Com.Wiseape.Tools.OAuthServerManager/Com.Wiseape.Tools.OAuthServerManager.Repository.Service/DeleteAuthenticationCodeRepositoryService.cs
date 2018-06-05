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
    public class DeleteAuthenticationCodeRepository : BaseRepository<AuthenticationCode>, IDeleteAuthenticationCodeRepository
    {
        class Keywords
        {
            public static string DeleteAuthenticationCode = "Delete.Tools.OAuthServerManager.AuthenticationCode";
        }

        /// <summary>
        /// Constructor for DeleteAuthenticationCodeRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public DeleteAuthenticationCodeRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public DeleteAuthenticationCodeRepository()
        {
            this.DataContextKey = Keywords.DeleteAuthenticationCode;
        }

//------------------- Delete by keywords --------------------------------------------------------

        /// <summary>
        /// Delete all  Authentication Code data with authentication Code String containing specified keyword
        /// </summary>
		/// <param name="authenticationCodeString"> Authentication Code String</param>
		/// <returns>List of  Authentication Code</returns>
        public void DeleteByAuthenticationCodeString(string authenticationCodeString)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.AuthenticationCodes
                       where
							o.AuthenticationCodeString.Contains(authenticationCodeString) 						
						select o;
			dataContext.AuthenticationCodes.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  Authentication Code data with client I D containing specified keyword
        /// </summary>
		/// <param name="clientID"> Client I D</param>
		/// <returns>List of  Authentication Code</returns>
        public void DeleteByClientID(string clientID)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.AuthenticationCodes
                       where
							o.ClientID.Contains(clientID) 						
						select o;
			dataContext.AuthenticationCodes.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  Authentication Code data with authorization Session I D containing specified keyword
        /// </summary>
		/// <param name="authorizationSessionID"> Authorization Session I D</param>
		/// <returns>List of  Authentication Code</returns>
        public void DeleteByAuthorizationSessionID(string authorizationSessionID)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.AuthenticationCodes
                       where
							o.AuthorizationSessionID.Contains(authorizationSessionID) 						
						select o;
			dataContext.AuthenticationCodes.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  Authentication Code data with created Date containing specified keyword
        /// </summary>
		/// <param name="createdDate"> Created Date</param>
		/// <returns>List of  Authentication Code</returns>
        public void DeleteByCreatedDate(DateTime createdDate)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.AuthenticationCodes
                       where
							o.CreatedDate.Equals(createdDate) 						
						select o;
			dataContext.AuthenticationCodes.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  Authentication Code data with expired Date containing specified keyword
        /// </summary>
		/// <param name="expiredDate"> Expired Date</param>
		/// <returns>List of  Authentication Code</returns>
        public void DeleteByExpiredDate(DateTime expiredDate)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.AuthenticationCodes
                       where
							o.ExpiredDate.Equals(expiredDate) 						
						select o;
			dataContext.AuthenticationCodes.RemoveRange(list);
            dataContext.SaveChanges();
        }


//-----------------------  Delete by Foreign keys ---------------------------------------


    }
}
