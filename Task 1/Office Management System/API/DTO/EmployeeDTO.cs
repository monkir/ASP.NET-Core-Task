using API.EF.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.DTO
{
    public class EmployeeDTO
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public int AdminID { get; set; }
    }
}
