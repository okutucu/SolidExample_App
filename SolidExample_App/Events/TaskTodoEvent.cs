using SolidExample_App.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExample_App.Events
{
    public class TaskTodoEvent:IEvent
    {


        public string TaskAssignedEmailAddress { get; private set; }
        public string Message { get; private set; }
        public string TaskTitle { get; private set; }
        public string MessageTitle { get; private set; }
        public int TaskHour { get; private set; }

        public TaskTodoEvent(string assignedUserEmail,string taskTitle,int taskHour)
        {
            this.TaskAssignedEmailAddress = assignedUserEmail;
            this.TaskTitle = taskTitle;
            this.MessageTitle = $"{taskTitle} Todo' ya Çekildi";
            this.TaskHour = taskHour;
            this.Message = $"Değerli Takım Arkadaşımız, \n {taskTitle} için uygun görülen süre {taskHour} saattir.Taskınız Todo'ya Çekilmiştir.";
        }


    }
}
