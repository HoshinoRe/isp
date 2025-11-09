using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mammal bear = new Mammal("Медведь", 10, " Тайга", "Плоды", " Плотный и грубый", 180);
            Bird parrot = new Bird("Попугай ара", 7, "Тропические леса", "Фрукты", 1, " Деревянные дупла ");
            Reptile crocodile = new Reptile(" Крокодил нильский", 15, "Африканские реки", "Рыба", "Твердая", 30);
            Fish fish = new Fish("Щука ", 5, "Озеро", "Рыба", "Мелкая", 10);

            Console.WriteLine("Каталог:");
            bear.DisplayInfo(); Console.WriteLine();
            parrot.DisplayInfo(); Console.WriteLine();
            crocodile.DisplayInfo(); Console.WriteLine();
            fish.DisplayInfo(); Console.WriteLine();

            Console.WriteLine("Действия:");
            bear.MakeSound(); bear.FeedMilk();
            parrot.MakeSound(); parrot.Fly();
            crocodile.MakeSound(); crocodile.Sunbathe();
            fish.MakeSound(); fish.Swim();

            Console.ReadLine();
        }
    }
}