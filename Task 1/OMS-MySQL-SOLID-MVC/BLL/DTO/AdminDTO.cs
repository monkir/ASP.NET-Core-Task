using BLL.DTO.BaseDTO;

namespace BLL.DTO
{
    public class AdminDTO: AdminBaseDTO
    {
        public List<EmployeeBaseDTO> Employees { get; set; } = null;
    }
}
