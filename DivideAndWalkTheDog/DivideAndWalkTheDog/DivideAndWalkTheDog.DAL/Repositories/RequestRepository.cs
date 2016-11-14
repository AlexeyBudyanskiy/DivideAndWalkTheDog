using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DivideAndWalkTheDog.DAL.EF;
using DivideAndWalkTheDog.DAL.Entities;
using DivideAndWalkTheDog.DAL.Interfaces;

namespace DivideAndWalkTheDog.DAL.Repositories
{
    public class RequestRepository : IRepository<Request>
    {
        private readonly ApplicationContext _db;
        public RequestRepository(ApplicationContext context)
        {
            _db = context;
        }

        public IEnumerable<Request> GetAll()
        {
            return _db.Requests;
        }

        public Request Get(int id)
        {
            return _db.Requests.Find(id);
        }

        public void Create(Request request)
        {
            _db.Requests.Add(request);
        }

        public void Update(Request request)
        {
            _db.Entry(request).State = EntityState.Modified;
        }

        public IEnumerable<Request> Find(Func<Request, bool> predicate)
        {
            return _db.Requests.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            var request = _db.Requests.Find(id);

            if (request != null)
            {
                _db.Requests.Remove(request);
            }
        }
    }
}
