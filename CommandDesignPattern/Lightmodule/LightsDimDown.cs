using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPattern.Lightmodule
{
    class LightsDimDown : ICommand
    {
        IOTDevice IotDevide;
        public LightsDimDown(IOTDevice device)
        {
            IotDevide = device;
        }
        public void Execute()
        {
            IotDevide.IncreaseMagnitude();
        }

        public void UnDo()
        {
            IotDevide.DecreaseMagnitude();
        }
    }
}
