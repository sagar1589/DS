using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 4, 3, 7, 8, 9, 10,2,5 };
            heapsort(arr);
            buildHeap(arr);
        }

        static void heapsort(int[] arr)
        {
            int size = arr.Count() - 1;
            buildHeap(arr);
            for(int i=size;i>=1;i--)
            {
                swap(arr, 0, i);
                size--;
                maxheapify(arr, 0, size);
            }
        }

        static void buildHeap(int[] arr)
        {
            for (int i = (arr.Count()-1)/2; i >=0; i--)
            {
                maxheapify(arr, i, arr.Count() - 1);
            }
        }
        static void maxheapify(int[] arr, int i,int n)
        {
            int left = 2 * i+1;
            int right = (2 * i) + 2;
            int largest=-1;
            
            if(left<=n && arr[left]>arr[i])
            {
                largest = left;
            }
            else
            {
                largest = i;
            }
            if(right<=n && arr[right]>arr[largest])
            {
                largest = right;
            }
            if(largest!=i && largest!=-1)
            {
                swap(arr, i, largest);
                maxheapify(arr, largest,n);
            }
        }
        static void swap(int[] arr, int a, int b)
        {
            int temp=arr[a];
            arr[a] =arr[b];
            arr[b]=temp;
        }
    }
}
