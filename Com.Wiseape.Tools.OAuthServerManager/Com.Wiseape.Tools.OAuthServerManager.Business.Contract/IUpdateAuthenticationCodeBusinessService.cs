using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Utility;
using Com.Wiseape.Tools.Data.Model;


namespace Com.Wiseape.Tools.OAuthServerManager.Business.Contract
{
    public interface IUpdateAuthenticationCodeBusinessService
    {

        /// <summary>
        /// Updates  Authentication Code's authentication Code String which has specified idAuthenticationCode
        /// </summary>
		/// <param name="idAuthenticationCode">id Authentication Code</param>
		/// <param name="authenticationCodeString">authentication Code String</param>
		/// <returns>List of  Authentication Code</returns>
		OperationResult UpdateAuthenticationCodeString(Int64 idAuthenticationCode, string authenticationCodeString);

        /// <summary>
        /// Updates  Authentication Code's client I D which has specified idAuthenticationCode
        /// </summary>
		/// <param name="idAuthenticationCode">id Authentication Code</param>
		/// <param name="clientID">client I D</param>
		/// <returns>List of  Authentication Code</returns>
		OperationResult UpdateClientID(Int64 idAuthenticationCode, string clientID);

        /// <summary>
        /// Updates  Authentication Code's authorization Session I D which has specified idAuthenticationCode
        /// </summary>
		/// <param name="idAuthenticationCode">id Authentication Code</param>
		/// <param name="authorizationSessionID">authorization Session I D</param>
		/// <returns>List of  Authentication Code</returns>
		OperationResult UpdateAuthorizationSessionID(Int64 idAuthenticationCode, string authorizationSessionID);

        /// <summary>
        /// Updates  Authentication Code's created Date which has specified idAuthenticationCode
        /// </summary>
		/// <param name="idAuthenticationCode">id Authentication Code</param>
		/// <param name="createdDate">created Date</param>
		/// <returns>List of  Authentication Code</returns>
		OperationResult UpdateCreatedDate(Int64 idAuthenticationCode, DateTime createdDate);

        /// <summary>
        /// Updates  Authentication Code's expired Date which has specified idAuthenticationCode
        /// </summary>
		/// <param name="idAuthenticationCode">id Authentication Code</param>
		/// <param name="expiredDate">expired Date</param>
		/// <returns>List of  Authentication Code</returns>
		OperationResult UpdateExpiredDate(Int64 idAuthenticationCode, DateTime expiredDate);

	}
}