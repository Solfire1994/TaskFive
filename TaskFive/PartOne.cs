using System;

namespace TaskFive
{
    internal class PartOne
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string str = Console.ReadLine();
            Print(DivideString(str));
            Console.ReadKey();
        }

        static string[] DivideString(string str)
        {
            return str.Split(' ');
        }

        static void Print(string[] arr)
        {
            Console.Clear();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
