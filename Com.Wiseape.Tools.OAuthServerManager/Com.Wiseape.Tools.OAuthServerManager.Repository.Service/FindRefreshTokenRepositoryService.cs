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
    public class FindRefreshTokenRepository : BaseRepository<RefreshToken>, IFindRefreshTokenRepository
    {
        class Keywords
        {
            public static string FindRefreshToken = "Find.Tools.OAuthServerManager.RefreshToken";
        }

        /// <summary>
        /// Constructor for RefreshTokenRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public FindRefreshTokenRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public FindRefreshTokenRepository()
        {
            this.DataContextKey = Keywords.FindRefreshToken;
        }

//------------------- Find by keywords --------------------------------------------------------

        /// <summary>
        /// Finds all  Refresh Token data with client I D containing specified keyword
        /// </summary>
		/// <param name="clientID"> Client I D</param>
		/// <returns>List of  Refresh Token</returns>
        public List<RefreshToken> FindByClientID(string clientID)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.RefreshTokens
                       where
							o.ClientID.Contains(clientID) 						
						select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  Refresh Token data with client Secret containing specified keyword
        /// </summary>
		/// <param name="clientSecret"> Client Secret</param>
		/// <returns>List of  Refresh Token</returns>
        public List<RefreshToken> FindByClientSecret(string clientSecret)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.RefreshTokens
                       where
							o.ClientSecret.Contains(clientSecret) 						
						select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  Refresh Token data with authentication Code containing specified keyword
        /// </summary>
		/// <param name="authenticationCode"> Authentication Code</param>
		/// <returns>List of  Refresh Token</returns>
        public List<RefreshToken> FindByAuthenticationCode(string authenticationCode)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.RefreshTokens
                       where
							o.AuthenticationCode.Contains(authenticationCode) 						
						select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  Refresh Token data with refresh Token String containing specified keyword
        /// </summary>
		/// <param name="refreshTokenString"> Refresh Token String</param>
		/// <returns>List of  Refresh Token</returns>
        public List<RefreshToken> FindByRefreshTokenString(string refreshTokenString)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.RefreshTokens
                       where
							o.RefreshTokenString.Contains(refreshTokenString) 						
						select o;
            return list.ToList();
        }


//----------------------  find by dates -----------------------------------------------

        /// <summary>
        /// Finds all  Refresh Token with CreatedDate between CreatedDate1 and CreatedDate2
        /// </summary>
		/// <param name="createdDate1"> Created Date</param>
		/// <param name="createdDate2"> Created Date</param>
		/// <returns>List of  Refresh Token</returns>
        public List<RefreshToken> FindByCreatedDateBetween(DateTime createdDate1, DateTime createdDate2)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.RefreshTokens
                       where
                            o.CreatedDate >= createdDate1 &&
                            o.CreatedDate <= createdDate2
                       select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  Refresh Token with ExpiredDate between ExpiredDate1 and ExpiredDate2
        /// </summary>
		/// <param name="expiredDate1"> Expired Date</param>
		/// <param name="expiredDate2"> Expired Date</param>
		/// <returns>List of  Refresh Token</returns>
        public List<RefreshToken> FindByExpiredDateBetween(DateTime expiredDate1, DateTime expiredDate2)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.RefreshTokens
                       where
                            o.ExpiredDate >= expiredDate1 &&
                            o.ExpiredDate <= expiredDate2
                       select o;
            return list.ToList();
        }


//-----------------------  Find by Foreign keys ---------------------------------------




    }
}
