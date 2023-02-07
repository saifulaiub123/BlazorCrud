using Microsoft.AspNetCore.Mvc;
using SOM.Bll.IService;

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
    }
}
