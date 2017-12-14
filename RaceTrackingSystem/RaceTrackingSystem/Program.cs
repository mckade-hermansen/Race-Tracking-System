using System;
using RaceData;
using AppLayer;
using GUI;
using System.Threading;
 

namespace RaceTrackingSystem
{
    class MainClass
    {
        public static GUIHandler handler;

        public static void Main(string[] args)
        {
            handler = new GUIHandler();
            //Thread t = new Thread(handler.ShowControlForm);
            //handler.ShowControlForm();
            SimulatorController controller = new SimulatorController(handler);
            Thread t = new Thread(() => controller.Run("Data/Short Race Simulation-01.csv"));
            t.Start();
            //controller.Run("Data/Short Race Simulation-01.csv");

            handler.ShowControlForm();
        }
    }
}
