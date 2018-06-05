using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Framework;

namespace Com.Wiseape.Tools.OAuthServerManager.View.Contract.Validator
{
    public interface IAuthenticationSessionValidator
    {

		ValidationResult ValidateAuthenticationSessionString(Int64 idAuthenticationSession, string authenticationSessionString);

		ValidationResult ValidateAuthenticationSessionString(string authenticationSessionString);

		ValidationResult ValidateClientID(Int64 idAuthenticationSession, string clientID);

		ValidationResult ValidateClientID(string clientID);

		ValidationResult ValidateSessionCreatedDate(Int64 idAuthenticationSession, DateTime sessionCreatedDate);

		ValidationResult ValidateSessionCreatedDate(DateTime sessionCreatedDate);

		ValidationResult ValidateSessionExpiredDate(Int64 idAuthenticationSession, DateTime sessionExpiredDate);

		ValidationResult ValidateSessionExpiredDate(DateTime sessionExpiredDate);

	}
}