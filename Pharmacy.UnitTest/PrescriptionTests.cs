using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace Pharmacy.UnitTest
{
    [TestFixture]
    public class PrescripionTests
    {
        [Test]
        public void NumberRxValidation_GiveEmptyValue_ReturnZero()
        {
            //Arrange
            var prescription = new Prescripion();

            //Act
            var tmp = prescription.numberRxValidation("");

            //Assert
            Assert.AreEqual(0, tmp);

        }

        [Test]
        public void NumberRxValidation_GiveIncorectValue_ReturnZero()
        {
            //Arrange
            var prescription = new Prescripion();

            //Act
            var tmp = prescription.numberRxValidation("34289");

            //Assert
            Assert.AreEqual(0, tmp);

        }

        [Test]
        public void NumberRxValidation_GiveCorrectValue_ReturnOne()
        {
            //Arrange
            var prescription = new Prescripion();

            //Act
            var tmp = prescription.numberRxValidation("3428984738");

            //Assert
            Assert.AreEqual(1, tmp);

        }
        [Test]
        public void PeselValidation_GiveNullValue_ReturnZero()
        {
            //Arrange
            var prescription = new Prescripion();

            //Act
            var tmp = prescription.peselValidation("");

            //Assert
            Assert.AreEqual(0, tmp);

        }

        [Test]
        public void PeselValidation_GiveIncorrectValue_ReturnZero()
        {
            //Arrange
            var prescription = new Prescripion();

            //Act
            var tmp = prescription.peselValidation("9707042389");

            //Assert
            Assert.AreEqual(0, tmp);

        }

        [Test]
        public void PeselValidation_GiveCorrectValue_ReturnOne()
        {
            //Arrange
            var prescription = new Prescripion();

            //Act
            var tmp = prescription.peselValidation("98070247382");

            //Assert
            Assert.AreEqual(1, tmp);

        }

        [TestCase("948290938",2843,938492019, "948290938")]
        [TestCase("948290938", null, null, "Incorrect data")]
        [TestCase("948290938", 0, 0, "Incorrect data")]
        [TestCase("948290938",32133 , 938492019, "Incorrect accesNumber")]
        [TestCase("948290938", 321, 938492019, "Incorrect accesNumber")]
        [TestCase("948290938", 3214, 938, "Incorrect phoneNumber")]
        [TestCase("948290938", 3214, 9384920, "Incorrect phoneNumber")]
        public void EnterAccessNumberAndPhoneNumber_GiveIncorrectAccesNumber_Return(string numberRx, int accessNumber, int phoneNumber, string expectedResult)
        {
            //Arrange
            var prescription = new Prescripion(numberRx);

       

            //Assert
            Assert.AreEqual(expectedResult, prescription.enterAccessNumberAndPhoneNumber(accessNumber, phoneNumber));

        }


    }
}
