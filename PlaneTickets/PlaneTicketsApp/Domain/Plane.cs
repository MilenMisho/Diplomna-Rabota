using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TechnoWorld.Models.Brand;

namespace PlaneTicketsApp.Domain
{
    public class Plane
    {
        public Plane()
        {
            Brands = new List<BrandChoiceVM>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string PlaneNumber { get; set; }
        public int BrandId { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual List<BrandChoiceVM> Brands { get; set; }
        public string Picture { get; set; }
        public string HandLuggage { get; set; }
        public string BarOnBoard { get; set; }
        public int SeatsTypeBed { get; set; }
        public int PassangerSeats { get; set; }
        public virtual IEnumerable<Flight> Flights { get; set; }





        //public virtual IEnumerable<BusCourse> BusCourses { get; set; }

    }
}
