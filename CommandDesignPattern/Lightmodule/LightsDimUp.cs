using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPattern.Lights
{
    class LightsDimUp : ICommand
    {
        IOTDevice IotDevide;
        public LightsDimUp(IOTDevice device)
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
