using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Utility;
using Com.Wiseape.Tools.Data.Model;


namespace Com.Wiseape.Tools.OAuthServerManager.Business.Contract
{
    public interface IUpdateAuthenticationSourceBusinessService
    {

        /// <summary>
        /// Updates  Authentication Source's authentication Source Name which has specified idAuthenticationSource
        /// </summary>
		/// <param name="idAuthenticationSource">id Authentication Source</param>
		/// <param name="authenticationSourceName">authentication Source Name</param>
		/// <returns>List of  Authentication Source</returns>
		OperationResult UpdateAuthenticationSourceName(Int16 idAuthenticationSource, string authenticationSourceName);

        /// <summary>
        /// Updates  Authentication Source's authentication Library which has specified idAuthenticationSource
        /// </summary>
		/// <param name="idAuthenticationSource">id Authentication Source</param>
		/// <param name="authenticationLibrary">authentication Library</param>
		/// <returns>List of  Authentication Source</returns>
		OperationResult UpdateAuthenticationLibrary(Int16 idAuthenticationSource, string authenticationLibrary);

        /// <summary>
        /// Updates  Authentication Source's authentication Classname which has specified idAuthenticationSource
        /// </summary>
		/// <param name="idAuthenticationSource">id Authentication Source</param>
		/// <param name="authenticationClassname">authentication Classname</param>
		/// <returns>List of  Authentication Source</returns>
		OperationResult UpdateAuthenticationClassname(Int16 idAuthenticationSource, string authenticationClassname);

	}
}