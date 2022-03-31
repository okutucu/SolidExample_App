using SolidExample_App.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExample_App.Factories
{
    //db
    public static class DbContextFactory
    {
      
        public static ProjectContext GetInstance()
        {
            return new ProjectContext();
        }
    }
}
