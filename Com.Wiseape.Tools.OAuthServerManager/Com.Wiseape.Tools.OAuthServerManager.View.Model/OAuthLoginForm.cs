using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Wiseape.Tools.OAuthServerManager.View.Model
{
    public class OAuthLoginForm
    {
        public string ClientID { get; set; }
        public string AuthorizationSessionID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
