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
    /// Repository for UpdateRefreshToken data.
    /// </summary>
    public class UpdateRefreshTokenRepository : BaseRepository<RefreshToken>, IUpdateRefreshTokenRepository
    {
        class Keywords
        {
            public static string UpdateRefreshToken = "Update.Tools.OAuthServerManager.RefreshToken";
        }

        /// <summary>
        /// Constructor for RefreshTokenRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public UpdateRefreshTokenRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public UpdateRefreshTokenRepository()
        {
            this.DataContextKey = Keywords.UpdateRefreshToken;
        }


//-------------------------- Update columns by Primary key -----------------------------------------

        /// <summary>
        /// Updates  Refresh Token's id Refresh Token, client I D by idRefreshToken
        /// </summary>
		/// <param name="idRefreshToken">id Refresh Token</param>
		/// <param name="clientID">client I D</param>
		/// <returns>List of  Refresh Token</returns>
        public void UpdateClientID(Int64 idRefreshToken, string clientID)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.RefreshTokens
                       where
                       		o.IdRefreshToken == idRefreshToken
                       	select o;
           	list.ToList().ForEach(o => {
      			o.ClientID = clientID;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Refresh Token's id Refresh Token, client Secret by idRefreshToken
        /// </summary>
		/// <param name="idRefreshToken">id Refresh Token</param>
		/// <param name="clientSecret">client Secret</param>
		/// <returns>List of  Refresh Token</returns>
        public void UpdateClientSecret(Int64 idRefreshToken, string clientSecret)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.RefreshTokens
                       where
                       		o.IdRefreshToken == idRefreshToken
                       	select o;
           	list.ToList().ForEach(o => {
      			o.ClientSecret = clientSecret;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Refresh Token's id Refresh Token, authentication Code by idRefreshToken
        /// </summary>
		/// <param name="idRefreshToken">id Refresh Token</param>
		/// <param name="authenticationCode">authentication Code</param>
		/// <returns>List of  Refresh Token</returns>
        public void UpdateAuthenticationCode(Int64 idRefreshToken, string authenticationCode)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.RefreshTokens
                       where
                       		o.IdRefreshToken == idRefreshToken
                       	select o;
           	list.ToList().ForEach(o => {
      			o.AuthenticationCode = authenticationCode;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Refresh Token's id Refresh Token, refresh Token String by idRefreshToken
        /// </summary>
		/// <param name="idRefreshToken">id Refresh Token</param>
		/// <param name="refreshTokenString">refresh Token String</param>
		/// <returns>List of  Refresh Token</returns>
        public void UpdateRefreshTokenString(Int64 idRefreshToken, string refreshTokenString)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.RefreshTokens
                       where
                       		o.IdRefreshToken == idRefreshToken
                       	select o;
           	list.ToList().ForEach(o => {
      			o.RefreshTokenString = refreshTokenString;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Refresh Token's id Refresh Token, created Date by idRefreshToken
        /// </summary>
		/// <param name="idRefreshToken">id Refresh Token</param>
		/// <param name="createdDate">created Date</param>
		/// <returns>List of  Refresh Token</returns>
        public void UpdateCreatedDate(Int64 idRefreshToken, DateTime createdDate)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.RefreshTokens
                       where
                       		o.IdRefreshToken == idRefreshToken
                       	select o;
           	list.ToList().ForEach(o => {
      			o.CreatedDate = createdDate;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Refresh Token's id Refresh Token, expired Date by idRefreshToken
        /// </summary>
		/// <param name="idRefreshToken">id Refresh Token</param>
		/// <param name="expiredDate">expired Date</param>
		/// <returns>List of  Refresh Token</returns>
        public void UpdateExpiredDate(Int64 idRefreshToken, DateTime expiredDate)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.RefreshTokens
                       where
                       		o.IdRefreshToken == idRefreshToken
                       	select o;
           	list.ToList().ForEach(o => {
      			o.ExpiredDate = expiredDate;	
            });
            dataContext.SaveChanges();
        }


//-------------------------- Update foreign keys -----------------------------------------


    }
}
