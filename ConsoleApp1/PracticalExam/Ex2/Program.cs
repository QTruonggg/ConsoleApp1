﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.PracticalExam.Ex2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Lion(250, "Lion");
            a.Show();
            a = new Tiger(200, "Tiger");
            a.Show();
        }
    }
}
