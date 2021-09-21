using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Robot.Common;

namespace YuliiaVanchytska.RobotChallenge.Test
{
    [TestClass]
    public class TestChecker
    {
        [TestMethod]
        public void TestIsCellFreeFromOthers()
        {
            Robot.Common.Robot currentRobot = new Robot.Common.Robot()
            {
                Position = new Position(2, 2)
            };
            Position cellPos = new Position(3, 2);

            Robot.Common.Robot testRobot1 = new Robot.Common.Robot() { Position = new Position(3, 5) };
            Robot.Common.Robot testRobot2 = new Robot.Common.Robot() { Position = new Position(3, 4) };
            Robot.Common.Robot testRobot3 = new Robot.Common.Robot() { Position = new Position(4, 4) };
            Robot.Common.Robot testRobot4 = new Robot.Common.Robot() { Position = new Position(2, 4) };            List<Robot.Common.Robot> robots = new List<Robot.Common.Robot>
            {
                testRobot1,
                testRobot2,
                testRobot3,
                testRobot4
            };            bool testRes = Checker.IsCellFreeFromOthers(cellPos, currentRobot, robots);            Assert.IsTrue(testRes);
        }
        [TestMethod]
        public void TestIsStationFree()
        {
            Robot.Common.Robot currentRobot = new Robot.Common.Robot()
            {
                Position = new Position(2, 2)
            };
            EnergyStation curEnergyStation = new EnergyStation()
            {
                Position = new Position(5, 5)
            };
            
            Robot.Common.Robot testRobot1 = new Robot.Common.Robot() { Position = new Position(3, 5) };
            Robot.Common.Robot testRobot2 = new Robot.Common.Robot() { Position = new Position(13, 4) };
            Robot.Common.Robot testRobot3 = new Robot.Common.Robot() { Position = new Position(6, 6) };
            Robot.Common.Robot testRobot4 = new Robot.Common.Robot() { Position = new Position(2, 4) };
            List<Robot.Common.Robot> robots = new List<Robot.Common.Robot>
            {
                testRobot1,
                testRobot2,
                testRobot3,
                testRobot4
            };

            bool testRes = Checker.isStationFree(curEnergyStation.Position, currentRobot, robots);
            Assert.IsFalse(testRes);
        }
        [TestMethod]
        public void TestIsNearTheStation()
        {
            Robot.Common.Robot currentRobot = new Robot.Common.Robot()
            {
                Position = new Position(2, 2)
            };
            Map map = new Map()
            {
                MinPozition = new Position(0, 0), MaxPozition = new Position(99, 99)
            };
            EnergyStation curEnergyStation = new EnergyStation()
            {
                Position = new Position(4, 3)
            };
            Robot.Common.Robot testRobot1 = new Robot.Common.Robot() { Position = new Position(20, 5) };
            Robot.Common.Robot testRobot2 = new Robot.Common.Robot() { Position = new Position(13, 4) };
            Robot.Common.Robot testRobot3 = new Robot.Common.Robot() { Position = new Position(6, 6) };
            Robot.Common.Robot testRobot4 = new Robot.Common.Robot() { Position = new Position(1, 4) };
            List<Robot.Common.Robot> robots = new List<Robot.Common.Robot>
            {
                testRobot1,
                testRobot2,
                testRobot3,
                testRobot4
            };

            bool testRes = Checker.IsNearTheStation(currentRobot, map, robots);

            Assert.IsTrue(testRes);
        }
        [TestMethod]
        public void TestFindDistance()
        {
            Position a = new Position(2, 3);
            Position b = new Position(4, 1);

            int testRes = DistanceHelper.FindDistance(a, b);
            int expectedRes = 8;

            Assert.AreEqual(expectedRes, testRes);
        }
        [TestMethod]
        public void TestFindEnemies()
        {

        }
    }
    
}
