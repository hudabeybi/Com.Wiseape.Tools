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
    /// Repository for RefreshToken data.
    /// </summary>
    public class DeleteRefreshTokenRepository : BaseRepository<RefreshToken>, IDeleteRefreshTokenRepository
    {
        class Keywords
        {
            public static string DeleteRefreshToken = "Delete.Tools.OAuthServerManager.RefreshToken";
        }

        /// <summary>
        /// Constructor for DeleteRefreshTokenRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public DeleteRefreshTokenRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public DeleteRefreshTokenRepository()
        {
            this.DataContextKey = Keywords.DeleteRefreshToken;
        }

//------------------- Delete by keywords --------------------------------------------------------

        /// <summary>
        /// Delete all  Refresh Token data with client I D containing specified keyword
        /// </summary>
		/// <param name="clientID"> Client I D</param>
		/// <returns>List of  Refresh Token</returns>
        public void DeleteByClientID(string clientID)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.RefreshTokens
                       where
							o.ClientID.Contains(clientID) 						
						select o;
			dataContext.RefreshTokens.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  Refresh Token data with client Secret containing specified keyword
        /// </summary>
		/// <param name="clientSecret"> Client Secret</param>
		/// <returns>List of  Refresh Token</returns>
        public void DeleteByClientSecret(string clientSecret)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.RefreshTokens
                       where
							o.ClientSecret.Contains(clientSecret) 						
						select o;
			dataContext.RefreshTokens.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  Refresh Token data with authentication Code containing specified keyword
        /// </summary>
		/// <param name="authenticationCode"> Authentication Code</param>
		/// <returns>List of  Refresh Token</returns>
        public void DeleteByAuthenticationCode(string authenticationCode)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.RefreshTokens
                       where
							o.AuthenticationCode.Contains(authenticationCode) 						
						select o;
			dataContext.RefreshTokens.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  Refresh Token data with refresh Token String containing specified keyword
        /// </summary>
		/// <param name="refreshTokenString"> Refresh Token String</param>
		/// <returns>List of  Refresh Token</returns>
        public void DeleteByRefreshTokenString(string refreshTokenString)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.RefreshTokens
                       where
							o.RefreshTokenString.Contains(refreshTokenString) 						
						select o;
			dataContext.RefreshTokens.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  Refresh Token data with created Date containing specified keyword
        /// </summary>
		/// <param name="createdDate"> Created Date</param>
		/// <returns>List of  Refresh Token</returns>
        public void DeleteByCreatedDate(DateTime createdDate)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.RefreshTokens
                       where
							o.CreatedDate.Equals(createdDate) 						
						select o;
			dataContext.RefreshTokens.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  Refresh Token data with expired Date containing specified keyword
        /// </summary>
		/// <param name="expiredDate"> Expired Date</param>
		/// <returns>List of  Refresh Token</returns>
        public void DeleteByExpiredDate(DateTime expiredDate)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.RefreshTokens
                       where
							o.ExpiredDate.Equals(expiredDate) 						
						select o;
			dataContext.RefreshTokens.RemoveRange(list);
            dataContext.SaveChanges();
        }


//-----------------------  Delete by Foreign keys ---------------------------------------


    }
}
