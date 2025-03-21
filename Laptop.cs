using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Laptop
    {
        private string _model;
        private int _frequency;
        private int _amountRam;
        private int _amountHardDrive;
        private int _mass;
        public Laptop()
        {

        }
        public Laptop(string model, int frequency, int amountRam, int amountHardDrive, int mass)
        {
            _model = model;
            _frequency = frequency;
            _amountRam = amountRam;
            _amountHardDrive = amountHardDrive;
            _mass = mass;
        }

        public void Info()
        {
            Console.WriteLine($"Ноутбук: {_model}\n" +
                $"Тактовая частота ЦП: {_frequency}\n" +
                $"Объем ОЗУ: {_amountRam}\n" +
                $"Объем Жесткого диска: {_amountHardDrive}\n" +
                $"Масса: {_mass}");
        }
    }
}
