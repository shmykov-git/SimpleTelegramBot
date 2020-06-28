using System;
using Suit;
using Suit.Logs;
using SimpleTelegramBot.Tools;

namespace SimpleTelegramBot
{
    class Program
    {
        static Program()
        {
            IoC.Configure(IoCSuitConsole.Register);
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
