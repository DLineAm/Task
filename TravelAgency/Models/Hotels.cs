using System;
using System.Collections.Generic;
using System.Text;

namespace TravelAgency.Models
{
    public class Hotels : Model
    {
       // public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string TheContactPerson { get; set; }
    }
}
