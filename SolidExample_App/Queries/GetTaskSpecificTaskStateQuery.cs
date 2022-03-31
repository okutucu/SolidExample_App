using SolidExample_App.Enums;
using SolidExample_App.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExample_App.Queries
{
    public class GetTaskSpecificTaskStateQuery:IQuery
    {
        public GetTaskSpecificTaskStateQuery(TaskState taskState)
        {
            this.State = (int)taskState;
        }

        public int State { get; private set; }
    }
}
