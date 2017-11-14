using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueue
{
    struct Item
    {
        public int key;
        public int priority;

        static public Item createItem(int key, int prio)
        {
            var item = new Item();
            item.key = key;
            item.priority = prio;
            return item;
        }
        public static Item empty()
        {
            var item = new Item();
            item.key = -1;
            item.priority = -1;
            return item;
        }
    }
    //Normal queue.
    class Program
    {
        static int  rear, size, capacity;
        static Item[] array;

        static void Main(string[] args)
        {
            cerateQueue(5);
            enqueue(Item.createItem(1,7));
            printQ();
            enqueue(Item.createItem(2, 1));
            printQ();
            enqueue(Item.createItem(3, 5));
            printQ();
            enqueue(Item.createItem(4, 4));
            printQ();
            enqueue(Item.createItem(5, 3));
            printQ();
            enqueue(Item.createItem(6, 2));
            printQ();
            enqueue(Item.createItem(7, 1));
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
            dequeue();
            printQ();

            Console.ReadLine();
        }

        static void cerateQueue(int cap)
        {
            rear = cap - 1;
            capacity = cap;
            array = new Item[capacity];
        }

        static bool isFull()
        {
            return size == capacity;

        }

        static bool isEmpty()
        {
            return size == 0;
        }

        static void enqueue(Item item)
        {
            if (isFull())
            {
                Console.WriteLine("\nqueue is full.");
            }
            else
            {

                rear = (rear + 1) % capacity;
                array[rear] = item;
                if (size < capacity)
                {
                    size += 1;
                }
                Console.WriteLine("\n" + item.key + " queued.");
            }
        }

        static public int getHighestPriorityItem()
        {
            int index=-1;
            int maxPrio = int.MaxValue;
            for(int i = 0;i<size;i++)
            {
                if(array[i].priority<maxPrio)
                {
                    maxPrio = array[i].priority;
                    index = i;
                }
            }
            return index;
        }

        static void deleteHighestPriorityItem(int index)
        {
            size -= 1;
            for(int i =index;i<size;i++)
            {
                array[i] = array[i + 1];
            }
        }

        static Item dequeue()
        {
            if (isEmpty())
            {
                Console.WriteLine("\nqueued is empty");
                return Item.empty();
            }
            else
            {
                var inedxHighPrio = getHighestPriorityItem();
                var item = array[inedxHighPrio];
                deleteHighestPriorityItem(inedxHighPrio);
                Console.WriteLine("\nDequeued " + item.key);
                return item;
            }
        }

        static void printQ()
        {
            
            for (int i = 0; i < size; i++)
            {
                Console.Write(array[i].key + ", ");
                
            }
        }


    }
}
