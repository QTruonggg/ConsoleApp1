using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.PracticalExam.Ex2
{
    public class Animal
    {
        public double weight;
        public string name;
        public Animal(double weight, string name)
        {
            SetMe(weight, name);
        }

        public void Show()
        {
            Console.WriteLine("Name: " + name + ", " + "Weight: " + weight);
        }

        public void SetMe(double weight, string name)
        {
            this.weight = weight;
            this.name = name;
        }
    }
}
