using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DivideAndWalkTheDog.DAL.EF;
using DivideAndWalkTheDog.DAL.Entities;
using DivideAndWalkTheDog.DAL.Interfaces;

namespace DivideAndWalkTheDog.DAL.Repositories
{
    public class MessageRepository : IRepository<Message>
    {
        private readonly ApplicationContext _db;
        public MessageRepository(ApplicationContext context)
        {
            _db = context;
        }

        public IEnumerable<Message> GetAll()
        {
            return _db.Messages;
        }

        public Message Get(int id)
        {
            return _db.Messages.Find(id);
        }

        public void Create(Message message)
        {
            _db.Messages.Add(message);
        }

        public void Update(Message message)
        {
            _db.Entry(message).State = EntityState.Modified;
        }

        public IEnumerable<Message> Find(Func<Message, bool> predicate)
        {
            return _db.Messages.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            var message = _db.Messages.Find(id);

            if (message != null)
            {
                _db.Messages.Remove(message);
            }
        }
    }
}
