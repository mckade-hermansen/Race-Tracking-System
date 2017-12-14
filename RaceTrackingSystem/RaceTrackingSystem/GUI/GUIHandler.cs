using System;
using System.Windows.Forms;
using System.Collections.Generic;
using RaceTrackingSystem.Monitor.RaceData;
using AppLayer;
using System.Threading;
using RaceData.Messages;

namespace GUI
{
    public class GUIHandler
    {
        public List<Subject> subjects = new List<Subject>();
        private ControlForm controlF;
        private System.Object _lock = new System.Object();
        private static object syncLock = new object();

        public GUIHandler()
        {
            controlF = new ControlForm(this);
        }

        public void ShowControlForm()
        {
            Application.EnableVisualStyles();
			Application.Run(controlF);
        }

        public void AddAthlete(Subject ath)
        {
            lock (syncLock)
            {
                subjects.Add(ath);
                controlF.RefreshAthletes();
            }
        }

        public void updateObservers(AthleteUpdate update)
        {
            //sub.NotifyObservers(update);
            foreach(Subject sub in subjects)
            {
                if (sub.BibNumber == update.BibNumber)
                {
                    sub.NotifyObservers(update);
                }
            }
        }
    }
}
