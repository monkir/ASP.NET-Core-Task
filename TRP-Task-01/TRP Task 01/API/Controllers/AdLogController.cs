using BLL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdLogController : ControllerBase
    {
        [HttpGet]
        public ActionResult All()
        {
            try
            {
                var AdLogList = AdLogService.All();
                return Ok(AdLogList);
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
                var AdLogObj = AdLogService.Get(Id);
                return Ok(AdLogObj);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("ListOfAdLogStatus")]
        public ActionResult GetListOfAdLogStatus()
        {
            try
            {
                var ListOfAdLogStatus = AdLogService.GetListOfAdLogStatus();
                return Ok(ListOfAdLogStatus);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
