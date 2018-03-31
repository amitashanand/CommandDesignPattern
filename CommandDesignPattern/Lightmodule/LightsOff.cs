using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPattern
{
    class LightsOff : ICommand
    {
        IOTDevice IotDevide;
        public LightsOff(IOTDevice device)
        {
            IotDevide = device;
        }
        public void Execute()
        {
            IotDevide.Off();
        }

        public void UnDo()
        {
            IotDevide.On();
        }
    }
}
