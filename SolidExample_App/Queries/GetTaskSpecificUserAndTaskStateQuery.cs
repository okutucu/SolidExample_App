using SolidExample_App.Enums;
using SolidExample_App.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExample_App.Queries
{
    public class GetTaskSpecificUserAndTaskStateQuery:IQuery
    {

        public int State { get; private set; }
        public int UserId { get; private set; }


        public GetTaskSpecificUserAndTaskStateQuery(int userId,TaskState taskState)
        {
            this.UserId = userId;
            this.State = (int)taskState;
        }
    }
}
