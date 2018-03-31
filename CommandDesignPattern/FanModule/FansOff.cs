using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPattern
{
    internal class FansOff : ICommand
    {
        IOTDevice IotDevide;
        public FansOff(IOTDevice device)
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
