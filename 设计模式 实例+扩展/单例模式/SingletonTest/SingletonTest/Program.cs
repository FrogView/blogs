﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton.Instance.Show();
            Console.Read();
        }
    }
}
