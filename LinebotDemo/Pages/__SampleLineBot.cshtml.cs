using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using isRock.Web.Core.Razor;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace __NameSpace__.Pages
{
    public class SampleLineBot : isPageModel
    {
        public void OnGet()
        {

        }

        [PageMethod]
        public static object PushMessage(dynamic para)
        {
            try
            {
                string Token = para.fieldToken;
                string userID = para.fieldUserId;
                string Message = para.fieldMessage;

                var bot = new isRock.LineBot.Bot(Token);
                //push text
                bot.PushMessage(userID, Message);
                //push sticker
                bot.PushMessage(userID, 1, 2);
                return true;
            }
            catch (System.Exception ex)
            {
                return ex.Message;
            }
        }
    }
}