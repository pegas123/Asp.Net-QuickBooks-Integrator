using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services;

namespace MK.QuickBooksIntegration
{
    [WebService(Namespace = "http://developer.intuit.com/")]
    [WebServiceBinding(Name = "QuickBooksIntegrationService", Namespace = "http://developer.intuit.com/")]
    public class QuickBooksIntegrationService : IQuickBooksIntegrationService
    {
        public string[] authenticate(string strUserName, string strPassword)
        {
            // TODO validate strUserName and strPassword
            return new string[2] { new Guid().ToString(), "" };
        }

        public string clientVersion(string strVersion)
        {
            throw new NotImplementedException();
        }

        public string closeConnection(string ticket)
        {
            throw new NotImplementedException();
        }

        public string connectionError(string ticket, string hresult, string message)
        {
            throw new NotImplementedException();
        }

        public string getLastError(string ticket)
        {
            throw new NotImplementedException();
        }

        public int receiveResponseXML(string ticket, string response, string hresult, string message)
        {
            throw new NotImplementedException();
        }

        public string sendRequestXML(string ticket, string strHCPResponse, string strCompanyFileName, string qbXMLCountry, int qbXMLMajorVers, int qbXMLMinorVers)
        {
            throw new NotImplementedException();
        }

        public string serverVersion()
        {
            throw new NotImplementedException();
        }
    }
}
