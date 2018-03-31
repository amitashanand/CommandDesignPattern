using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPattern
{
    class FansOn : ICommand
    {
        IOTDevice IotDevide;
        public FansOn(IOTDevice device)
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
