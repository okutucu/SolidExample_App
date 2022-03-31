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
    public class TaskCreateHandler : ICommandHandler<TaskCreateCommand, ResponseBase>
    {
        private readonly ITaskRepository _taskRepository;

        public TaskCreateHandler(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public ResponseBase Execute(TaskCreateCommand command)
        {
            ResponseBase response = ResponseBaseFactory.GetInstance();

            Entities.Task new_task = new Entities.Task(
                command.Title, 
                command.Description, 
                command.AssignedUserId, 
                command.EstimatedWorkHour);

            _taskRepository.Add(new_task);

            int result = _taskRepository.Save();

            if (result > 0)
            {
                response.IsSucceded = true;
                response.Message = "Yeni Bir Task Oluştu";
            }
            else
            {
                response.IsSucceded = false;
                response.Message = "Task Oluşurken Bir Hata Meydana Geldi";
            }

            return response;
        }
    }
}
