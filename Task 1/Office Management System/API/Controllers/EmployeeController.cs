using API.DTO;
using API.EF.Models;
using API.EF;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly OMSContext _context;

        public EmployeeController(OMSContext context)
        {
            _context = context;
        }
        [HttpGet]
        public List<EmployeeDTO> get()
        {
            return convert(_context.Employees.ToList());
        }
        [HttpGet]
        [Route("{id}")]
        public EmployeeDTO get(int id)
        {
            return convert(_context.Employees.Find(id));
        }

        [HttpGet]
        [Route("{id}/Admin")]
        public AdminDTO getAdmin(int id)
        {
            var list = _context.Employees.Include(e => e.Admin);
            var Obj = list.Where(e => e.Id == id).SingleOrDefault();
            var adminObj = Obj.Admin;
            return convert(adminObj);
        }
        [HttpDelete]
        [Route("{id}")]
        public ActionResult<string> delete(int id)
        {

            try
            {
                var ExObj = _context.Employees.Find(id);
                _context.Employees.Remove(ExObj);
                _context.SaveChanges();
                return Ok("The Employee is deleted successfully");
            }
            catch
            {
                return NotFound("The Employee is not deleted.");
            }
        }
        [HttpPost]
        public ActionResult<string> post([FromBody] EmployeeDTO obj)
        {
            try
            {
                _context.Employees.Add(convert(obj));
                _context.SaveChanges();
                return Ok("New Employee is added successfully");
            }
            catch
            {
                return NotFound("New Employee is not added.");
            }

        }
        [HttpPut]
        public ActionResult<string> update([FromBody] EmployeeDTO obj)
        {
            try
            {
                _context.Employees.Update(convert(obj));
                _context.SaveChanges();
                return Ok("The Employee is updated successfully");
            }
            catch
            {
                return NotFound("The Employee is not updated.");
            }

        }
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
    }
}
