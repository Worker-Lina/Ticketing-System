using System;
using System.Collections.Generic;
using System.Text;

namespace TicketingSystems
{
    public class Ticket
    {
        public double Price { get; set; }

        public Bus Bus { get; set; }
        public Way Way { get; set; }
        public Station SaleStation { get; set; }

        public int SeatNumber { get; set; }

        public Cities City { get; set; }

        public string CompanyName { get; set; }
        public string PaymentCode { get; set; }

        public bool PaymentMethod { get; set; }
        

    }
}
