using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KolchakovDR.Sprint0.Task5.V0.Lib;
namespace Tyuiu.KolchakovDR.Sprint0.Task5.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a + b = " + DataService.Addition(1, 5));
            Console.WriteLine("a - b = " + DataService.Sub(15, 5));
            Console.WriteLine("a * b = " + DataService.Mult(5, 5));
            Console.WriteLine("a / b = " + DataService.Div(15, 0));

            Console.ReadKey();
        }
    }
}
