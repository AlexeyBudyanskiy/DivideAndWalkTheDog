using System.Collections.Generic;

namespace DivideAndWalkTheDog.DAL.Entities
{
    public class Request
    {
        public int Id { get; set; }       
        public string Address { get; set; }
        public string Text { get; set; }
        public virtual UserInfo User { get; set; }
        public virtual Dog Dog { get; set; }
        public virtual List<TimePeriod> TimePeriodsWhenUserCanWalk { get; set; }
        public virtual List<TimePeriod> TimePeriodsWhenUserNeedWalk { get; set; }
    }
}
