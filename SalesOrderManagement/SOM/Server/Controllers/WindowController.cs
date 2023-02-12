using Microsoft.AspNetCore.Mvc;
using SOM.Bll.IService;
using SOM.Core.Model;

namespace SOM.Server.Controllers
{
    public class WindowController : BaseController
    {
        private readonly IWindowService _windowService;
        public WindowController(IWindowService windowService)
        {
            _windowService = windowService;
        }
        [HttpGet]
        [Route("GetAll")]
        public async Task<ActionResult> GetAll()
        {
            var result = await _windowService.GetAll();
            return Ok(result);
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<ActionResult> GetById(int id)
        {
            var result = await _windowService.GetById(id);
            return Ok(result);
        }
        [HttpGet]
        [Route("GetByOrderId")]
        public async Task<ActionResult> GetByOrderId([FromQuery]int id)
        {
            var result = await _windowService.GetByOrderId(id);
            return Ok(result);
        }
        [HttpGet]
        [Route("GetWindowElementByWindowId")]
        public async Task<ActionResult> GetWindowElementByWindowId(int id)
        {
            var result = await _windowService.GetWindowElementByWindowId(id);
            return Ok(result);
        }

        [HttpPost]
        [Route("Add")]
        public async Task<ActionResult> Add([FromBody] WindowModel window)
        {
            await _windowService.Add(window);
            return Ok();
        }

        [HttpPut]
        [Route("Update")]
        public async Task<ActionResult> Update([FromBody] WindowModel window)
        {
            await _windowService.Update(window);
            return Ok();
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<ActionResult> Delete([FromQuery] int id)
        {
            await _windowService.Delete(id);
            return Ok();
        }
    }
}
