﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fib(5));
        }

        static int Fib(int n)
        {
            if(n <= 0) {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return Fib(n - 1) + Fib(n - 2);
            }
        }
    }
}
