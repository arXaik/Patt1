using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerSystem.Components
{
    public class PowerSupply
    {
        public void TurnOn()
        {
            Console.WriteLine("Блок питания: включён.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Блок питания: выключён.");
        }
    }
}

