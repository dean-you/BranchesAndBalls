using Microsoft.VisualStudio.TestTools.UnitTesting;
using BranchesAndBalls;
using System;
using System.Collections.Generic;
using System.Text;

namespace BranchesAndBalls.Tests
{
    [TestClass()]
    public class BranchesAndBallTests
    {
        [TestInitialize()]
        public void Startup() {
        }

        [TestCleanup()]
        public void Cleanup() {
        }

        [TestMethod()]
        public void PredictTest() {
            var system = new BranchesAndBall(4, false);
            var result = system.Predict();
            Assert.AreEqual(16, result);
        }

        [TestMethod()]
        public void RunBallsTest() {
            var system = new BranchesAndBall(4, false);
            var result = system.RunBalls();
            Assert.AreEqual(16, result);
        }
    }
}