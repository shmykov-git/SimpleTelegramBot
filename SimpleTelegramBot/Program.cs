using System;
using System.Globalization;
using System.Threading;
using SimpleTelegramBot.Bot;
using SimpleTelegramBot.Tools;
using Suit;
using Suit.Logs;
using TelegramBot;

namespace SimpleTelegramBot
{
    class Program
    {
        static Program()
        {
            // suit + telegramBotEngine + theBot + youBusinessLogic
            IoC.Configure(IoCTelegramBot.Register, IoCBot.Register, IoCSimpleTelegramBot.Register);
        }

        static void Main(string[] args)
        {
            var log = IoC.Get<ILog>();

            log.Debug("### Start console ###");

            IoC.Get<MyTool>().Start();

            Console.ReadLine();

            log.Debug("### End ###");
        }
    }
}
