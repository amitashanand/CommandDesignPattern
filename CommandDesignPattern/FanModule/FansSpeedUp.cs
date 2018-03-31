using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPattern.Lights
{
    class FansSpeedUp : ICommand
    {
        IOTDevice IotDevide;
        public FansSpeedUp(IOTDevice device)
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
