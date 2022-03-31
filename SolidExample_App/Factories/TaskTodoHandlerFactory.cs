using SolidExample_App.Handlers;
using SolidExample_App.Repositories;
using SolidExample_App.Subscribers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExample_App.Factories
{
    public static class TaskTodoHandlerFactory
    {
        public static TaskTodoHandler GetInstance()
        {
            UserRepository userRepo = UserRepositoryFactory.GetInstance();
            TaskRepository taskRepo = TaskRepositoryFactory.GetInstance();
            TaskTodoEventSubscriber notification = TaskTodoEventSubscriberFactory.GetInstance();

            return new TaskTodoHandler(taskRepo,userRepo,notification);
        }
    }
}
