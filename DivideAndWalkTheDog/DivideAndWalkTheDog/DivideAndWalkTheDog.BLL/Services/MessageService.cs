using System;
using System.Collections.Generic;
using AutoMapper;
using DivideAndWalkTheDog.BLL.DTO;
using DivideAndWalkTheDog.BLL.Infrastructure;
using DivideAndWalkTheDog.BLL.Interfaces;
using DivideAndWalkTheDog.DAL.Entities;
using DivideAndWalkTheDog.DAL.Interfaces;
using static System.String;

namespace DivideAndWalkTheDog.BLL.Services
{
    public class MessageService: IMessageService
    {
        private IUnitOfWork Database { get; }

        private readonly IMapper _mapperToDTO =
            new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UserInfo, UserDTO>();
                cfg.CreateMap<Message, MessageDTO>();
            }).CreateMapper();
        private readonly IMapper _mapperFromDTO =
            new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UserDTO, UserInfo>();
                cfg.CreateMap<MessageDTO, Message>();
            }).CreateMapper();

        public MessageService(IUnitOfWork uow)
        {
            Database = uow;
        }

        public void CreateMessage(MessageDTO messageDTO)
        {
            if (messageDTO == null)
            {
                throw new ValidationException("Invalid message", "Message");
            }
            if (messageDTO.Sender == null || messageDTO.Sender.Id == 0)
            {
                throw new ValidationException("Invalid sender", "Sender");
            }
            if (messageDTO.Reciever == null || messageDTO.Reciever.Id == 0)
            {
                throw new ValidationException("Invalid Reciever", "Reciever");
            }
            if (IsNullOrWhiteSpace(messageDTO.Text))
            {
                throw new ValidationException("Message text is null, empty or consist only of whitespaces", "Text");
            }

            if (messageDTO.DateTime == null || messageDTO.DateTime < DateTime.Parse("01/01/2010") || messageDTO.DateTime > DateTime.Now)
            {
                throw new ValidationException("Invalid DateTime", "DateTime");
            }

            var message = _mapperFromDTO.Map<Message>(messageDTO);
            var sender = Database.Users.Get(message.Sender.Id);
            if (sender == null)
            {
                throw new ValidationException("Invalid Sender", "Sender");
            }
            var reciever = Database.Users.Get(message.Reciever.Id);
            if (reciever == null)
            {
                throw new ValidationException("Invalid reciever", "Reciever");
            }
            message.Reciever = reciever;
            message.Sender = sender;
            Database.Messages.Create(message);
            Database.Save();
        }

        public void DeleteMessae(int messageId)
        {
            if (messageId == 0)
            {
                throw new ValidationException("Invalid message Id", "Id");
            }

            Database.Messages.Delete(messageId);
            Database.Save();
        }

        public IEnumerable<MessageDTO> GetUserMessages(int userId)
        {
            if(userId == 0)
            {
                throw new ValidationException("User id is null or empty", "UserId");
            }         

            return _mapperToDTO.Map<IEnumerable<MessageDTO>>(
                Database.Messages.Find(
                    m => m.Sender.Id==userId || m.Reciever.Id == userId));
        }

        public IEnumerable<MessageDTO> GetConversation(int userId1, int userId2)
        {
            if (userId1 == 0)
            {
                throw new ValidationException("User id is null or empty", "UserId");
            }
            if (userId2 == 0)
            {
                throw new ValidationException("User id is null or empty", "UserId");
            }

            return _mapperToDTO.Map<IEnumerable<MessageDTO>>(
                Database.Messages.Find(
                    m => (m.Sender.Id == userId1 && m.Reciever.Id == userId2) 
                    || (m.Sender.Id == userId2 && m.Reciever.Id == userId1)));
        }
    }
}
