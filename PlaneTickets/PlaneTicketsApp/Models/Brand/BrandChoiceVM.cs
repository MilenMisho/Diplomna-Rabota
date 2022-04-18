using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechnoWorld.Models.Brand
{
    public class BrandChoiceVM
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Brand")]
        public string BrandName { get; set; }
       
    }
}
