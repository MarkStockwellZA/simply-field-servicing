using System;

namespace SimplyFieldServicing.Models
{
    public class Booking
    {
        public int Id { get; set; }

        public DateTime BookingDate { get; set; }

        public string Contact { get; set; }

        public string BookingAddress { get; set; }

        public string BookingDescription { get; set; }
    }
}
