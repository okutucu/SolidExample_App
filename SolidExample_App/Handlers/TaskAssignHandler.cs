using SolidExample_App.Base;
using SolidExample_App.Commands;
using SolidExample_App.Factories;
using SolidExample_App.Interfaces;
using SolidExample_App.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExample_App.Handlers
{
    public class TaskAssignHandler : ICommandHandler<TaskAssignCommand, ResponseBase>
    {
        private readonly ITaskRepository _taskRepository;

        public TaskAssignHandler(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public ResponseBase Execute(TaskAssignCommand command)
        {
            ResponseBase response = ResponseBaseFactory.GetInstance();

            Entities.Task task =  _taskRepository.Find(command.TaskId);

            task.UserId = command.UserId;

            _taskRepository.Update(task);

            int result = _taskRepository.Save();

            if (result > 0)
            {
                response.IsSucceded = true;
                response.Message = "Task Assign İşlemi Başarılı";
            }
            else
            {
                response.IsSucceded = false;
                response.Message = "Task Assign İşlemi Başarısız";
            }

            return response;
        }
    }
}
