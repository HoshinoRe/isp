using ConsoleApp33;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    public class Bird : Animal
    {
        private double Wingspan;       
        private string NestingType;   
        public Bird(string species, int age, string habitat, string diet, double wingspan, string nesting)
            : base(species, age, habitat, diet)
        {
            Wingspan = wingspan;
            NestingType = nesting;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Размах крыльев: {Wingspan} м");
            Console.WriteLine($"Тип гнездования: {NestingType}");
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Species} щебечет или поёт.");
        }
        public void Fly()
        {
            Console.WriteLine($"{Species} взлетает в небо!");
        }
    }
}