using SolidExample_App.Services;
using SolidExample_App.Subscribers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExample_App.Factories
{
    public static class TaskTodoEventSubscriberFactory
    {
        public static TaskTodoEventSubscriber GetInstance()
        {

            NetMailService mailService = NetMailServiceFactory.GetInstance();

            return new TaskTodoEventSubscriber(mailService);
        }
    }
}
