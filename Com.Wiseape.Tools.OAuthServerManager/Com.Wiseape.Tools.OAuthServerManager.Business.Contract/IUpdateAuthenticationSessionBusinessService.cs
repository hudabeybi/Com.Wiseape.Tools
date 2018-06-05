using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Utility;
using Com.Wiseape.Tools.Data.Model;


namespace Com.Wiseape.Tools.OAuthServerManager.Business.Contract
{
    public interface IUpdateAuthenticationSessionBusinessService
    {

        /// <summary>
        /// Updates  Authentication Session's authentication Session String which has specified idAuthenticationSession
        /// </summary>
		/// <param name="idAuthenticationSession">id Authentication Session</param>
		/// <param name="authenticationSessionString">authentication Session String</param>
		/// <returns>List of  Authentication Session</returns>
		OperationResult UpdateAuthenticationSessionString(Int64 idAuthenticationSession, string authenticationSessionString);

        /// <summary>
        /// Updates  Authentication Session's client I D which has specified idAuthenticationSession
        /// </summary>
		/// <param name="idAuthenticationSession">id Authentication Session</param>
		/// <param name="clientID">client I D</param>
		/// <returns>List of  Authentication Session</returns>
		OperationResult UpdateClientID(Int64 idAuthenticationSession, string clientID);

        /// <summary>
        /// Updates  Authentication Session's session Created Date which has specified idAuthenticationSession
        /// </summary>
		/// <param name="idAuthenticationSession">id Authentication Session</param>
		/// <param name="sessionCreatedDate">session Created Date</param>
		/// <returns>List of  Authentication Session</returns>
		OperationResult UpdateSessionCreatedDate(Int64 idAuthenticationSession, DateTime sessionCreatedDate);

        /// <summary>
        /// Updates  Authentication Session's session Expired Date which has specified idAuthenticationSession
        /// </summary>
		/// <param name="idAuthenticationSession">id Authentication Session</param>
		/// <param name="sessionExpiredDate">session Expired Date</param>
		/// <returns>List of  Authentication Session</returns>
		OperationResult UpdateSessionExpiredDate(Int64 idAuthenticationSession, DateTime sessionExpiredDate);

	}
}