using System;
using System.Collections.Generic;
using System.Text;

namespace TicketingSystems
{
    public class Way
    {
        public string FromWhere { get; set; }
        public string WhereTo { get; set; }
        public DateTime DispatchTimeAndDate { get; set; }
        public DateTime ArrivalTimeAndDate { get; set; }
    }
}
