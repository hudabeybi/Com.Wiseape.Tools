using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Framework;

namespace Com.Wiseape.Tools.OAuthServerManager.View.Contract.Validator
{
    public interface IRegisteredApplicationValidator
    {

		ValidationResult ValidateApplicationName(Int16 idApplication, string applicationName);

		ValidationResult ValidateApplicationName(string applicationName);

		ValidationResult ValidateApplicationDesc(Int16 idApplication, string applicationDesc);

		ValidationResult ValidateApplicationDesc(string applicationDesc);

		ValidationResult ValidateClientID(Int16 idApplication, string clientID);

		ValidationResult ValidateClientID(string clientID);

		ValidationResult ValidateClientSecret(Int16 idApplication, string clientSecret);

		ValidationResult ValidateClientSecret(string clientSecret);

		ValidationResult ValidateAuthorizationTokenRedirectURI(Int16 idApplication, string authorizationTokenRedirectURI);

		ValidationResult ValidateAuthorizationTokenRedirectURI(string authorizationTokenRedirectURI);

		ValidationResult ValidateAccessTokenRedirectURI(Int16 idApplication, string accessTokenRedirectURI);

		ValidationResult ValidateAccessTokenRedirectURI(string accessTokenRedirectURI);

		ValidationResult ValidateAuthenticationSourceConnectionString(Int16 idApplication, string authenticationSourceConnectionString);

		ValidationResult ValidateAuthenticationSourceConnectionString(string authenticationSourceConnectionString);

		ValidationResult ValidateAuthenticationUrl(Int16 idApplication, string authenticationUrl);

		ValidationResult ValidateAuthenticationUrl(string authenticationUrl);

		ValidationResult ValidateCreatedDate(Int16 idApplication, DateTime createdDate);

		ValidationResult ValidateCreatedDate(DateTime createdDate);

		ValidationResult ValidateAuthenticationSourceId(Int16 idApplication, Int16 authenticationSourceId);

		ValidationResult ValidateAuthenticationSourceId(Int16 authenticationSourceId);

		ValidationResult ValidateAuthenticationSourceIdAndIsActive(Int16 idApplication, Int16 authenticationSourceId, Int16 isActive);

		ValidationResult ValidateAuthenticationSourceIdAndIsActive(Int16 authenticationSourceId, Int16 isActive);

		ValidationResult ValidateIsActive(Int16 idApplication, Int16 isActive);

		ValidationResult ValidateIsActive(Int16 isActive);

	}
}