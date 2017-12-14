using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RaceData;
using RaceData.Messages;
using GUI;
using RaceTrackingSystem;
using RaceTrackingSystem.Monitor.RaceData;

namespace AppLayer
{
    public class DataProcessor : IAthleteUpdateHandler
    {
        private GUIHandler handler;
        private System.Object _lock = new System.Object();

        public DataProcessor(GUIHandler h)
        {
            handler = h;
        }

        public void ProcessUpdate(AthleteUpdate updateMessage)
        {
            lock (_lock)
            {
                if (updateMessage.UpdateType == AthleteRaceStatus.Registered)
                {
                    RegistrationUpdate temp = (RegistrationUpdate)updateMessage;
                    handler.AddAthlete(new Athlete(temp.BibNumber, temp.FirstName, temp.LastName, temp.Gender, temp.Age));
                }
                else
                {
                    handler.updateObservers(updateMessage);
                }
            }

            Console.WriteLine(updateMessage.ToString());
        }
    }
}
