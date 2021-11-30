using System;
using GameStore.Models;
using NUnit.Framework;
using System;

namespace GameStore.Tests
{
    [TestFixture]
    class AttendeeListModelTests
    {
        [Test]
        public void CreateAttendeeList_InputId0_OutputId0()
        {
            //arrange
            int inId = 0;
            int inEventId;
            int inPersonId;
            Event inEvent;
            Person inPerson;

            var expected = inId;

            AttendeeList t = new AttendeeList();
            //act

            t.Id = inId;
            var actual = t.Id;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateAttendeeList_InputId3934939_OutputId3934939()
        {
            //arrange
            int inId = 3934939;
            int inEventId;
            int inPersonId;
            Event inEvent;
            Person inPerson;

            var expected = inId;

            AttendeeList t = new AttendeeList();
            //act

            t.Id = inId;
            var actual = t.Id;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateAttendeeList_InputId99992210_OutputId99992210()
        {
            //arrange
            int inId = 99992210;
            int inEventId;
            int inPersonId;
            Event inEvent;
            Person inPerson;

            var expected = inId;

            AttendeeList t = new AttendeeList();
            //act

            t.Id = inId;
            var actual = t.Id;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateAttendeeList_InputEventId99992210_OutputEventId99992210()
        {
            //arrange
            int inId = 99992210;
            int inEventId = 99992210;
            int inPersonId;
            Event inEvent;
            Person inPerson;

            var expected = inId;

            AttendeeList t = new AttendeeList();
            //act

            t.Id = inId;
            var actual = t.Id;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateAttendeeList_InputEventId0000_OutputEventId0()
        {
            //arrange
            int inId = 99992210;
            int inEventId = 0000;
            int inPersonId;
            Event inEvent;
            Person inPerson;

            var expected = 0;

            AttendeeList t = new AttendeeList();
            //act

            t.eventId = inEventId;
            var actual = t.eventId;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateAttendeeList_InputEventIdNegative4_OutputEventIdNegative4()
        {
            //arrange
            int inId = 99992210;
            int inEventId = -4;
            int inPersonId;
            Event inEvent;
            Person inPerson;

            var expected = inEventId;

            AttendeeList t = new AttendeeList();
            //act

            t.eventId = inEventId;
            var actual = t.eventId;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateAttendeeList_InputPersonIdNegative1111_OutputPersonIdNegative1111()
        {
            //arrange
            int inId = 99992210;
            int inEventId = -4;
            int inPersonId = -1111;
            Event inEvent;
            Person inPerson;

            var expected = inPersonId;

            AttendeeList t = new AttendeeList();
            //act

            t.personId = inPersonId;
            var actual = t.personId;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateAttendeeList_InputPersonIdNegative0_OutputPersonId0()
        {
            //arrange
            int inId = 99992210;
            int inEventId = -4;
            int inPersonId = -0;
            Event inEvent;
            Person inPerson;

            var expected = 0;

            AttendeeList t = new AttendeeList();
            //act

            t.personId = inPersonId;
            var actual = t.personId;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateAttendeeList_InputPersonId9909123_OutputPersonId9909123()
        {
            //arrange
            int inId = 99992210;
            int inEventId = -4;
            int inPersonId = 9909123;
            Event inEvent;
            Person inPerson;

            var expected = inPersonId;

            AttendeeList t = new AttendeeList();
            //act

            t.personId = inPersonId;
            var actual = t.personId;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateAttendeeList_InputNewEvent_OutputNewEvent()
        {
            //arrange
            int inId = 99992210;
            int inEventId = -4;
            int inPersonId = 9909123;
            Event inEvent = new Event();
            Person inPerson;

            var expected = inEvent;

            AttendeeList t = new AttendeeList();
            //act

            t.Event = inEvent;
            var actual = t.Event;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateAttendeeList_InputNewPerson_OutputNewPerson()
        {
            //arrange
            int inId = 99992210;
            int inEventId = -4;
            int inPersonId = 9909123;
            Event inEvent = new Event();
            Person inPerson = new Person();

            var expected = inPerson;

            AttendeeList t = new AttendeeList();
            //act

            t.Person = inPerson;
            var actual = t.Person;

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
