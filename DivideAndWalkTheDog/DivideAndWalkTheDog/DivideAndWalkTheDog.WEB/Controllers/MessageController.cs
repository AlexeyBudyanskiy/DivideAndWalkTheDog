using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Results;
using AutoMapper;
using DivideAndWalkTheDog.BLL.DTO;
using DivideAndWalkTheDog.BLL.Infrastructure;
using DivideAndWalkTheDog.BLL.Interfaces;
using DivideAndWalkTheDog.WEB.ViewModels;

namespace DivideAndWalkTheDog.WEB.Controllers
{
    public class MessageController:ApiController
    {
        private readonly IMessageService _messageService;

        private readonly IMapper _mapperToDTO =
      new MapperConfiguration(cfg =>
      {
          cfg.CreateMap<UserViewModel, UserDTO>();
          cfg.CreateMap<MessageViewModel, MessageDTO>();
      }).CreateMapper();
        private readonly IMapper _mapperFromDTO =
            new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UserDTO, UserViewModel>();
                cfg.CreateMap<MessageDTO, MessageViewModel>();
            }).CreateMapper();


        public MessageController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        [HttpGet]
        [Route("messages/{userId}")]
        public IHttpActionResult GetUserMessages(int userId)
        {
            try
            {
                return Json(_mapperFromDTO.Map<IEnumerable<MessageViewModel>>(_messageService.GetUserMessages(userId)));
            }
            catch (ValidationException)
            {
                return new BadRequestErrorMessageResult("Invalid Id", this);
            }
        }

        [HttpGet]
        [Route("messages/{userId1}/{userId2}")]
        public IHttpActionResult GetUserMessages(int userId1, int userId2)
        {
            try
            {
                return Json(_mapperFromDTO.Map<IEnumerable<MessageViewModel>>(_messageService.GetConversation(userId1,userId2)));
            }
            catch (ValidationException)
            {
                return new BadRequestErrorMessageResult("Invalid Id", this);
            }
        }

        [HttpPost]
        [Route("messages/create")]
        public IHttpActionResult Create(MessageViewModel message)
        {
            try
            {
                _messageService.CreateMessage(_mapperToDTO.Map<MessageDTO>(message));
                return new OkResult(this);
            }
            catch (ValidationException)
            {
                return new BadRequestErrorMessageResult("Invalid request", this);
            }
        }
    }
}