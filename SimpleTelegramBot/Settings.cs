using System.IO;
using Newtonsoft.Json.Linq;
using Suit.Extensions;

namespace SimpleTelegramBot
{
    class Settings
    {
        private JObject settings;

        public Settings()
        {
            settings = File.ReadAllText("settings.json").FromJson<JObject>();
        }
    }
}