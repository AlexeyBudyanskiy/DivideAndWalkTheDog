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
    public class DogService:IDogService
    {
        private IUnitOfWork Database { get; }

        private readonly IMapper _mapperToDTO =
            new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UserInfo, UserDTO>();
                cfg.CreateMap<Dog, DogDTO>();
            }).CreateMapper();
        private readonly IMapper _mapperFromDTO =
            new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UserDTO, UserInfo>();
                cfg.CreateMap<DogDTO, Dog>();
            }).CreateMapper();

        public DogService(IUnitOfWork uow)
        {
            Database = uow;
        }
        public DogDTO GetDog(int dogId)
        {
            if (dogId == 0)
            {
                throw new ValidationException("Dog id equals 0", "requestId");
            }

            return _mapperToDTO.Map<DogDTO>(Database.Dogs.Get(dogId));
        }

        public IEnumerable<DogDTO> GetAllDogs()
        {
            List<Dog> dogs = Database.Dogs.GetAll().ToList();
            return _mapperToDTO.Map<IEnumerable<DogDTO>>(dogs);
        }

        public void CreateDog(DogDTO dog)
        {
            if (dog == null)
            {
                throw new ValidationException("Undefined dog", "");
            }
            if (string.IsNullOrWhiteSpace(dog.Name))
            {
                throw new ValidationException("Dog name is null or empty", "Name");
            }
            if (string.IsNullOrWhiteSpace(dog.Breed))
            {
                throw new ValidationException("Dog breed is null or empty", "Breed");
            }
            if (dog.User == null || dog.User.Id == 0)
            {
                throw new ValidationException("Dog User is null or invalid", "User");
            }

            Database.Dogs.Create(_mapperFromDTO.Map<Dog>(dog));
            Database.Save();
        }

        public void EditDog(DogDTO dog)
        {
            if (dog.Id == 0)
            {
                throw new ValidationException("Dog id is invalid", "Id");
            }
            if (string.IsNullOrWhiteSpace(dog.Name))
            {
                throw new ValidationException("Dog name is null or empty", "Name");
            }
            if (string.IsNullOrWhiteSpace(dog.Breed))
            {
                throw new ValidationException("Dog breed is null or empty", "Breed");
            }
            if (dog.User == null || dog.User.Id == 0)
            {
                throw new ValidationException("Dog User is null or invalid", "User");
            }

            var updatingDog = Database.Dogs.Get(dog.Id);
            var updatingDogUser = Database.Users.Get(dog.User.Id);         
            if (updatingDog != null && updatingDogUser != null)
            {
                _mapperFromDTO.Map(dog, updatingDog);
                updatingDog.User = updatingDogUser;
                Database.Dogs.Update(updatingDog);
                Database.Save();
            }
            else
            {
                throw new ValidationException("There is no such information in database", "");
            }
        }

        public IEnumerable<DogDTO> FindDogs(SearchDogDTO searchingDog)
        {
            Func<Dog, bool> findDogsPredicate = delegate(Dog dog)
            {
                if (!string.IsNullOrWhiteSpace(searchingDog.Breed))
                {
                    if (!searchingDog.Breed.ToLower().Trim().Equals(dog.Breed.ToLower().Trim()))
                    {
                        return false;
                    }
                }

                if (!string.IsNullOrWhiteSpace(searchingDog.Username))
                {
                    if (!searchingDog.Username.Equals(dog.User.Name))
                    {
                        return false;
                    }
                }

                if (!string.IsNullOrWhiteSpace(searchingDog.Name))
                {
                    if (!searchingDog.Name.Equals(dog.Name))
                    {
                        return false;
                    }
                }

                return true;
            };

            return _mapperToDTO.Map<IEnumerable<DogDTO>>(Database.Dogs.Find(findDogsPredicate));
        }
    }
}
