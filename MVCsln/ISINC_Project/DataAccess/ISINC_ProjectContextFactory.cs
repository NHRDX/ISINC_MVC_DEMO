using ISINC_Project.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Socrates.DataAccess
{
    public static class SocratesContextFactory
    {
        public static IISINC_ProjectContext GetContext(string connStr, bool useProxies = true)
        {
            return new SocratesContext(connStr, useProxies);
        }
    }
}