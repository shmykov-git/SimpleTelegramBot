using Suit;
using TelegramBot.Tools;
using Unity;

namespace SimpleTelegramBot.Bot
{
    static class IoCBot
    {
        public static void Register(UnityContainer container)
        {
            container.RegisterSingleton<BotSettings>();
            container.RegisterFactory<ITelegramBotManagerSettings>(c => IoC.Get<BotSettings>());
            container.RegisterFactory<IActionManagerSettings>(c => IoC.Get<BotSettings>());

            container.RegisterSingleton<BotActions>();
            container.RegisterFactory<IActionManager>(c => IoC.Get<BotActions>());
        }
    }
}
