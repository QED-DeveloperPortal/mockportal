using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockPortal_Components
{
    public class Constants
    {
        public const string ApiBaseUrl = "https://mockaco.azurewebsites.net/";
            //= "http://localhost:5010/";

        public const string UrlPrefix = "/mocks"; // <= for azure deployment to inside of qed-developerportal
            // ""; <= for localhost
    }
}