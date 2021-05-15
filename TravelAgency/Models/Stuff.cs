using System;
using System.Collections.Generic;
using System.Text;

namespace TravelAgency.Models
{
    class Stuff : Model
    {
       // public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int PassportCode { get; set; }
    }
}
