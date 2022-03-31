using SolidExample_App.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExample_App.Interfaces
{
    //Komutları işleyen Interface.
    //Command classlar ICommand arayüzünü kullanmak zorundadır şartı belirttik.
    //Response classlar ResponseBase'den Türemek zorundadır şartı belirttik.
    public interface ICommandHandler<TCommand,TResponse> where TCommand:ICommand where TResponse:ResponseBase
    {
        //Komutu gerçekleştirme Methodu.
        TResponse Execute(TCommand command); 
    }
}
