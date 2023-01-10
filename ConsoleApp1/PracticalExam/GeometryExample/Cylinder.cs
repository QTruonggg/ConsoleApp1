using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.PracticalExam.GeometryExample
{
    public class Cylinder
    {
        private double baseArea;
        private double lateralArea;
        private double totalArea;
        private double volume;
        private double radius;
        private double height;

        public void Process(double r, double h)
        {
            radius = r;
            height = h;
            baseArea = Math.PI * radius * radius;
            lateralArea = 2 * Math.PI * radius * height;
            totalArea = 2 * Math.PI * radius * (radius + height);
            volume = Math.PI * radius * radius * height;
        }

        public void Result()
        {
            Console.WriteLine("Base Area: " + baseArea);
            Console.WriteLine("Lateral Area: " + lateralArea);
            Console.WriteLine("Total Area: " + totalArea);
            Console.WriteLine("Volume: " + volume);
        }
    }
}
