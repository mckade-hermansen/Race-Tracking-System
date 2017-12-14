
using System.Threading;
using RaceData;
using GUI;

namespace AppLayer
{
    public class SimulatorController
    {
        private SimulatedDataSource _simluatedData;
        private GUIHandler gui;

        public SimulatorController(GUIHandler h)
        {
            gui = h;
        }

        public void Run(string inputFileName)
        {
            IAthleteUpdateHandler handler = new DataProcessor(gui);
            _simluatedData = new SimulatedDataSource()
            {
                InputFilename = inputFileName,
                Handler = handler
            };

            _simluatedData.Start();

            // Let the simulator run for 3 minutes
            Thread.Sleep(180000);

            _simluatedData.Stop();
        }
    }
}
