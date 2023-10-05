using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class AddEmployeeDTO
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int? Salary { get; set; }
        //FK
        [Required]
        public int? AdminId { get; set; }
    }
}
