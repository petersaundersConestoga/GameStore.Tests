using System;
using GameStore.Models;
using NUnit.Framework;
using System;

namespace GameStore.Tests
{
    [TestFixture]
    class WishlistModelTests
    {
        [Test]
        public void CreateWishlist_InputId0_OutputId0()
        {
            //arrange
            int inId = 0;
            int inPerson;
            int inGuid;
            Game game;
            Person person;

            var expected = inId;

            Wishlist t = new Wishlist();
            //act

            t.Id = inId;
            var actual = t.Id;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateWishlist_InputId101010101_OutputId101010101()
        {
            //arrange
            int inId = 101010101;
            int inPerson;
            int inGuid;
            Game game;
            Person person;

            var expected = inId;

            Wishlist t = new Wishlist();
            //act

            t.Id = inId;
            var actual = t.Id;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateWishlist_InputId1119999192_OutputId1119999192()
        {
            //arrange
            int inId = 1119999192;
            int inPerson;
            int inGuid;
            Game game;
            Person person;

            var expected = inId;

            Wishlist t = new Wishlist();
            //act

            t.Id = inId;
            var actual = t.Id;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateWishlist_InputNewPersonId959950923_OutputNewPersonId959950923()
        {
            //arrange
            int inId = 1119999192;
            int inPersonId = 959950923;
            Guid inGuid;
            Game game;
            Person person;

            var expected = inPersonId;

            Wishlist t = new Wishlist();
            //act

            t.personId = inPersonId;
            var actual = t.personId;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateWishlist_InputNewPersonId9912_OutputNewPersonId9912()
        {
            //arrange
            int inId = 1119999192;
            int inPersonId = 9912;
            Guid inGuid;
            Game game;
            Person person;

            var expected = inPersonId;

            Wishlist t = new Wishlist();
            //act

            t.personId = inPersonId;
            var actual = t.personId;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateWishlist_InputNewPersonIdNegative12298423_OutputNewPersonIdNegative12298423()
        {
            //arrange
            int inId = 1119999192;
            int inPersonId = -12298423;
            Guid inGuid;
            Game game;
            Person person;

            var expected = inPersonId;

            Wishlist t = new Wishlist();
            //act

            t.personId = inPersonId;
            var actual = t.personId;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateWishlist_InputNewGuid_OutputNewGuid()
        {
            //arrange
            int inId = 1119999192;
            int inPersonId = -12298423;
            Guid inGuid = new Guid();
            Game game;
            Person person;

            var expected = inGuid;

            Wishlist t = new Wishlist();
            //act

            t.Guid = inGuid;
            var actual = t.Guid;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateWishlist_InputNewGame_OutputNewGame()
        {
            //arrange
            int inId = 1119999192;
            int inPersonId = -12298423;
            Guid inGuid = new Guid();
            Game inGame = new Game();
            Person person;

            var expected = inGame;

            Wishlist t = new Wishlist();
            //act

            t.Game = inGame;
            var actual = t.Game;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateWishlist_InputNewGameFrenchPlayerCount44_OutputNewGameFrenchPlayerCount44()
        {
            //arrange
            int inId = 1119999192;
            int inPersonId = -12298423;
            Guid inGuid = new Guid();
            Game inGame = new Game();
            inGame.FrenchPlayerCount = "44";
            Person person;

            var expected = inGame.FrenchPlayerCount;

            Wishlist t = new Wishlist();
            //act

            t.Game = inGame;
            var actual = t.Game.FrenchPlayerCount;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateWishlist_InputNewGameNewGameCategory_OutputNewGameNewGameCategory()
        {
            //arrange
            int inId = 1119999192;
            int inPersonId = -12298423;
            Guid inGuid = new Guid();
            Game inGame = new Game();
            inGame.GameCategory = new GameCategory();
            Person person;

            var expected = inGame.GameCategory;

            Wishlist t = new Wishlist();
            //act

            t.Game = inGame;
            var actual = t.Game.GameCategory;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateWishlist_InputNewPerson_OutputNewGameNewPerson()
        {
            //arrange
            int inId = 1119999192;
            int inPersonId = -12298423;
            Guid inGuid = new Guid();
            Game inGame = new Game();
            inGame.GameCategory = new GameCategory();
            Person inPerson = new Person();

            var expected = inPerson;

            Wishlist t = new Wishlist();
            //act

            t.Person = inPerson;
            var actual = t.Person;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateWishlist_InputNewPersonNameAlfi_OutputNewGameNewPersonNameAfli()
        {
            //arrange
            int inId = 1119999192;
            int inPersonId = -12298423;
            Guid inGuid = new Guid();
            Game inGame = new Game();
            Person inPerson = new Person();
            inPerson.GivenName = "Alfi";

            var expected = inPerson.GivenName;

            Wishlist t = new Wishlist();
            //act

            t.Person = inPerson;
            var actual = t.Person.GivenName;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CreateWishlist_InputNewPersonPostalnnn222_OutputNewGameNewPersonPostalnnn222()
        {
            //arrange
            int inId = 1119999192;
            int inPersonId = -12298423;
            Guid inGuid = new Guid();
            Game inGame = new Game();
            inGame.GameCategory = new GameCategory();
            Person inPerson = new Person();
            inPerson.PostalCode = "nnn222";

            var expected = inPerson.PostalCode;

            Wishlist t = new Wishlist();
            //act

            t.Person = inPerson;
            var actual = t.Person.PostalCode;

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
