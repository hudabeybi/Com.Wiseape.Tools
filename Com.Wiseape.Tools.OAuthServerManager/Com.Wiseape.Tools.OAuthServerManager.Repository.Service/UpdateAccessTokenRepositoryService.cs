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
    /// Repository for UpdateAccessToken data.
    /// </summary>
    public class UpdateAccessTokenRepository : BaseRepository<AccessToken>, IUpdateAccessTokenRepository
    {
        class Keywords
        {
            public static string UpdateAccessToken = "Update.Tools.OAuthServerManager.AccessToken";
        }

        /// <summary>
        /// Constructor for AccessTokenRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public UpdateAccessTokenRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public UpdateAccessTokenRepository()
        {
            this.DataContextKey = Keywords.UpdateAccessToken;
        }


//-------------------------- Update columns by Primary key -----------------------------------------

        /// <summary>
        /// Updates  Access Token's id Access Token, access Token String by idAccessToken
        /// </summary>
		/// <param name="idAccessToken">id Access Token</param>
		/// <param name="accessTokenString">access Token String</param>
		/// <returns>List of  Access Token</returns>
        public void UpdateAccessTokenString(Int64 idAccessToken, string accessTokenString)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.AccessTokens
                       where
                       		o.IdAccessToken == idAccessToken
                       	select o;
           	list.ToList().ForEach(o => {
      			o.AccessTokenString = accessTokenString;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Access Token's id Access Token, refresh Token by idAccessToken
        /// </summary>
		/// <param name="idAccessToken">id Access Token</param>
		/// <param name="refreshToken">refresh Token</param>
		/// <returns>List of  Access Token</returns>
        public void UpdateRefreshToken(Int64 idAccessToken, string refreshToken)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.AccessTokens
                       where
                       		o.IdAccessToken == idAccessToken
                       	select o;
           	list.ToList().ForEach(o => {
      			o.RefreshToken = refreshToken;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Access Token's id Access Token, client I D by idAccessToken
        /// </summary>
		/// <param name="idAccessToken">id Access Token</param>
		/// <param name="clientID">client I D</param>
		/// <returns>List of  Access Token</returns>
        public void UpdateClientID(Int64 idAccessToken, string clientID)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.AccessTokens
                       where
                       		o.IdAccessToken == idAccessToken
                       	select o;
           	list.ToList().ForEach(o => {
      			o.ClientID = clientID;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Access Token's id Access Token, client Secret by idAccessToken
        /// </summary>
		/// <param name="idAccessToken">id Access Token</param>
		/// <param name="clientSecret">client Secret</param>
		/// <returns>List of  Access Token</returns>
        public void UpdateClientSecret(Int64 idAccessToken, string clientSecret)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.AccessTokens
                       where
                       		o.IdAccessToken == idAccessToken
                       	select o;
           	list.ToList().ForEach(o => {
      			o.ClientSecret = clientSecret;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Access Token's id Access Token, created Date by idAccessToken
        /// </summary>
		/// <param name="idAccessToken">id Access Token</param>
		/// <param name="createdDate">created Date</param>
		/// <returns>List of  Access Token</returns>
        public void UpdateCreatedDate(Int64 idAccessToken, DateTime createdDate)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.AccessTokens
                       where
                       		o.IdAccessToken == idAccessToken
                       	select o;
           	list.ToList().ForEach(o => {
      			o.CreatedDate = createdDate;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Access Token's id Access Token, expired Date by idAccessToken
        /// </summary>
		/// <param name="idAccessToken">id Access Token</param>
		/// <param name="expiredDate">expired Date</param>
		/// <returns>List of  Access Token</returns>
        public void UpdateExpiredDate(Int64 idAccessToken, DateTime expiredDate)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.AccessTokens
                       where
                       		o.IdAccessToken == idAccessToken
                       	select o;
           	list.ToList().ForEach(o => {
      			o.ExpiredDate = expiredDate;	
            });
            dataContext.SaveChanges();
        }


//-------------------------- Update foreign keys -----------------------------------------


    }
}
