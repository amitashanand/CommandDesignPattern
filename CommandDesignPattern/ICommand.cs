using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPattern
{
    interface ICommand
    {
         void Execute();
         void UnDo();
    }
}
