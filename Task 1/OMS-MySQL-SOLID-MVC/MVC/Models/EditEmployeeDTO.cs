using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class EditEmployeeDTO: AddEmployeeDTO
    {
        [Required]
        public int Id { get; set; }
    }
}
