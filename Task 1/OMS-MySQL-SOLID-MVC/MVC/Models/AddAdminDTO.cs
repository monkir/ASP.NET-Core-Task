using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class AddAdminDTO
    {

        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
