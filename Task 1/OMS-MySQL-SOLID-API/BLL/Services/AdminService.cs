using AutoMapper;
using BLL.DTO;
using BLL.DTO.BaseDTO;
using DAL;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AdminService
    {
        public static List<AdminDTO> All()
        {
            var ObjList = DataAccess.AdminRepo().All();
            var mapper = MapperService.GetMapper<Admin, AdminDTO, Employee, EmployeeBaseDTO>();
            return mapper.Map<List<AdminDTO>>(ObjList).ToList();
        }
        public static AdminDTO Get(int Id)
        {
            var Obj = DataAccess.AdminRepo().Get(Id);
            var mapper = MapperService.GetMapper<Admin, AdminDTO, Employee, EmployeeBaseDTO>();
            return mapper.Map<AdminDTO>(Obj);
        }
        public static bool Add(AdminBaseDTO dto)
        {
            var mapper = MapperService.GetMapper<AdminBaseDTO, Admin>();
            var Obj = mapper.Map<Admin>(dto);
            return DataAccess.AdminRepo().Add(Obj);
        }
        public static bool Update(AdminBaseDTO dto)
        {
            var mapper = MapperService.GetMapper<AdminBaseDTO, Admin>();
            var Obj = mapper.Map<Admin>(dto);
            return DataAccess.AdminRepo().Update(Obj);
        }
        public static bool Delete(int Id)
        {
            return DataAccess.AdminRepo().Delete(Id);
        }
    }
}
