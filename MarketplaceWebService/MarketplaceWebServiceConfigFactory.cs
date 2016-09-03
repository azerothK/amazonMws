using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketplaceWebService.Sellers;

namespace MarketplaceWebService
{
    public abstract class MarketplaceWebServiceConfigFactory
    {
        public static MarketplaceWebServiceConfigBase CreateConfig(ConfigEnum configEnum)
        {
            MarketplaceWebServiceConfigBase config = null;
            switch (configEnum)
            {
                case ConfigEnum.Seller:
                {
                    config = new MarketplaceWebServiceSellersConfig();
                    break;
                }
            }
            return config;
        }
    }

   
}
