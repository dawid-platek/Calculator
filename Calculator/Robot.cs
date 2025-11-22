using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Robot
    {
        private string _serialNumber;
        public string Name;

        public Robot(string serialNumber)
        {
            _serialNumber = serialNumber;
            Console.WriteLine("Konstruktor.");
        }
        public void SayHello()
        {
            Console.WriteLine("Cześć, jestem robotem !!! Mój numer seryjny to " + _serialNumber);
        }

        public DateTime GetCurrentDate()
        {
            var currentTime = DateTime.Now;
            return currentTime;
        }
    }
}
