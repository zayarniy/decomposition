using System;

namespace Task1
{
    class Program {


        static bool IsEven(int n)
        {
            return (n & 1) == 0;
        }

        static void Main()
        {
                System.Console.WriteLine(IsEven(5));//False
                System.Console.WriteLine(IsEven(6));//True                
        }
    }
}