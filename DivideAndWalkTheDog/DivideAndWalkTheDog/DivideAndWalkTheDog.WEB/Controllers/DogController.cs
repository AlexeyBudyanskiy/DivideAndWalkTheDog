using System.Collections.Generic;
using System.Web.Http;
using AutoMapper;
using DivideAndWalkTheDog.BLL.DTO;
using DivideAndWalkTheDog.BLL.Interfaces;
using DivideAndWalkTheDog.WEB.ViewModels;

namespace DivideAndWalkTheDog.WEB.Controllers
{
    public class DogController : ApiController
    {
        private readonly IDogService _dogService;

        private readonly IMapper _mapperToDTO =
      new MapperConfiguration(cfg =>
      {
          cfg.CreateMap<UserViewModel, UserDTO>();
          cfg.CreateMap<DogViewModel, DogDTO>();
      }).CreateMapper();
        private readonly IMapper _mapperFromDTO =
            new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UserDTO, UserViewModel>();
                cfg.CreateMap<DogDTO, DogViewModel>();
            }).CreateMapper();


        public DogController(IDogService dogService)
        {
            _dogService = dogService;
        }

        [HttpGet]
        [Route("dogs")]
        public IHttpActionResult GetAll()
        {
            return Json(_mapperFromDTO.Map<IEnumerable<DogViewModel>>(_dogService.GetAllDogs()));
        }

        [HttpGet]
        [Route("dogs/{id}")]       
        public IHttpActionResult Get(int id)
        {
            return Json(_mapperFromDTO.Map<DogViewModel>(_dogService.GetDog(id)));
        }
    }
}
