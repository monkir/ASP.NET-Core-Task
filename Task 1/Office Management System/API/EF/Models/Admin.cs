using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace API.EF.Models
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
