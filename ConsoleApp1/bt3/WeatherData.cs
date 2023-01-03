using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.bt3
{
    internal class WeatherData
    {
        public string Name { get; set; }
        public Main Mainn { get; set; }
        public Weather[] Weather { get; set; }
        public object Main { get; internal set; }
    }
}
