using Microsoft.AspNet.Identity.EntityFramework;

namespace DivideAndWalkTheDog.DAL.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public virtual UserInfo ClientProfile { get; set; }
    }
}
