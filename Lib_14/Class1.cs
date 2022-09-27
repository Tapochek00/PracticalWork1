using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_14
{
    public class Class1
    {
        /// <summary>
        /// Вычислить сумму целых случайных чисел, распределенных в диапазоне от 55 до 70,
        /// пока эта сумма не превышает некоторого числа K. 
        /// </summary>
        /// <param name="k"></param>
        /// <param name="sum">Сумма</param>
        /// <param name="numbers">Слагаемые</param>
        /// <param name="count">Количество чисел</param>
        public static void RandomSum(int k, out int sum, out string numbers, out int count)
        {
            int theRandomNumber;
            count = 0;
            sum = 0;
            numbers = "";
            Random rand = new Random();

            while (sum < k)
            {
                theRandomNumber = rand.Next(55, 70);
                numbers += theRandomNumber.ToString() + "\n";
                sum += theRandomNumber;
                count++;
            }
        }
    }
}