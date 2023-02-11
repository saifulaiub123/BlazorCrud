using Microsoft.AspNetCore.Mvc;
using SOM.Bll.IService;

namespace SOM.Server.Controllers
{
    public class ElementTypeController : BaseController
    {
        private readonly IElementTypeService _elementTypeService;
        public ElementTypeController(IElementTypeService elementTypeService)
        {
            _elementTypeService = elementTypeService;
        }
        [HttpGet]
        [Route("GetAll")]
        public async Task<ActionResult> GetAll()
        {
            var result = await _elementTypeService.GetAll();
            return Ok(result);
        }
    }
}
