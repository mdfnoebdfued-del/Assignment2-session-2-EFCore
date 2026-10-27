using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fluentApi.Models
{
    public class Organizer
    {
        public int id { get; set; }
        [MaxLength(100)]
        [Required]
        public string name { get; set; }
        [MaxLength(100)]
        public String? copmanyname { get; set; }
        public bool isverfied { get; set; }

        public OrganizerProfile profile { get; set; }

        public List<Event> events { get; set; }

    }
}
