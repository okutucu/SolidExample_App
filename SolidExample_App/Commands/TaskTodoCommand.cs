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
    //Single Responsibility Prensibi => Sınıfların ve Methodların Tek bir sorumlulugu olması gerektigini belirtir.
    //Bu Sınıfın Görevi => Belirli bir görevin state'tini Todo'ya Çekmektir.
    public class TaskTodoCommand:TaskStateBase,ICommand
    {

        public TaskTodoCommand(int taskId)
        {
            this.TaskId = taskId;
            this.State = (int)TaskState.Todo;
        }



    }
}
