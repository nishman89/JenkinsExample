using NUnit.Framework;
using SafariParkApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkTests
{
    public class VehicleTests
    {
        [Test]
        public void WhenADefaultVehicleIsConstructedItsPositionIsZero()
        {
            Vehicle v = new Vehicle();
            Assert.AreEqual(0, v.Position);
        }

        [Test]
        public void WhenADefaultVehicleMovesTwiceItsPositionIs20()
        {
            Vehicle v = new Vehicle();
            var result = v.Move(2);
            Assert.AreEqual(20, v.Position);
            Assert.AreEqual("Moving along 2 times", result);
        }

        [Test]
        public void WhenAVehicleWithSpeed40IsMovedOnceItsPositionIs40()
        {
            Vehicle v = new Vehicle(5, 40);
            var result = v.Move();
            Assert.AreEqual(40, v.Position);
            Assert.AreEqual("Moving along", result);
        }

        [TestCase(-1, 0)] //no. of passengers = -1, expect 0
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(3, 3)]
        [TestCase(5, 5)]
        [TestCase(6, 5)] //no. of passengers = 6, despite the capacity being 5. The expeted no
        public void VehicleCapacityTests(int numPassengers, int expectedPassengers)
        {
            Vehicle v = new Vehicle(5)
            {
                NumPassengers = numPassengers
            };
            Assert.AreEqual(expectedPassengers, v.NumPassengers);
        }
    }
}
