using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment1;
namespace Assignment1Test
{
    [TestClass]
    public class FootballPlayerTest
    {
        FootballPlayer player = new FootballPlayer {id = 1, Name = "Bob", Age=21, ShirtNumber= 42 };
        FootballPlayer playerNameToShort = new FootballPlayer { id = 2, Name = "B", Age = 21, ShirtNumber = 56};
        FootballPlayer playerAgeToLow = new FootballPlayer { id = 3, Name = "Bill", Age = 1, ShirtNumber = 34 };
        FootballPlayer playerShirtnumberToLow = new FootballPlayer { id = 4, Name = "Ted", Age = 21, ShirtNumber = 0 };
        FootballPlayer playerShirtnumberToHigh = new FootballPlayer { id = 4, Name = "Ted", Age = 21, ShirtNumber = 101 };


        [TestMethod]
        public void ValidateNameTest()
        {
            player.ValidateName();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => playerNameToShort.ValidateName());
        }

        [TestMethod]
        public void ValidateAgeTest()
        {
            player.ValidateAge();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => playerAgeToLow.ValidateAge());
        }

        [TestMethod]
        public void ValidateShirtTest()
        {
            player.ValidateShirt();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => playerShirtnumberToLow.ValidateShirt());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => playerShirtnumberToHigh.ValidateShirt());
        }
        [TestMethod]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(40)]
        [DataRow(98)]
        [DataRow(99)]
        public void ValidateShirtNumberTest(int shirtNumber)
        {
            player.ShirtNumber = shirtNumber;
            player.ValidateShirt();
        }
    }
}