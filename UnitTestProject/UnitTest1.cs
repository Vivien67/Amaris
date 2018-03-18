using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParkPrice;

namespace UnitTestProject
{

    [TestClass]
    public class UnitTest1
    {
        ParkingInput userInput;
        ParkRate parkRate;

        [TestMethod]
        public void TestMethodCourteDuree()
        {
            userInput = new ParkingInput(0, 0, 12, EparkRate.ParkRate1);
            parkRate = new ParkRate(userInput.ParkRate);
            int price = parkRate.CalculatePrice(userInput.ParkDuration);
            Assert.AreEqual(price, 6);

            userInput = new ParkingInput(0, 0, 84, EparkRate.ParkRate1);
            parkRate = new ParkRate(userInput.ParkRate);
             price = parkRate.CalculatePrice(userInput.ParkDuration);
            Assert.AreEqual(price, 30);

            userInput = new ParkingInput(0, 1, 84, EparkRate.ParkRate1);
            parkRate = new ParkRate(userInput.ParkRate);
            price = parkRate.CalculatePrice(userInput.ParkDuration);
            Assert.AreEqual(price, 37);


            userInput = new ParkingInput(45, 1, 84, EparkRate.ParkRate1);
            parkRate = new ParkRate(userInput.ParkRate);
            price = parkRate.CalculatePrice(userInput.ParkDuration);
            Assert.AreEqual(price, 1702);
        }

        [TestMethod]
        public void TestMethodEtage()
        {
            userInput = new ParkingInput(0, 0, 12, EparkRate.ParkRate2);
            parkRate = new ParkRate(userInput.ParkRate);
            int price = parkRate.CalculatePrice(userInput.ParkDuration);
            Assert.AreEqual(price, 6);

            userInput = new ParkingInput(0, 0, 84, EparkRate.ParkRate2);
            parkRate = new ParkRate(userInput.ParkRate);
            price = parkRate.CalculatePrice(userInput.ParkDuration);
            Assert.AreEqual(price, 30);

            userInput = new ParkingInput(0, 1, 84, EparkRate.ParkRate2);
            parkRate = new ParkRate(userInput.ParkRate);
            price = parkRate.CalculatePrice(userInput.ParkDuration);
            Assert.AreEqual(price, 30);


            userInput = new ParkingInput(45, 1, 84, EparkRate.ParkRate2);
            parkRate = new ParkRate(userInput.ParkRate);
            price = parkRate.CalculatePrice(userInput.ParkDuration);
            Assert.AreEqual(price, 1380);
        }

        [TestMethod]
        public void TestMethodValetParc()
        {
            userInput = new ParkingInput(0, 0, 12, EparkRate.ParkRate3);
            parkRate = new ParkRate(userInput.ParkRate);
            int price = parkRate.CalculatePrice(userInput.ParkDuration);
            Assert.AreEqual(price, 12);

            userInput = new ParkingInput(0, 0, 84, EparkRate.ParkRate3);
            parkRate = new ParkRate(userInput.ParkRate);
            price = parkRate.CalculatePrice(userInput.ParkDuration);
            Assert.AreEqual(price, 42);

            userInput = new ParkingInput(0, 1, 84, EparkRate.ParkRate3);
            parkRate = new ParkRate(userInput.ParkRate);
            price = parkRate.CalculatePrice(userInput.ParkDuration);
            Assert.AreEqual(price, 42);


            userInput = new ParkingInput(45, 1, 84, EparkRate.ParkRate3);
            parkRate = new ParkRate(userInput.ParkRate);
            price = parkRate.CalculatePrice(userInput.ParkDuration);
            Assert.AreEqual(price, 1932);
        }
    }
}
