using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Framework;

namespace Com.Wiseape.Tools.OAuthServerManager.View.Contract.Validator
{
    public interface IAccessTokenValidator
    {

		ValidationResult ValidateAccessTokenString(Int64 idAccessToken, string accessTokenString);

		ValidationResult ValidateAccessTokenString(string accessTokenString);

		ValidationResult ValidateRefreshToken(Int64 idAccessToken, string refreshToken);

		ValidationResult ValidateRefreshToken(string refreshToken);

		ValidationResult ValidateClientID(Int64 idAccessToken, string clientID);

		ValidationResult ValidateClientID(string clientID);

		ValidationResult ValidateClientSecret(Int64 idAccessToken, string clientSecret);

		ValidationResult ValidateClientSecret(string clientSecret);

		ValidationResult ValidateCreatedDate(Int64 idAccessToken, DateTime createdDate);

		ValidationResult ValidateCreatedDate(DateTime createdDate);

		ValidationResult ValidateExpiredDate(Int64 idAccessToken, DateTime expiredDate);

		ValidationResult ValidateExpiredDate(DateTime expiredDate);

	}
}