using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using DivideAndWalkTheDog.BLL.DTO;
using DivideAndWalkTheDog.BLL.Interfaces;
using DivideAndWalkTheDog.DAL.Entities;
using DivideAndWalkTheDog.DAL.Interfaces;
using DivideAndWalkTheDog.BLL.Infrastructure;

namespace DivideAndWalkTheDog.BLL.Services
{
    public class RequestService: IRequestService
    {
        private IUnitOfWork Database { get; }

        private readonly IMapper _mapperToDTO =
            new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TimePeriod, TimePeriodDTO>();
                cfg.CreateMap<UserInfo, UserDTO>();
                cfg.CreateMap<Dog, DogDTO>();
                cfg.CreateMap<Request, RequestDTO>();
            }).CreateMapper();

        private readonly IMapper _mapperFromDTO =
            new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TimePeriodDTO,TimePeriod>();
                cfg.CreateMap<UserDTO, UserInfo>();
                cfg.CreateMap<DogDTO, Dog>();
                cfg.CreateMap<RequestDTO, Request>();
            }).CreateMapper();

        public RequestService(IUnitOfWork uow)
        {
            Database = uow;
        }

        public RequestDTO GetRequest(int requestId)
        {
            if (requestId == 0)
            {
                throw new ValidationException("Request id equals 0", "requestId");
            }

            return _mapperToDTO.Map<RequestDTO>(Database.Requests.Get(requestId));
        }

        public IEnumerable<RequestDTO> GetAllRequests()
        {
            return _mapperToDTO.Map<IEnumerable<RequestDTO>>(Database.Requests.GetAll().ToList());
        }

        public IEnumerable<RequestDTO> GetNearbyRequests()
        {
            throw new NotImplementedException();
        }

        public void CreateRequest(RequestDTO requestDTO)
        {
            if (string.IsNullOrWhiteSpace(requestDTO.Address))
            {
                throw new ValidationException("Request address is null or empty", "Address");
            }

            if (string.IsNullOrWhiteSpace(requestDTO.Text))
            {
                throw new ValidationException("Request text id is null or empty", "Text");
            }

            if (requestDTO.User == null || requestDTO.User.Id == 0)
            {
                throw new ValidationException("Request User invalid", "User");
            }
            if (requestDTO.Dog == null || requestDTO.Dog.Id == 0)
            {
                throw new ValidationException("Request Dog invalid", "Dog");
            }

            if (requestDTO.TimePeriodsWhenUserCanWalk == null || requestDTO.TimePeriodsWhenUserCanWalk.Count == 0)
            {
                throw new ValidationException("Request TimePeriodsWhenUserCanWalk is invalid", "TimePeriodsWhenUserCanWalk");
            }

            if (requestDTO.TimePeriodsWhenUserNeedWalk == null || requestDTO.TimePeriodsWhenUserNeedWalk.Count == 0)
            {
                throw new ValidationException("Request TimePeriodsWhenUserNeedWalk is invalid", "TimePeriodsWhenUserNeedWalk");
            }

            var request = _mapperFromDTO.Map<Request>(requestDTO);
            var user = Database.Users.Get(request.User.Id);
            if (user == null)
            {
                throw new ValidationException("Invalid User", "User");
            }
            request.User = user;
            request.Dog.User = user;
            Database.Requests.Create(request);
            Database.Save();
        }

        public void EditRequest(RequestDTO request)
        {
            if (string.IsNullOrWhiteSpace(request.Address))
            {
                throw new ValidationException("Request address is null or empty", "Address");
            }

            if (string.IsNullOrWhiteSpace(request.Text))
            {
                throw new ValidationException("Request text id is null or empty", "Text");
            }

            if (request.User == null || request.User.Id == 0)
            {
                throw new ValidationException("Request User invalid", "User");
            }
            if (request.Dog == null || request.Dog.Id == 0)
            {
                throw new ValidationException("Request Dog invalid", "Dog");
            }

            if (request.TimePeriodsWhenUserCanWalk == null || request.TimePeriodsWhenUserCanWalk.Count == 0)
            {
                throw new ValidationException("Request TimePeriodsWhenUserCanWalk is invalid", "TimePeriodsWhenUserCanWalk");
            }

            if (request.TimePeriodsWhenUserNeedWalk == null || request.TimePeriodsWhenUserNeedWalk.Count == 0)
            {
                throw new ValidationException("Request TimePeriodsWhenUserNeedWalk is invalid", "TimePeriodsWhenUserNeedWalk");
            }

            var updatingRequest= Database.Requests.Get(request.Id);
            var updatingRequestDog = Database.Dogs.Get(request.Dog.Id);
            var updatingRequestUser = Database.Users.Get(request.User.Id);
            if (updatingRequest != null && updatingRequestUser != null && updatingRequestDog != null)
            {
                _mapperFromDTO.Map(request, updatingRequest);
                updatingRequest.Dog = updatingRequestDog;
                updatingRequest.User = updatingRequestUser;
                Database.Requests.Update(updatingRequest);
                Database.Save();
            }
            else
            {
                throw new ValidationException("There is no such information in database", "");
            }
        }

        public void RemoveRequest(int id)
        {
            if (id == 0)
            {
                throw new ValidationException("Request id equals 0", "requestId");
            }
            Database.Requests.Delete(id);
            Database.Save();
        }

        public IEnumerable<RequestDTO> FindRequests(SearchRequestDTO request)
        {
            throw new NotImplementedException();
        }
    }
}
