using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GUI;
using RaceData.Messages;
using RaceTrackingSystem.Monitor.RaceData;

namespace RaceTrackingSystem.Monitor.RaceDataTesting
{
    [TestClass]
    class UpdateTest
    {

        [TestMethod]
        public void RunTests()
        {
            GUIHandler handler = new GUIHandler();
            handler.AddAthlete(new Athlete(4));

            var finished = new FinishedUpdate();
            handler.updateObservers(finished);
            Athlete temp = (Athlete)handler.subjects[0];
            Assert.AreEqual(temp.observers.Count, 1);
        }
    }
}
