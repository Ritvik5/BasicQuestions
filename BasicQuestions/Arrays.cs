namespace BasicQuestions
{
    public class Arrays
    {
        public static void CopyArray()
        {
            int[] arr = new int[5];
            int[] arr1 = new int[5];
            int i;
            int n;

            Console.WriteLine("Copy the elements one array into another array : \n");

            Console.WriteLine("Input the elements you want to store : \n");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\nAll the elemesnts in first array is : \n");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            for (i = 0; i < arr.Length; i++)
            {
                arr1[i] = arr[i];
            }
            Console.WriteLine("\nAll the elemesnts in Second array is : ");
            foreach (var item in arr1)
            {
                Console.WriteLine(item);
            }
        }

        public static void Sort()
        {
            string[] stringArray = new string[5] { "Sumit", "John", "Smith", "Jack", "Snow" };

            for (int i = 0; i <= stringArray.Length - 1; i++)
            {
                for (int j = i + 1; j < stringArray.Length; j++)
                {
                    if (stringArray[i].CompareTo(stringArray[j]) > 0)
                    {
                        string temp = stringArray[i];
                        stringArray[i] = stringArray[j];
                        stringArray[j] = temp;
                    }
                }
            }
            Console.WriteLine("After Sorting the array : ");
            foreach (var item in stringArray)
            {
                Console.WriteLine(item);
            }
        }

        public static void SortBubble()
        {
            string[] stringArray = new string[5] { "Sumit", "John", "Smith", "Jack", "Snow" };

            for (int i = 1; i <= stringArray.Length - 1; i++)
            {
                for (int j = 0; j <= stringArray.Length - 2; j++)
                {
                    if (stringArray[j].CompareTo(stringArray[j + 1]) > 0)
                    {
                        string temp = stringArray[j];
                        stringArray[j] = stringArray[j + 1];
                        stringArray[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("After Sorting the array : ");
            foreach (var item in stringArray)
            {
                Console.WriteLine(item);
            }
        }

        public static void BubbleSort()
        {
            int[] intArray = new int[5] { 2, 5, 4, 7, 1 };
            for (int i = 0; i <= intArray.Length - 2; i++)
            {
                for (int j = 0; j <= intArray.Length - 2; j++)
                {
                    if (intArray[j] > intArray[j + 1])
                    {
                        int temp = intArray[j + 1];
                        intArray[j + 1] = intArray[j];
                        intArray[j] = temp;
                    }
                }
            }
            Console.WriteLine("After Sorting the array : ");
            foreach (var item in intArray)
            {
                Console.WriteLine(item);
            }
        }
        public static void InsertionSort()
        {
            string[] stringArray = new string[5] { "Sumit", "John", "Smith", "Jack", "Snow" };
            for (int i = 0; i <= stringArray.Length - 1; i++)
            {
                string temp = stringArray[i];
                int hole = i;
                while ((hole > 0) && (stringArray[hole - 1].CompareTo(temp) > 0))
                {
                    stringArray[hole] = stringArray[hole - 1];
                    hole = hole - 1;
                }
                stringArray[hole] = temp;
            }
            Console.WriteLine("After sorting the Array : ");
            foreach (var item in stringArray)
            {
                Console.WriteLine(item);
            }
        }
        
    }
}
