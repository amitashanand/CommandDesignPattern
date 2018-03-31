using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPattern
{
    class LightsOn : ICommand
    {
        IOTDevice IotDevide;
        public LightsOn(IOTDevice device)
        {
            IotDevide = device;
        }
        public void Execute()
        {
            IotDevide.On();
        }

        public void UnDo()
        {
            IotDevide.Off();
        }
    }
}
