using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KolchakovDR.Sprint0.Task4.V0.Lib;

namespace Tyuiu.KolchakovDR.Sprint0.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(1, 5));
            Console.WriteLine(DataService.Sub(15, 5));
            Console.WriteLine(DataService.Mult(5, 5));
            Console.WriteLine(DataService.Div(15, 5));

            Console.ReadKey();
        }
    }
}
