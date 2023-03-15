using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicQuestions
{
    public class While
    {
        public static void SumOfNaturalnumbers()
        {
            int num = 1;
            int result = 0;
            while (num <= 5)
            {
                result += num;
                num++;
            }
            Console.WriteLine(result);
        }

        public static void ReverseNumber() 
        {
            Console.WriteLine("Enter the number to reverse : \n");
            int num = Convert.ToInt32(Console.ReadLine());

            int reverse = 0;

            while (num > 0)
            {
                int lastDigit = num % 10;
                reverse = (reverse * 10) + lastDigit;
                num = num / 10;
            }
            Console.WriteLine(reverse);
        }

        public static void PalindromeNumber()
        {
            Console.WriteLine("Enter the Palindrome Number : \n");
            int num = Convert.ToInt32(Console.ReadLine());

            int reverse = 0;
            int temp = num;
            while (num > 0)
            {
                int lastDigit = num % 10;
                reverse = (reverse * 10) + lastDigit;
                num = num / 10;
            }
            Console.WriteLine(reverse);

            if(temp == reverse)
            {
                Console.WriteLine("The " + reverse + " number is Palindrome");
            }
            else
            {
                Console.WriteLine("The " + reverse + " number is not Palindrome");
            }
            
        }
    }
}
