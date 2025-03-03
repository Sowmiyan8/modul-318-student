﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace SwissTransport
{
    [TestClass]
    public class TransportTest
    {
        private ITransport testee;

        [TestMethod]
        public void Locations()
        {
            testee = new Transport();
            var stations = testee.GetStations("Sursee,");

            Assert.AreEqual(10, stations.StationList.Count);
        }

        [TestMethod]
        public void Id()
        {
            testee = new Transport();
            string id = testee.GetStations("Luzern").StationList.ElementAt(0).Id;

            Assert.IsNotNull(id);
        }


        [TestMethod]
        public void StationBoard()
        {
            testee = new Transport();
            var stationBoard = testee.GetStationBoard("Sursee", "8502007");

            Assert.IsNotNull(stationBoard);
        }

        [TestMethod]
        public void Connections()
        {
            testee = new Transport();
            var connections = testee.GetConnections("Sursee", "Luzern", "2019-12-17", "00:00");

            Assert.IsNotNull(connections);
        }
    }
}
