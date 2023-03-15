namespace BasicQuestions
{
    public class IfElse
    {

        public string numberInWord;
        public string numberInWeekDay;
        public int numberPosition;
        public string NumberInWord(int number)
        {

            if (number == 0)
            {
                numberInWord = "Zero";
            }
            else if (number == 1)
            {
                numberInWord = "One";
            }
            else if (number == 2)
            {
                numberInWord = "Two";
            }
            else if (number == 3)
            {
                numberInWord = "Three";
            }
            else if (number == 4)
            {
                numberInWord = "Four";
            }
            else if (number == 5)
            {
                numberInWord = "Five";
            }
            else if (number == 6)
            {
                numberInWord = "Six";
            }
            else if (number == 7)
            {
                numberInWord = "Seven";
            }
            else if (number == 8)
            {
                numberInWord = "Eight";
            }
            else if (number == 9)
            {
                numberInWord = "Nine";
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            return numberInWord;
        }

        public string NumberInWeekDay(int day)
        {
            if (day == 1)
            {
                numberInWeekDay = "Monday";
            }
            else if (day == 2)
            {
                numberInWeekDay = "Tuesday";
            }
            else if (day == 3)
            {
                numberInWeekDay = "Wednesday";
            }
            else if (day == 4)
            {
                numberInWeekDay = "Thursday";
            }
            else if (day == 5)
            {
                numberInWeekDay = "Friday";
            }
            else if (day == 6)
            {
                numberInWeekDay = "Saturday";
            }
            else if (day == 7)
            {
                numberInWeekDay = "Sunday";
            }
            else
            {
                numberInWeekDay = "Invalid Input ";
            }
            return numberInWeekDay;

        }

        public static void NumberPosition(int number)
        {
            if (number >= 0 && number <= 1000)
            {
                int unit = number % 10;
                int tens = (number / 10) % 10;
                int hundred = (number / 100) % 10;
                Console.WriteLine("Units : " + unit);
                Console.WriteLine("Tens : " + tens);
                Console.WriteLine("Hundreds : " + hundred);
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }

        public static void MinMaxArithmetic()
        {
            int a, b, c;
            Console.WriteLine("Enter the value for a :");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value for b :");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value for c :");
            c = Convert.ToInt32(Console.ReadLine());

            int operationOne = a + b * c;
            int operationTwo = c + a / b;
            int operationThree = a % b + c;
            int operationFour = a * b + c;

            int max = operationOne;
            int min = operationOne;

            if (operationTwo > max)
            {
                max = operationTwo;
            }
            else if (operationTwo < min)
            {
                min = operationTwo;
            }
            else if (operationThree > max)
            {
                max = operationThree;
            }
            else if (operationThree < min)
            {
                min = operationThree;
            }
            else if (operationFour > max)
            {
                max = operationFour;
            }
            else if (operationFour < min)
            {
                min = operationFour;
            }

            Console.WriteLine("The Maximum of the 4 Operation is : " + max);
            Console.WriteLine("The Minimum of the 4 Operation is : " + min);
        }

        public static void MinMaxRandomNumber()
        {
            Random random = new Random();
            int num1 = random.Next(100, 1000);
            int num2 = random.Next(100, 1000);
            int num3 = random.Next(100, 1000);

            int max = num1;
            int min = num2;

            if (num2 > max)
            {
                max = num2;
            }
            else if (num2 < min)
            {
                min = num2;
            }
            else if (num3 > max)
            {
                max = num3;
            }
            else if (num3 < min)
            {
                min = num3;
            }

            Console.WriteLine("The Maximum of 3 Random Number is : " + max);
            Console.WriteLine("The Minimum of 3 Random Number is : " + min);
        }

        public static void IsLeapYear()
        {
            Console.WriteLine("Enter the year : ");
            int year = Convert.ToInt32(Console.ReadLine());

            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
            {
                Console.WriteLine("The " + year + " is a Leap Year");
            }
            else
            {
                Console.WriteLine("The " + year + " is not a Leap Year");
            }
        }

        public static void IsHeadOrTail()
        {
            Random random = new Random();
            int flip = random.Next(2);

            if (flip == 0)
            {
                Console.WriteLine("Head");
            }
            else 
            { 
                Console.WriteLine("Tail"); 
            }
        }
    }
}
