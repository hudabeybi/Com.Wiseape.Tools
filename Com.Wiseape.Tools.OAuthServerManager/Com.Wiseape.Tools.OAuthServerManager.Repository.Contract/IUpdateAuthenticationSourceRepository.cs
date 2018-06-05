using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Tools.Data.Model;



namespace Com.Wiseape.Tools.OAuthServerManager.Repository.Contract
{
    public interface IUpdateAuthenticationSourceRepository
    {

	    /// <summary>
	    /// Updates  Authentication Source's id Authentication Source, authentication Source Name by idAuthenticationSource
	    /// </summary>
		/// <param name="idAuthenticationSource">id Authentication Source</param>
		/// <param name="authenticationSourceName">authentication Source Name</param>
		/// <returns>List of  Authentication Source</returns>
		void UpdateAuthenticationSourceName(Int16 idAuthenticationSource, string authenticationSourceName);
	
	    /// <summary>
	    /// Updates  Authentication Source's id Authentication Source, authentication Library by idAuthenticationSource
	    /// </summary>
		/// <param name="idAuthenticationSource">id Authentication Source</param>
		/// <param name="authenticationLibrary">authentication Library</param>
		/// <returns>List of  Authentication Source</returns>
		void UpdateAuthenticationLibrary(Int16 idAuthenticationSource, string authenticationLibrary);
	
	    /// <summary>
	    /// Updates  Authentication Source's id Authentication Source, authentication Classname by idAuthenticationSource
	    /// </summary>
		/// <param name="idAuthenticationSource">id Authentication Source</param>
		/// <param name="authenticationClassname">authentication Classname</param>
		/// <returns>List of  Authentication Source</returns>
		void UpdateAuthenticationClassname(Int16 idAuthenticationSource, string authenticationClassname);
	
    }
}

