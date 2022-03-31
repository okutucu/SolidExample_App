using SolidExample_App.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExample_App.Entities
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int State { get; set; }
        public int? UserId { get; set; }
        public int Hour { get; set; }
        public virtual User User { get; set; }


        public Task(string title,string description,int? userId,int hour)
        {
            this.Title = title.Trim();
            this.Description = description;
            this.UserId = userId;
            this.Hour = hour;
            this.State = (int)TaskState.Todo;

        }

        public Task()
        {

        }

    }
}
