using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppModul18_Youtube
{
    /// <summary>
    /// Реализация команды "Считать инфу из файла"
    /// </summary>
    class CommandGet : Command
    {
        Receiver receiver;
        string Url;

        public CommandGet(Receiver receiver, string url)
        {
            this.receiver = receiver;
            Url = url;
        }

        // Выполнить
        public async override void Run()
        {
            Console.WriteLine("\r\n1. Отправлена команда на получение информации о видео...");
            receiver.GetVideoAsync(Url).Wait();
        }
    }
}
