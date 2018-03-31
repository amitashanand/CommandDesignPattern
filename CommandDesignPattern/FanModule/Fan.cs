using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPattern
{
    class Fan : IOTDevice
    {
        private int Magnitude = 0;
        public string DeviceName => "Fan";
        public void DecreaseMagnitude()
        {
            Magnitude = Magnitude - 2;
            Console.WriteLine("Magnitude Decreased . Now :{0}", Magnitude);
        }

        public void IncreaseMagnitude()
        {
            Magnitude = Magnitude + 2;
            Console.WriteLine("Magnitude Increased . Now :{0}", Magnitude);
        }

        public void Off()
        {
            Console.WriteLine("{0} OFF..", DeviceName);
        }

        public void On()
        {
            Console.WriteLine("{0} ON..", DeviceName);
        }
    }
}
