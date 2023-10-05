using BLL.DTO;
using BLL.DTO.BaseDTO;
using BLL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        [HttpGet]
        public ActionResult All()
        {
            try
            {
                return Ok(AdminService.All());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
        [HttpGet]
        [Route("{Id}")]
        public ActionResult Get(int Id)
        {
            try
            {
                var Obj = AdminService.Get(Id);
                if (Obj == null)
                {
                    NotFound(new { Message = "Admin is not found" });
                }
                return Ok(Obj);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
        [HttpDelete]
        [Route("{Id}")]
        public ActionResult Delete(int Id)
        {
            try
            {
                if (AdminService.Delete(Id) == false)
                {
                    NotFound(new { Message = "Admin is not found" });
                }
                return Ok(new { Message = "Admin is deleted" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
        [HttpPost]
        public ActionResult Add([FromBody] AdminBaseDTO Obj)
        {
            try
            {
                if (AdminService.Add(Obj) == false)
                {
                    NotFound(new { Message = "Admin is not added" });
                }
                return Ok(new { Message = "Admin is added successfully" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
        [HttpPut]
        public ActionResult Update([FromBody] AdminBaseDTO Obj)
        {
            try
            {
                if (AdminService.Update(Obj) == false)
                {
                    NotFound(new { Message = "Admin is not updated" });
                }
                return Ok(new { Message = "Admin is updated successfully" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
