using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Order.Model;
using Order.Service;

namespace Order.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private IOrderService _orderService;
        public OrderController(IOrderService orderService )
        {
           _orderService= orderService;
        }
        [HttpPost]
        public void post([FromBody] OrderData orderData)
        {
            _orderService.AddOrder(orderData);
            // Save Order and Trigger Event
        }
    }
}
