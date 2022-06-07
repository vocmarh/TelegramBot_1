using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;

namespace TelegramBot_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var botClient = new TelegramBotClient("5516354710:AAFRDPEFklDU6K7ae-UDVJ7ypL4uq320pq8");
            var me = botClient.GetMeAsync().Result.FirstName;


            Console.WriteLine($"Привет! Меня зовут {me}.");
            Console.ReadKey();
        }       

    }
}
