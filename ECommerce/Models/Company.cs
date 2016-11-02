using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ECommerce.Models
{
    public class Company
    {


        [Key]
        public int CompanyId { get; set; }


        [Required(ErrorMessage = "The field {0} is requiered")]
        [MaxLength(50, ErrorMessage = "The field {0} must be max {1} characters lenght")]
        [Display(Name = "Company")]
        [Index("Company_Name_Index", IsUnique = true)]
        public string Name { get; set; }


        [Required(ErrorMessage = "The field {0} is requiered")]
        [MaxLength(20, ErrorMessage = "The field {0} must be max {1} characters lenght")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }


        [Required(ErrorMessage = "The field {0} is requiered")]
        [MaxLength(100, ErrorMessage = "The field {0} must be max {1} characters lenght")]
        public string Address { get; set; }

        
        [DataType(DataType.ImageUrl )]
        public string Logo { get; set; }



        [Required(ErrorMessage = "The field {0} is requiered")]
        [Range(1, Double.MaxValue, ErrorMessage = "You must select a {0}")]
        public int DepartmentId { get; set; }

        

        [Required(ErrorMessage = "The field {0} is requiered")]
        [Range(1, Double.MaxValue, ErrorMessage = "You must select a {0}")]
        public int CityId { get; set; }


        [NotMapped]
        public HttpPostedFileBase LogoFile { get; set; }




        public virtual Department Department { get; set; }
        public virtual City City { get; set; }

        public virtual ICollection<User> Users { get; set; }


        public virtual ICollection<Category> Categories { get; set; }


        // public virtual ICollection<City> Cities { get; set; }



    }
}