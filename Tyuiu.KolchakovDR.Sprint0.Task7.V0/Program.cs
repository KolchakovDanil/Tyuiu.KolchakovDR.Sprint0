using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KolchakovDR.Sprint0.Task7.V0.Lib;
namespace Tyuiu.KolchakovDR.Sprint0.Task7.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #0| Выполнил: Колчаков Д. Р. | ИИПб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #0                                                               *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #0                                                              *");
            Console.WriteLine("* Выполнил Колчаков Д. Р. | ИИПб-23-2                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на С#, которая суммирует значения двух    *");
            Console.WriteLine("* одинаковых массивов по длинне.                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] arrayPain1 = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Значение элементов массива №1");
            for (int i = 0; i < arrayPain1.Length; i++)
            {
                Console.Write(arrayPain1[i] + ", ");
            }
            Console.WriteLine();
            int[] arrayPain2 = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Значение элементов массива №2");
            for (int i = 0; i < arrayPain2.Length; i++)
            {
                Console.Write(arrayPain2[i] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            
            if (arrayPain1.Length == arrayPain2.Length)
            {
                int[] resArrayPain = DataService.AddArray(arrayPain1, arrayPain2);
                Console.WriteLine("Сумма элементов массивов = ");
                for (int i = 0; i < resArrayPain.Length; i++)
                {
                    Console.Write(resArrayPain[i] + ", ");
                }
            }
            else
            {
                Console.WriteLine("Ошибка! В исходных массивах разное количество элементов!");
            }
            
            Console.ReadKey();
        }
    }
}
