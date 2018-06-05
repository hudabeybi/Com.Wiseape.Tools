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
    public class FindAccessTokenRepository : BaseRepository<AccessToken>, IFindAccessTokenRepository
    {
        class Keywords
        {
            public static string FindAccessToken = "Find.Tools.OAuthServerManager.AccessToken";
        }

        /// <summary>
        /// Constructor for AccessTokenRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public FindAccessTokenRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public FindAccessTokenRepository()
        {
            this.DataContextKey = Keywords.FindAccessToken;
        }

//------------------- Find by keywords --------------------------------------------------------

        /// <summary>
        /// Finds all  Access Token data with access Token String containing specified keyword
        /// </summary>
		/// <param name="accessTokenString"> Access Token String</param>
		/// <returns>List of  Access Token</returns>
        public List<AccessToken> FindByAccessTokenString(string accessTokenString)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.AccessTokens
                       where
							o.AccessTokenString.Contains(accessTokenString) 						
						select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  Access Token data with refresh Token containing specified keyword
        /// </summary>
		/// <param name="refreshToken"> Refresh Token</param>
		/// <returns>List of  Access Token</returns>
        public List<AccessToken> FindByRefreshToken(string refreshToken)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.AccessTokens
                       where
							o.RefreshToken.Contains(refreshToken) 						
						select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  Access Token data with client I D containing specified keyword
        /// </summary>
		/// <param name="clientID"> Client I D</param>
		/// <returns>List of  Access Token</returns>
        public List<AccessToken> FindByClientID(string clientID)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.AccessTokens
                       where
							o.ClientID.Contains(clientID) 						
						select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  Access Token data with client Secret containing specified keyword
        /// </summary>
		/// <param name="clientSecret"> Client Secret</param>
		/// <returns>List of  Access Token</returns>
        public List<AccessToken> FindByClientSecret(string clientSecret)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.AccessTokens
                       where
							o.ClientSecret.Contains(clientSecret) 						
						select o;
            return list.ToList();
        }


//----------------------  find by dates -----------------------------------------------

        /// <summary>
        /// Finds all  Access Token with CreatedDate between CreatedDate1 and CreatedDate2
        /// </summary>
		/// <param name="createdDate1"> Created Date</param>
		/// <param name="createdDate2"> Created Date</param>
		/// <returns>List of  Access Token</returns>
        public List<AccessToken> FindByCreatedDateBetween(DateTime createdDate1, DateTime createdDate2)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.AccessTokens
                       where
                            o.CreatedDate >= createdDate1 &&
                            o.CreatedDate <= createdDate2
                       select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  Access Token with ExpiredDate between ExpiredDate1 and ExpiredDate2
        /// </summary>
		/// <param name="expiredDate1"> Expired Date</param>
		/// <param name="expiredDate2"> Expired Date</param>
		/// <returns>List of  Access Token</returns>
        public List<AccessToken> FindByExpiredDateBetween(DateTime expiredDate1, DateTime expiredDate2)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.AccessTokens
                       where
                            o.ExpiredDate >= expiredDate1 &&
                            o.ExpiredDate <= expiredDate2
                       select o;
            return list.ToList();
        }


//-----------------------  Find by Foreign keys ---------------------------------------




    }
}
