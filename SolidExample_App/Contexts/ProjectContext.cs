using SolidExample_App.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExample_App.Contexts
{
    public class ProjectContext:DbContext
    {
        public virtual DbSet<Entities.Task> Tasks { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
