using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ECommerce.Models
{
    public class Department
    {
        [Key]
        public int DeparmentId { get; set; }

        [Required (ErrorMessage ="The field {0} is requiered")]
        [MaxLength(50, ErrorMessage ="The field {0} must be max {1} characters lenght")]
        [Display(Name ="Department")]
        public string Name { get; set; }


        public virtual ICollection<City> Cities { get; set; }


    }
}