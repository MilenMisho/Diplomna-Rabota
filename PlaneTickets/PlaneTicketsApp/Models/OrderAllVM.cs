using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PlaneTicketsApp.Models
{
    public class OrderAllVM
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string DateOfReservation { get; set; }
        
        public int FlightId { get; set; }
        [Display(Name = "Flight")]
        public int FlightNumber { get; set; }

        public string Plane { get; set; }
        public string Picture { get; set; }

        public string UserId { get; set; }
        [Display(Name = "User")]
        public string User { get; set; }
        [Display(Name = "CountTickets")]
        public int CountTickets { get; set; }

        [Display(Name = "Price")]

        public decimal PricePerTicket { get; set; }
        public int Discount { get; set; }

        [Display(Name = "TotalPrice")]
        public decimal TotalPrice { get; set; }


        
    }
}
