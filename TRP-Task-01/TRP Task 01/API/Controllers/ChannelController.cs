using BLL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChannelController : ControllerBase
    {
        [HttpGet]
        [Route("{Id}")]
        public ActionResult Get(int Id)
        {
            try
            {
                var AdLogObj = ChannelService.Get(Id);
                return Ok(AdLogObj);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
