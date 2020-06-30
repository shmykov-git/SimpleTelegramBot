using Suit.Logs;
using TelegramBot.Tools;

namespace SimpleTelegramBot.Tools
{
    class MyTool
    {
        private readonly ITelegramBotManager theBotManager;

        public MyTool(ILog log, ITelegramBotManager theBotManager)
        {
            this.theBotManager = theBotManager;
        }

        public void Start()
        {
            theBotManager.Start();
        }
    }
}
