using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            phone myPhone = new phone("Samsung", 50);
            myPhone.UsePhone();
            myPhone.UsePhone();
            myPhone.UsePhone();
        }
    }
}