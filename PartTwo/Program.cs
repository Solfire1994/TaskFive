using System;

namespace PartTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string str = Console.ReadLine();
            ReverseWords(str);
            Console.ReadKey();
        }

        static void ReverseWords(string str)
        {
            string[] arr = DivideString(str);
            string resultString = arr[^1];
            for (int i = arr.Length - 2; i >= 0; i--)
            {
                resultString = string.Concat(resultString, " ", arr[i]);
            }
            Console.WriteLine(resultString);
        }

        static string[] DivideString(string str)
        {
            return str.Split(' ');
        }

    }
}
