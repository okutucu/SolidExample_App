using SolidExample_App.Contexts;
using SolidExample_App.Handlers;
using SolidExample_App.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExample_App.Factories
{
    //TaskRepo Nesnesi üretti.
    public static class TaskRepositoryFactory
    {
        public static TaskRepository GetInstance()
        {
            ProjectContext db = DbContextFactory.GetInstance();
   

            return new TaskRepository(db);
        }
    }
}
