using System;

namespace Task7
{
    class Program {


        static bool TryDivide(int a, int b, out int result)
        {
            if (b==0) {
                result = 0;
                return false;
            }
            result=a/b;
            return true;
        }

        static void Main()
        {
               int res;
               bool flag;
               flag=TryDivide(4,2,out res);
               System.Console.WriteLine($"flag={flag} res={res}");
               flag=TryDivide(4,0,out res);
               System.Console.WriteLine($"flag={flag} res={res}");
        }
    }
}