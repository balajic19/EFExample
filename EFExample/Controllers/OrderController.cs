using EFExample.Infra;
using EFExample.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderDataAccess _orderDataAccess;

        public OrderController(
            IOrderDataAccess orderDataAccess)
        {
            _orderDataAccess = orderDataAccess;
        }

        [HttpPost]
        [Route("createorder")]
        public async Task<IActionResult> CreateOrder([FromBody] OrderModel orderModel)
        {
            _orderDataAccess.SaveOrder(orderModel);

            return Ok("Success");
        }

        [HttpGet]
        [Route("getall")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(_orderDataAccess.GetAllOrder());
            }catch(Exception ex)
            {
                return null;
            }
        }
    }
}
