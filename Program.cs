using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tim_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            sorting s1 = new sorting();
            int[] arr = { 5, 21, 7, 23, 19,100,90,70,320 };        
            int n = arr.Length;
            Console.Write("Given Array is\n");
            s1.printArray(arr, n);

            s1.TimSort(arr, n);

            Console.Write("After Sorting Array is\n");
            s1.printArray(arr, n);  
        }
    }
    class sorting
    {
        int RUN = 32;
        // this function sorts array from left index to 
        // to right index which is of size atmost RUN 
        public void InsertionSort(int[] arr, int left, int right)
        {
            for (int i = left + 1; i <= right; i++)
            {
                int temp = arr[i];
                int j = i - 1;
                while (arr[j] > temp && j >= left)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = temp;
            }
        }
        // merge function merges the sorted runs 
       public void merge(int[] numbers, int left, int mid, int right) 
       {
           // original array is broken in two parts 
           // left and right array 
        int[] temp = new int[numbers.Length];
        int i, eol, num, pos;
            eol = (mid - 1);
            pos = left;
            num = (right - left + 1);
            while ((left <= eol) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                   temp[pos++] = numbers[left++];
                else
                    temp[pos++] = numbers[mid++];
            }
            while (left <= eol)
            {
                temp[pos++] = numbers[left++];
            }
            while (mid <= right)
            {
                temp[pos++] = numbers[mid++];
            }
            for (i = 0; i < num; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
       }
       // iterative Timsort function to sort the 
       // array[0...n-1] (similar to merge sort) 
        public void TimSort(int[] arr,int n)
       {
            // Sort individual subarrays of size RUN 
           for (int i = 0; i < n; i += RUN)
           {
               InsertionSort(arr, i, Math.Min((i + 31), (n - 1)));
           }
           // start merging from size RUN (or 32). It will merge 
           // to form size 64, then 128, 256 and so on .... 
           for (int size = RUN; size < n; size = 2 * size)
           {
               // pick starting point of left sub array. We 
               // are going to merge arr[left..left+size-1] 
               // and arr[left+size, left+2*size-1] 
               // After every merge, we increase left by 2*size 
               for (int left = 0; left < n; left += 2 * size)
               {
                   // find ending point of left sub array 
                   // mid+1 is starting point of right sub array 
                   int mid = left + size - 1;
                   int right = Math.Min((left + 2 * size - 1), (n - 1));
                   // merge sub array arr[left.....mid] & 
                   // arr[mid+1....right] 
                   merge(arr, left, mid, right);
               }
           }
       }
        //Print function to print sorted array
        public void printArray(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
            Console.Write("\n");
        }  
    }
}

      







