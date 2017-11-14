using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    ////Circular queue.
    class Program
    {
        static int front, rear, size, capacity;
        static int[] array;

        static void Main(string[] args)
        {
            cerateQueue(5);
            enqueue(1);
            printQ();
            enqueue(2);
            printQ();
            enqueue(3);
            printQ();
            enqueue(4);
            printQ();
            dequeue();
            printQ();
            enqueue(5);
            printQ();
            enqueue(6);
            printQ();
            dequeue();
            printQ();
            enqueue(7);
            printQ();
            enqueue(8);
            printQ();
            dequeue();
            printQ();
            dequeue();
            printQ();
            dequeue();
            printQ();
            enqueue(1);
            printQ();
            enqueue(2);
            printQ();
            dequeue();
            printQ();
            dequeue();
            printQ();
            dequeue();
            printQ();
            dequeue();
            printQ();
            dequeue();
            printQ();
            dequeue();
            printQ();

            Console.ReadLine();
        }

        static void cerateQueue(int cap)
        {
            front = size = 0;
            rear = 0;
            capacity = cap;
            array = new int[capacity];
        }

        static bool isFull()
        {
            return size == capacity;

        }

        static bool isEmpty()
        {
            return size == 0;
        }

        static void enqueue(int item)
        {
            array[rear] = item;
            rear = (rear + 1) % capacity;
            
            if (size < capacity)
            {
                size += 1;
            }else
            {
                front = (front + 1) % capacity;
            }
            Console.WriteLine("\n" + item + " queued.");
        }

        static int dequeue()
        {
            if (isEmpty())
            {
                Console.WriteLine("\nqueued is empty");
                return -1;
            }
            else
            {
                var item = array[front];
                array[front] = 0;
                front = (front + 1) % capacity;
                size -= 1;
                Console.WriteLine("\nDequeued " + item);
                return item;
            }
        }

        static void printQ()
        {

            int temp = front;
            for (int i = 0; i < capacity; i++)
            {
                if (array[temp] != 0)
                {
                    Console.Write(array[temp] + ", ");
                    temp = (temp + 1) % capacity;
                }else
                {
                    break;
                }
            }
        }


    }


    ////Normal queue.
    //class Program
    //{
    //    static int front, rear, size, capacity;
    //    static int[] array;

    //    static void Main(string[] args)
    //    {
    //        cerateQueue(5);
    //        enqueue(1);
    //        printQ();
    //        enqueue(2);
    //        printQ();
    //        enqueue(3);
    //        printQ();
    //        enqueue(4);
    //        printQ();
    //        enqueue(5);
    //        printQ();
    //        enqueue(6);
    //        printQ();
    //        enqueue(7);
    //        printQ();
    //        enqueue(8);
    //        printQ();
    //        dequeue();
    //        printQ();
    //        dequeue();
    //        printQ();
    //        dequeue();
    //        printQ();
    //        dequeue();
    //        printQ();
    //        dequeue();
    //        printQ();
    //        dequeue();
    //        printQ();
    //        dequeue();
    //        printQ();

    //        Console.ReadLine();
    //    }

    //    static void cerateQueue(int cap)
    //    {
    //        front = size  = 0;
    //        rear = cap - 1;
    //        capacity = cap;
    //        array = new int[capacity];
    //    }

    //    static bool isFull()
    //    {
    //        return size == capacity;

    //    }

    //    static bool isEmpty()
    //    {
    //        return size == 0;
    //    }

    //    static void enqueue(int item)
    //    {
    //        if (isFull())
    //        {
    //            Console.WriteLine("\nqueue is full.");
    //        }
    //        else
    //        {

    //            rear = (rear + 1) % capacity;
    //            array[rear] = item;
    //            if (size < capacity)
    //            {
    //                size += 1;
    //            }
    //            Console.WriteLine("\n" + item + " queued.");
    //        }
    //    }

    //    static int dequeue()
    //    {
    //        if(isEmpty())
    //        {
    //            Console.WriteLine("\nqueued is empty");
    //            return -1;
    //        }else
    //        {
    //            var item = array[front];
    //            array[front] = 0;
    //            front = (front + 1) % capacity;
    //            size -= 1;
    //            Console.WriteLine("\nDequeued " + item);
    //            return item;
    //        }
    //    }

    //    static void printQ()
    //    {

    //        int temp = front;
    //        for (int i = 0; i < capacity; i++)
    //        {
    //            Console.Write(array[temp] + ", ");
    //            temp = (temp + 1) % capacity;
    //        }
    //    }


    //}
}
