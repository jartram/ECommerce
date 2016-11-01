using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ECommerce.Models
{
    public class City
    {
        
        [Key]
        public int CityId { get; set; }

        [Required(ErrorMessage = "The field {0} is requiered")]
        [MaxLength(50, ErrorMessage = "The field {0} must be max {1} characters lenght")]
        [Display(Name = "City")]
        [Index("City_Name_Index",2, IsUnique = true)]
        public string Name { get; set; }

        [Required(ErrorMessage = "The field {0} is requiered")]
        [Range(1,Double.MaxValue, ErrorMessage ="You must select a department ID")]
        [Index("City_Name_Index",1, IsUnique = true)]
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }

        public virtual ICollection<Company> Companies { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}