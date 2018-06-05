using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Framework;

namespace Com.Wiseape.Tools.OAuthServerManager.View.Contract.Validator
{
    public interface IOAuthSettingValidator
    {

		ValidationResult ValidateSettingKey(Int16 idOAuthSetting, string settingKey);

		ValidationResult ValidateSettingKey(string settingKey);

		ValidationResult ValidateSettingValue(Int16 idOAuthSetting, string settingValue);

		ValidationResult ValidateSettingValue(string settingValue);

	}
}