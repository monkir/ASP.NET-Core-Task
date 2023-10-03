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

        [ForeignKey(nameof(Admin))]
        public int AdminID { get; set; }
        public virtual Admin Admin { get; set; }
    }
}
