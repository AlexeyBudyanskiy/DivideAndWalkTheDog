using System;
using DivideAndWalkTheDog.DAL.Entities;

namespace DivideAndWalkTheDog.DAL.Interfaces
{
    public interface IUnitOfWork:IDisposable
    {
        IRepository<Dog> Dogs { get; }
        IRepository<Request> Requests { get; }
        IRepository<Message> Messages { get; }
        IRepository<UserInfo> Users { get; }
        void Save();
    }
}
