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
    public class GetTaskSpecificTaskStateQueryHandler : IQueryHandler<GetTaskSpecificTaskStateQuery, List<Entities.Task>>
    {


        private readonly ITaskRepository _taskRepository;

        public GetTaskSpecificTaskStateQueryHandler(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public List<Entities.Task> Execute(GetTaskSpecificTaskStateQuery query)
        {
            List<Entities.Task> tasks = _taskRepository.Where(x => x.State == query.State);

            return tasks;
        }
    }
}
