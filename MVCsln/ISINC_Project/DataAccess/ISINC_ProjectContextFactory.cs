using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISINC_Project.DataAccess
{
    public static class ISINC_ProjectContextFactory
    {
        public static IISINC_ProjectContext GetContext(string connStr, bool useProxies = true)
        {
            return new ISINC_ProjectContext(connStr, useProxies);
        }
    }
}