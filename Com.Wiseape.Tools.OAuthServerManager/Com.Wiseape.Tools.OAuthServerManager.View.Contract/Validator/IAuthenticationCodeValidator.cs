using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Framework;

namespace Com.Wiseape.Tools.OAuthServerManager.View.Contract.Validator
{
    public interface IAuthenticationCodeValidator
    {

		ValidationResult ValidateAuthenticationCodeString(Int64 idAuthenticationCode, string authenticationCodeString);

		ValidationResult ValidateAuthenticationCodeString(string authenticationCodeString);

		ValidationResult ValidateClientID(Int64 idAuthenticationCode, string clientID);

		ValidationResult ValidateClientID(string clientID);

		ValidationResult ValidateAuthorizationSessionID(Int64 idAuthenticationCode, string authorizationSessionID);

		ValidationResult ValidateAuthorizationSessionID(string authorizationSessionID);

		ValidationResult ValidateCreatedDate(Int64 idAuthenticationCode, DateTime createdDate);

		ValidationResult ValidateCreatedDate(DateTime createdDate);

		ValidationResult ValidateExpiredDate(Int64 idAuthenticationCode, DateTime expiredDate);

		ValidationResult ValidateExpiredDate(DateTime expiredDate);

	}
}