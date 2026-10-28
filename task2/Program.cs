using System;

namespace Task1
{
    class Program {


        static int Max3(int a, int b, int c)
        {
        //    int m=a;
        //    if (b>m) m=b;
        //    if (c>m) m=c;
        //    return m;
           return a>b && a>c?a:b>a && b>c?b:c;
        }

        static void Main()
        {
                System.Console.WriteLine(Max3(1,2,3));//3
                System.Console.WriteLine(Max3(3,2,1));//3
        }
    }
}