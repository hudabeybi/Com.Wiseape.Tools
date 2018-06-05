using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Tools.Data.Model;
using Com.Wiseape.Tools.OAuthServerManager.Repository.Contract;
using Com.Wiseape.Tools.OAuthServerManager.Business.Contract;
using Com.Wiseape.Utility;
using Com.Wiseape.Factory;
using System.Configuration;

namespace Com.Wiseape.Tools.OAuthServerManager.Business.Service
{
    public class AuthorizationBusinessService : IAuthorizationBusinessService
    {
        public bool CheckClientID(string clientID)
        {
            IFindRegisteredApplicationRepository bs = (IFindRegisteredApplicationRepository)RepositoryFactory.Create("Find.Tools.OAuthServerManager.RegisteredApplication");
            List<RegisteredApplication> applications = bs.FindByClientID(clientID);
            if (applications.Count > 0)
                return true;
            else
                return false;
        }

        public AuthenticationSession GenerateAuthenticationSession(string clientID)
        {
            AuthenticationSession session = new AuthenticationSession();
            session.AuthenticationSessionString = StringUtility.GenerateRandom(10);
            session.ClientID = clientID;
            session.SessionCreatedDate = DateTime.Now;
            session.SessionExpiredDate = DateTime.Now.AddHours(1);
            return session;
        }

        public string GetLoginHtml(string clientID, AuthenticationSession session, string loginFile)
        {
            string htmlFile = loginFile;
            string content = System.IO.File.ReadAllText( htmlFile);
            content = content.Replace("{{AuthenticationSession}}", session.AuthenticationSessionString);
            content = content.Replace("{{ClientID}}", session.ClientID);
            return content;
        }

        public OperationResult SaveAuthenticationSession(AuthenticationSession session)
        {
            Com.Wiseape.Framework.BaseBusinessService<AuthenticationSession> authenticationSession = (Com.Wiseape.Framework.BaseBusinessService<AuthenticationSession>)BusinessFactory.Create("Find.Tools.OAuthServerManager.AuthenticationSession");
            return authenticationSession.Add(session);
        }
    }
}
