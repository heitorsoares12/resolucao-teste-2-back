using Microsoft.AspNetCore.Mvc;
using Payments.API.Data;

namespace Payments.API.Controllers
{
    [Route("payments")]
    public class PaymentController : Controller
    {
        public PaymentController() { }

        [HttpGet]
        public async Task<ActionResult> GetPayments()
        {
            Response.Headers.Add("Access-Control-Allow-Origin", "*");
            var payments = DataBaseInMemory.GetPayments();
            return Ok(payments);
        }

        [HttpGet("user/{userId}")]
        public async Task<ActionResult> GetPaymentsByUser(string userId)
        {
            Response.Headers.Add("Access-Control-Allow-Origin", "*");
            var payments = DataBaseInMemory.GetPaymentsByUser(userId);
            return Ok(payments);
        }
    }
}
