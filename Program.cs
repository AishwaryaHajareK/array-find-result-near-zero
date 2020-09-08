using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Enter the array size:");
            var n = int.Parse(Console.ReadLine());
            var array = new int[n];
            Console.WriteLine("Enter the array elements:");
            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Below are the array elements:");
            foreach (var arr in array)
            {
                Console.WriteLine(arr);
            }

            Console.WriteLine("Result given below.");
            p.GetResult(array, n);
            Console.ReadKey();
        }

        public void GetResult(int[] array, int size)
        {
            int result = 0;

            for (int i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    result = array[i] + array[j];
                    if (result == -1 || result == 1)
                    {
                        Console.WriteLine("{0} & {1} have the sum {2} which is closest to 0", array[i],array[j],result);
                    }
                }
            }
        }
    }
}
