using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExample_App.Base
{
    public abstract class TaskAssignBase
    {
        public int TaskId { get; protected set; }
        public int? UserId { get; protected set; }
    }
}
