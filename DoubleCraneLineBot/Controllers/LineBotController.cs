using DoubleCraneLineBot.Models;
using DoubleCraneLineBot.DataAccess;
using DoubleCraneLineBot.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using DoubleCraneLineBot.LineBot.Domain;
using DoubleCraneLineBot.LineBot.Dtos;
using DoubleCraneLineBot.LineBot.Enum;
using DoubleCraneLineBot.LineBot.Providers;


namespace DoubleCraneLineBot.Controllers
{
    public class LineBotController : Controller
    {
        private readonly LineBotService _lineBotService;
        // ================================================================
        private readonly ILogger<LineBotController> _logger;

        public LineBotController(ILogger<LineBotController> logger)
        {
            _logger = logger;
            _lineBotService = new LineBotService();
        }
        public IActionResult Broadcast()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        // ================================================================
        [HttpPost]
        public List<BotListModel>GetBotList()
        {
            Console.WriteLine("Run LibeBotController.GetBotList() Success.");
            var LineBot = new LineBotDA();
            var BotList = LineBot.GetBotList();
            return BotList;
        }
        [HttpPost("Webhook")]
        public IActionResult Webhook(WebhookRequestBodyDto body)
        {
            _lineBotService.ReceiveWebhook(body);
            return Ok();
        }

        /*[HttpPost]
        public IActionResult Broadcast(string messageType, object body)
        {
            Console.WriteLine("Run LibeBotController.Broadcast() Success.");
            // string ss = body.ToString();
            _lineBotService.BroadcastMessageHandler(messageType, body);
            return Ok();
        }*/
    }
}