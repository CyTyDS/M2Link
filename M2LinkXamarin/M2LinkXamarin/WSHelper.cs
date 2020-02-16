using M2LinkXamarin.WebServiceClients;
//using M2LinkXamarin.WebServiceClients;
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Text;

namespace M2LinkXamarin
{
    public class WSHelper
    {
        public static WSLoginClient WSLoginClient = new WSLoginClient(
            new BasicHttpBinding(),
            new EndpointAddress(AppConstants.WSServer + "/WebServices/WSLogin.svc")
        );
    }
}
