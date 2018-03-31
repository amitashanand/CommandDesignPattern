using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPattern.Lightmodule
{
    class FansSpeedDown:ICommand
    {
        IOTDevice IotDevide;
        public FansSpeedDown(IOTDevice device)
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
