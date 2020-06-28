using System.IO;
using System.Linq;
using Newtonsoft.Json.Linq;
using Suit.Extensions;
using TelegramBot.Model;
using TelegramBot.Tools;

namespace SimpleTelegramBot
{
    class Settings : ITelegramBotManagerSettings
    {
        private JObject settings;

        public Settings()
        {
            settings = File.ReadAllText("settings.json").FromJson<JObject>();
        }

        public SingleBotSettings[] Bots => settings["Bots"].Cast<JObject>().Select(bot => bot.ToObject<SingleBotSettings>()).ToArray();
    }
}