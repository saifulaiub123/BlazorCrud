using Microsoft.AspNetCore.Mvc;
using SOM.Bll.IService;
using SOM.Core.Dto;
using SOM.Core.Model;

namespace SOM.Server.Controllers
{
    public class ElementController : BaseController
    {
        private readonly IElementService _elementService;
        public ElementController(IElementService elementService)
        {
            _elementService = elementService;
        }
        [HttpGet]
        [Route("GetAll")]
        public async Task<ActionResult> GetAll()
        {
            var result = await _elementService.GetAll();
            return Ok(result);
        }
        [Route("GetById")]
        public async Task<ActionResult> GetById([FromQuery]int id)
        {
            var result = await _elementService.GetById(id);
            return Ok(result);
        }

        [Route("GetByWindowId")]
        public async Task<ActionResult> GetByWindowId([FromQuery] int id)
        {
            var result = await _elementService.GetByWindowId(id);
            return Ok(result);
        }

        [HttpPost]
        [Route("Add")]
        public async Task<ActionResult> Add([FromBody] ElementModel element)
        {
            await _elementService.Add(element);
            return Ok();
        }

        [HttpPut]
        [Route("Update")]
        public async Task<ActionResult> Update([FromBody] ElementModel element)
        {
            await _elementService.Update(element);
            return Ok();
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<ActionResult> Delete([FromQuery] int id)
        {
            await _elementService.Delete(id);
            return Ok();
        }
    }
}
