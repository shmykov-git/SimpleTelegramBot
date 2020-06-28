using System;
using System.Globalization;
using System.Threading;
using Suit;
using Suit.Logs;
using SimpleTelegramBot.Tools;
using TelegramBot;

namespace SimpleTelegramBot
{
    class Program
    {
        static Program()
        {
            IoC.Configure(IoCTelegramBot.Register, IoCSimpleTelegramBot.Register);
        }

        static void Main(string[] args)
        {
            var log = IoC.Get<ILog>();

            log.Debug("### Start console ###");

            IoC.Get<HelloBot>().Start();

            Console.ReadLine();

            log.Debug("### End ###");
        }
    }
}
