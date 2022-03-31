using SolidExample_App.Interfaces;
using SolidExample_App.Queries;
using SolidExample_App.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExample_App.Handlers
{
    public class GetTaskSpecificUserQueryHandler : IQueryHandler<GetTaskSpecificUserQuery, List<Entities.Task>>
    {
        private readonly ITaskRepository _taskRepository;

        public GetTaskSpecificUserQueryHandler(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public List<Entities.Task> Execute(GetTaskSpecificUserQuery query)
        {
            List<Entities.Task> tasks = _taskRepository.Where(x => x.UserId == query.UserId);

            return tasks;
        }
    }
}
