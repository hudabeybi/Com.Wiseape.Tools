using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Utility;
using Com.Wiseape.Tools.Data.Model;


namespace Com.Wiseape.Tools.OAuthServerManager.Business.Contract
{
    public interface IDeleteAuthenticationSessionBusinessService
    {

        /// <summary>
        /// Delete all  Authentication Session data with authentication Session String containing specified keyword
        /// </summary>
		/// <param name="authenticationSessionString"> Authentication Session String</param>
		/// <returns>List of  Authentication Session</returns>
		OperationResult DeleteByAuthenticationSessionString(string authenticationSessionString);

        /// <summary>
        /// Delete all  Authentication Session data with client I D containing specified keyword
        /// </summary>
		/// <param name="clientID"> Client I D</param>
		/// <returns>List of  Authentication Session</returns>
		OperationResult DeleteByClientID(string clientID);

        /// <summary>
        /// Delete all  Authentication Session data with session Created Date containing specified keyword
        /// </summary>
		/// <param name="sessionCreatedDate"> Session Created Date</param>
		/// <returns>List of  Authentication Session</returns>
		OperationResult DeleteBySessionCreatedDate(DateTime sessionCreatedDate);

        /// <summary>
        /// Delete all  Authentication Session data with session Expired Date containing specified keyword
        /// </summary>
		/// <param name="sessionExpiredDate"> Session Expired Date</param>
		/// <returns>List of  Authentication Session</returns>
		OperationResult DeleteBySessionExpiredDate(DateTime sessionExpiredDate);

	}
}