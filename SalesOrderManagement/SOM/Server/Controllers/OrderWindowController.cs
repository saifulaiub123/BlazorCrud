using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SOM.Bll.IService;
using SOM.Core.Model;

namespace SOM.Server.Controllers
{
    public class OrderWindowController : BaseController
    {
        private readonly IOrderWindowService _orderWindowService;
        public OrderWindowController(IOrderWindowService orderWindowService)
        {
            _orderWindowService = orderWindowService;
        }


        [HttpGet]
        [Route("GetByOrderId")]
        public async Task<ActionResult> GetByOrderId([FromQuery] int id)
        {
            var result = await _orderWindowService.GetByOrderId(id);
            return Ok(result);
        }
        [HttpPost]
        [Route("AddBulk")]
        public async Task<ActionResult> AddBulk([FromBody] List<OrderWindowModel> orderWindowModel)
        {
            var result = await _orderWindowService.AddBulk(orderWindowModel);
            return Ok(result);
        }
        [HttpDelete]
        [Route("Delete")]
        public async Task<ActionResult> Delete([FromQuery] int id)
        {
            await _orderWindowService.Delete(id);
            return Ok();
        }
    }
}
