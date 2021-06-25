using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppModul18_Youtube
{
    /// <summary>
    /// Отправитель команды
    /// </summary>
    class Sender
    {
        Command _command;

        public void SetCommand(Command command)
        {
            _command = command;
        }

        // Выполнить
        public void Run()
        {
            _command.Run();
        }
    }
}
