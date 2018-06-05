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
    /// Repository for AuthenticationSource data.
    /// </summary>
    public class DeleteAuthenticationSourceRepository : BaseRepository<AuthenticationSource>, IDeleteAuthenticationSourceRepository
    {
        class Keywords
        {
            public static string DeleteAuthenticationSource = "Delete.Tools.OAuthServerManager.AuthenticationSource";
        }

        /// <summary>
        /// Constructor for DeleteAuthenticationSourceRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public DeleteAuthenticationSourceRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public DeleteAuthenticationSourceRepository()
        {
            this.DataContextKey = Keywords.DeleteAuthenticationSource;
        }

//------------------- Delete by keywords --------------------------------------------------------

        /// <summary>
        /// Delete all  Authentication Source data with authentication Source Name containing specified keyword
        /// </summary>
		/// <param name="authenticationSourceName"> Authentication Source Name</param>
		/// <returns>List of  Authentication Source</returns>
        public void DeleteByAuthenticationSourceName(string authenticationSourceName)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.AuthenticationSources
                       where
							o.AuthenticationSourceName.Contains(authenticationSourceName) 						
						select o;
			dataContext.AuthenticationSources.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  Authentication Source data with authentication Library containing specified keyword
        /// </summary>
		/// <param name="authenticationLibrary"> Authentication Library</param>
		/// <returns>List of  Authentication Source</returns>
        public void DeleteByAuthenticationLibrary(string authenticationLibrary)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.AuthenticationSources
                       where
							o.AuthenticationLibrary.Contains(authenticationLibrary) 						
						select o;
			dataContext.AuthenticationSources.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  Authentication Source data with authentication Classname containing specified keyword
        /// </summary>
		/// <param name="authenticationClassname"> Authentication Classname</param>
		/// <returns>List of  Authentication Source</returns>
        public void DeleteByAuthenticationClassname(string authenticationClassname)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.AuthenticationSources
                       where
							o.AuthenticationClassname.Contains(authenticationClassname) 						
						select o;
			dataContext.AuthenticationSources.RemoveRange(list);
            dataContext.SaveChanges();
        }


//-----------------------  Delete by Foreign keys ---------------------------------------


    }
}
