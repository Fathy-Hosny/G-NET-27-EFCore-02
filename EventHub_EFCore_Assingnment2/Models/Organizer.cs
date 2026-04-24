using System;
using System.Collections.Generic;
using System.Text;

namespace EventHub_EFCore_Assingnment2.Models
{
    public class Organizer
    {
        public int OrganizerId { get; set; }
        public string Name { get; set; }
        public string? CompanyName { get; set; }
        public bool IsVerified { get; set; }

        public OrganizerProfile Profile { get; set; }
    }
}
