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
    }
}
