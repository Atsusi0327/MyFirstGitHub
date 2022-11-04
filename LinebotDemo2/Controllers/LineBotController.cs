using LinebotDemo2.Dtos;
using LinebotDemo2.Domain;
using Microsoft.AspNetCore.Mvc;

namespace LinebotDem02.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class LinebotController : ControllerBase
    {

        private readonly LinebotService _lineBotService;
        // constructor
        public LinebotController()
        {
            _lineBotService = new LinebotService();
        }

        [HttpPost("Webhook")]
        public IActionResult Webhook(WebhookRequestBodyDto body)
        {
            _lineBotService.ReceiveWebhook(body);
            return Ok();
        }

    }
}