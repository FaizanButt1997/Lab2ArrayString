using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1FindEvenNumberInIntArray
{
    class Program
    {
        static void Main(string[] args)
        {
            


            int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };

            Program p = new Program();

           int total = p.EvenNumber_arr(arr);
            Console.WriteLine(" Sum of Even Number " + total );
            Console.ReadKey();
        }

        public int EvenNumber_arr(int[] arr)
        {
            //1st way
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {

                    sum += arr[i];
                }
            }
            return sum;

            //2nd way

            //return arr.Where(x => x % 2 == 0).Sum();

        }

    }
}
