using GameStore.Models;
using NUnit.Framework;
using System;

namespace GameStore.Tests
{
    [TestFixture]
    public class GameModelTests
    {
        [Test]
        public void CreateGame_InputNewGuid_OutputNewGuid()
        {
            //arrange
            Guid inGameGuid = new Guid();

            Type actual = null;
            Type expected = typeof(Guid);
            Game g = new Game();

            //act
            g.Guid = inGameGuid;
            actual = g.Guid.GetType();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CreateGame_InputEmptyStatusCode_OutputEmptyStatusCode()
        {
            //arrange
            string inGameStatusCode = "";
            string actual;
            string expected = "";
            Game g = new Models.Game();

            //act
            g.GameStatusCode = inGameStatusCode;
            actual = g.GameStatusCode;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CreateGame_InputStatusCodeABC_OutputStatusCodeABC()
        {
            //arrange
            string inGameStatusCode = "ABC";
            string actual;
            string expected = "ABC";
            Game g = new Game();

            //act
            g.GameStatusCode = inGameStatusCode;
            actual = g.GameStatusCode;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CreateGame_InputStatusCodeF_OutputStatusCodeF()
        {
            //arrange
            string inGameStatusCode = "F";
            string actual;
            string expected = "F";
            Game g = new Game();

            //act
            g.GameStatusCode = inGameStatusCode;
            actual = g.GameStatusCode;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CreateGame_InputCategoryId0_OutputCategory0()
        {
            //arrange
            int inGameCategoryId = 0;
            int actual;
            int expected = 0;
            Game g = new Game();

            //act
            g.GameCategoryId = inGameCategoryId;
            actual = g.GameCategoryId;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CreateGame_InputCategoryId22_OutputCategory22()
        {
            //arrange
            int inGameCategoryId = 22;
            int actual;
            int expected = 22;
            Game g = new Game();

            //act
            g.GameCategoryId = inGameCategoryId;
            actual = g.GameCategoryId;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CreateGame_InputCategoryId32789888_OutputCategory32789888()
        {
            //arrange
            int inGameCategoryId = 32789888;
            int actual;
            int expected = 32789888;
            Game g = new Game();

            //act
            g.GameCategoryId = inGameCategoryId;
            actual = g.GameCategoryId;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CreateGame_InputCategoryIdNegative2_OutputCategoryNegative2()
        {
            //arrange
            int inGameCategoryId = -2;
            int actual;
            int expected = -2;
            Game g = new Game();

            //act
            g.GameCategoryId = inGameCategoryId;
            actual = g.GameCategoryId;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CreateGame_InputSubCategoryIdNegative1_OutputSubCategoryNegative1()
        {
            //arrange
            int? inGameSubCategoryId = -1;
            int? actual;
            int? expected = -1;
            Game g = new Game();

            //act
            g.GameSubCategoryId = inGameSubCategoryId;
            actual = g.GameSubCategoryId;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CreateGame_InputSubCategoryId44_OutputSubCategory44()
        {
            //arrange
            int? inGameSubCategoryId = 44;
            int? actual;
            int? expected = 44;
            Game g = new Game();

            //act
            g.GameSubCategoryId = inGameSubCategoryId;
            actual = g.GameSubCategoryId;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CreateGame_InputSubCategoryIdNull_OutputSubCategoryNull()
        {
            //arrange
            int? inGameSubCategoryId = null;
            int? actual;
            int? expected = null;
            Game g = new Game();

            //act
            g.GameSubCategoryId = inGameSubCategoryId;
            actual = g.GameSubCategoryId;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CreateGame_InputEsrbRatingCodeA_OutputEsrbRatingCodeA()
        {
            //arrange
            string inEsrbRatingCode = "A";
            string actual;
            string expected = "A";
            Game g = new Game();

            //act
            g.EsrbRatingCode = inEsrbRatingCode;
            actual = g.EsrbRatingCode;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CreateGame_InputEsrbRatingCodeNull_OutputEsrbRatingCodeNull()
        {
            //arrange
            string inEsrbRatingCode = null;
            string actual;
            string expected = null;
            Game g = new Game();

            //act
            g.EsrbRatingCode = inEsrbRatingCode;
            actual = g.EsrbRatingCode;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CreateGame_InputEsrbRatingCodeE10Plus_OutputEsrbRatingCodeE10Plus()
        {
            //arrange
            string inEsrbRatingCode = "E10+";
            string actual;
            string expected = "E10+";
            Game g = new Game();

            //act
            g.EsrbRatingCode = inEsrbRatingCode;
            actual = g.EsrbRatingCode;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CreateGame_InputEnglishNameNull_OutputEnglishNameNull()
        {
            //arrange
            string input = null;
            string actual;
            string expected = null;
            Game g = new Game();

            //act
            g.EnglishName = input;
            actual = g.EnglishName;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CreateGame_InputEnglishNameFallout_4_OutputEnglishNameFallout_4()
        {
            //arrange
            string input = "Fallout 4";
            string actual;
            string expected = "Fallout 4";
            Game g = new Game();

            //act
            g.EnglishName = input;
            actual = g.EnglishName;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CreateGame_InputEnglishNameTombRaider_OutputEnglishNameTombRaider()
        {
            //arrange
            string input = "Tomb Raider";
            string actual;
            string expected = "Tomb Raider";
            Game g = new Game();

            //act
            g.EnglishName = input;
            actual = g.EnglishName;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CreateGame_InputFrenchNameNull_OutputFrenchNameNull()
        {
            //arrange
            string input = null;
            string actual;
            string expected = null;
            Game g = new Game();

            //act
            g.FrenchName = input;
            actual = g.FrenchName;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CreateGame_InputFrenchNameAMPED2_OutputFrenchNameAMPED2()
        {
            //arrange
            string input = "AMPED 2";
            string actual;
            string expected = "AMPED 2";
            Game g = new Game();

            //act
            g.FrenchName = input;
            actual = g.FrenchName;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CreateGame_InputFrenchNameHalo_OutputFrenchNameHalo()
        {
            //arrange
            string input = "Halo";
            string actual;
            string expected = "Halo";
            Game g = new Game();

            //act
            g.FrenchName = input;
            actual = g.FrenchName;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CreateGame_InputFrenchVersionTrue_OutputFrenchVersionTrue()
        {
            //arrange
            bool input = true;
            bool actual;
            bool expected = true;
            Game g = new Game();

            //act
            g.FrenchVersion = input;
            actual = g.FrenchVersion;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CreateGame_InputFrenchVersionFalse_OutputFrenchVersionFalse()
        {
            //arrange
            bool input = false;
            bool actual;
            bool expected = false;
            Game g = new Game();

            //act
            g.FrenchVersion = input;
            actual = g.FrenchVersion;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CreateGame_InputEnglishPlayerCountNull_OutputEnglishPlayerCountNull()
        {
            //arrange
            string input = null;
            string actual;
            string expected = null;
            Game g = new Game();

            //act
            g.EnglishPlayerCount = input;
            actual = g.EnglishPlayerCount;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CreateGame_InputEnglishPlayerCount1_OutputEnglishPlayerCount1()
        {
            //arrange
            string input = "1";
            string actual;
            string expected = "1";
            Game g = new Game();

            //act
            g.EnglishPlayerCount = input;
            actual = g.EnglishPlayerCount;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CreateGame_InputEnglishPlayerCount16_OutputEnglishPlayerCount16()
        {
            //arrange
            string input = "16";
            string actual;
            string expected = "16";
            Game g = new Game();

            //act
            g.EnglishPlayerCount = input;
            actual = g.EnglishPlayerCount;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CreateGame_InputFrenchPlayerCount4_OutputFrenchPlayerCount4()
        {
            //arrange
            string input = "4";
            string actual;
            string expected = "4";
            Game g = new Game();

            //act
            g.FrenchPlayerCount = input;
            actual = g.FrenchPlayerCount;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CreateGame_InputFrenchPlayerCount2_OutputFrenchPlayerCount2()
        {
            //arrange
            string input = "2";
            string actual;
            string expected = "2";
            Game g = new Game();

            //act
            g.FrenchPlayerCount = input;
            actual = g.FrenchPlayerCount;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CreateGame_InputFrenchPlayerCountNull_OutputFrenchPlayerCountNull()
        {
            //arrange
            string input = null;
            string actual;
            string expected = null;
            Game g = new Game();

            //act
            g.FrenchPlayerCount = input;
            actual = g.FrenchPlayerCount;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CreateGame_InputGamePerspectiveCodeNull_OutputGamePerspectiveCodeNull()
        {
            //arrange
            string input = null;
            string actual;
            string expected = null;
            Game g = new Game();

            //act
            g.GamePerspectiveCode = input;
            actual = g.GamePerspectiveCode;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CreateGame_InputGamePerspectiveCodeT_OutputGamePerspectiveCodeT()
        {
            //arrange
            string input = "T";
            string actual;
            string expected = "T";
            Game g = new Game();

            //act
            g.GamePerspectiveCode = input;
            actual = g.GamePerspectiveCode;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CreateGame_InputGamePerspectiveCodeB_OutputGamePerspectiveCodeB()
        {
            //arrange
            string input = "B";
            string actual;
            string expected = "B";
            Game g = new Game();

            //act
            g.GamePerspectiveCode = input;
            actual = g.GamePerspectiveCode;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void 
            CreateGame_InputEnglishTrailerBYgoN4b13rg_OutputEnglishTrailerBYgoN4b13rg()
        {
            //arrange
            string input = "BYgoN4b13rg";
            string actual;
            string expected = "BYgoN4b13rg";
            Game g = new Game();

            //act
            g.EnglishTrailer = input;
            actual = g.EnglishTrailer;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void
            CreateGame_InputEnglishTrailerDwbYxPdashetMY_OutputEnglishTrailerDwbYxPdashetMY()
        {
            //arrange
            string input = "DwbYxP-etMY";
            string actual;
            string expected = "DwbYxP-etMY";
            Game g = new Game();

            //act
            g.EnglishTrailer = input;
            actual = g.EnglishTrailer;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void
            CreateGame_InputEnglishTrailerNull_OutputEnglishTrailerNull()
        {
            //arrange
            string input = null;
            string actual;
            string expected = null;
            Game g = new Game();

            //act
            g.EnglishTrailer = input;
            actual = g.EnglishTrailer;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void
            CreateGame_InputFrenchTrailerNull_OutputFrenchTrailerNull()
        {
            //arrange
            string input = null;
            string actual;
            string expected = null;
            Game g = new Game();

            //act
            g.FrenchTrailer = input;
            actual = g.FrenchTrailer;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void
            CreateGame_InputFrenchTrailers0eIgl5iqqQ_OutputFrenchTrailers0eIgl5iqqQ()
        {
            //arrange
            string input = "s0eIgl5iqqQ";
            string actual;
            string expected = "s0eIgl5iqqQ";
            Game g = new Game();

            //act
            g.FrenchTrailer = input;
            actual = g.FrenchTrailer;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void
            CreateGame_InputFrenchTrailermGkO7oM5Vl8_OutputFrenchTrailermGkO7oM5Vl8()
        {
            //arrange
            string input = "mGkO7oM5Vl8";
            string actual;
            string expected = "mGkO7oM5Vl8";
            Game g = new Game();

            //act
            g.FrenchTrailer = input;
            actual = g.FrenchTrailer;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void
            CreateGame_InputEnglishDescriptionWhatDoesTheAmericanDreamMeanQuestion_OutputEnglishDescriptionWhatDoesTheAmericanDreamMeanQuestion()
        {
            //arrange
            string input = "What does the American dream mean?";
            string actual;
            string expected = "What does the American dream mean?";
            Game g = new Game();

            //act
            g.EnglishDescription = input;
            actual = g.EnglishDescription;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void
            CreateGame_InputEnglishDescriptionPlotDash_OutputEnglishDescriptionPlotDash()
        {
            //arrange
            string input = "Plot -";
            string actual;
            string expected = "Plot -";
            Game g = new Game();

            //act
            g.EnglishDescription = input;
            actual = g.EnglishDescription;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void
            CreateGame_InputEnglishDescriptionNull_OutputEnglishDescriptionNull()
        {
            //arrange
            string input = null;
            string actual;
            string expected = null;
            Game g = new Game();

            //act
            g.EnglishDescription = input;
            actual = g.EnglishDescription;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void
            CreateGame_InputFrenchDescriptionNull_OutputFrenchDescriptionNull()
        {
            //arrange
            string input = null;
            string actual;
            string expected = null;
            Game g = new Game();

            //act
            g.FrenchDescription = input;
            actual = g.FrenchDescription;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void
            CreateGame_InputFrenchDescriptionFIFA09CommaLeNouvel_OutputFrenchDescriptionFIFA09CommaLeNouvel()
        {
            //arrange
            string input = "FIFA 09, le nouvel";
            string actual;
            string expected = "FIFA 09, le nouvel";
            Game g = new Game();

            //act
            g.FrenchDescription = input;
            actual = g.FrenchDescription;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void
            CreateGame_InputFrenchDescriptionQueLeRêve_OutputFrenchDescriptionQueLeRêve()
        {
            //arrange
            string input = "Que le rêve";
            string actual;
            string expected = "Que le rêve";
            Game g = new Game();

            //act
            g.FrenchDescription = input;
            actual = g.FrenchDescription;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void
            CreateGame_InputEnglishDetailExploreVastAreas_OutputEnglishDetailExploreVastAreas()
        {
            //arrange
            string input = "Explore vast areas";
            string actual;
            string expected = "Explore vast areas";
            Game g = new Game();

            //act
            g.EnglishDetail = input;
            actual = g.EnglishDetail;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void
            CreateGame_InputEnglishDetailStepOntoThePitch_OutputEnglishDetailStepOntoThePitch()
        {
            //arrange
            string input = "Step onto the pitch";
            string actual;
            string expected = "Step onto the pitch";
            Game g = new Game();

            //act
            g.EnglishDetail = input;
            actual = g.EnglishDetail;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void
            CreateGame_InputEnglishDetailNull_OutputEnglishDetailNull()
        {
            //arrange
            string input = null;
            string actual;
            string expected = null;
            Game g = new Game();

            //act
            g.EnglishDetail = input;
            actual = g.EnglishDetail;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void
            CreateGame_InputFrenchDetailNull_OutputFrenchDetailNull()
        {
            //arrange
            string input = null;
            string actual;
            string expected = null;
            Game g = new Game();

            //act
            g.FrenchDetail = input;
            actual = g.FrenchDetail;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void
            CreateGame_InputFrenchDetailUnGrandJeuAvec_OutputFrenchDetailUnGrandJeuAvec()
        {
            //arrange
            string input = "un grand jeu avec";
            string actual;
            string expected = "un grand jeu avec";
            Game g = new Game();

            //act
            g.FrenchDetail = input;
            actual = g.FrenchDetail;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void
            CreateGame_InputFrenchDetailDeSurfAcrobatique_OutputFrenchDetailDeSurfAcrobatique()
        {
            //arrange
            string input = "de surf acrobatique";
            string actual;
            string expected = "de surf acrobatique";
            Game g = new Game();

            //act
            g.FrenchDetail = input;
            actual = g.FrenchDetail;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void
           CreateGame_InputUserNameUnknown_OutputUserNameUnknown()
        {
            //arrange
            string input = "Unknown";
            string actual;
            string expected = "Unknown";
            Game g = new Game();

            //act
            g.UserName = input;
            actual = g.UserName;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void
           CreateGame_InputUserNamePeter_OutputUserNamePeter()
        {
            //arrange
            string input = "Peter";
            string actual;
            string expected = "Peter";
            Game g = new Game();

            //act
            g.UserName = input;
            actual = g.UserName;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void
           CreateGame_InputUserNameNull_OutputUserNameNull()
        {
            //arrange
            string input = null;
            string actual;
            string expected = null;
            Game g = new Game();

            //act
            g.UserName = input;
            actual = g.UserName;

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}