using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DivideAndWalkTheDog.WEB.ViewModels
{
    public class MessageViewModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime DateTime { get; set; }
        public UserViewModel Sender { get; set; }
        public UserViewModel Reciever { get; set; }
    }
}