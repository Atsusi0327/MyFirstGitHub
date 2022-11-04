using Microsoft.AspNetCore.Mvc;

namespace LineBotMessage.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class LineBotController : ControllerBase
    {

        // 貼上 messaging api channel 中的 accessToken & secret
        private readonly string channelAccessToken = "22v87iug/49+uKqbXISyJpEU6RsWpqSHU5xcu37yG3BVbUdjCsSt13QiKRw6cY7kvkdz1vE7muKZq7He3HMLulVze9STvQryOQBmqElgGqcijqklZ12+5hB93kZejsC+sKGcxjO8FZRXw5zHKJi0tQdB04t89/1O/w1cDnyilFU=";
        private readonly string channelSecret = "c6df19d320672e00a4a388572be6aac5";

        // constructor
        public LineBotController()
        {

        }

        // 使用 Post 方法的原因是因為這支 API 會接收 Line 傳送的 webhook event，
        // 這部分在下一篇會介紹～
        [HttpPost("Webhook")]
        public IActionResult Webhook()
        {
            return Ok();
        }
    }
}