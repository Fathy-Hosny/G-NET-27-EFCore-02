using System;
using System.Collections.Generic;
using System.Text;

namespace EventHub_EFCore_Assingnment2.Models
{
    public class Registration
    {
        public int EventId { get; set; }
        public Event Event { get; set; }
        public int AttendeeId { get; set; }
        public Attendee Attendee { get; set; }
        public string Note { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
