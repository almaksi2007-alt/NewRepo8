using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст  ");
            string text = Console.ReadLine();
            string[] words = text.Split();
            int wordCount = words.Length;
            Console.WriteLine($"Количество слов   {wordCount}");
        }
    }
}
