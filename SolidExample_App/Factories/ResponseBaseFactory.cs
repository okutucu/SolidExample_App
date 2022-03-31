using SolidExample_App.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExample_App.Factories
{
    public static class ResponseBaseFactory
    {
        public static ResponseBase GetInstance()
        {
            return new ResponseBase();
        }
    }
}
