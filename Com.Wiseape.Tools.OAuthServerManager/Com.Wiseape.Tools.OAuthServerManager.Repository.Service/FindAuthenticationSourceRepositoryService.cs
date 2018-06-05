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
    public class FindAuthenticationSourceRepository : BaseRepository<AuthenticationSource>, IFindAuthenticationSourceRepository
    {
        class Keywords
        {
            public static string FindAuthenticationSource = "Find.Tools.OAuthServerManager.AuthenticationSource";
        }

        /// <summary>
        /// Constructor for AuthenticationSourceRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public FindAuthenticationSourceRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public FindAuthenticationSourceRepository()
        {
            this.DataContextKey = Keywords.FindAuthenticationSource;
        }

//------------------- Find by keywords --------------------------------------------------------

        /// <summary>
        /// Finds all  Authentication Source data with authentication Source Name containing specified keyword
        /// </summary>
		/// <param name="authenticationSourceName"> Authentication Source Name</param>
		/// <returns>List of  Authentication Source</returns>
        public List<AuthenticationSource> FindByAuthenticationSourceName(string authenticationSourceName)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.AuthenticationSources
                       where
							o.AuthenticationSourceName.Contains(authenticationSourceName) 						
						select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  Authentication Source data with authentication Library containing specified keyword
        /// </summary>
		/// <param name="authenticationLibrary"> Authentication Library</param>
		/// <returns>List of  Authentication Source</returns>
        public List<AuthenticationSource> FindByAuthenticationLibrary(string authenticationLibrary)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.AuthenticationSources
                       where
							o.AuthenticationLibrary.Contains(authenticationLibrary) 						
						select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  Authentication Source data with authentication Classname containing specified keyword
        /// </summary>
		/// <param name="authenticationClassname"> Authentication Classname</param>
		/// <returns>List of  Authentication Source</returns>
        public List<AuthenticationSource> FindByAuthenticationClassname(string authenticationClassname)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.AuthenticationSources
                       where
							o.AuthenticationClassname.Contains(authenticationClassname) 						
						select o;
            return list.ToList();
        }


//----------------------  find by dates -----------------------------------------------


//-----------------------  Find by Foreign keys ---------------------------------------




    }
}
