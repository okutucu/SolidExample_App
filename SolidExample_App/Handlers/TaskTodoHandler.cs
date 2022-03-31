using SolidExample_App.Base;
using SolidExample_App.Commands;
using SolidExample_App.Entities;
using SolidExample_App.Events;
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
    //TaskTodoHandler Sınıfı TaskTodoCommand tipi ile çalışıp. Aldıgı Commandı gerçekleştiricek.
    public class TaskTodoHandler : ICommandHandler<TaskTodoCommand, ResponseBase>
    {
        private readonly ITaskRepository _taskRepository;
        private readonly IUserRepository _userRepository;
        private readonly INotification<TaskTodoEvent> _notification;

        public TaskTodoHandler(ITaskRepository taskRepository, IUserRepository userRepository
, INotification<TaskTodoEvent> notification)  
            {
            _taskRepository = taskRepository;
            _userRepository = userRepository;
            _notification = notification;
        }

        public ResponseBase Execute(TaskTodoCommand command)
        {

            ResponseBase response = ResponseBaseFactory.GetInstance();

            Entities.Task task =  _taskRepository.Find(command.TaskId);

            User user = _userRepository.Find((int)task.UserId);

            task.State = command.State;

            _taskRepository.Update(task);

            int result = _taskRepository.Save();

            if (result > 0)
            {
                response.IsSucceded = true;
                response.Message = "Task Todo'Ya Çekildi";

                if (user != null)
                {
                    TaskTodoEvent @event = new TaskTodoEvent(

                        user.EmailAddress,
                        task.Title,
                        task.Hour
                        );


                    _notification.Notify(@event);

                    response.Message = $"{_notification.NotificationMessage}";

                    
                }


            }
            else
            {
                response.IsSucceded = false;
                response.Message = "Task Todo'ya Çekilirken Bir Hata Meydana Geldi";
            }

            return response;
        }
    }
}
