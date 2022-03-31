using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExample_App.Interfaces
{
    public interface IQueryHandler<TQuery,TResponse> where TQuery : IQuery where TResponse:class
    {
        TResponse Execute(TQuery query);
    }
}
