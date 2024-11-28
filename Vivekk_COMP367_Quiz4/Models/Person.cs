using System.ComponentModel.DataAnnotations;

namespace Vivekk_COMP367_Quiz4.Models
{
    public class Person
    {
        public int Id { get; set; } // Primary key

        [Required]
        [StringLength(100)]
        public string Name { get; set; }
    }
}
