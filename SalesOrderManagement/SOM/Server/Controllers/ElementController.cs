using Microsoft.AspNetCore.Mvc;

namespace SOM.Server.Controllers
{
    public class ElementController : BaseController
    {
        [HttpGet]
        [Route("GetAll")]
        public async Task<ActionResult> GetAll()
        {
            return Ok();
        }
    }
}
