using BLL.DTO.BaseDTO;
using BLL.DTO;
using BLL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public ActionResult All()
        {
            try
            {
                return Ok(EmployeeService.All());
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
                var Obj = EmployeeService.Get(Id);
                if (Obj == null)
                {
                    NotFound(new { Message = "Employee is not found" });
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
                if (EmployeeService.Delete(Id) == false)
                {
                    NotFound(new { Message = "Employee is not found" });
                }
                return Ok(new { Message = "Employee is deleted" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Add([FromBody] EmployeeBaseDTO Obj)
        {
            try
            {
                if (EmployeeService.Add(Obj) == false)
                {
                    NotFound(new { Message = "Employee is not added" });
                }
                return Ok(new { Message = "Employee is added successfully" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public ActionResult Update([FromBody] EmployeeBaseDTO Obj)
        {
            try
            {
                if (EmployeeService.Update(Obj) == false)
                {
                    NotFound(new { Message = "Employee is not updated" });
                }
                return Ok(new { Message = "Employee is updated successfully" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
