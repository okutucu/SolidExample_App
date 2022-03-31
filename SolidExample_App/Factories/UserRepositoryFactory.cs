using SolidExample_App.Contexts;
using SolidExample_App.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExample_App.Factories
{
    public static class UserRepositoryFactory
    {
        public static UserRepository GetInstance()
        {
            ProjectContext db = DbContextFactory.GetInstance();

            return new UserRepository(db);
        }
    }
}
