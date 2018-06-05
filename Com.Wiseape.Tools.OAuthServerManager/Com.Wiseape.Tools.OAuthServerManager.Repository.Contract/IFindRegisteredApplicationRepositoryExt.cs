using Com.Wiseape.Tools.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Wiseape.Tools.OAuthServerManager.Repository.Contract
{
    public interface IFindRegisteredApplicationRepositoryExt
    {
        List<RegisteredApplication> FindByClientIDAndClientSecret(string clientId, string clientSecret);
    }
}
