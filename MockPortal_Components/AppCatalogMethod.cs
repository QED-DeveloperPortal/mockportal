using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockPortal_Components
{
    public class AppCatalogMethod
    {
        public string Id { get; set; } // Guid Identifier
        public string GroupCode { get; set; }
        public string DomainName { get; set; }
        public string MethodType { get; set;}
        public string MethodPrefix { get; set; }
        public string Method { get; set; }
        public string MethodDescription { get; set; }
        public string FileName { get; set; }
    }
}