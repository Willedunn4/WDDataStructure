using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WDDataStructures
{
    class DataStructure
    {
        static void Main()
        {
            // Read data from a file (each line is a unique string)
            string[] lines = File.ReadAllLines("data.txt");

            // Array - fixed size based on input data
            string[] array = new string[lines.Length];
            Array.Copy(lines, array, lines.Length);

            // Dictionary - storing data with line number as key
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            for (int i = 0; i < lines.Length; i++)
            {
                dictionary.Add(i, lines[i]);
            }

            // Stack - adding elements (LIFO)
            Stack<string> stack = new Stack<string>();
            foreach (var line in lines)
            {
                stack.Push(line);
            }

            // Queue - adding elements (FIFO)
            Queue<string> queue = new Queue<string>();
            foreach (var line in lines)
            {
                queue.Enqueue(line);
            }

            // Demonstrating array access
            Console.WriteLine("Array element at index 0: " + array[0]);

            // Demonstrating dictionary access by key
            Console.WriteLine("Dictionary element with key 0: " + dictionary[0]);

            // Demonstrating stack access (LIFO)
            Console.WriteLine("Stack Pop: " + stack.Pop());

            // Demonstrating queue access (FIFO)
            Console.WriteLine("Queue Dequeue: " + queue.Dequeue());
        }
    }
}
