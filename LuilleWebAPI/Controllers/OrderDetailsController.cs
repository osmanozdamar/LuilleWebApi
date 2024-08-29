using LuilleWebAPI.Context;
using LuilleWebAPI.Entities.Concreate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LuilleWebAPI.Controllers
{
    [Route("api/orderdetails")]
    [ApiController]
    public class OrderDetailsController : ControllerBase
    {

        [HttpGet]  // http://localhost:5216
        public List<OrderDetail> GetOrderDetails()
        {
            var ctx = new LuilleContext();
            var result = ctx.OrderDetails.ToList();

            return result;
        }
    }
}
