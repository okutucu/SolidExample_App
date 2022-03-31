using SolidExample_App.Contexts;
using SolidExample_App.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SolidExample_App.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        //Dependency Inversion prensibi nedeniyle bu işlemi yapamayız.
        //ProjectContext db = new ProjectContext();

        //Dependency Injection
        private readonly ProjectContext _db;

        public TaskRepository(ProjectContext db)
        {
            _db = db;
        }

        public void Add(Entities.Task item)
        {
            _db.Tasks.Add(item);
        }

        public Entities.Task Find(int id)
        {
            return _db.Tasks.Find(id);
        }

        public List<Entities.Task> GetAll()
        {
            return _db.Tasks.ToList();
        }

        public int Save()
        {
            return _db.SaveChanges();
        }

        //Tasks Veri tabanındaki tablo   //Task object modelimiz

        public void Update(Entities.Task item)
        {
            _db.Tasks.Attach(item);

            DbEntityEntry entry = _db.Entry(item);

            foreach (var propertyName in entry.OriginalValues.PropertyNames)
            {
                object original = entry.GetDatabaseValues().GetValue<object>(propertyName);

                object current = entry.CurrentValues.GetValue<object>(propertyName);
          
                if (!object.Equals(original,current))
                {
                    entry.Property(propertyName).IsModified = true;
                }
            }
        }

        public List<Entities.Task> Where(Expression<Func<Entities.Task, bool>> expression)
        {
            return _db.Tasks.Where(expression).ToList();
        }
    }
}
