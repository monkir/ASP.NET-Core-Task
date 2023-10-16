using BLL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViewLogController : ControllerBase
    {
        [HttpGet]
        public ActionResult All()
        {
            try
            {
                var ViewLogList = ViewLogService.All();
                return Ok(ViewLogList);
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
                var ViewLogObj = ViewLogService.Get(Id);
                return Ok(ViewLogObj);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("ListOfViewLogStatus")]
        public ActionResult GetListOfViewLogStatus()
        {
            try
            {
                var ListOfViewLogStatus = ViewLogService.GetListOfViewLogStatus();
                return Ok(ListOfViewLogStatus);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
