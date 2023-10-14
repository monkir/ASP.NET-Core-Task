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
        [Route("GetDate")]
        public ActionResult GetDate()
        {
            try
            {
                var AdMinDate = AdLogService.GetMinDate();
                var AdMaxDate = AdLogService.GetMaxDate();
                return Ok(new { AdMinDate, AdMaxDate });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
