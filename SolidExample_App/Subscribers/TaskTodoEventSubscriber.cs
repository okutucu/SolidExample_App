using SolidExample_App.Events;
using SolidExample_App.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExample_App.Subscribers
{
    public class TaskTodoEventSubscriber : INotification<TaskTodoEvent>
    {
        public string NotificationMessage { get; set; }

        private readonly IMailService _mailService;

        public TaskTodoEventSubscriber(IMailService mailService)
        {
            _mailService = mailService;
        }

        public void Notify(TaskTodoEvent @event)
        {
            if (_mailService != null)
            {
                List<string> emailList = new List<string>();

                emailList.Add(@event.TaskAssignedEmailAddress);

                bool result = _mailService.SendMail(
                    subject: @event.MessageTitle,
                    body: @event.Message,
                    to: emailList
                    );

                if (result == true)
                {
                    NotificationMessage = "Eposta Başarılı Bir Şekilde İletildi";
                }
                else
                {
                    NotificationMessage = "E-Posta Gönderilemedi";
                }
            }
        }
    }
}
