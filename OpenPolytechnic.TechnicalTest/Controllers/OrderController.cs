using Microsoft.AspNetCore.Mvc;
using OpenPolytechnic.Business.Model.Order;
using OpenPolytechnic.Business.Services.Interfaces;
using System.Collections.Generic;

namespace OpenPolytechnic.TechnicalTest.Controllers
{
    [ApiController]
    [Route("api/order")]
    public class OrderController
    {
        private readonly IOrderService OrderService;
        public OrderController(IOrderService OrderService)
        {
            this.OrderService = OrderService;
        }

        [HttpPost]
        [Route("place")]
        ///api/order/place
        public OrderSummary PlaceOrders(Orders orders)
        {            
            return OrderService.PlaceOrders(orders);
        }
    }
}
