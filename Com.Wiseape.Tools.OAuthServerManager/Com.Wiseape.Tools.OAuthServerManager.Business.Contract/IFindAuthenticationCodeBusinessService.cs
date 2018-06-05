using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Utility;
using Com.Wiseape.Tools.Data.Model;


namespace Com.Wiseape.Tools.OAuthServerManager.Business.Contract
{
    public interface IFindAuthenticationCodeBusinessService
    {

        /// <summary>
        /// Finds all  Authentication Code data with authentication Code String containing specified keyword
        /// </summary>
		/// <param name="authenticationCodeString"> Authentication Code String</param>
		/// <returns>List of  Authentication Code</returns>
		OperationResult FindByAuthenticationCodeString(string authenticationCodeString);

        /// <summary>
        /// Finds all  Authentication Code data with client I D containing specified keyword
        /// </summary>
		/// <param name="clientID"> Client I D</param>
		/// <returns>List of  Authentication Code</returns>
		OperationResult FindByClientID(string clientID);

        /// <summary>
        /// Finds all  Authentication Code data with authorization Session I D containing specified keyword
        /// </summary>
		/// <param name="authorizationSessionID"> Authorization Session I D</param>
		/// <returns>List of  Authentication Code</returns>
		OperationResult FindByAuthorizationSessionID(string authorizationSessionID);

        /// <summary>
        /// Finds all  Authentication Code with CreatedDate between CreatedDate1 and CreatedDate2
        /// </summary>
		/// <param name="createdDate1"> Created Date</param>
		/// <param name="createdDate2"> Created Date</param>
		/// <returns>List of  Authentication Code</returns>
		OperationResult FindByCreatedDateBetween(DateTime createdDate1, DateTime createdDate2);

        /// <summary>
        /// Finds all  Authentication Code with ExpiredDate between ExpiredDate1 and ExpiredDate2
        /// </summary>
		/// <param name="expiredDate1"> Expired Date</param>
		/// <param name="expiredDate2"> Expired Date</param>
		/// <returns>List of  Authentication Code</returns>
		OperationResult FindByExpiredDateBetween(DateTime expiredDate1, DateTime expiredDate2);

	}
}