using Suit;
using SimpleTelegramBot.Tools;
using TelegramBot.Tools;
using Unity;

namespace SimpleTelegramBot
{
    public static class IoCSimpleTelegramBot
    {
        public static void Register(UnityContainer container)
        {
            container.RegisterSingleton<Settings>();
            container.RegisterFactory<ITelegramBotManagerSettings>(c => IoC.Get<Settings>());

            container.RegisterSingleton<HelloBot>();
            container.RegisterFactory<IActionManagerSettings>(c => IoC.Get<HelloBot>());
        }
    }
}