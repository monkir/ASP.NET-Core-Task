using API.DTO;
using API.EF;
using API.EF.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        public List<AdminDTO> get()
        {
            return convert(_context.Admins.ToList());
        }
        /*[HttpGet]
        [Route("{id}")]
        public AdminDTO get(int id)
        {
            return convert(_context.Admins.Find(id));
        }*/
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
        Admin convert(AdminDTO obj)
        {
            Admin convObj = new Admin()
            {
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
