﻿using API.DTO;
using API.EF;
using API.EF.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class adminController : ControllerBase
    {
        private readonly OMSContext _context;

        public adminController(OMSContext context)
        {
            _context = context;
        }
        [HttpGet]
        public List<Admin> get()
        {
            return (_context.Admins.ToList());
        }
        [HttpGet]
        [Route("{id}")]
        public AdminDTO get(int id)
        {
            return convert(_context.Admins.Find(id));
        }
        [HttpGet]
        [Route("{id}/Employees")]
        public List<EmployeeDTO> getEmplyee(int id)
        {
            var Obj = _context.Admins.Include(a => a.Employees).Where(a => a.Id == id).SingleOrDefault();
            var EmpList = Obj.Employees.ToList();
            return convert(EmpList);
        }
        [HttpDelete]
        [Route("{id}")]
        public ActionResult<string> delete(int id)
        {
            
            try
            {
                var ExObj = _context.Admins.Find(id);
                _context.Admins.Remove(ExObj);
                _context.SaveChanges();
                return Ok("The admin is deleted successfully");
            }
            catch
            {
                return NotFound("The admin is not deleted.");
            }
        }
        [HttpPost]
        public ActionResult<string> post([FromBody] AdminDTO obj)
        {
            try
            {
                _context.Admins.Add(convert(obj));
                _context.SaveChanges();
                return Ok("New admin is added successfully");
            }
            catch
            {
                return NotFound("New admin is not added.");
            }
            
        }
        [HttpPut]
        public ActionResult<string> update([FromBody] AdminDTO obj)
        {
            try
            {
                _context.Admins.Update(convert(obj));
                _context.SaveChanges();
                return Ok("The admin is updated successfully");
            }
            catch
            {
                return NotFound("The admin is not updated.");
            }
            
        }


        //Admin
        //Conversion  
        Admin convert(AdminDTO obj)
        {
            Admin convObj = new Admin()
            {
                Id = obj.Id,
                UserName = obj.UserName,
                Password = obj.Password,
                Name = obj.Name
            };
            return convObj;
        }
        List<Admin> convert(List<AdminDTO> objList)
        {
            var convList = new List<Admin>();
            foreach (var item in objList)
            {
                var convObj = convert(item);
                convList.Add(convObj);
            }
            return convList;
        }
        AdminDTO convert(Admin obj)
        {
            var convObj = new AdminDTO()
            {
                Id = obj.Id,
                UserName = obj.UserName,
                Password = obj.Password,
                Name = obj.Name
            };
            return convObj;
        }
        List<AdminDTO> convert(List<Admin> objList)
        {
            var convList = new List<AdminDTO>();
            foreach (var item in objList)
            {
                var convObj = convert(item);
                convList.Add(convObj);
            }
            return convList;
        }

    //Employe
    //Conversion  

        Employee convert(EmployeeDTO obj)
        {
            Employee convObj = new Employee()
            {
                Id = obj.Id,
                UserName = obj.UserName,
                Password = obj.Password,
                Name = obj.Name,
                Salary = obj.Salary,
                AdminId = obj.AdminId,
            };
            return convObj;
        }
        List<Employee> convert(List<EmployeeDTO> objList)
        {
            var convList = new List<Employee>();
            foreach (var item in objList)
            {
                var convObj = convert(item);
                convList.Add(convObj);
            }
            return convList;
        }
        EmployeeDTO convert(Employee obj)
        {
            var convObj = new EmployeeDTO()
            {
                Id = obj.Id,
                UserName = obj.UserName,
                Password = obj.Password,
                Name = obj.Name,
                Salary = obj.Salary,
                AdminId = obj.AdminId,
            };
            return convObj;
        }
        List<EmployeeDTO> convert(List<Employee> objList)
        {
            var convList = new List<EmployeeDTO>();
            foreach (var item in objList)
            {
                var convObj = convert(item);
                convList.Add(convObj);
            }
            return convList;
        }
    }
}
