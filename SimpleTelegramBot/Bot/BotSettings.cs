using System.IO;
using Suit.Extensions;
using TelegramBot.Model;
using TelegramBot.Tools;

namespace SimpleTelegramBot.Bot
{
    class BotSettings: ITelegramBotManagerSettings
    {
        private readonly SingleBotSettings botSettings;

        public BotSettings()
        {
            botSettings = File.ReadAllText("Bot/BotSettings.json").FromJson<SingleBotSettings>();
        }

        public SingleBotSettings[] Bots => new[] { botSettings };
    }
}