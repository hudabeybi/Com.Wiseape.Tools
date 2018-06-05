using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Tools.Data.Model;



namespace Com.Wiseape.Tools.OAuthServerManager.Repository.Contract
{
    public interface IUpdateAuthenticationSessionRepository
    {

	    /// <summary>
	    /// Updates  Authentication Session's id Authentication Session, authentication Session String by idAuthenticationSession
	    /// </summary>
		/// <param name="idAuthenticationSession">id Authentication Session</param>
		/// <param name="authenticationSessionString">authentication Session String</param>
		/// <returns>List of  Authentication Session</returns>
		void UpdateAuthenticationSessionString(Int64 idAuthenticationSession, string authenticationSessionString);
	
	    /// <summary>
	    /// Updates  Authentication Session's id Authentication Session, client I D by idAuthenticationSession
	    /// </summary>
		/// <param name="idAuthenticationSession">id Authentication Session</param>
		/// <param name="clientID">client I D</param>
		/// <returns>List of  Authentication Session</returns>
		void UpdateClientID(Int64 idAuthenticationSession, string clientID);
	
	    /// <summary>
	    /// Updates  Authentication Session's id Authentication Session, session Created Date by idAuthenticationSession
	    /// </summary>
		/// <param name="idAuthenticationSession">id Authentication Session</param>
		/// <param name="sessionCreatedDate">session Created Date</param>
		/// <returns>List of  Authentication Session</returns>
		void UpdateSessionCreatedDate(Int64 idAuthenticationSession, DateTime sessionCreatedDate);
	
	    /// <summary>
	    /// Updates  Authentication Session's id Authentication Session, session Expired Date by idAuthenticationSession
	    /// </summary>
		/// <param name="idAuthenticationSession">id Authentication Session</param>
		/// <param name="sessionExpiredDate">session Expired Date</param>
		/// <returns>List of  Authentication Session</returns>
		void UpdateSessionExpiredDate(Int64 idAuthenticationSession, DateTime sessionExpiredDate);
	
    }
}

