using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExample_App.Base
{
    //Soyut Sınıf.
    //Liskov substutaion Prensibi => Base classtan Türemis classlar sınıf içerisindeki tüm özellikleri kullanmalıdır. Kullanmadıgı özellikleri gereksiz yere sınıflara yüklememeliyiz.
    public abstract class TaskStateBase
    {
        public int TaskId { get; set; } //TaskState'i Değişecek olan Task.
        public int State { get; set; } //Task'in Değişecek olan State'i
    }
}
