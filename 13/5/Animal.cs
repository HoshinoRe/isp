using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    public abstract class Animal
    {
        protected string Species { get; set; }    
        protected int Age { get; set; }             
        protected string Habitat { get; set; }     
        protected string Diet { get; set; }        

        public Animal(string species, int age, string habitat, string diet)
        {
            Species = species;
            Age = age;
            Habitat = habitat;
            Diet = diet;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Вид: {Species}");
            Console.WriteLine($"Возраст: {Age} лет");
            Console.WriteLine($"Среда обитания: {Habitat}");
            Console.WriteLine($"Рацион: {Diet}");
        }
        public virtual void Eat()
        {
            Console.WriteLine($"{Species} ест {Diet}.");
        }

        public abstract void MakeSound();   
    }
}