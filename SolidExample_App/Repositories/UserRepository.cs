using SolidExample_App.Contexts;
using SolidExample_App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SolidExample_App.Repositories
{
    public class UserRepository : IUserRepository
    {

        private readonly ProjectContext _db;

        public UserRepository(ProjectContext db)
        {
            _db = db;
        }

        public void Add(User item)
        {
            throw new NotImplementedException();
        }

        public User Find(int id)
        {
            return _db.Users.Find(id);
        }

        public List<User> GetAll()
        {
            return _db.Users.ToList();
        }

        public int Save()
        {
            throw new NotImplementedException();
        }

        public void Update(User item)
        {
            throw new NotImplementedException();
        }

        public List<User> Where(Expression<Func<User, bool>> expression)
        {
            return _db.Users.Where(expression).ToList();
        }
    }
}
