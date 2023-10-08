using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Tests
{
    [TestClass()]
    public class CalculateTests
    {
        /*[TestMethod()]
        [DataRow(25, 3, 75)]

        public void CalculateSpeedTest(double speed, double time, double result)
        {
            var ray = Calculate.CalculateSpeed(speed, time);

            Assert.AreEqual(result, ray);
        }*/

        [TestMethod()]
        [DataRow(26, 3, 75)]
        public void CalculateSpeedTest1(double speed, double time, double result)
        {
            var ray = Calculate.CalculateSpeed(speed, time);

            Assert.AreEqual(result, ray);
            
        }

        [TestMethod()]
        [DataRow(-25)]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculateSpeedTest2(double speed)
        {
            Calculate.CheckValues(speed);


        }
    }
}