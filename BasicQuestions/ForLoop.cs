using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicQuestions
{
    public class ForLoop
    {
        public static void SumOfNaturalNumbs()
        {
            int num = 5;
            int sum = 0;

            for(int i = 1; i <= num; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }

        public static void Reverse() 
        {
            Console.WriteLine("Enter the Number to reverse : \n");
            int num = Convert.ToInt32(Console.ReadLine());

            int reverse = 0;

            for(int i = num; num > 0;i++)
            {
                int lastDigit = num % 10;
                reverse = ( reverse * 10 ) + lastDigit;
                num = num / 10;
            }
            Console.WriteLine(reverse);
        }

        public static void IsPalindrome()
        {
            Console.WriteLine("Enter the Number to reverse : \n");
            int num = Convert.ToInt32(Console.ReadLine());

            int reverse = 0;
            int temp = num;

            for (int i = num; num > 0; i++)
            {
                int lastDigit = num % 10;
                reverse = (reverse * 10) + lastDigit;
                num = num / 10;
            }
            Console.WriteLine(reverse);

            if(temp == reverse)
            {
                Console.WriteLine("The " + reverse + " number is a Palindrome");
            }
            else
            {
                Console.WriteLine("The " + reverse + " number is not Palindrome");
            }
        }
    }
}
