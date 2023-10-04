using BLL.DTO.BaseDTO;
using BLL.DTO;
using DAL.EF.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class EmployeeService
    {

        public static List<EmployeeDTO> All()
        {
            var ObjList = DataAccess.EmployeeRepo().All();
            var mapper = MapperService.GetMapper<Employee, EmployeeDTO, Admin, AdminBaseDTO>();
            return mapper.Map<List<EmployeeDTO>>(ObjList).ToList();
        }
        public static EmployeeDTO Get(int Id)
        {
            var Obj = DataAccess.EmployeeRepo().Get(Id);
            var mapper = MapperService.GetMapper<Employee, EmployeeDTO, Admin, AdminBaseDTO>();
            return mapper.Map<EmployeeDTO>(Obj);
        }
        public static bool Add(EmployeeBaseDTO dto)
        {
            var mapper = MapperService.GetMapper<EmployeeBaseDTO, Employee>();
            var Obj = mapper.Map<Employee>(dto);
            return DataAccess.EmployeeRepo().Add(Obj);
        }
        public static bool Update(EmployeeBaseDTO dto)
        {
            var mapper = MapperService.GetMapper<EmployeeBaseDTO, Employee>();
            var Obj = mapper.Map<Employee>(dto);
            return DataAccess.EmployeeRepo().Update(Obj);
        }
        public static bool Delete(int Id)
        {
            return DataAccess.EmployeeRepo().Delete(Id);
        }
    }
}
