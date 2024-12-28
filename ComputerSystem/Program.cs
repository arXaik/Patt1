using System;
using ComputerSystem; // Подключаем проект с фасадом

namespace ComputerClient
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаём экземпляр фасада компьютера
            ComputerFacade computer = new ComputerFacade();

            // Запуск компьютера
            computer.StartComputer();

            // Выключение компьютера
            computer.ShutdownComputer();
        }
    }
}
