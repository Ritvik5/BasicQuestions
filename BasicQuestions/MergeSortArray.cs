using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicQuestions
{
    public class MergeSortArray
    {
        public static void MergeSort(int[] arr)
        {
            int n = arr.Length;
            if( n < 2 )
            {
                return; 
            }
            int mid = n / 2;
            int[] leftArray = new int[mid];
            int[] rightArray = new int[n-mid];
            
            for(int i = 0; i < mid; i++)
            {
                leftArray[i] = arr[i];
            }
            for (int i = mid; i < n; i++)
            {
                rightArray[i-mid] = arr[i];
            }
            MergeSort(leftArray);
            MergeSort(rightArray);

            Merge(arr,leftArray,rightArray);
        }
        public static void Merge(int[] arr, int[] leftArray , int[] rightArray) 
        {
            int leftLength = leftArray.Length;
            int rightLength = rightArray.Length;

            int i = 0, j = 0, k = 0;
            while (i < leftLength && j < rightLength)
            {
                if(leftArray[i] <= rightArray[j])
                {
                    arr[k] = leftArray[i];
                    i++;
                }
                else
                {
                    arr[k] = rightArray[j];
                    j++;
                }
                k++;
            }

            while(i < leftLength)
            {
                arr[k] = leftArray[i];
                i++;
                k++;
            }
            while (j < rightLength)
            {
                arr[k] = rightArray[j];
                j++;
                k++;
            }

        }
    }
}
