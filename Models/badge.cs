using fluentApi.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fluentApi.Models
{
    public class badge
    {
        public int Id { get; set; }
        public DateTime IssuedDate { get; set; }
        public Badgelevel Level { get; set; }
        public int AttendeeId { get; set; }
        public Attendee Attendee{ get; set; }
    }
}
