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
        public string BotFiles => "https://api.telegram.org/file/bot<token>/<file_path>";
        public string GetBotFile(string token, string path) =>
            BotFiles.Replace("<token>", token).Replace("<file_path>", path);

    }
}