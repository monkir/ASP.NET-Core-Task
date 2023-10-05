using BLL.DTO.BaseDTO;

namespace BLL.DTO
{
    public class EmployeeDTO:EmployeeBaseDTO
    {
        public AdminBaseDTO Admin { get; set; } = null;
    }
}
