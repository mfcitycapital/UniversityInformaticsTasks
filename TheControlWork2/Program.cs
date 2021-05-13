using System;
using System.Collections.Generic;

namespace TheControlWork2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            LinkedList<int> numbers = GetLinkedList("55555444449999922222333311111111"); // 1:8, 2:5, 3:4, 4:5, 5:5, 9:5
            int c = Convert.ToInt32(Console.ReadLine());

            numbers = SortLinkedList(numbers, c);

            foreach (int i in numbers)
            {
                Console.Write(i);
            }
        }

        public static LinkedList<int> GetLinkedList(string text)
        {
            LinkedList<int> list = new LinkedList<int>();
            for (int i = 0; i < text.Length; i++)
            {
                var a = text[i] - '0';
                list.AddLast(a);
            }

            return list;
        }

        public static LinkedList<int> SortLinkedList(LinkedList<int> list, int c)
        {
            LinkedList<int> new_list = new LinkedList<int>();
            foreach (int i in list)
            {
                if (i >= c)
                {
                    new_list.AddLast(i);
                }
                else
                {
                    new_list.AddFirst(i);
                }
            }

            return new_list;
        }
    }
}