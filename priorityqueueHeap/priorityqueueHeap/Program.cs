using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace priorityqueueHeap
{
    class Program
    {
        static int[] arr = null;
        static void Main(string[] args)
        {
            arr = new int[] { 1, 4, 3, 7, 8, 9, 10, 2, 5 };
            //heapMinsort(arr);
            buildminHeap(arr);
            Console.WriteLine("Extracted minimum is " + extractMinimum());
            Console.WriteLine("Extracted minimum is " + extractMinimum());
           // heapMinsort(arr);
            decreaseValue(5, 1);
        }

        static void heapMinsort(int[] arr)
        {
            int size = arr.Count() - 1;
            buildminHeap(arr);
            for (int i = size; i >= 1; i--)
            {
                swap(arr, 0, i);
                size--;
                minheapify(arr, 0, size);
            }
        }

      
        static void buildminHeap(int[] arr)
        {
            for (int i = (arr.Count() - 1) / 2; i >= 0; i--)
            {
                minheapify(arr, i, arr.Count() - 1);
            }
        }
        static void minheapify(int[] arr, int i, int n)
        {
            int left = 2 * i + 1;
            int right = (2 * i) + 2;
            int smallest = -1;

            if (left <= n && arr[left] < arr[i])
            {
                smallest = left;
            }
            else
            {
                smallest = i;
            }
            if (right <= n && arr[right] < arr[smallest])
            {
                smallest = right;
            }
            if (smallest != i && smallest != -1)
            {
                swap(arr, i, smallest);
                minheapify(arr, smallest, n);
            }
        }
        static void swap(int[] arr, int a, int b)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }

        static int minimum()
        {
            return arr[0];
        }

        static int extractMinimum()
        {
            int minimum = int.MinValue;
            minimum = arr[0];
            arr[0] = arr.Last();
            Array.Resize(ref arr, arr.Count() - 1);
            minheapify(arr,0,arr.Count()-1);
            return minimum;
        }

        static void decreaseValue(int i, int val)
        {
            if(val<arr[i])
            {
                arr[i] = val;
                while(i>0 && arr[i/2]>arr[i])
                {
                    swap(arr, i / 2, i);
                    i = i / 2;
                }
            }
        }
    }
}
