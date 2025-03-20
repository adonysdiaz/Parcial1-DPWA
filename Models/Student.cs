using System.ComponentModel.DataAnnotations;

namespace Parcial_PWA.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        public string LastName { get; set; } = string.Empty;

        public int Age { get; set; }

        [Required]
        public string StudentNumber { get; set; } = string.Empty;
    }
}
