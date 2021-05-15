using System;
using System.Collections.Generic;
using System.Text;

namespace TravelAgency.Models
{
    class Vouchers : Model
    {
       // public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Duration { get; set; }
        public int HotelId { get; set; }
        public int RestTypeId { get; set; }
        public int AdditService1Id { get; set; }
        public int AdditService2Id { get; set; }
        public int AdditService3Id { get; set; }
        public int ClientId { get; set; }
        public int StuffId { get; set; }
        public string BookingStatus { get; set; }
        public string PaymentStatus { get; set; }

        //AdditServiceName
        public string AdditServiceName1 { get; set; }  
        public string AdditServiceName2 { get; set; } 
        public string AdditServiceName3 { get; set; }

        //Stuff
        public string StuffName { get; set; }
        public string StuffSurname { get; set; }
        public string StuffPatronymic { get; set; }

        //Client
        public string ClientName { get; set; }
        public string ClientSurname { get; set; }
        public string ClientPatronymic { get; set; }


        //Hotel
        public string HotelName { get; set; }

        //RestType
        public string RestTypeName { get; set; }
    }
}
