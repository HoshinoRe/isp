using ConsoleApp33;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    public class Fish : Animal
    {
        private string ScaleType;    
        private double Depth;          
        public Fish(string species, int age, string habitat, string diet, string scale, double depth)
            : base(species, age, habitat, diet)
        {
            ScaleType = scale;
            Depth = depth;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Тип чешуи: {ScaleType}");
            Console.WriteLine($"Глубина обитания: {Depth} м");
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Species} не издаёт звуков, но пузырится :)");
        }
        public void Swim()
        {
            Console.WriteLine($"{Species} плавает на глубине {Depth} метров.");
        }
    }
}