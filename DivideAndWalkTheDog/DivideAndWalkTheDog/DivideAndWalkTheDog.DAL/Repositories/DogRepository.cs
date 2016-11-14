using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DivideAndWalkTheDog.DAL.EF;
using DivideAndWalkTheDog.DAL.Entities;
using DivideAndWalkTheDog.DAL.Interfaces;

namespace DivideAndWalkTheDog.DAL.Repositories
{
    public class DogRepository: IRepository<Dog>
    {
        private readonly ApplicationContext _db;
        public DogRepository(ApplicationContext context)
        {
            _db = context;
        }

        public IEnumerable<Dog> GetAll()
        {
            return _db.Dogs;
        }

        public Dog Get(int id)
        {
            return _db.Dogs.Find(id);
        }

        public void Create(Dog dog)
        {
            _db.Dogs.Add(dog);
        }

        public void Update(Dog dog)
        {
            _db.Entry(dog).State = EntityState.Modified;
        }

        public IEnumerable<Dog> Find(Func<Dog, bool> predicate)
        {
            return _db.Dogs.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            var auto = _db.Dogs.Find(id);

            if (auto != null)
            {
                _db.Dogs.Remove(auto);
            }
        }
    }
}
