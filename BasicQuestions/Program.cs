namespace BasicQuestions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Leap Year Check \n");

            //int number = Convert.ToInt32(Console.ReadLine());

            //IfElse display = new IfElse();

            //string displayInWord = display.NumberInWeekDay(number);
            //Console.WriteLine(displayInWord);


            // IfElse.NumberPosition(number);
            //IfElse.MinMaxArithmetic();
            //IfElse.MinMaxRandomNumber();
            //IfElse.IsLeapYear();
            //IfElse.IsHeadOrTail();
            //While.SumOfNaturalnumbers();
            //While.ReverseNumber();
            //While.PalindromeNumber();
            //ForLoop.SumOfNaturalNumbs();
            //ForLoop.Reverse();
            //ForLoop.IsPalindrome();
            //FibonacciSeries.Fibonacci();
            //Arrays.CopyArray();
            //Arrays.Sort();
            //Arrays.SortBubble();
            //Arrays.BubbleSort();
            //Arrays.InsertionSort();
            //List.InsertionSort();
            //List.BubbleSort();


            int[] numbers = new int[10] { 102, 20, 25, 26, 2, 44, 45, 65, 111, 999 };
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            MergeSortArray.MergeSort(numbers);

            Console.WriteLine("\nAfter Implementing Merge Sort\n");

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}