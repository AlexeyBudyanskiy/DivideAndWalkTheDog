using System;
using System.Collections.Generic;

namespace DivideAndWalkTheDog.DAL.Entities
{
    public class UserInfo
    {
        public int Id { get; set; }
        public string ApplicationUserId { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public DateTime Birthday { get; set; }
        public string AdditionalInfo { get; set; }
        public string Phone { get; set; }
        public bool IsPhoneVisible { get; set; }
        public List<Request> Requests { get; set; }
    }
}
