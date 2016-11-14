using System;
using DivideAndWalkTheDog.DAL.EF;
using DivideAndWalkTheDog.DAL.Entities;
using DivideAndWalkTheDog.DAL.Interfaces;

namespace DivideAndWalkTheDog.DAL.Repositories
{
    public class UnitOfWork:IUnitOfWork
    {
        private ApplicationContext _db;
        private DogRepository _dogRepository;
        private MessageRepository _messageRepository;
        private RequestRepository _requestRepository;
        private UserRepository _userRepository;

        public UnitOfWork(string connectionString)
        {
            _db = new ApplicationContext(connectionString);
        }

        public IRepository<Dog> Dogs => _dogRepository ?? (_dogRepository = new DogRepository(_db));
        public IRepository<Message> Messages => _messageRepository ?? (_messageRepository = new MessageRepository(_db));
        public IRepository<Request> Requests => _requestRepository ?? (_requestRepository = new RequestRepository(_db));
        public IRepository<UserInfo> Users => _userRepository ?? (_userRepository = new UserRepository(_db));

        public void Save()
        {
            _db.SaveChanges();
        }

        private bool _disposed;

        public virtual void Dispose(bool disposing)
        {
            if (_disposed) return;
            if (disposing)
            {
                _db.Dispose();
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }

    
}
