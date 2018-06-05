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
    /// Repository for UpdateAuthenticationSource data.
    /// </summary>
    public class UpdateAuthenticationSourceRepository : BaseRepository<AuthenticationSource>, IUpdateAuthenticationSourceRepository
    {
        class Keywords
        {
            public static string UpdateAuthenticationSource = "Update.Tools.OAuthServerManager.AuthenticationSource";
        }

        /// <summary>
        /// Constructor for AuthenticationSourceRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public UpdateAuthenticationSourceRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public UpdateAuthenticationSourceRepository()
        {
            this.DataContextKey = Keywords.UpdateAuthenticationSource;
        }


//-------------------------- Update columns by Primary key -----------------------------------------

        /// <summary>
        /// Updates  Authentication Source's id Authentication Source, authentication Source Name by idAuthenticationSource
        /// </summary>
		/// <param name="idAuthenticationSource">id Authentication Source</param>
		/// <param name="authenticationSourceName">authentication Source Name</param>
		/// <returns>List of  Authentication Source</returns>
        public void UpdateAuthenticationSourceName(Int16 idAuthenticationSource, string authenticationSourceName)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.AuthenticationSources
                       where
                       		o.IdAuthenticationSource == idAuthenticationSource
                       	select o;
           	list.ToList().ForEach(o => {
      			o.AuthenticationSourceName = authenticationSourceName;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Authentication Source's id Authentication Source, authentication Library by idAuthenticationSource
        /// </summary>
		/// <param name="idAuthenticationSource">id Authentication Source</param>
		/// <param name="authenticationLibrary">authentication Library</param>
		/// <returns>List of  Authentication Source</returns>
        public void UpdateAuthenticationLibrary(Int16 idAuthenticationSource, string authenticationLibrary)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.AuthenticationSources
                       where
                       		o.IdAuthenticationSource == idAuthenticationSource
                       	select o;
           	list.ToList().ForEach(o => {
      			o.AuthenticationLibrary = authenticationLibrary;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Authentication Source's id Authentication Source, authentication Classname by idAuthenticationSource
        /// </summary>
		/// <param name="idAuthenticationSource">id Authentication Source</param>
		/// <param name="authenticationClassname">authentication Classname</param>
		/// <returns>List of  Authentication Source</returns>
        public void UpdateAuthenticationClassname(Int16 idAuthenticationSource, string authenticationClassname)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.AuthenticationSources
                       where
                       		o.IdAuthenticationSource == idAuthenticationSource
                       	select o;
           	list.ToList().ForEach(o => {
      			o.AuthenticationClassname = authenticationClassname;	
            });
            dataContext.SaveChanges();
        }


//-------------------------- Update foreign keys -----------------------------------------


    }
}
