using System;
using System.Collections.Generic;
using System.IO;

namespace TheControlWork1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            LinkedList<int> numberOfSymbols = new LinkedList<int>();
            
            try
            {
                StreamReader sr = new StreamReader("/Users/arslanrashidov/RiderProjects/Solution/TheControlWork1/NewFile1.txt");
                string line = sr.ReadLine();

                numberOfSymbols.AddLast(numberOfCharsInString(line));
                
                while (line != null)
                {
                    line = sr.ReadLine();
                    if (line != null)
                    {
                        numberOfSymbols.AddLast(numberOfCharsInString(line));
                    }
                }
                sr.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Конец считывания файла");
            }

            foreach (int i in numberOfSymbols)
            {
                Console.WriteLine(i);
            }
        }

        public static int numberOfCharsInString(string text)
        {
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                count += 1;
            }

            return count;
        }
    }
}