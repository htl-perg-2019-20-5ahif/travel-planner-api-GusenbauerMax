using System;
using System.Collections.Generic;
using System.Text;

namespace TravelPlannerLibrary.Modles
{

    public class Schedule
    {
        public string City { get; set; }

        public DepTime[] ToLinz { get; set; }

        public DepTime[] FromLinz { get; set; }
    }

    public class DepTime
    {
        public string Leave { get; set; }

        public string Arrive { get; set; }
    }
}
