using System;
using System.Collections.Generic;
using System.Globalization;

namespace DivideAndWalkTheDog.DAL.Entities
{
    public class TimePeriod
    {
        public int Id { get; set; }
        public int Day { get; set; }
        public double DayTimeStart { get; set; }
        public double DayTimeFinish { get; set; }
    }
}
