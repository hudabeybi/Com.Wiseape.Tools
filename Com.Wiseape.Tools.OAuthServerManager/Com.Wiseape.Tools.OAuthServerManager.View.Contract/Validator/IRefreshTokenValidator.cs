using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Framework;

namespace Com.Wiseape.Tools.OAuthServerManager.View.Contract.Validator
{
    public interface IRefreshTokenValidator
    {

		ValidationResult ValidateClientID(Int64 idRefreshToken, string clientID);

		ValidationResult ValidateClientID(string clientID);

		ValidationResult ValidateClientSecret(Int64 idRefreshToken, string clientSecret);

		ValidationResult ValidateClientSecret(string clientSecret);

		ValidationResult ValidateAuthenticationCode(Int64 idRefreshToken, string authenticationCode);

		ValidationResult ValidateAuthenticationCode(string authenticationCode);

		ValidationResult ValidateRefreshTokenString(Int64 idRefreshToken, string refreshTokenString);

		ValidationResult ValidateRefreshTokenString(string refreshTokenString);

		ValidationResult ValidateCreatedDate(Int64 idRefreshToken, DateTime createdDate);

		ValidationResult ValidateCreatedDate(DateTime createdDate);

		ValidationResult ValidateExpiredDate(Int64 idRefreshToken, DateTime expiredDate);

		ValidationResult ValidateExpiredDate(DateTime expiredDate);

	}
}