using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;
using AutoMapper;
using DivideAndWalkTheDog.BLL.DTO;
using DivideAndWalkTheDog.BLL.Infrastructure;
using DivideAndWalkTheDog.BLL.Interfaces;
using DivideAndWalkTheDog.WEB.ViewModels;

namespace DivideAndWalkTheDog.WEB.Controllers
{
    public class RequestController : ApiController
    {
        private readonly IRequestService _requestService;

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


        public RequestController(IRequestService requestService)
        {
            _requestService = requestService;
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("requests")]
        public IHttpActionResult GetAll()
        {
            return Json(_mapperFromDTO.Map<IEnumerable<RequestViewModel>>(_requestService.GetAllRequests().ToList()));
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("requests/{id}")]
        public IHttpActionResult Get(int id)
        {
            try
            {
                return Json(_mapperFromDTO.Map<RequestViewModel>(_requestService.GetRequest(id)));
            }
            catch (ValidationException)
            {
                return new BadRequestErrorMessageResult("Invalid Id", this);
            }
        }

        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("requests/create")]
        public IHttpActionResult Create(RequestViewModel request)
        {
            try
            {
                _requestService.CreateRequest(_mapperToDTO.Map<RequestDTO>(request));
                return new OkResult(this);
            }
            catch (ValidationException)
            {
                return new BadRequestErrorMessageResult("Invalid request", this);
            }
        }

        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("requests/edit")]
        public IHttpActionResult Edite(RequestViewModel request)
        {
            try
            {
                _requestService.EditRequest(_mapperToDTO.Map<RequestDTO>(request));
                return new OkResult(this);
            }
            catch (ValidationException)
            {
                return new BadRequestErrorMessageResult("Invalid request", this);
            }
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("requests/{id}/delete")]
        public IHttpActionResult Delete(int id)
        {
            try
            {
                _requestService.RemoveRequest(id);
                return new OkResult(this);
            }
            catch (ValidationException)
            {
                return new BadRequestErrorMessageResult("Invalid Id", this);
            }
        }
    }
}
