using System.Collections.Generic;
using DivideAndWalkTheDog.BLL.DTO;

namespace DivideAndWalkTheDog.WEB.ViewModels
{
    public class RequestViewModel
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string Text { get; set; }
        public List<TimePeriodDTO> TimePeriodsWhenUserCanWalk { get; set; }
        public List<TimePeriodDTO> TimePeriodsWhenUserNeedWalk { get; set; }
        public UserViewModel User { get; set; }
        public DogViewModel Dog { get; set; }
    }
}