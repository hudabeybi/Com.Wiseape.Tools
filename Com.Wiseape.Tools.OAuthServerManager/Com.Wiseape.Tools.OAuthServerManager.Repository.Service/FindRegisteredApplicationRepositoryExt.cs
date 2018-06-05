using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Tools.Data.Model;
using Com.Wiseape.Tools.OAuthServerManager.Repository.Contract;
using Com.Wiseape.Tools.OAuthServerManager.Repository.Service;
using Com.Wiseape.Tools.Data.Context;

namespace Com.Wiseape.Tools.OAuthServerManager.Repository.Service
{
    public class FindRegisteredApplicationRepositoryExt : FindRegisteredApplicationRepository, IFindRegisteredApplicationRepositoryExt
    {
        public List<RegisteredApplication> FindByClientIDAndClientSecret(string clientId, string clientSecret)
        {
            ToolsDataContext dataContext = (ToolsDataContext)this.DataContext;
            var list = from o in dataContext.RegisteredApplications
                       where
                            o.ClientID.Contains(clientId) &&
                            o.ClientSecret.Contains(clientSecret)
                       select o;
            return list.ToList();
        }
    }
}
