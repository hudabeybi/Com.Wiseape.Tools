using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Tools.Data.Model;



namespace Com.Wiseape.Tools.OAuthServerManager.Repository.Contract
{
    public interface IFindRefreshTokenRepository
    {

        /// <summary>
        /// Finds all  Refresh Token data with client I D containing specified keyword
        /// </summary>
		/// <param name="clientID"> Client I D</param>
		/// <returns>List of  Refresh Token</returns>
		List<RefreshToken> FindByClientID(string clientID);

        /// <summary>
        /// Finds all  Refresh Token data with client Secret containing specified keyword
        /// </summary>
		/// <param name="clientSecret"> Client Secret</param>
		/// <returns>List of  Refresh Token</returns>
		List<RefreshToken> FindByClientSecret(string clientSecret);

        /// <summary>
        /// Finds all  Refresh Token data with authentication Code containing specified keyword
        /// </summary>
		/// <param name="authenticationCode"> Authentication Code</param>
		/// <returns>List of  Refresh Token</returns>
		List<RefreshToken> FindByAuthenticationCode(string authenticationCode);

        /// <summary>
        /// Finds all  Refresh Token data with refresh Token String containing specified keyword
        /// </summary>
		/// <param name="refreshTokenString"> Refresh Token String</param>
		/// <returns>List of  Refresh Token</returns>
		List<RefreshToken> FindByRefreshTokenString(string refreshTokenString);

        /// <summary>
        /// Finds all  Refresh Token data with created Date1, created Date2 containing specified keyword
        /// </summary>
		/// <param name="createdDate1"> Created Date</param>
		/// <param name="createdDate2"> Created Date</param>
		/// <returns>List of  Refresh Token</returns>
		List<RefreshToken> FindByCreatedDateBetween(DateTime createdDate1, DateTime createdDate2);

        /// <summary>
        /// Finds all  Refresh Token data with expired Date1, expired Date2 containing specified keyword
        /// </summary>
		/// <param name="expiredDate1"> Expired Date</param>
		/// <param name="expiredDate2"> Expired Date</param>
		/// <returns>List of  Refresh Token</returns>
		List<RefreshToken> FindByExpiredDateBetween(DateTime expiredDate1, DateTime expiredDate2);

    }
}

