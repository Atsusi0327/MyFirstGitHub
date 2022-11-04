using System;
using LineBotMessage.Dtos;
using LineBotMessage.Enum;

namespace LineBotMessage.Domain
{
    public class LineBotService
    {

        // 貼上 messaging api channel 中的 accessToken & secret
        private readonly string channelAccessToken = "22v87iug/49+uKqbXISyJpEU6RsWpqSHU5xcu37yG3BVbUdjCsSt13QiKRw6cY7kvkdz1vE7muKZq7He3HMLulVze9STvQryOQBmqElgGqcijqklZ12+5hB93kZejsC+sKGcxjO8FZRXw5zHKJi0tQdB04t89/1O/w1cDnyilFU=";
        private readonly string channelSecret = "c6df19d320672e00a4a388572be6aac5";

        public LineBotService()
        {
        }

        public void ReceiveWebhook(WebhookRequestBodyDto requestBody)
        {
            foreach (var eventObject in requestBody.Events)
            {
                switch (eventObject.Type)
                {
                    case WebhookEventTypeEnum.Message:
                        Console.WriteLine("收到使用者傳送訊息！");
                        break;
                    case WebhookEventTypeEnum.Unsend:
                        Console.WriteLine($"使用者{eventObject.Source.UserId}在聊天室收回訊息！");
                        break;
                    case WebhookEventTypeEnum.Follow:
                        Console.WriteLine($"使用者{eventObject.Source.UserId}將我們新增為好友！");
                        break;
                    case WebhookEventTypeEnum.Unfollow:
                        Console.WriteLine($"使用者{eventObject.Source.UserId}封鎖了我們！");
                        break;
                    case WebhookEventTypeEnum.Join:
                        Console.WriteLine("我們被邀請進入聊天室了！");
                        break;
                    case WebhookEventTypeEnum.Leave:
                        Console.WriteLine("我們被聊天室踢出了");
                        break;
                }
            }
        }


    }
}

