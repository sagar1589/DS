using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace priorityqueueHeap
{
    ////Works with only int values
    //class Program
    //{

    //    static int[] arr = null;

    //    static void Main(string[] args)
    //    {

    //        arr = new int[] { 1, 4, 3, 7, 8, 9, 10, 2, 5 };

    //        //heapMinsort(arr);

    //        buildminHeap(arr);

    //        Console.WriteLine("Extracted minimum is " + extractMinimum());

    //        Console.WriteLine("Extracted minimum is " + extractMinimum());

    //        // heapMinsort(arr);

    //        decreaseValue(5, 1);
    //        Console.ReadLine();

    //    }



    //    static void heapMinsort(int[] arr)
    //    {

    //        int size = arr.Count() - 1;

    //        buildminHeap(arr);

    //        for (int i = size; i >= 1; i--)
    //        {

    //            swap(arr, 0, i);

    //            size--;

    //            minheapify(arr, 0, size);

    //        }

    //    }





    //    static void buildminHeap(int[] arr)
    //    {

    //        for (int i = (arr.Count() - 1) / 2; i >= 0; i--)
    //        {

    //            minheapify(arr, i, arr.Count() - 1);

    //        }

    //    }

    //    static void minheapify(int[] arr, int i, int n)
    //    {

    //        int left = 2 * i + 1;

    //        int right = (2 * i) + 2;

    //        int smallest = -1;



    //        if (left <= n && arr[left] < arr[i])
    //        {

    //            smallest = left;

    //        }

    //        else
    //        {

    //            smallest = i;

    //        }

    //        if (right <= n && arr[right] < arr[smallest])
    //        {

    //            smallest = right;

    //        }

    //        if (smallest != i && smallest != -1)
    //        {

    //            swap(arr, i, smallest);

    //            minheapify(arr, smallest, n);

    //        }

    //    }

    //    static void swap(int[] arr, int a, int b)
    //    {

    //        int temp = arr[a];

    //        arr[a] = arr[b];

    //        arr[b] = temp;

    //    }



    //    static int minimum()
    //    {

    //        return arr[0];

    //    }



    //    static int extractMinimum()
    //    {

    //        int minimum = int.MinValue;

    //        minimum = arr[0];

    //        arr[0] = arr.Last();

    //        Array.Resize(ref arr, arr.Count() - 1);

    //        minheapify(arr, 0, arr.Count() - 1);

    //        return minimum;

    //    }



    //    static void decreaseValue(int i, int val)
    //    {

    //        if (val < arr[i])
    //        {

    //            arr[i] = val;

    //            while (i > 0 && arr[i / 2] > arr[i])
    //            {

    //                swap(arr, i / 2, i);

    //                i = i / 2;

    //            }

    //        }

    //    }

    //}


    ////works with generic type Item 
    public class Item
    {
        public char vertex;
        public int key;

        public Item(char vertex, int key)
        {
            this.vertex = vertex;
            this.key = key;
        }
    }

    public class PriorityQueue
    {
        public static Item[] arr = null;
        static void Main(string[] args)
        {
            var input = new int[] { 1, 4, 3, 7, 8, 9, 10, 2, 5 };
            //var input = new char[] { '1', '4', '3', '7', '8', '9', '2', '5' };
            arr = new Item[input.Count()];
            for (int i = 0; i < arr.Count(); i++)
            {
                arr[i] = new Item('A', input[i]);
            }
            //heapMinsort(arr);
            buildminHeap(arr);
            Console.WriteLine("Extracted minimum is " + extractMinimum().key);
            Console.WriteLine("Extracted minimum is " + extractMinimum().key);
            //heapMinsort(arr);
            arr[5].vertex = 'F';
            decreaseValue(arr[5], 1);
            heapMinsort(arr);
            Console.ReadLine();
        }

        public static void heapMinsort(Item[] arr)
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


        public static void buildminHeap(Item[] input)
        {
            arr = input;
            for (int i = (input.Count() - 1) / 2; i >= 0; i--)
            {
                minheapify(input, i, input.Count() - 1);
            }
        }
        public static void minheapify(Item[] arr, int i, int n)
        {
            int left = 2 * i + 1;
            int right = (2 * i) + 2;
            int smallest = -1;

            if (left <= n && arr[left].key < arr[i].key)
            {
                smallest = left;
            }
            else
            {
                smallest = i;
            }
            if (right <= n && arr[right].key < arr[smallest].key)
            {
                smallest = right;
            }
            if (smallest != i && smallest != -1)
            {
                swap(arr, i, smallest);
                minheapify(arr, smallest, n);
            }
        }
        public static void swap(Item[] arr, int a, int b)
        {
            var temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }

        public static Item minimum()
        {
            return arr[0];
        }

        public static Item extractMinimum()
        {
            if (arr != null)
            {
                if (arr.Count() > 0)
                {
                    Item minimum = null;
                    minimum = arr[0];
                    arr[0] = arr.Last();
                    Array.Resize(ref arr, arr.Count() - 1);
                    minheapify(arr, 0, arr.Count() - 1);
                    return minimum;
                }
            }
            return null;
        }

        public static void decreaseValue(Item item, int val)
        {
            int i = findIndex(item);
            if (i != -1)
            {
                if (val < arr[i].key)
                {
                    arr[i].key = val;
                    while (i > 0 && arr[i / 2].key > arr[i].key)
                    {
                        swap(arr, i / 2, i);
                        i = i / 2;
                    }
                }
            }
        }

        public static int findIndex(Item item)
        {
            for (int i = 0; i < arr.Count(); i++)
            {
                if (arr[i].vertex == item.vertex)
                {
                    return i;
                }
            }
            return -1;
        }

        public static Item findItem(char vertex)
        {
            for (int i = 0; i < arr.Count(); i++)
            {
                if (arr[i].vertex == vertex)
                {
                    return arr[i];
                }
            }
            return null;
        }
    }
}
