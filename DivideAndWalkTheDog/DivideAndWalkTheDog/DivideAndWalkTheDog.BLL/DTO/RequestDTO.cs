using System.Collections.Generic;

namespace DivideAndWalkTheDog.BLL.DTO
{
    public class RequestDTO
    {
        public int Id { get; set; }        
        public string Address { get; set; }
        public string Text { get; set; }
        public List<TimePeriodDTO> TimePeriodsWhenUserCanWalk { get; set; }
        public List<TimePeriodDTO> TimePeriodsWhenUserNeedWalk { get; set; }
        public UserDTO User { get; set; }
        public DogDTO Dog { get; set; }
    }
}
