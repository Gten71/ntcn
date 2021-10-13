using System;
using System.Threading;

namespace ntcn
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.ForegroundColor = ConsoleColor.White;

            int res = 0;

            for (int e= 1000; e >0; e -=7)

            {
                res = e - 7;
                Console.WriteLine(e + "-" + 7 + "=" + res);
                Thread.Sleep(100);


            }


        }

      





    }
}
