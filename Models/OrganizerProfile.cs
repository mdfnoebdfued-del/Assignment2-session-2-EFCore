using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fluentApi.Models
{
    public class OrganizerProfile
    {
        public int id { get; set; }
        public string Biography { get; set; }
        public string? WebsiteUrl { get; set; }
        public string? LogoUrl { get; set; }
        public int OrganizerId { get; set; }
        public Organizer organizer { get; set; }
    }
}
