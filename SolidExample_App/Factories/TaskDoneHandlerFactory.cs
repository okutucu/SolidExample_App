using SolidExample_App.Handlers;
using SolidExample_App.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExample_App.Factories
{
    public static class TaskDoneHandlerFactory
    {
        public static TaskDoneHandler GetInstance()
        {

            TaskRepository taskRepo = TaskRepositoryFactory.GetInstance();

            return new TaskDoneHandler(taskRepo);
        }
    }
}
