using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO.BaseDTO
{
    public class EmployeeBaseDTO
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        //FK
        public int AdminId { get; set; }
    }
}
