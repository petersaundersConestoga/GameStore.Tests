using GameStore.Models;
using NUnit.Framework;
using System;

namespace GameStore.Tests
{
    [TestFixture]
    class EventModelTests
    {
        [Test]
        public void CreateEvent_InputIdZero_OutputIdZero()
        {
            //arrange
            int inId = 0;
            string inName;
            DateTime inDateStart;
            DateTime inDateEnd;
            int inAttendeeList;
            string inDescription;
            string inLocation;

            int actual;
            int expected = 0;

            Event e = new Event();
            //act

            e.Id = inId;
            actual = e.Id;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CreateEvent_InputIdNegativeOne_OutputIdNegativeOne()
        {
            //arrange
            int inId = -1;
            string inName;
            DateTime inDateStart;
            DateTime inDateEnd;
            int inAttendeeList;
            string inDescription;
            string inLocation;

            int actual;
            int expected = -1;

            Event e = new Event();
            //act

            e.Id = inId;
            actual = e.Id;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CreateEvent_InputId4444_OutputId4444()
        {
            //arrange
            int inId = 4444;
            string inName;
            DateTime inDateStart;
            DateTime inDateEnd;
            int inAttendeeList;
            string inDescription;
            string inLocation;

            int actual;
            int expected = 4444;

            Event e = new Event();
            //act

            e.Id = inId;
            actual = e.Id;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CreateEvent_InputNameEmpty_OutputNameEmpty()
        {
            //arrange
            int inId = 0;
            string inName = "";
            DateTime inDateStart;
            DateTime inDateEnd;
            int inAttendeeList;
            string inDescription;
            string inLocation;

            var expected = "";

            Event e = new Event();
            //act

            e.name = inName;
            var actual = e.name;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateEvent_InputNameHalloween2020_OutputNameHalloween2020()
        {
            //arrange
            int inId = 0;
            string inName = "Halloween2020";
            DateTime inDateStart;
            DateTime inDateEnd;
            int inAttendeeList;
            string inDescription;
            string inLocation;

            var expected = inName;

            Event e = new Event();
            //act

            e.name = inName;
            var actual = e.name;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateEvent_InputNameXMassMassGiveaway_OutputNameXMassMassGiveaway()
        {
            //arrange
            int inId = 0;
            string inName = "XMass Mass Giveaway";
            DateTime inDateStart;
            DateTime inDateEnd;
            int inAttendeeList;
            string inDescription;
            string inLocation;

            var expected = inName;

            Event e = new Event();
            //act

            e.name = inName;
            var actual = e.name;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateEvent_InputDateStartYear1999Month11Day1_OutputDateStartYear1999Month11Day1()
        {
            //arrange
            int inId = 0;
            string inName = "";
            DateTime inDateStart = new DateTime(1999, 11, 1);
            DateTime inDateEnd;
            int inAttendeeList;
            string inDescription;
            string inLocation;

            var expected = inDateStart;

            Event e = new Event();
            //act

            e.dateStart = inDateStart;
            var actual = e.dateStart;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateEvent_InputDateStartYear0Month0Day0_OutputArgumentOutOfRangeException()
        {
            //arrange

            //assert
            Assert.Throws(typeof(ArgumentOutOfRangeException), () => new DateTime(0, 0, 0));
        }
        [Test]
        public void CreateEvent_InputDateStartYear2040Month11Day1_OutputDateStartYear2040Month11Day1()
        {
            //arrange
            int inId = 0;
            string inName = "";
            DateTime inDateStart = new DateTime(2040, 11, 1);
            DateTime inDateEnd;
            int inAttendeeList;
            string inDescription;
            string inLocation;

            var expected = inDateStart;

            Event e = new Event();
            //act

            e.dateStart = inDateStart;
            var actual = e.dateStart;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateEvent_InputDateEndYear1999Month11Day1_OutputDateEndYear1999Month11Day1()
        {
            //arrange
            int inId = 0;
            string inName = "";
            DateTime inDateStart;
            DateTime inDateEnd = new DateTime(1999, 11, 1);
            int inAttendeeList;
            string inDescription;
            string inLocation;

            var expected = inDateEnd;

            Event e = new Event();
            //act

            e.dateEnd = inDateEnd;
            var actual = e.dateEnd;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateEvent_InputDateEndYear1856Month1Day2_OutputDateEndYear1856Month1Day2()
        {
            //arrange
            int inId = 0;
            string inName = "";
            DateTime inDateStart;
            DateTime inDateEnd = new DateTime(1856, 1, 2);
            int inAttendeeList;
            string inDescription;
            string inLocation;

            var expected = inDateEnd;

            Event e = new Event();
            //act

            e.dateEnd = inDateEnd;
            var actual = e.dateEnd;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateEvent_InputDateEndYear500Month6Day4_OutputDateEndYear500Month6Day4()
        {
            //arrange
            int inId = 0;
            string inName = "";
            DateTime inDateStart;
            DateTime inDateEnd = new DateTime(500, 6, 5);
            int inAttendeeList;
            string inDescription;
            string inLocation;

            var expected = inDateEnd;

            Event e = new Event();
            //act

            e.dateEnd = inDateEnd;
            var actual = e.dateEnd;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateEvent_InputAttendeeList0_OutputAttendeeList0()
        {
            //arrange
            int inId = 0;
            string inName = "";
            DateTime inDateStart;
            DateTime inDateEnd;
            int inAttendeeList = 0;
            string inDescription;
            string inLocation;

            var expected = inAttendeeList;

            Event e = new Event();
            //act

            e.attendeeList = inAttendeeList;
            var actual = e.attendeeList;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateEvent_InputAttendeeListNegative4_OutputAttendeeListNegative4()
        {
            //arrange
            int inId = 0;
            string inName = "";
            DateTime inDateStart;
            DateTime inDateEnd;
            int inAttendeeList = -4;
            string inDescription;
            string inLocation;

            var expected = inAttendeeList;

            Event e = new Event();
            //act

            e.attendeeList = inAttendeeList;
            var actual = e.attendeeList;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateEvent_InputAttendeeList999_OutputAttendeeList999()
        {
            //arrange
            int inId = 0;
            string inName = "";
            DateTime inDateStart;
            DateTime inDateEnd;
            int inAttendeeList = 999;
            string inDescription;
            string inLocation;

            var expected = inAttendeeList;

            Event e = new Event();
            //act

            e.attendeeList = inAttendeeList;
            var actual = e.attendeeList;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateEvent_InputDescriptionHallowBashYall_OutputDescriptionHalloweenBashYall()
        {
            //arrange
            int inId = 0;
            string inName = "";
            DateTime inDateStart;
            DateTime inDateEnd;
            int inAttendeeList;
            string inDescription = "Halloween Bash Yall";
            string inLocation;

            var expected = inDescription;

            Event e = new Event();
            //act

            e.description = inDescription;
            var actual = e.description;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateEvent_InputDescriptionEasterAtCVGS_OutputDescriptionEasterAtCVGS()
        {
            //arrange
            int inId = 0;
            string inName = "";
            DateTime inDateStart;
            DateTime inDateEnd;
            int inAttendeeList;
            string inDescription = "Easter At CVGS";
            string inLocation;

            var expected = inDescription;

            Event e = new Event();
            //act

            e.description = inDescription;
            var actual = e.description;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateEvent_InputDescriptionBigBadChristmasBash_OutputDescriptionBigBadChristmasBash()
        {
            //arrange
            int inId = 0;
            string inName = "";
            DateTime inDateStart;
            DateTime inDateEnd;
            int inAttendeeList;
            string inDescription = "Big Bad Christmas Bash";
            string inLocation;

            var expected = inDescription;

            Event e = new Event();
            //act

            e.description = inDescription;
            var actual = e.description;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateEvent_InputLocationEmpty_OutputLocationEmpty()
        {
            //arrange
            int inId = 0;
            string inName = "";
            DateTime inDateStart;
            DateTime inDateEnd;
            int inAttendeeList;
            string inDescription;
            string inLocation = "";

            var expected = inLocation;

            Event e = new Event();
            //act

            e.location = inLocation;
            var actual = e.location;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateEvent_InputLocationCVGSWaterloo_OutputLocationCVGSWaterloo()
        {
            //arrange
            int inId = 0;
            string inName = "";
            DateTime inDateStart;
            DateTime inDateEnd;
            int inAttendeeList;
            string inDescription;
            string inLocation = "CVGS Waterloo";

            var expected = inLocation;

            Event e = new Event();
            //act

            e.location = inLocation;
            var actual = e.location;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateEvent_InputLocationArea51_OutputLocationArea51()
        {
            //arrange
            int inId = 0;
            string inName = "";
            DateTime inDateStart;
            DateTime inDateEnd;
            int inAttendeeList;
            string inDescription;
            string inLocation = "Area 51";

            var expected = inLocation;

            Event e = new Event();
            //act

            e.location = inLocation;
            var actual = e.location;

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
