﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbeKN1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           
            for (int i = 1; i <= n + 1; i = i*2+1)
            {
                Console.WriteLine(i);               
            }
        }
    }
}
