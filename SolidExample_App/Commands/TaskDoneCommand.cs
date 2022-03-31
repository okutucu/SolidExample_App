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
    public class TaskDoneCommand:TaskStateBase,ICommand
    {
        public TaskDoneCommand(int taskId)
        {
            this.TaskId = taskId;
            this.State = (int)TaskState.Done;
        }
    }
}
