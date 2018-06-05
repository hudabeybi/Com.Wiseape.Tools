using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Tools.Data.Model;



namespace Com.Wiseape.Tools.OAuthServerManager.Repository.Contract
{
    public interface IFindAuthenticationSessionRepository
    {

        /// <summary>
        /// Finds all  Authentication Session data with authentication Session String containing specified keyword
        /// </summary>
		/// <param name="authenticationSessionString"> Authentication Session String</param>
		/// <returns>List of  Authentication Session</returns>
		List<AuthenticationSession> FindByAuthenticationSessionString(string authenticationSessionString);

        /// <summary>
        /// Finds all  Authentication Session data with client I D containing specified keyword
        /// </summary>
		/// <param name="clientID"> Client I D</param>
		/// <returns>List of  Authentication Session</returns>
		List<AuthenticationSession> FindByClientID(string clientID);

        /// <summary>
        /// Finds all  Authentication Session data with session Created Date1, session Created Date2 containing specified keyword
        /// </summary>
		/// <param name="sessionCreatedDate1"> Session Created Date</param>
		/// <param name="sessionCreatedDate2"> Session Created Date</param>
		/// <returns>List of  Authentication Session</returns>
		List<AuthenticationSession> FindBySessionCreatedDateBetween(DateTime sessionCreatedDate1, DateTime sessionCreatedDate2);

        /// <summary>
        /// Finds all  Authentication Session data with session Expired Date1, session Expired Date2 containing specified keyword
        /// </summary>
		/// <param name="sessionExpiredDate1"> Session Expired Date</param>
		/// <param name="sessionExpiredDate2"> Session Expired Date</param>
		/// <returns>List of  Authentication Session</returns>
		List<AuthenticationSession> FindBySessionExpiredDateBetween(DateTime sessionExpiredDate1, DateTime sessionExpiredDate2);

    }
}

