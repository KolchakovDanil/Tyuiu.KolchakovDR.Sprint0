using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KolchakovDR.Sprint0.Task6.V0.Lib;
namespace Tyuiu.KolchakovDR.Sprint0.Task6.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = new int[] { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("Сумма элементов массива = " + DataService.AddArray(numArray));
            Console.WriteLine("Разность элементов массива = " + DataService.SubArray(numArray));
            Console.WriteLine("Произведение элементов массива = " + DataService.MultArray(numArray));
            Console.WriteLine("Деление элементов массива = " + DataService.DivArray(numArray));
            Console.ReadKey();
        }
    }
}
