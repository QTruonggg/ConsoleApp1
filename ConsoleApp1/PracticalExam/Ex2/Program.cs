using System;
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
            Animal a = new Tiger(100, "Tiger");
            a.Show();
            a = new Lion(200, "Lion");
            a.Show();
        }
    }
}
