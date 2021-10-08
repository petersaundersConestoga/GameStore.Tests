using NUnit.Framework;

namespace GameStore.Tests
{
    public class GameModelTests
    {
        [Test]
        public void CreateGame_InputEmptyString_OutputEmptyString()
        {
            //arrange
            string input = "";
            string actual;
            string expected = "";
            Models.Game g = new Models.Game();

            //act
            g.GameStatusCode = input;
            actual = g.GameStatusCode;

            //assert
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void CreateGame_InputNothing_OutputNothing()
        {
            //arrange
            string actual;
            string expected = null;
            Models.Game g = new Models.Game();

            //act
            actual = g.GameStatusCode;

            //assert
            Assert.AreEqual(actual, expected);
        }
    }
}