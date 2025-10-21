using ConsoleApp24;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Pet praim = new Pet("Super krutoi pes 999 optimus praim comander destroer apporation aghanim protector spirit", 150);
                praim.Play();
                praim.Rest();
                praim.Play();
            }
        }
    }
}