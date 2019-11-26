//`using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Telegram.Bot;

//namespace LonelyIslandTelegramBot.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class BotController : ControllerBase
//    {
//        private readonly TelegramBotClient client = new TelegramBotClient(token);
//        [HttpPost]
//        public async void Post([FromBody]Update update)
//        {
//            if (update == null) return;
//            var message = update.Message;
//            if (message?.Type == MessageType.TextMessage)
//            {
//                await client.SendTextMessageAsync(message.Chat.Id, message.Text);
//            }
//        }
//    }
//}