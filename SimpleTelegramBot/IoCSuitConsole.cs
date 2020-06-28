using Suit;
using SimpleTelegramBot.Tools;
using Unity;

namespace SimpleTelegramBot
{
    public static class IoCSuitConsole
    {
        public static void Register(UnityContainer container)
        {
            container.RegisterSingleton<Settings>();
            container.RegisterFactory<IMyToolSettings>(c => IoC.Get<Settings>());
        }
    }
}