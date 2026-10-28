using System;

namespace Task8
{
    class Program {


        static long DigitSum(int n)
        {
            if (n<10) return n;
            else return DigitSum(n/10)+n%10;
        }

        static void Main()
        {
            System.Console.WriteLine(DigitSum(5));//5
            System.Console.WriteLine(DigitSum(15));//6
            System.Console.WriteLine(DigitSum(1234));//10
        }
    }
}