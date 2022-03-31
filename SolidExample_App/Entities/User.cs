using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExample_App.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EmailAddress { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }


        public override string ToString()
        {
            return $"{Name} {Surname}";
        }
    }
}
