using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockPortal_Components
{
    public class Constants
    {
        public const string ApiBaseUrl = "https://mockaco.azurewebsites.net/";
            // = "http://localhost:5010/";

        public const string UrlPrefix = "/mocks"; // <= for azure deployment to inside of qed-developerportal
                                     // = ""; // <= for localhost

        public const string IndexPageUrl = UrlPrefix + "/";
        public const string ApiProductsPageUrl = UrlPrefix + "/apiproducts";
        public const string ApiProductMethodsPageUrl = UrlPrefix + "/apiproductmethods/{groupcode}";
        public const string ApiProductMethodTestPageUrl = UrlPrefix + "/apiproductmethodtest/{groupcode}/{id}";

        public const string NewLine = "\r\n";
    }
}