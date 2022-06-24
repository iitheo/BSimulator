using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using BankSimulator.Policies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BankSimulator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankSimulatorController : ControllerBase
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly ClientPolicy _clientPolicy;

        public BankSimulatorController(ClientPolicy clientPolicy, IHttpClientFactory clientFactory)
        {
            _clientPolicy = clientPolicy;
            _clientFactory = clientFactory;
        }
        
        [HttpGet]
        public async Task<IActionResult> MakeRequestPaymentGateway()
        {
            var client = _clientFactory.CreateClient();
            var response = await _clientPolicy.ExponentialHttpRetry.ExecuteAsync(
                () => client.GetAsync("https://localhost:8080/api/payment/transactionReference/003da7fb-aced-4782-a1ff-d72a760422e1"));
            if (response.IsSuccessStatusCode)
            {
                return Ok();
            }

            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }
}