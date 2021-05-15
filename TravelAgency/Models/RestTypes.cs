using System;
using System.Collections.Generic;
using System.Text;

namespace TravelAgency.Models
{
    class RestTypes : Model
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Restrictions { get; set; }
    }
}
