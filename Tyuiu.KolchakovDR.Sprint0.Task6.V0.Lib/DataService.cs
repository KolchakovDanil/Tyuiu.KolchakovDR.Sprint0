using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.KolchakovDR.Sprint0.Task6.V0.Lib
{
    public class DataService
    {
        public static int AddArray(int[] num)
        {
            var total = 0;
            for (var i = 0; i < num.Length; i++)
            {
                total = total + num[i];
            }
            return total;
        }
        public static int SubArray(int[] num)
        {
            var total = 0;
            var i = 0;

            while (i < num.Length)
            {
                total = total - num[i];
                i++;
            }
            return total;
        }
        public static int MultArray(int[] num)
        {
            var total = 1;
            var i = 0;

            do
            {
                total = total * num[i];
                i++;
            }
            while (i < num.Length);

            return total;
        }
        public static double DivArray(int[] num)
        {
            var total = 720;
            var i = 0;

            do
            {
                total = total / num[i];
                i++;
            }
            while (i < num.Length);

            return total;
        }
    }
}
