using System.ComponentModel.DataAnnotations;
//in order to access data notation

namespace AnimalShelter.Models
{
    public class Animal
    {
        public int AnimalId { get; set; }
        [Required] //data anotation must be entered
        [StringLength(20)] //max length
        public string Name { get; set; }
        [Required]
        public string Species { get; set; }
        [Required]
        [Range(0, 200, ErrorMessage = "Age must be between 0 and 200.")]
        public int Age { get; set; }
        [Required]
        public string Gender { get; set; }
    }
}