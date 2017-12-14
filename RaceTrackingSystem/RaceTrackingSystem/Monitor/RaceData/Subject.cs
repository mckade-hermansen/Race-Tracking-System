using System;
using System.Collections.Generic;
using RaceData.Messages;

namespace RaceTrackingSystem.Monitor.RaceData
{
    public abstract class Subject
    {
        public abstract int BibNumber { get; set; }
        public abstract void RegisterObserver(Observer o);
        public abstract void RemoveObserver(Observer o);
        public abstract void NotifyObservers(AthleteUpdate update);
    
    }
}
