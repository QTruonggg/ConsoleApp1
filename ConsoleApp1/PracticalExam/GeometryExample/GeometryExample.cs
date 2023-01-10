using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.PracticalExam.GeometryExample
{
    public class GeometryExample
    {
        static void Main(string[] args)
        {
            Cylinder cylinder = new Cylinder();
            cylinder.Process(3, 4);
            cylinder.Result();
        }
    }
}
