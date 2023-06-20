using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_1
{
    public class Order : Clients
    {
        public List<AirConditioner> AirConditioner { get; set; } = new List<AirConditioner>();
        public string Status { get; set; }
        public string DateAndYear { get; set; }

    }
}
