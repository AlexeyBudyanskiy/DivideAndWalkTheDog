using System;

namespace DivideAndWalkTheDog.BLL.DTO
{
    public class MessageDTO
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime DateTime { get; set; }
        public UserDTO Sender { get; set; }
        public UserDTO Reciever { get; set; }
    }
}
