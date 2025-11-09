using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    internal class Program
    {
        static void Main(string[] args)
        {

            VideoCourse v = new VideoCourse("Data-аналитик", "Научитесь работать с BI-инструментами", "Василий Сизов", 6963, 30, 720);
            TextCourse t = new TextCourse("Изучаем Python пошагово", "Развитие технологий", "Команда CodeBase", 0, 15, 50);
            InteractiveCourse i = new InteractiveCourse("Практическое программирование на Python", "Практика и задачи", " Алексей Петров", 1500, 15, "Автопроверка");

            Console.WriteLine("Каталог: ");
            v.DisplayInfo(); Console.WriteLine();
            t.DisplayInfo(); Console.WriteLine();
            i.DisplayInfo(); Console.WriteLine();
            Console.WriteLine("Начало: ");
            v.StartCourse();
            t.StartCourse();
            i.StartCourse();

            Console.ReadLine();
        }
    }
}