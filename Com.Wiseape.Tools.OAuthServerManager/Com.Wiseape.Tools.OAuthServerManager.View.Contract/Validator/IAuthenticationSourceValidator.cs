using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Framework;

namespace Com.Wiseape.Tools.OAuthServerManager.View.Contract.Validator
{
    public interface IAuthenticationSourceValidator
    {

		ValidationResult ValidateAuthenticationSourceName(Int16 idAuthenticationSource, string authenticationSourceName);

		ValidationResult ValidateAuthenticationSourceName(string authenticationSourceName);

		ValidationResult ValidateAuthenticationLibrary(Int16 idAuthenticationSource, string authenticationLibrary);

		ValidationResult ValidateAuthenticationLibrary(string authenticationLibrary);

		ValidationResult ValidateAuthenticationClassname(Int16 idAuthenticationSource, string authenticationClassname);

		ValidationResult ValidateAuthenticationClassname(string authenticationClassname);

	}
}