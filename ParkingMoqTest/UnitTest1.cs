using Lab3_UniteTest_Moq_ParkCar.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;

namespace ParkingMoqTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        Mock<ParkingContext> mockRepo = new Mock<ParkingContext>();
            Pass pass = new Pass(mockRepo.Object);
            //Arrange
            Pass mockPass = new Pass {
                ID = 1,
                Purchaser = "12345",
                Premium = true,
                Capacity = 0
            };


            //Act Assert
            Assert.ThrowsException<NullReferenceException>(() => pass.CreatePass(mockPass));
        }
    }
}