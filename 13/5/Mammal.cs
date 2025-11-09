using ConsoleApp33;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    public class Mammal : Animal
    {
        private string FurType;      
        private int GestationDays;    

        public Mammal(string species, int age, string habitat, string diet, string furType, int gestDays)
            : base(species, age, habitat, diet)
        {
            FurType = furType;
            GestationDays = gestDays;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Тип меха: {FurType}");
            Console.WriteLine($"Беременность: {GestationDays} дней");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Species} издаёт звуки млекопитающего.");
        }

        public void FeedMilk()
        {
            Console.WriteLine($"{Species} кормит детёнышей молоком.");
        }
    }
}