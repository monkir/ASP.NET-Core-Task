using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class EditAdminDTO:AddAdminDTO
    {
        [Required]
        public int Id { get; set; }
    }
}
