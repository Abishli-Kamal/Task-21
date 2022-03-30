using System;
using System.Collections;

namespace Task_collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList sortedList = new SortedList();

            sortedList.Add(2001,"C#");
            sortedList.Add(1990, "Python");
            sortedList.Add(1995, "JavaScript");
            sortedList.Add(1996, "Java");

            Console.WriteLine("Key is sorting:");
            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine(item.Key);
            }


            Console.WriteLine("Value is sorting:");
            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine(item.Value);
            }

        }
    }
}
