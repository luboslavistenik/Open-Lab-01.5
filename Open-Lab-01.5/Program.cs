using System;

namespace Open_Lab_01._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Reverse(true);
        }
        static bool Reverse(bool boolean)
        {
            Console.WriteLine(!boolean);
            return !boolean;
        }
    }
}
