using System;
using System.IO;
using System.Threading.Tasks;
using Bot.PublicModel;
using Bot.PublicModel.ActionResult;
using Suit.Logs;
using TelegramBot.Tools;

namespace SimpleTelegramBot.Bot
{
    class BotActions: IActionManagerSettings
    {
        private readonly ILog log;

        public BotActions(ILog log)
        {
            this.log = log;
        }

        public async Task<ActionResult> DoAction(ActionArguments arguments)
        {
            switch (arguments.ActionName)
            {
                case "HelloGenerated":
                    return new PicAndCaptionResult()
                    {
                        Caption = "Генерируем какие-то бизнес данные, строим графики",
                        
                        // this pic can be generated depends on business logic
                        Pic = File.ReadAllBytes("Bot/Gen/Gen.png"),

                        NameGoes = new NameGo[]
                        {
                            ("Статус", "underconstruction"),
                            ("Меню", "HelloBot"),
                            ("Старт", "start"),
                            ("Хорошо", "HelloBot"),
                        },
                        ColumnsCount = 3
                    };

                default:
                    throw new NotImplementedException(arguments.ActionName);
            }
        }
    }
}
