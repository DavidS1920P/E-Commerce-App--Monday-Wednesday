using System.ComponentModel.DataAnnotations;

namespace E_Commerce_App__Monday_Wednesday.DAL.Entities
{
    public class Entity
    {

        [Key]
        [Required]
        public Guid Id { get; set; }
        [Display(Name = "Creation Date")]

        public DateTime CreatedDate { get; set; }
        [Display(Name = "Creation Date")]
        public DateTime ModifiedDate { get; set; }
    }
}
