using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SOM.Bll.IService;
using SOM.Core.Model;

namespace SOM.Server.Controllers
{
    public class OrderController : BaseController
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        [HttpGet]
        [Route("GetAll")]
        public async Task<ActionResult> GetAll()
        {
            var result = await _orderService.GetAll();
            return Ok(result);
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<ActionResult> GetById(int id)
        {
            var result = await _orderService.GetById(id);
            return Ok(result);
        }

        [HttpPost]
        [Route("Add")]
        public async Task<ActionResult> Add([FromBody] OrderModel order)
        {
            await _orderService.Add(order);
            return Ok();
        }

        [HttpPatch]
        [Route("Update")]
        public async Task<ActionResult> Update([FromBody] OrderModel order)
        {
            await _orderService.Update(order);
            return Ok();
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<ActionResult> Delete([FromQuery] int id)
        {
            await _orderService.Delete(id);
            return Ok();
        }
    }
}
