using ComputerSystem.Components;

namespace ComputerSystem
{
    public class ComputerFacade
    {
        private PowerSupply powerSupply;
        private CPU cpu;
        private RAM ram;
        private ComputerSystem.Components.OperatingSystem os; // Указание полного имени

        public ComputerFacade()
        {
            powerSupply = new PowerSupply();
            cpu = new CPU();
            ram = new RAM();
            os = new ComputerSystem.Components.OperatingSystem();
        }

        public void StartComputer()
        {
            Console.WriteLine("Запуск компьютера...");
            powerSupply.TurnOn();
            cpu.Freeze();
            ram.Load("0x00", "BIOS");
            cpu.JumpTo("0x00");
            os.Load();
            cpu.Execute();
            Console.WriteLine("Компьютер успешно включён.\n");
        }

        public void ShutdownComputer()
        {
            Console.WriteLine("Выключение компьютера...");
            cpu.Freeze();
            powerSupply.TurnOff();
            Console.WriteLine("Компьютер успешно выключен.\n");
        }
    }
}
