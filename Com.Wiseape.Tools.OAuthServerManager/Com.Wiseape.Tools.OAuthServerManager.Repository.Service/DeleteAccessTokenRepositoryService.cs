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
    /// Repository for AccessToken data.
    /// </summary>
    public class DeleteAccessTokenRepository : BaseRepository<AccessToken>, IDeleteAccessTokenRepository
    {
        class Keywords
        {
            public static string DeleteAccessToken = "Delete.Tools.OAuthServerManager.AccessToken";
        }

        /// <summary>
        /// Constructor for DeleteAccessTokenRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public DeleteAccessTokenRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public DeleteAccessTokenRepository()
        {
            this.DataContextKey = Keywords.DeleteAccessToken;
        }

//------------------- Delete by keywords --------------------------------------------------------

        /// <summary>
        /// Delete all  Access Token data with access Token String containing specified keyword
        /// </summary>
		/// <param name="accessTokenString"> Access Token String</param>
		/// <returns>List of  Access Token</returns>
        public void DeleteByAccessTokenString(string accessTokenString)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.AccessTokens
                       where
							o.AccessTokenString.Contains(accessTokenString) 						
						select o;
			dataContext.AccessTokens.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  Access Token data with refresh Token containing specified keyword
        /// </summary>
		/// <param name="refreshToken"> Refresh Token</param>
		/// <returns>List of  Access Token</returns>
        public void DeleteByRefreshToken(string refreshToken)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.AccessTokens
                       where
							o.RefreshToken.Contains(refreshToken) 						
						select o;
			dataContext.AccessTokens.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  Access Token data with client I D containing specified keyword
        /// </summary>
		/// <param name="clientID"> Client I D</param>
		/// <returns>List of  Access Token</returns>
        public void DeleteByClientID(string clientID)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.AccessTokens
                       where
							o.ClientID.Contains(clientID) 						
						select o;
			dataContext.AccessTokens.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  Access Token data with client Secret containing specified keyword
        /// </summary>
		/// <param name="clientSecret"> Client Secret</param>
		/// <returns>List of  Access Token</returns>
        public void DeleteByClientSecret(string clientSecret)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.AccessTokens
                       where
							o.ClientSecret.Contains(clientSecret) 						
						select o;
			dataContext.AccessTokens.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  Access Token data with created Date containing specified keyword
        /// </summary>
		/// <param name="createdDate"> Created Date</param>
		/// <returns>List of  Access Token</returns>
        public void DeleteByCreatedDate(DateTime createdDate)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.AccessTokens
                       where
							o.CreatedDate.Equals(createdDate) 						
						select o;
			dataContext.AccessTokens.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  Access Token data with expired Date containing specified keyword
        /// </summary>
		/// <param name="expiredDate"> Expired Date</param>
		/// <returns>List of  Access Token</returns>
        public void DeleteByExpiredDate(DateTime expiredDate)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.AccessTokens
                       where
							o.ExpiredDate.Equals(expiredDate) 						
						select o;
			dataContext.AccessTokens.RemoveRange(list);
            dataContext.SaveChanges();
        }


//-----------------------  Delete by Foreign keys ---------------------------------------


    }
}
