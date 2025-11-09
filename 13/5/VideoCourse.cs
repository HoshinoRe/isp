using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    public class VideoCourse : Course
    {
        public int VideoCount { get; set; }      
        public int TotalDuration { get; set; }  

        public VideoCourse(string title, string desc, string author, decimal price, int count, int duration)
            : base(title, desc, author, price)
        {
            VideoCount = count;
            TotalDuration = duration;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Видео: {VideoCount}, Общая длительность: {TotalDuration} мин.");
        }
        public override void StartCourse()
        {
            Console.WriteLine($"Начато видеокурс '{Title}'");
        }
    }
}