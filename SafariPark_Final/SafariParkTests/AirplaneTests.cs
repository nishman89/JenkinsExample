using NUnit.Framework;
using SafariParkApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkTests
{
    public class AirplaneTests
    {
        private Airplane a;

        [SetUp]
        public void SetUp()
        {
            a = new Airplane(200, 100, "JetsRUs") { NumPassengers = 150 };
        }

        [Test]
        public void WhenAirplaneAscendsBy500_NewAltitudeShouldBe500()
        {
            a.Ascend(500);
            var actual = a.Altitude;
            Assert.AreEqual(500, actual);
        }

        [Test]
        public void WhenAirplaneAscendsBy500_ThenDescendsby200_NewAltitudeShouldBe300()
        {
            a.Ascend(500);
            a.Descend(200);
            Assert.AreEqual(300, a.Altitude);
        }

        [Test]
        public void WhenAirplaneHasAltitudeOf0_ThenDescends100_ItsAltitudeShouldBe0()
        {
            a.Descend(500);
            Assert.AreEqual(0, a.Altitude);
        }

        [Test]
        public void WhenAirplaneAscends500_Move3_MoveTwice_MoveShouldReturnExpectedMessage()
        {
            a.Ascend(500);
            a.Move(3);
            a.Descend(200);
            a.Move();
            a.Move();
            var actual = a.ToString();
            var expected = "Thank you for flying JetsRUs: SafariParkApp.Airplane capacity: 200 passengers: 150 speed: 100 position: 500 altitude: 300.";
            Assert.AreEqual(expected, actual);
        }
        [Test]

        public void WhenAirplaneAscends500_AndMoves3Times_MoveShouldReturnCorrectMessage()
        {
            a.Ascend(500);
            a.Move(3);

            var actual = a.Move(3);

            var expected = "Moving along 3 times at an altitude of 500 metres.";
            Assert.AreEqual(expected, actual);
        }

        [Test]

        public void WhenAirplaneAscend500andMove3Times_ToStringShouldShowCorrectReturnCorrectMessage()
        {
            a.Ascend(500);
            a.Move(3);

            var actual = a.ToString();

            var expected = "Thank you for flying JetsRUs: SafariParkApp.Airplane capacity: 200 passengers: 150 speed: 100 position: 300 altitude: 500.";
            Assert.AreEqual(expected, actual);
        }

        [Test]

        public void WhenAirplaneAscend500Move3TimesDescend200_MoveShouldReturnCorrectMessage()
        {
            a.Ascend(500);
            a.Move(3);
            a.Descend(200);

            var actual = a.Move();

            var expected = "Moving along at an altitude of 300 metres.";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void WhenAirplaneAscend500andMove3TimesDescend200_WhenAirplaneAscend500Move3TimesDescend200_MoveShouldReturnCorrectMessage()
        {
            a.Ascend(500);
            a.Move(3);
            a.Descend(200);
            a.Move();
            a.Move();
            var actual = a.ToString();
            var expected = "Thank you for flying JetsRUs: SafariParkApp.Airplane capacity: 200 passengers: 150 speed: 100 position: 500 altitude: 300.";
            Assert.AreEqual(expected, actual);
        }
    }
}
