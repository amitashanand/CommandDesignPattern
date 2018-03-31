using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPattern
{
     /// <summary>
     /// Invoker
     /// </summary>
    class RemoteButton
    { 
        private ICommand _command;
        public RemoteButton(ICommand Command)
        {
            _command = Command;
        }
        
        public void ButtonPressed()
        {
            _command.Execute();
        }
        public void Back()
        {
            _command.UnDo();
        }



    }
}
