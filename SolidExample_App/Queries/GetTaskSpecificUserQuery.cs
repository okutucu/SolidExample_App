using SolidExample_App.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExample_App.Queries
{
    public class GetTaskSpecificUserQuery:IQuery
    {
        public int UserId { get; private set; }

        public GetTaskSpecificUserQuery(int userId)
        {
            this.UserId = userId;
        }
    }
}
