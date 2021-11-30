using GameStore.Models;
using NUnit.Framework;
using System;

namespace GameStore.Tests
{
    [TestFixture]
    class FriendModelTests
    {
        [Test]
        public void CreateFriend_InputId0_OutputId0()
        {
            //arrange
            int inId = 0;
            int inPersonOneId;
            int inPersonTwoId;
            Person personOne;
            Person personTwo;

            var expected = inId;

            Friend t = new Friend();
            //act

            t.Id = inId;
            var actual = t.Id;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateFriend_InputId878_OutputId878()
        {
            //arrange
            int inId = 878;
            int inPersonOneId;
            int inPersonTwoId;
            Person personOne;
            Person personTwo;

            var expected = inId;

            Friend t = new Friend();
            //act

            t.Id = inId;
            var actual = t.Id;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateFriend_InputIdNegative200_OutputIdNegative200()
        {
            //arrange
            int inId = -200;
            int inPersonOneId;
            int inPersonTwoId;
            Person personOne;
            Person personTwo;

            var expected = inId;

            Friend t = new Friend();
            //act

            t.Id = inId;
            var actual = t.Id;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateFriend_InputPersonOneId2_OutputPersonOneId2()
        {
            //arrange
            int inId = -200;
            int inPersonOneId = 2;
            int inPersonTwoId;
            Person personOne;
            Person personTwo;

            var expected = inPersonOneId;

            Friend t = new Friend();
            //act

            t.personOneId = inPersonOneId;
            var actual = t.personOneId;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateFriend_InputPersonOneId99_OutputPersonOneId99()
        {
            //arrange
            int inId = -200;
            int inPersonOneId = 99;
            int inPersonTwoId;
            Person personOne;
            Person personTwo;

            var expected = inPersonOneId;

            Friend t = new Friend();
            //act

            t.personOneId = inPersonOneId;
            var actual = t.personOneId;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateFriend_InputPersonOneId100_OutputPersonOneId100()
        {
            //arrange
            int inId = -200;
            int inPersonOneId = 100;
            int inPersonTwoId;
            Person personOne;
            Person personTwo;

            var expected = inPersonOneId;

            Friend t = new Friend();
            //act

            t.personOneId = inPersonOneId;
            var actual = t.personOneId;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateFriend_InputPersonTwoId20_OutputPersonTwoId20()
        {
            //arrange
            int inId = -200;
            int inPersonOneId = 2;
            int inPersonTwoId = 20;
            Person personOne;
            Person personTwo;

            var expected = inPersonTwoId;

            Friend t = new Friend();
            //act

            t.personTwoId = inPersonTwoId;
            var actual = t.personTwoId;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateFriend_InputPersonTwoId11122999_OutputPersonTwoId11122999()
        {
            //arrange
            int inId = -200;
            int inPersonOneId = 2;
            int inPersonTwoId = 11122999;
            Person personOne;
            Person personTwo;

            var expected = inPersonTwoId;

            Friend t = new Friend();
            //act

            t.personTwoId = inPersonTwoId;
            var actual = t.personTwoId;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateFriend_InputPersonTwoId19_OutputPersonTwoId19()
        {
            //arrange
            int inId = -200;
            int inPersonOneId = 2;
            int inPersonTwoId = 19;
            Person personOne;
            Person personTwo;

            var expected = inPersonTwoId;

            Friend t = new Friend();
            //act

            t.personTwoId = inPersonTwoId;
            var actual = t.personTwoId;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateFriend_InputNewPerson_OutputNewPerson()
        {
            //arrange
            int inId = -200;
            int inPersonOneId = 2;
            int inPersonTwoId = 19;
            Person personOne = new Person();
            Person personTwo;

            var expected = personOne;

            Friend t = new Friend();
            //act

            t.Person = personOne;
            var actual = t.Person;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateFriend_InputNewPersonNameFrenk_OutputNewPersonNameFrenk()
        {
            //arrange
            int inId = -200;
            int inPersonOneId = 2;
            int inPersonTwoId = 19;
            Person personOne = new Person();
            personOne.GivenName = "Frenk";
            Person personTwo;

            var expected = personOne.GivenName;

            Friend t = new Friend();
            //act

            t.Person = personOne;
            var actual = t.Person.GivenName;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateFriend_InputNewPersonNameGerge_OutputNewPersonNewGerge()
        {
            //arrange
            int inId = -200;
            int inPersonOneId = 2;
            int inPersonTwoId = 19;
            Person personOne = new Person();
            personOne.GivenName = "Gerge";
            Person personTwo;

            var expected = personOne.GivenName;

            Friend t = new Friend();
            //act

            t.Person = personOne;
            var actual = t.Person.GivenName;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateFriend_InputNewPerson1_OutputNewPerson1()
        {
            //arrange
            int inId = -200;
            int inPersonOneId = 2;
            int inPersonTwoId = 19;
            Person personOne;
            Person personTwo = new Person();

            var expected = personTwo;

            Friend t = new Friend();
            //act

            t.Person1 = personTwo;
            var actual = t.Person1;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateFriend_InputNewPerson1Id444_OutputNewPerson1Id444()
        {
            //arrange
            int inId = -200;
            int inPersonOneId = 2;
            int inPersonTwoId = 19;
            Person personOne;
            Person personTwo = new Person();
            personTwo.Id = 444;

            var expected = personTwo.Id;

            Friend t = new Friend();
            //act

            t.Person1 = personTwo;
            var actual = t.Person1.Id;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateFriend_InputNewPerson1PasswordMoreTest_OutputNewPerson1PasswordMoreTests()
        {
            //arrange
            int inId = -200;
            int inPersonOneId = 2;
            int inPersonTwoId = 19;
            Person personOne;
            Person personTwo = new Person();
            personTwo.Password = "MoreTests";

            var expected = personTwo.Password;

            Friend t = new Friend();
            //act

            t.Person1 = personTwo;
            var actual = t.Person1.Password;

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
