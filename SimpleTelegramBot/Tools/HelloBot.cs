using System;
using System.IO;
using System.Threading.Tasks;
using Bot.PublicModel;
using Bot.PublicModel.ActionResult;
using Suit.Logs;
using TelegramBot.Tools;

namespace SimpleTelegramBot.Tools
{
    class HelloBot: IActionManagerSettings
    {
        private readonly ILog log;
        private readonly ITelegramBotManager botManager;

        public HelloBot(ILog log, ITelegramBotManager botManager)
        {
            this.log = log;
            this.botManager = botManager;
        }

        public void Start()
        {
            botManager.Start();
        }

        public async Task<ActionResult> DoAction(ActionArguments arguments)
        {
            switch (arguments.ActionName)
            {
                case "HelloGenerated":
                    return new PicAndCaptionResult()
                    {
                        Caption = "Генерируем какие-то бизнес данные, строим графики",
                        Pic = File.ReadAllBytes("Content/Gen.png"),
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
