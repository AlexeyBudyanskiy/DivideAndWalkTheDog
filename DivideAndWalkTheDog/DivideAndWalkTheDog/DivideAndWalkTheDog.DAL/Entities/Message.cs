using System;

namespace DivideAndWalkTheDog.DAL.Entities
{
    public class Message
    {
        public int Id { get; set; }      
        public string Text { get; set; }
        public DateTime DateTime { get; set; }
        public virtual UserInfo Sender { get; set; }
        public virtual UserInfo Reciever { get; set; }
    }
}
