using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlfaTask
{
    class Program
    {
        /*
         Нужно написать функцию bsearch, которая принимает на вход отсортированный
         по убыванию массив целых чисел и целое число X. В качестве результата функция
         должна возвращать индекс первого элемента массива, строго меньшего X. В Вашей
         реализации функция может принимать любое количество любых параметров, только
         2 этих параметра обязательны.
         */

        static void Main(string[] args)
        {
            int[] nums = new int[4] { 5, 2, 0, -7 };
            int x = 1;

            Console.WriteLine(bsearch(nums, x));

            Console.ReadLine();
        }

        public static int bsearch(int[] arr, int x)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (x > arr[i])
                    return i;
            }
            return arr[arr.Length - 1];
        }
    }
}
