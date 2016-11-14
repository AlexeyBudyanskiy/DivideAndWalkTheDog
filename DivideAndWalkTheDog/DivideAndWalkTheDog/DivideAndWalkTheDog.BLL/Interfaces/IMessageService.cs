using System.Collections.Generic;
using DivideAndWalkTheDog.BLL.DTO;

namespace DivideAndWalkTheDog.BLL.Interfaces
{
    public interface IMessageService
    {
        void CreateMessage(MessageDTO messageDTO);
        void DeleteMessae(int messageId);
        IEnumerable<MessageDTO> GetUserMessages(int userId);
        IEnumerable<MessageDTO> GetConversation(int userId1, int userId2);
    }
}
