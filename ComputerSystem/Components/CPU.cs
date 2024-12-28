using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerSystem.Components
{
    public class CPU
    {
        public void Freeze()
        {
            Console.WriteLine("Процессор: остановка.");
        }

        public void JumpTo(string address)
        {
            Console.WriteLine($"Процессор: переход к адресу {address}.");
        }

        public void Execute()
        {
            Console.WriteLine("Процессор: выполнение программы.");
        }
    }
}

