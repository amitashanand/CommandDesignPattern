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
            switchOnCommand.Execute();
            ICommand dimUp = new LightsDimUp(light);
            dimUp.Execute();
            dimUp.Execute();
            dimUp.Execute();
            dimUp.UnDo();
            dimUp.UnDo();
            dimUp.UnDo();
            switchOnCommand.UnDo();

            var fan = new Fan();
            switchOnCommand = new FansOn(fan);
            switchOnCommand.Execute();
            ICommand speedUp = new FansSpeedUp(fan);
            speedUp.Execute();
            speedUp.Execute();
            speedUp.Execute();
            speedUp.UnDo();
            speedUp.UnDo();
            speedUp.UnDo();
            switchOnCommand.UnDo();
        }
    }
}
