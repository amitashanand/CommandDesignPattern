using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPattern
{
    interface IOTDevice
    {
        string DeviceName { get; }
        void On();
        void Off();
        void IncreaseMagnitude();
        void DecreaseMagnitude();
    }
}
