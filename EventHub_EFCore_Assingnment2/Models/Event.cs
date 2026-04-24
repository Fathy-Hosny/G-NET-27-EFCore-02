using System;
using System.Collections.Generic;
using System.Text;

namespace EventHub_EFCore_Assingnment2.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int MaxAttendees { get; set; }
        public int? ParentEventId { get; set; }
        public Event ParentEvent { get; set; }
        public int OrganizerId { get; set; }
        public Organizer Organizer { get; set; }
    }
}
