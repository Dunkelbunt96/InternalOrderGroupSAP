using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAP.Middleware.Connector;
using System.Configuration;
namespace InternalOrderGroupBAPI
{
    class connector : IDestinationConfiguration
    {
        public event RfcDestinationManager.ConfigurationChangeHandler ConfigurationChanged;

        public bool ChangeEventsSupported()
        {
            return false;
        
        }

        public RfcConfigParameters GetParameters(string destinationName)
        {
            RfcConfigParameters param = new RfcConfigParameters();
            param.Add(RfcConfigParameters.Name, ConfigurationManager.AppSettings["NAME"]);
            param.Add(RfcConfigParameters.AppServerHost, ConfigurationManager.AppSettings["SAP_APPServerHost"]);
            param.Add(RfcConfigParameters.SAPRouter, ConfigurationManager.AppSettings["SAP_ROUTER"]);
            param.Add(RfcConfigParameters.SystemNumber, ConfigurationManager.AppSettings["SAP_SYSTEMNUMBER"]);
            param.Add(RfcConfigParameters.SystemID, ConfigurationManager.AppSettings["SAP_SYSTEMID"]);
            param.Add(RfcConfigParameters.User, ConfigurationManager.AppSettings["SAP_USERNAME"]);
            param.Add(RfcConfigParameters.Password, ConfigurationManager.AppSettings["SAP_PASSWORD"]);
            param.Add(RfcConfigParameters.Client, ConfigurationManager.AppSettings["SAP_Client"]);
            param.Add(RfcConfigParameters.Language, ConfigurationManager.AppSettings["SAP_LANGUAGE"]);
            param.Add(RfcConfigParameters.PoolSize, ConfigurationManager.AppSettings["SAP_POOLSIZE"]);

            
            return param;

        }
    }
}
