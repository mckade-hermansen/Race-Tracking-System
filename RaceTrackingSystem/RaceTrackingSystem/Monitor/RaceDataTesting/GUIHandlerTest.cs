using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GUI;
using RaceTrackingSystem.Monitor.RaceData;
using RaceData.Messages;

namespace RaceTrackingSystem.Monitor.RaceDataTesting
{
    [TestClass]
    class GUIHandlerTest
    {

        [TestMethod]
        public void TestHandler()
        {
            var handler = new GUIHandler();
            handler.AddAthlete(new Athlete(3));

            Assert.AreEqual(handler.subjects[0].BibNumber, 3);

        }
    }
}
