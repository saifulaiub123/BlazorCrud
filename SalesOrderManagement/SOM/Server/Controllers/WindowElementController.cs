using Microsoft.AspNetCore.Mvc;
using SOM.Bll.IService;
using SOM.Core.Model;

namespace SOM.Server.Controllers
{
    public class WindowElementController : BaseController
    {
        private readonly IWindowElementService _windowElementService;
        public WindowElementController(IWindowElementService windowElementService)
        {
            _windowElementService = windowElementService;
        }
        

        [HttpGet]
        [Route("GetByWindowId")]
        public async Task<ActionResult> GetByWindowId([FromQuery]int windowId)
        {
            var result = await _windowElementService.GetByWindowId(windowId);
            return Ok(result);
        }
        [HttpPost]
        [Route("AddBulk")]
        public async Task<ActionResult> AddBulk([FromBody] List<WindowElementModel> windowElementModel)
        {
            await _windowElementService.AddBulk(windowElementModel);
            return Ok();
        }
        [HttpDelete]
        [Route("Delete")]
        public async Task<ActionResult> Delete([FromQuery] int id)
        {
            await _windowElementService.Delete(id);
            return Ok();
        }
    }
}
