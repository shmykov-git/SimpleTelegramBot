using System.IO;
using Newtonsoft.Json.Linq;
using Suit.Extensions;
using SimpleTelegramBot.Tools;

namespace SimpleTelegramBot
{
    class Settings : IMyToolSettings
    {
        private JObject settings;

        public Settings()
        {
            settings = File.ReadAllText("settings.json").FromJson<JObject>();
        }
    }
}