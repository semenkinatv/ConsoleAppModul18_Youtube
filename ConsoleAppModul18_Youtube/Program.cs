using System;
using YoutubeExplode;
using YoutubeExplode.Converter;
using System.Threading.Tasks;

namespace ConsoleAppModul18_Youtube
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите ссылку на  Youtube-видео:");
            //var url = Console.ReadLine();  

            var url      = "https://www.youtube.com/watch?v=bDV0q2BjiOs";
            var filePath = @"C:\Semenkina\video\Voices.mp4";

            Console.WriteLine("Задана ссылка на  Youtube-видео: https://www.youtube.com/watch?v=bDV0q2BjiOs");

            // создадим отправителя
            var sender = new Sender();

            // создадим получателя
            var receiver = new Receiver();

            // создадим команду на считывание информации
            var commandGet = new CommandGet(receiver, url);

            // инициализация команды
            sender.SetCommand(commandGet);

            //  Выполнение
            sender.Run();

            // создадим команду на загрузку файла
            var commandSave = new CommandSave(receiver, url, filePath);

            // инициализация команды
            sender.SetCommand(commandSave);

            //  Выполнение
            sender.Run();
        }
    }
}
