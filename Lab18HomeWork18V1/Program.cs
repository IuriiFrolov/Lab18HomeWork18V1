using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab18HomeWork18V1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку для проверки: ");
            string start = Console.ReadLine();
            if (Staples(start) == true)
            {
                Console.WriteLine("Строка корректна");
            }
            else
            {
                Console.WriteLine("Скобки расставленны НЕ корректно!");
            }
            Console.ReadKey();
        }

        static bool Staples(string start)
        {
            string example = "[{(]})";
            Stack<char> araay = new Stack<char>();
            foreach (var x in start)
            {
                int a = example.IndexOf(x);
                if (a >= 0 && a <= 2)
                { 
                    araay.Push(x); 
                }

                else if (a > 2)
                {
                    if (araay.Count == 0 || araay.Pop() != example[a - 3])
                    { return false; }
                }
            }
            if (araay.Count != 0)
            { return false; }
            return true;
        }
    }
}
