
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class phone
    {
        private string Brand;
        private int Battery;

        public phone(string pBrand, int pBattery)
        {
            Brand = pBrand;
            if (pBattery >= 0 && pBattery <= 100)
            {
                Battery = pBattery;
            }
            else
            {
                Battery = 0;
                Console.WriteLine("заряд телефона может быть от 1 до 100");
            }
        }
        public void UsePhone()
        {
            if (Battery > 0)
            {
                Battery -= 10;
                if (Battery < 0)
                    Battery = 0;
                Console.WriteLine($"Телефон {Brand}, заряд: {Battery}%.");
            }
            else
            {
                Console.WriteLine($"Телефон {Brand} разряжен!");
            }
        }

    }

}
