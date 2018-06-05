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
    /// Repository for UpdateAuthenticationCode data.
    /// </summary>
    public class UpdateAuthenticationCodeRepository : BaseRepository<AuthenticationCode>, IUpdateAuthenticationCodeRepository
    {
        class Keywords
        {
            public static string UpdateAuthenticationCode = "Update.Tools.OAuthServerManager.AuthenticationCode";
        }

        /// <summary>
        /// Constructor for AuthenticationCodeRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public UpdateAuthenticationCodeRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public UpdateAuthenticationCodeRepository()
        {
            this.DataContextKey = Keywords.UpdateAuthenticationCode;
        }


//-------------------------- Update columns by Primary key -----------------------------------------

        /// <summary>
        /// Updates  Authentication Code's id Authentication Code, authentication Code String by idAuthenticationCode
        /// </summary>
		/// <param name="idAuthenticationCode">id Authentication Code</param>
		/// <param name="authenticationCodeString">authentication Code String</param>
		/// <returns>List of  Authentication Code</returns>
        public void UpdateAuthenticationCodeString(Int64 idAuthenticationCode, string authenticationCodeString)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.AuthenticationCodes
                       where
                       		o.IdAuthenticationCode == idAuthenticationCode
                       	select o;
           	list.ToList().ForEach(o => {
      			o.AuthenticationCodeString = authenticationCodeString;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Authentication Code's id Authentication Code, client I D by idAuthenticationCode
        /// </summary>
		/// <param name="idAuthenticationCode">id Authentication Code</param>
		/// <param name="clientID">client I D</param>
		/// <returns>List of  Authentication Code</returns>
        public void UpdateClientID(Int64 idAuthenticationCode, string clientID)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.AuthenticationCodes
                       where
                       		o.IdAuthenticationCode == idAuthenticationCode
                       	select o;
           	list.ToList().ForEach(o => {
      			o.ClientID = clientID;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Authentication Code's id Authentication Code, authorization Session I D by idAuthenticationCode
        /// </summary>
		/// <param name="idAuthenticationCode">id Authentication Code</param>
		/// <param name="authorizationSessionID">authorization Session I D</param>
		/// <returns>List of  Authentication Code</returns>
        public void UpdateAuthorizationSessionID(Int64 idAuthenticationCode, string authorizationSessionID)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.AuthenticationCodes
                       where
                       		o.IdAuthenticationCode == idAuthenticationCode
                       	select o;
           	list.ToList().ForEach(o => {
      			o.AuthorizationSessionID = authorizationSessionID;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Authentication Code's id Authentication Code, created Date by idAuthenticationCode
        /// </summary>
		/// <param name="idAuthenticationCode">id Authentication Code</param>
		/// <param name="createdDate">created Date</param>
		/// <returns>List of  Authentication Code</returns>
        public void UpdateCreatedDate(Int64 idAuthenticationCode, DateTime createdDate)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.AuthenticationCodes
                       where
                       		o.IdAuthenticationCode == idAuthenticationCode
                       	select o;
           	list.ToList().ForEach(o => {
      			o.CreatedDate = createdDate;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Authentication Code's id Authentication Code, expired Date by idAuthenticationCode
        /// </summary>
		/// <param name="idAuthenticationCode">id Authentication Code</param>
		/// <param name="expiredDate">expired Date</param>
		/// <returns>List of  Authentication Code</returns>
        public void UpdateExpiredDate(Int64 idAuthenticationCode, DateTime expiredDate)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.AuthenticationCodes
                       where
                       		o.IdAuthenticationCode == idAuthenticationCode
                       	select o;
           	list.ToList().ForEach(o => {
      			o.ExpiredDate = expiredDate;	
            });
            dataContext.SaveChanges();
        }


//-------------------------- Update foreign keys -----------------------------------------


    }
}
