using System;
using System.Collections.Generic;

namespace TheControlWork3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string text = GetRandomString(12);
            Console.WriteLine(text);
            
            Dictionary<int, int> AllKeyValuesDict = GetDictionaryOutString(text);
            foreach (KeyValuePair<int, int> keyValue in AllKeyValuesDict)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
            
            Console.WriteLine("---------------------");
            
            Console.WriteLine(text);

            Dictionary<int, int> topThreeSymbols = CountIt(text);
            foreach (KeyValuePair<int, int> keyValue in topThreeSymbols)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }

        }

        public static string GetRandomString(int length)
        {
            string text = "";
            
            Random rnd = new Random();
            for (int i = 0; i < length; i++)
            {
                text += Convert.ToString(rnd.Next(0, 10));
            }

            return text;
        }

        public static Dictionary<int, int> GetDictionaryOutString(string text)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < text.Length; i++)
            {
                var symbol = Convert.ToString(text[i]);
                if(!dict.ContainsKey(Convert.ToInt32(symbol)))
                    dict.Add(Convert.ToInt32(symbol), CountWords(text, symbol));
            }

            return dict;
        }
        public static int CountWords(string text, string symbol)
        {
            int count = (text.Length - text.Replace(symbol, "").Length);
            return count;
        }

        public static Dictionary<int, int> CountIt(string text)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int max = 0;
            string symbol_max = "";
            int symbol_count = 0;
            KeyValuePair<int, int> currentMaxPair = new KeyValuePair<int, int>(0,0);
            for(int j = 0; j < 3; j++){
                for (int i = 0; i < text.Length; i++)
                {
                    string symbol_string = Convert.ToString(text[i]);
                    symbol_count = CountWords(text, symbol_string);
                    if (symbol_count > max && !dict.ContainsKey(Convert.ToInt32(symbol_string)))
                    {
                        symbol_max = symbol_string;
                        max = symbol_count;
                        currentMaxPair = new KeyValuePair<int, int>(Convert.ToInt32(symbol_string), symbol_count);
                    }
                }
                dict.Add(currentMaxPair.Key, currentMaxPair.Value);
                text = text.Replace(symbol_max, "");

                symbol_max = "";
                symbol_count = 0;
                max = 0;
            }

            return dict;
        }
    }
}