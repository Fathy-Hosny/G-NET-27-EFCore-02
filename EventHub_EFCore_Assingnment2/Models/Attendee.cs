using System;
using System.Collections.Generic;
using System.Text;

namespace EventHub_EFCore_Assingnment2.Models
{
    public class Attendee
    {
        public int AttendeeId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public Address HomeAddress { get; set; }
        public Badge Badge { get; set; }
    }
}
