using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerSystem.Components
{
    public class RAM
    {
        public void Load(string address, string data)
        {
            Console.WriteLine($"Оперативная память: загрузка данных {data} по адресу {address}.");
        }
    }
}
