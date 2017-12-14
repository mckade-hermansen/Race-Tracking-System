using System;
using RaceData.Messages;
using RaceTrackingSystem.Monitor.RaceData;

namespace RaceTrackingSystem
{
    public interface Observer
    {
        void Update(AthleteUpdate update);
    }
}
