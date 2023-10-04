using System.ComponentModel.DataAnnotations.Schema;

namespace API.EF.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public int AdminId { get; set; }
        public Admin Admin { get; set; }
    }
}
