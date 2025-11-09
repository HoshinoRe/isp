using ConsoleApp32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    public class TextCourse : Course
    {
        public int Chapters { get; set; }     
        public int TextVolume { get; set; }   
        public TextCourse(string title, string desc, string author, decimal price, int chapters, int volume)
            : base(title, desc, author, price)
        {
            Chapters = chapters;
            TextVolume = volume;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Глав: {Chapters}, Объем: {TextVolume} стр.");
        }
        public override void StartCourse()
        {
            Console.WriteLine($"Начато текстовый курс '{Title}'");
        }
    }
}