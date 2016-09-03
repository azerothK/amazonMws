using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketplaceWebService.Sellers;

namespace MarketplaceWebService
{
    public class AcountConfig
    {
        
        // Developer AWS access key
       public string AccessKey = "replaceWithAccessKey";

        // Developer AWS secret key
        public string SecretKey = "replaceWithSecretKey";

        // The client application name
        public string AppName = "CSharpSampleCode";

        // The client application version
        public string AppVersion = "1.0";

        // The endpoint for region service and version (see developer guide)
        // ex: https://mws.amazonservices.com
        public string ServiceUrl = "replaceWithServiceURL";

        public MarketplaceWebServiceSellersConfig Config;
    }



}
