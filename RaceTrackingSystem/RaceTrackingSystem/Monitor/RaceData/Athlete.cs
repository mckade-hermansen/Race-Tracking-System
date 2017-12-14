using System;
using System.Collections.Generic;
using RaceTrackingSystem.Monitor.RaceData;
using RaceData.Messages;

namespace RaceTrackingSystem.Monitor.RaceData
{
    public class Athlete : Subject
    {
        public override int BibNumber {get; set;}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
      
        public Dictionary<Observer, int> observers = new Dictionary<Observer, int>();

        public Athlete(int bib, string first, string last, string gender, int age)
        {
            BibNumber = bib;
            FirstName = first;
            LastName = last;
            Gender = gender;
            Age = age;
        }

        public Athlete(int bib)
        {
            BibNumber = bib;
        }

        public override void RegisterObserver(Observer o) 
        {
            observers.Add(o, BibNumber);
        }
        public override void RemoveObserver(Observer o)
        {
            observers.Remove(o);
        }
        public override void NotifyObservers(AthleteUpdate update)
        {
            foreach(KeyValuePair<Observer, int> obs in observers)
            {
                //if(update.BibNumber == obs.Value)
                //{
                //    obs.Key.Update(update);
                //}
                obs.Key.Update(update);
            }
        }
        
    }
}
