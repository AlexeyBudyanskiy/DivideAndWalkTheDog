using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Results;
using AutoMapper;
using DivideAndWalkTheDog.BLL.DTO;
using DivideAndWalkTheDog.BLL.Infrastructure;
using DivideAndWalkTheDog.BLL.Interfaces;
using DivideAndWalkTheDog.WEB.ViewModels;
using Microsoft.AspNet.Identity;

namespace DivideAndWalkTheDog.WEB.Controllers
{
    public class UserController : ApiController
    {
        private readonly IUserService _userService;

        private readonly IMapper _mapperToDTO =
      new MapperConfiguration(cfg =>
      {
          cfg.CreateMap<UserViewModel, UserDTO>();
          cfg.CreateMap<DogViewModel, DogDTO>();
          cfg.CreateMap<TimePeriodDTO, TimePeriodDTO>();
          cfg.CreateMap<RequestViewModel, RequestDTO>();
      }).CreateMapper();

        private readonly IMapper _mapperFromDTO =
            new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UserDTO, UserViewModel>();
                cfg.CreateMap<DogDTO, DogViewModel>();
                cfg.CreateMap<TimePeriodDTO, TimePeriodDTO>();
                cfg.CreateMap<RequestDTO, RequestViewModel>();
            }).CreateMapper();


        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Route("users")]
        public IHttpActionResult GetAll()
        {
            return Json(_mapperFromDTO.Map<IEnumerable<UserViewModel>>(_userService.GetAllUsers()));
        }

        [HttpGet]
        [Route("user")]
        public IHttpActionResult Get()
        {
            try
            {
                var userDto = _userService.GetUserByApplicationId(User.Identity.GetUserId());
                var user = _mapperFromDTO.Map<UserViewModel>(userDto);
                return Json(user);
            }
            catch (ValidationException)
            {
                return new BadRequestErrorMessageResult("Invalid Id", this);
            }
        }

        [HttpGet]
        [Route("users/{id}")]
        public IHttpActionResult Get(int id)
        {
            try
            {
                return Json(_mapperFromDTO.Map<UserViewModel>(_userService.GetUser(id)));
            }
            catch (ValidationException)
            {
                return new BadRequestErrorMessageResult("Invalid Id", this);
            }
        }

        [HttpPost]
        [Route("users/create")]
        public IHttpActionResult Create(UserViewModel user)
        {
            try
            {
                user.ApplicationUserId = User.Identity.GetUserId();
               _userService.CreateUser(_mapperToDTO.Map<UserDTO>(user));
                return new OkResult(this);
            }
            catch (ValidationException)
            {
                return new BadRequestErrorMessageResult("Invalid request", this);
            }
        }

        [HttpPost]
        [Route("users/edit")]
        public IHttpActionResult Edit(UserViewModel user)
        {
            try
            {
                user.ApplicationUserId = User.Identity.GetUserId();
                _userService.EditUser(_mapperToDTO.Map<UserDTO>(user));
                return new OkResult(this);
            }
            catch (ValidationException)
            {
                return new BadRequestErrorMessageResult("Invalid request", this);
            }
        }
    }
}
