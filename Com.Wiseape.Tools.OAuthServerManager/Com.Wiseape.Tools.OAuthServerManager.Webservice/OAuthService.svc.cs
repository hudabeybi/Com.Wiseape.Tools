using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Com.Wiseape.Tools.OAuthServerManager.Business.Contract;
using Com.Wiseape.Tools.OAuthServerManager.View.Model;
using Com.Wiseape.Factory;
using Com.Wiseape.Utility;
using Com.Wiseape.Tools.Data.Model;
using System.ServiceModel.Web;
using System.ServiceModel.Activation;
using System.Configuration;
using System.Web.Hosting;
using System.Net;

namespace Com.Wiseape.Tools.OAuthServerManager.Webservice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "OAuthService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select OAuthService.svc or OAuthService.svc.cs at the Solution Explorer and start debugging.


    [AspNetCompatibilityRequirements(
            RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class OAuthService : IOAuthService
    {
        [WebInvoke(Method = "GET",
                   ResponseFormat = WebMessageFormat.Json,
                   UriTemplate = "oauth/checkacesstoken/{accessToken}")]
        public Stream CheckAccessToken(string accessToken)
        {
            IAccessTokenBusinessService businessService = (IAccessTokenBusinessService)BusinessFactory.Create("Tools.OAuthServerManager.AccessToken");
            OperationResult result = businessService.CheckAccessToken(accessToken);
            return result.ToJsonStream();
        }

        public void DoWork()
        {
        }

        [WebInvoke(Method = "GET",
               ResponseFormat = WebMessageFormat.Json,
               UriTemplate = "oauth/accesstoken/{authorizationCode}/{clientID}/{clientSecret}")]
        public Stream HandleAccessTokenRequest(string authorizationCode, string clientID, string clientSecret)
        {
            IHandleAccessTokenRequestBusinessService businessService = (IHandleAccessTokenRequestBusinessService)BusinessFactory.Create("Tools.OAuthServerManager.HandleAccessTokenRequest");
            OperationResult result = businessService.CheckClientIDAndClientSecret(clientID, clientSecret);
            if(result.Result)
            {
                result = businessService.CheckAuthorizationCode(clientID, clientSecret, authorizationCode);
                IFindAuthenticationCodeBusinessService authCodeBs = (IFindAuthenticationCodeBusinessService)BusinessFactory.Create("Find.Tools.OAuthServerManager.AuthenticationCode");
                OperationResult authCodeResult = authCodeBs.FindByAuthenticationCodeString(authorizationCode);

                if(result.Result)
                {
                    List<AuthenticationCode> codes = (List<AuthenticationCode>)authCodeResult.Data;
                    if(codes.Count > 0)
                    {
                        AuthenticationCode code = (AuthenticationCode)codes[0];
                        result = businessService.CreateAccessToken(code);
                        businessService.SaveAccessToken((AccessToken)result.Data);
                    }
                }
            }
            return result.ToJsonStream();
        }


        [WebInvoke(Method = "GET",
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "oauth/authorize/{clientID}")]
        public Stream HandleAuthorizationRequest(string clientID)
        {
            IAuthorizationBusinessService businessService = (IAuthorizationBusinessService)BusinessFactory.Create("Tools.OAuthServerManager.Authorization");
            bool result = businessService.CheckClientID(clientID);
            if(result)
            {

                OperationResult accessTokenResult = CheckAccessTokenHeader();
                if (accessTokenResult.Result)
                    return accessTokenResult.ToJsonStream();

                AuthenticationSession session = businessService.GenerateAuthenticationSession(clientID);
                OperationResult res = businessService.SaveAuthenticationSession(session);

                string loginFile = ConfigurationManager.AppSettings["LoginFile"];
                loginFile = HostingEnvironment.MapPath("~/" + loginFile);

                string html = businessService.GetLoginHtml(clientID, session, loginFile);

                string baseUrl = AppDomain.CurrentDomain.BaseDirectory;
                var baseAddress = "" + OperationContext.Current.Host.BaseAddresses[0].AbsoluteUri + "";
                baseAddress = baseAddress.Replace("OAuthService.svc", "");
                html = html.Replace("{baseurl}", baseAddress + "/Resources");
                html = html.Replace("{authenticationSession}", session.AuthenticationSessionString);
                html = html.Replace("{url}", baseAddress + "/OAuthService.svc/oauth/login");
                html = html.Replace("{clientID}", clientID);

                var stream = new MemoryStream();
                var writer = new StreamWriter(stream);
                writer.Write(html);
                writer.Flush();
                stream.Position = 0;

                return stream;
            }

            return new OperationResult(false, "Client : " + clientID + " does not exist!").ToJsonStream();
        }

        protected OperationResult CheckAccessTokenHeader()
        {
            IncomingWebRequestContext request = WebOperationContext.Current.IncomingRequest;
            WebHeaderCollection headers = request.Headers;
            string authHeader = headers[HttpRequestHeader.Authorization];
            if (authHeader != null)
            {
                string[] ss = authHeader.Split(new char[] { ' ' });
                if (ss.Length > 1)
                {
                    string accessToken = ss[1];
                    IAccessTokenBusinessService accessTokenBs = (IAccessTokenBusinessService)BusinessFactory.Create("Tools.OAuthServerManager.AccessToken");
                    OperationResult accessTokenResult = accessTokenBs.CheckAccessToken(accessToken);
                    return accessTokenResult;
                }
                else
                {
                    return new OperationResult(false, null, "Invalid authorization header");
                }
            }
            else
                return new OperationResult(false, null, "No authorization header");
        }

        [WebInvoke(Method = "POST",
           ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
           UriTemplate = "oauth/login")]
        public Stream HandleOAuthLogin(OAuthLoginForm loginForm)
        {
            IOAuthLoginBusinessService businessService = (IOAuthLoginBusinessService)BusinessFactory.Create("Tools.OAuthServerManager.OAuthLogin");
            OperationResult result = businessService.CheckAuthenticationSession(loginForm);
            if(result.Result)
            {
                result = businessService.GetAuthenticationServer(loginForm.ClientID);
                if(result.Result)
                {
                    //RegisteredApplication app = (RegisteredApplication)result.Data;
                    result = businessService.QueryAuthenticationServer((string)result.Data, loginForm.Username, loginForm.Password);
                    if(result.Result)
                    {
                        result = businessService.GenerateAuthorizationCode(result, loginForm.Username, loginForm.ClientID, loginForm.AuthorizationSessionID);
                        businessService.SaveAuthorizationCode((AuthenticationCode) result.Data);
                        result = businessService.CallCallbackUrlWithAuthorizationResult(loginForm.ClientID, ((AuthenticationCode)result.Data).AuthenticationCodeString);
                    }
                }
            }

            return result.ToJsonStream();
        }

        [WebInvoke(Method = "GET",
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "oauth/userinfo")]
        public Stream UserInfo()
        {
            OperationResult resultAccessToken = CheckAccessTokenHeader();
            if(resultAccessToken.Result)
            {
                AccessToken accestoken = (AccessToken)resultAccessToken.Data;
                
                IOAuthLoginBusinessService businessService = (IOAuthLoginBusinessService)BusinessFactory.Create("Tools.OAuthServerManager.OAuthLogin");
                OperationResult result = businessService.GetAuthenticationServer(accestoken.ClientID);
                string authserver = (string)result.Data;
               
                resultAccessToken = businessService.QueryAuthenticationServerAskForUserInfo(authserver, accestoken.UserID);
            }

            return resultAccessToken.ToJsonStream();
        }
    }
}
