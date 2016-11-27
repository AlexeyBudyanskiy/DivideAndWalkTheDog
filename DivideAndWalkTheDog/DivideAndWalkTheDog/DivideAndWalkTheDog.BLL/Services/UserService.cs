using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using DivideAndWalkTheDog.BLL.DTO;
using DivideAndWalkTheDog.BLL.Infrastructure;
using DivideAndWalkTheDog.BLL.Interfaces;
using DivideAndWalkTheDog.DAL.Entities;
using DivideAndWalkTheDog.DAL.Interfaces;

namespace DivideAndWalkTheDog.BLL.Services
{

    public class UserService:IUserService
    {
        private IUnitOfWork Database { get; }

        private readonly IMapper _mapperToDTO =
            new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UserInfo, UserDTO>();
            }).CreateMapper();
        private readonly IMapper _mapperFromDTO =
            new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UserDTO, UserInfo>();
            }).CreateMapper();

        public UserService(IUnitOfWork uow)
        {
            Database = uow;
        }

        public UserDTO GetUser(int userId)
        {
            if (userId == 0)
            {
                throw new ValidationException("User is equals 0", "userId");
            }

            return _mapperToDTO.Map<UserDTO>(Database.Users.Get(userId));
        }

        public UserDTO GetUserByApplicationId(string applicationId)
        {
            if (string.IsNullOrWhiteSpace(applicationId))
            {
                throw new ValidationException("Invalid application user Id", "applicationId");
            }
            var user = Database.Users.Find(x => x.ApplicationUserId.Equals(applicationId)).FirstOrDefault();
            var userDto = _mapperToDTO.Map<UserDTO>(user);
            return userDto;
        }

        public IEnumerable<UserDTO> GetAllUsers()
        {
            return _mapperToDTO.Map<IEnumerable<UserDTO>>(Database.Users.GetAll());
        }

        public void CreateUser(UserDTO user)
        {
            if (user == null)
            {
                throw new ValidationException("Undefined user", "");
            }
            if (string.IsNullOrWhiteSpace(user.ApplicationUserId))
            {
                throw new ValidationException("Invalid ApplicationUserId", "ApplicationUserId");
            }
            if (string.IsNullOrWhiteSpace(user.Name))
            {
                throw new ValidationException("User name is null or empty", "Name");
            }

            if (user.Birthday < DateTime.UtcNow.AddYears(-110) || user.Birthday > DateTime.UtcNow.AddDays(1))
            {
                user.Birthday = DateTime.UtcNow;
            }
            
            Database.Users.Create(_mapperFromDTO.Map<UserInfo>(user));
            Database.Save();
        }

        public void EditUser(UserDTO user)
        {
            if (user == null)
            {
                throw new ValidationException("Undefined user", "");
            }            
            if (user.Id == 0)
            {
                throw new ValidationException("User id is invalid", "Id");
            }
            if (string.IsNullOrWhiteSpace(user.ApplicationUserId))
            {
                throw new ValidationException("Invalid ApplicationUserId", "ApplicationUserId");
            }
            if (string.IsNullOrWhiteSpace(user.Name))
            {
                throw new ValidationException("User name is null or empty", "Name");
            }

            var updatingUser = Database.Users.Get(user.Id);
            if (updatingUser != null)
            {
                _mapperFromDTO.Map(user, updatingUser);
                Database.Users.Update(updatingUser);
                Database.Save();
            }
            else
            {
                throw new ValidationException("There is no such information in database", "");
            }
        }
    }
}
