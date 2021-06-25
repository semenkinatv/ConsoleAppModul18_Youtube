using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppModul18_Youtube
{
    /// <summary>
    /// Конкретная реализация команды.
    /// </summary>
    class CommandSave : Command
    {
        Receiver receiver;
        string Url;
        string FilePath;

        public CommandSave(Receiver receiver, string url, string filePath)
        {
            this.receiver = receiver;
            Url = url;
            FilePath = filePath;
        }

        // Выполнить
        public async override void Run()
        {
            Console.WriteLine("\r\n2. Отправлена команда на загрузку видео...");
            receiver.SaveVideoAsync(Url, FilePath).Wait();
        }
    }

}
