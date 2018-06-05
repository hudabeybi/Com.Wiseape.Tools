using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Web;
using System.ServiceModel.Activation;
using Com.Wiseape.Framework;
using Com.Wiseape.Utility;
using Com.Wiseape.Factory;
using Com.Wiseape.Tools.Data.Model;
using Com.Wiseape.Tools.OAuthServerManager.Business.Contract;


namespace Com.Wiseape.Tools.OAuthServerManager.Webservice
{
	[AspNetCompatibilityRequirements(
            RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class AuthenticationSourceService : IAuthenticationSourceService
    {

        class Keywords
        {
            public static string AuthenticationSource = "Tools.OAuthServerManager.AuthenticationSource";
            public static string FindAuthenticationSource = "Find.Tools.OAuthServerManager.AuthenticationSource";
            public static string AddAuthenticationSource = "Add.Tools.OAuthServerManager.AuthenticationSource";
            public static string UpdateAuthenticationSource = "Update.Tools.OAuthServerManager.AuthenticationSource";
            public static string DeleteAuthenticationSource = "Delete.Tools.OAuthServerManager.AuthenticationSource";
        }

        /// <summary>
        /// Service to add AuthenticationSource data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="AuthenticationSourceForm">AuthenticationSource data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [WebInvoke(Method = "POST",
                    ResponseFormat = WebMessageFormat.Json,
                    RequestFormat = WebMessageFormat.Json,
                    UriTemplate = "authenticationsource/add")]
        public Stream AddAuthenticationSource(AuthenticationSource authenticationSourceForm)
        {
            BaseBusinessService<AuthenticationSource> businessService = (BaseBusinessService<AuthenticationSource>)BusinessFactory.Create(Keywords.AddAuthenticationSource);
            OperationResult result = businessService.Add(authenticationSourceForm);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to update AuthenticationSource data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="authenticationSourceForm">AuthenticationSource data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [WebInvoke(Method = "POST",
                    ResponseFormat = WebMessageFormat.Json,
                    RequestFormat = WebMessageFormat.Json,
                    UriTemplate = "authenticationsource/update")]
        public Stream UpdateAuthenticationSource(AuthenticationSource authenticationSourceForm)
        {
            BaseBusinessService<AuthenticationSource> businessService = (BaseBusinessService<AuthenticationSource>)BusinessFactory.Create(Keywords.UpdateAuthenticationSource);
            OperationResult result = businessService.Update(authenticationSourceForm);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to delete AuthenticationSource data from data store. 
        /// The data deleted is defined by idAuthenticationSource.
        /// This is a GET request.
        /// </summary>
        /// <param name="idAuthenticationSource">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>  
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "authenticationsource/delete/{idAuthenticationSource}")]
        public Stream DeleteAuthenticationSource(string idAuthenticationSource)
        {
            BaseBusinessService<AuthenticationSource> businessService = (BaseBusinessService<AuthenticationSource>)BusinessFactory.Create(Keywords.DeleteAuthenticationSource);
            OperationResult result = businessService.Delete(idAuthenticationSource);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to get a AuthenticationSource data from data store. 
        /// The data retrieved is defined by idAuthenticationSource.
        /// This is a GET request.
        /// </summary>
        /// <param name="idAuthenticationSource">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>    
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "authenticationsource/get/{idAuthenticationSource}")]
        public Stream GetAuthenticationSource(string idAuthenticationSource)
        {
            BaseBusinessService<AuthenticationSource> businessService = (BaseBusinessService<AuthenticationSource>)BusinessFactory.Create(Keywords.FindAuthenticationSource);
            OperationResult result = businessService.Get(idAuthenticationSource);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to get all the AuthenticationSource data from data store. 
        /// The data items retrieved are those who contain the keyword given. 
        /// This is a GET request.
        /// </summary>
        /// <param name="keyword">the keyword to search</param>
        /// <param name="page">the page of the data navigation</param>
        /// <param name="max">the maximum amount of data to retrieve</param>
        /// <return>JSON string representation of operation result</return>    
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "authenticationsource/find/{keyword}/{page}/{max}")]
        public Stream FindAuthenticationSource(string keyword, string page, string max)
        {
            BaseBusinessService<AuthenticationSource> businessService = (BaseBusinessService<AuthenticationSource>)BusinessFactory.Create(Keywords.FindAuthenticationSource);

            SelectParam selectParam = new SelectParam();
            selectParam.Keyword = keyword;
            if (keyword.ToLower() == "all")
                selectParam.Keyword = "";
            OperationResult result = businessService.FindAll(selectParam, Convert.ToInt16(page), Convert.ToInt16(max) );

            return result.ToJsonStream();
        }	
        

        /// <summary>
        /// Finds all  Authentication Source data with authentication Source Name containing specified keyword
        /// </summary>
		/// <param name="authenticationSourceName"> Authentication Source Name</param>
		/// <returns>List of  Authentication Source</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "authenticationsource/find-by-authentication-source-name/{authenticationSourceName}")]
        public Stream FindByAuthenticationSourceName(string authenticationSourceName)
        {
            IFindAuthenticationSourceBusinessService businessService = (IFindAuthenticationSourceBusinessService)BusinessFactory.Create(Keywords.FindAuthenticationSource);
            OperationResult result = businessService.FindByAuthenticationSourceName(Convert.ToString(authenticationSourceName));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Authentication Source's authentication Source Name which has specified idAuthenticationSource
        /// </summary>
		/// <param name="idAuthenticationSource">id Authentication Source</param>
		/// <param name="authenticationSourceName">authentication Source Name</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "authenticationsource/update-authentication-source-name/{idAuthenticationSource}/{authenticationSourceName}")]
        public Stream UpdateAuthenticationSourceName(string idAuthenticationSource,string authenticationSourceName)
        {
            IUpdateAuthenticationSourceBusinessService businessService = (IUpdateAuthenticationSourceBusinessService)BusinessFactory.Create(Keywords.UpdateAuthenticationSource);
            OperationResult result = businessService.UpdateAuthenticationSourceName(Convert.ToInt16(idAuthenticationSource),Convert.ToString(authenticationSourceName) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Authentication Source data with authentication Source Name containing specified keyword
        /// </summary>
		/// <param name="authenticationSourceName"> Authentication Source Name</param>
		/// <returns>List of  Authentication Source</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "authenticationsource/delete-by-authentication-source-name/{authenticationSourceName}")]
        public Stream DeleteByAuthenticationSourceName(string authenticationSourceName)
        {
            IDeleteAuthenticationSourceBusinessService businessService = (IDeleteAuthenticationSourceBusinessService)BusinessFactory.Create(Keywords.DeleteAuthenticationSource);
            OperationResult result = businessService.DeleteByAuthenticationSourceName(Convert.ToString(authenticationSourceName) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Authentication Source data with authentication Library containing specified keyword
        /// </summary>
		/// <param name="authenticationLibrary"> Authentication Library</param>
		/// <returns>List of  Authentication Source</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "authenticationsource/find-by-authentication-library/{authenticationLibrary}")]
        public Stream FindByAuthenticationLibrary(string authenticationLibrary)
        {
            IFindAuthenticationSourceBusinessService businessService = (IFindAuthenticationSourceBusinessService)BusinessFactory.Create(Keywords.FindAuthenticationSource);
            OperationResult result = businessService.FindByAuthenticationLibrary(Convert.ToString(authenticationLibrary));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Authentication Source's authentication Library which has specified idAuthenticationSource
        /// </summary>
		/// <param name="idAuthenticationSource">id Authentication Source</param>
		/// <param name="authenticationLibrary">authentication Library</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "authenticationsource/update-authentication-library/{idAuthenticationSource}/{authenticationLibrary}")]
        public Stream UpdateAuthenticationLibrary(string idAuthenticationSource,string authenticationLibrary)
        {
            IUpdateAuthenticationSourceBusinessService businessService = (IUpdateAuthenticationSourceBusinessService)BusinessFactory.Create(Keywords.UpdateAuthenticationSource);
            OperationResult result = businessService.UpdateAuthenticationLibrary(Convert.ToInt16(idAuthenticationSource),Convert.ToString(authenticationLibrary) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Authentication Source data with authentication Library containing specified keyword
        /// </summary>
		/// <param name="authenticationLibrary"> Authentication Library</param>
		/// <returns>List of  Authentication Source</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "authenticationsource/delete-by-authentication-library/{authenticationLibrary}")]
        public Stream DeleteByAuthenticationLibrary(string authenticationLibrary)
        {
            IDeleteAuthenticationSourceBusinessService businessService = (IDeleteAuthenticationSourceBusinessService)BusinessFactory.Create(Keywords.DeleteAuthenticationSource);
            OperationResult result = businessService.DeleteByAuthenticationLibrary(Convert.ToString(authenticationLibrary) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Authentication Source data with authentication Classname containing specified keyword
        /// </summary>
		/// <param name="authenticationClassname"> Authentication Classname</param>
		/// <returns>List of  Authentication Source</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "authenticationsource/find-by-authentication-classname/{authenticationClassname}")]
        public Stream FindByAuthenticationClassname(string authenticationClassname)
        {
            IFindAuthenticationSourceBusinessService businessService = (IFindAuthenticationSourceBusinessService)BusinessFactory.Create(Keywords.FindAuthenticationSource);
            OperationResult result = businessService.FindByAuthenticationClassname(Convert.ToString(authenticationClassname));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Authentication Source's authentication Classname which has specified idAuthenticationSource
        /// </summary>
		/// <param name="idAuthenticationSource">id Authentication Source</param>
		/// <param name="authenticationClassname">authentication Classname</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "authenticationsource/update-authentication-classname/{idAuthenticationSource}/{authenticationClassname}")]
        public Stream UpdateAuthenticationClassname(string idAuthenticationSource,string authenticationClassname)
        {
            IUpdateAuthenticationSourceBusinessService businessService = (IUpdateAuthenticationSourceBusinessService)BusinessFactory.Create(Keywords.UpdateAuthenticationSource);
            OperationResult result = businessService.UpdateAuthenticationClassname(Convert.ToInt16(idAuthenticationSource),Convert.ToString(authenticationClassname) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Authentication Source data with authentication Classname containing specified keyword
        /// </summary>
		/// <param name="authenticationClassname"> Authentication Classname</param>
		/// <returns>List of  Authentication Source</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "authenticationsource/delete-by-authentication-classname/{authenticationClassname}")]
        public Stream DeleteByAuthenticationClassname(string authenticationClassname)
        {
            IDeleteAuthenticationSourceBusinessService businessService = (IDeleteAuthenticationSourceBusinessService)BusinessFactory.Create(Keywords.DeleteAuthenticationSource);
            OperationResult result = businessService.DeleteByAuthenticationClassname(Convert.ToString(authenticationClassname) );
            return result.ToJsonStream();
        }	
		
 
	}
}