using GameStore.Models;
using NUnit.Framework;
using System;

namespace GameStore.Tests
{
    [TestFixture]
    class CartModelTests
    {
        [Test]
        public void CreateCart_InputId0_OutputId0()
        {
            //arrange
            int inId = 0;
            int inPersonId;
            int inGuid;
            Person inPerson;

            var expected = inId;

            Cart t = new Cart();
            //act

            t.Id = inId;
            var actual = t.Id;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateCart_InputId1_OutputId1()
        {
            //arrange
            int inId = 1;
            int inPersonId;
            int inGuid;
            Person inPerson;

            var expected = inId;

            Cart t = new Cart();
            //act

            t.Id = inId;
            var actual = t.Id;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateCart_InputId1122334455_OutputId1122334455()
        {
            //arrange
            int inId = 1122334455;
            int inPersonId;
            int inGuid;
            Person inPerson;

            var expected = inId;

            Cart t = new Cart();
            //act

            t.Id = inId;
            var actual = t.Id;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateCart_InputPersonId0_OutputPersonId0()
        {
            //arrange
            int inId = 0;
            int inPersonId = 0;
            int inGuid;
            Person inPerson;

            var expected = inPersonId;

            Cart t = new Cart();
            //act

            t.personId = inPersonId;
            var actual = t.personId;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateCart_InputPersonIdNegative444_OutputPersonIdNegative444()
        {
            //arrange
            int inId = 0;
            int inPersonId = -444;
            int inGuid;
            Person inPerson;

            var expected = inPersonId;

            Cart t = new Cart();
            //act

            t.personId = inPersonId;
            var actual = t.personId;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateCart_InputPersonId1000_OutputPersonId1000()
        {
            //arrange
            int inId = 0;
            int inPersonId = 1000;
            Guid inGuid;
            Person inPerson;

            var expected = inPersonId;

            Cart t = new Cart();
            //act

            t.personId = inPersonId;
            var actual = t.personId;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateCart_InputGuidNewGuid_OutputGuidNewGuid()
        {
            //arrange
            int inId = 0;
            int inPersonId = 1000;
            Guid inGuid = new Guid();
            Person inPerson;

            var expected = inGuid;

            Cart t = new Cart();
            //act

            t.Guid = inGuid;
            var actual = t.Guid;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateCart_InputNewPerson_OutputNewPerson()
        {
            //arrange
            int inId = 0;
            int inPersonId = 1000;
            string inGuid;
            Person inPerson = new Person();

            var expected = inPerson;

            Cart t = new Cart();
            //act

            t.Person = inPerson;
            var actual = t.Person;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateCart_InputNewPersonNamedJon_OutputNewPersonNamedJon()
        {
            //arrange
            int inId = 0;
            int inPersonId = 1000;
            string inGuid;
            Person inPerson = new Person();
            inPerson.GivenName = "Jon";

            var expected = inPerson.GivenName;

            Cart t = new Cart();
            //act

            t.Person = inPerson;
            var actual = t.Person.GivenName;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateCart_InputNewPersonNewProvince_OutputNewPersonNewProvince()
        {
            //arrange
            int inId = 0;
            int inPersonId = 1000;
            string inGuid;
            Person inPerson = new Person();
            inPerson.Province = new Province();

            var expected = inPerson.Province;

            Cart t = new Cart();
            //act

            t.Person = inPerson;
            var actual = t.Person.Province;

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
