using SolidExample_App.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExample_App.Factories
{
    public static class NetMailServiceFactory
    {
        public static NetMailService GetInstance()
        {
            return new NetMailService();
        }
    }
}
