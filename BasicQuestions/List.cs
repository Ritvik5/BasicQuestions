using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicQuestions
{
    public class List
    {
        public static void InsertionSort()
        {
            List<string> list = new List<string>() { "Sumit", "John", "Smith", "Jack", "Snow" };
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("****************************\n");
            for (int i = 0; i <= list.Count - 1; i++)
            {
                string temp = list[i];
                int hole = i;
                while ((hole > 0) && (list[hole - 1].CompareTo(temp) > 0))
                {
                    list[hole] = list[hole - 1];
                    hole = hole - 1;
                }
                list[hole] = temp;
            }
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }

        public static void BubbleSort()
        {
            List<int> list = new List<int>() { 5, 9, 2, 3, 1, 0 };
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n*********************\n");
            for (int i = 0; i <= list.Count - 2; i++)
            {
                for (int j = 0; j <= list.Count - 2; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        int temp = list[j + 1];
                        list[j + 1] = list[j];
                        list[j] = temp;
                    }
                }
            }
            foreach(int item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
