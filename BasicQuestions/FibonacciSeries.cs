using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicQuestions
{
    public class FibonacciSeries
    {
        public static int Fibonacci(int n)
        {
            Console.WriteLine("Enter the number for Fibonacci Series : \n");

            int num = Convert.ToInt32(Console.ReadLine());

            int n1 = 0;
            int n2 = 1;
            int result = 0;
            for(int i = 2; i <= num; i++)
            {
                result = n1 + n2 ;
                n1 = n2;
                n2 = result ;
                Console.WriteLine(result);
            }
            return result;
        }
    }
}
