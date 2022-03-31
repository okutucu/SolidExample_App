using SolidExample_App.Handlers;
using SolidExample_App.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExample_App.Factories
{
    public static class TaskInprogressHandlerFactory
    {

        public static TaskInProgressHandler GetInstance()
        {
            TaskRepository taskRepo = TaskRepositoryFactory.GetInstance();

            return new TaskInProgressHandler(taskRepo);
        }

       
    }
}
