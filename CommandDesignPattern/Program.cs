using CommandDesignPattern.Lights;
using System;

namespace CommandDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var light = new Light();
            //One interface to andle all, it means one remote can handle all.
            //Extensible ,align to S and O of solid principle.
            ICommand switchOnCommand = new LightsOn(light);
            RemoteButton remoteButton = new RemoteButton(switchOnCommand);
            remoteButton.ButtonPressed();
            ICommand dimUp = new LightsDimUp(light);
            RemoteButton remoteButtonDimUp = new RemoteButton(dimUp);
            remoteButtonDimUp.ButtonPressed();
            remoteButtonDimUp.ButtonPressed();
            remoteButtonDimUp.ButtonPressed();
            remoteButtonDimUp.Back();
            remoteButtonDimUp.Back();
            remoteButtonDimUp.Back();
            remoteButton.Back();

            var fan = new Fan();
            switchOnCommand = new FansOn(fan);
            remoteButton = new RemoteButton(switchOnCommand);
            remoteButton.ButtonPressed();
            ICommand speedUp = new FansSpeedUp(fan);
            RemoteButton remoteButtonSpeedUp = new RemoteButton(speedUp);
            remoteButtonSpeedUp.ButtonPressed();
            remoteButtonSpeedUp.ButtonPressed();
            remoteButtonSpeedUp.ButtonPressed();
            remoteButtonSpeedUp.Back();
            remoteButtonSpeedUp.Back();
            remoteButtonSpeedUp.Back();
            remoteButtonSpeedUp.Back();
            remoteButton.Back();
        }
    }
}
