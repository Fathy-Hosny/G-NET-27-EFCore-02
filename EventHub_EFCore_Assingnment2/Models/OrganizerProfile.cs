using System;
using System.Collections.Generic;
using System.Text;

namespace EventHub_EFCore_Assingnment2.Models
{
    public class OrganizerProfile
    {
        public int ProfileId { get; set; }
        public string Bio { get; set; }
        public string WebsiteUrl { get; set; }
        public string LogoPath { get; set; }
        public int OrganizerId { get; set; }
        public Organizer Organizer { get; set; }
    }
}
