using System.Collections.Generic;

namespace DivideAndWalkTheDog.BLL.DTO
{
    public class SearchRequestDTO
    {
        public string Text { get; set; }
        public List<TimePeriodDTO> TimePeriodsWhenUserCanWalk { get; set; }
        public List<TimePeriodDTO> TimePeriodsWhenUserNeedWalk { get; set; }
    }
}
