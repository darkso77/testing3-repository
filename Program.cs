using System;

namespace Test_ZamianaWyrazow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz wyrazy, np. \"a simple program to a computer\"");
            var tekst = Console.ReadLine();
            var result = ReverseStr.ReverseWord(tekst);
            Console.WriteLine();
            Console.WriteLine(result);
        }
    }
}
