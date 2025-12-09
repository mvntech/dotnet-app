using System.ComponentModel.DataAnnotations;

namespace dotnet_app.Models
{
    public class Faculty
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Department { get; set; }
        [Required]
        public double Salary { get; set; }
        [Required]
        public string Image { get; set; }
    }
}
