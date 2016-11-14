using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DivideAndWalkTheDog.DAL.EF;
using DivideAndWalkTheDog.DAL.Entities;
using DivideAndWalkTheDog.DAL.Interfaces;

namespace DivideAndWalkTheDog.DAL.Repositories
{
    public class UserRepository:IRepository<UserInfo>
    {
        private readonly ApplicationContext _db;
        public UserRepository(ApplicationContext context)
        {
            _db = context;
        }
        public IEnumerable<UserInfo> GetAll()
        {
            return _db.Users;
        }

        public UserInfo Get(int id)
        {
            return _db.Users.Find(id);
        }

        public IEnumerable<UserInfo> Find(Func<UserInfo, bool> predicate)
        {
            return _db.Users.Where(predicate).ToList();
        }

        public void Create(UserInfo item)
        {
            _db.Users.Add(item);
        }

        public void Update(UserInfo item)
        {
            _db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            var user = _db.Users.Find(id);

            if (user != null)
            {
                _db.Users.Remove(user);
            }
        }
    }
}
