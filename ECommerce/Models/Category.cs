using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ECommerce.Models
{
    public class Category
    {


        [Key]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "The field {0} is requiered")]
        [MaxLength(50, ErrorMessage = "The field {0} must be max {1} characters lenght")]
        [Display(Name = "Category")]
        [Index("Category_CompanyId_Description_Index", 2, IsUnique = true)]
        public string Description { get; set; }

        
        [Required(ErrorMessage = "The field {0} is requiered")]
        [Range(1, Double.MaxValue, ErrorMessage = "You must select a department ID")]
        [Index("Category_CompanyId_Description_Index", 1, IsUnique = true)]
        [Display(Name = "Company")]
        public int CompanyId { get; set; }


        public virtual Company Company { get; set; }


        //public virtual Department Department { get; set; }

        //public virtual ICollection<Company> Companies { get; set; }

        //public virtual ICollection<User> Users { get; set; }


    }
}