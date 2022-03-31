using SolidExample_App.Base;
using SolidExample_App.Enums;
using SolidExample_App.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExample_App.Commands
{
    //Bu sınıfın Görevi state'i Inprogress yapmak.
    public class TaskInProgressCommand:TaskStateBase,ICommand
    {

        public TaskInProgressCommand(int taskId)
        {
            this.TaskId = taskId;
            this.State =(int)TaskState.InProgress;
        }
    }
}
