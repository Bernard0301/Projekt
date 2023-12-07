using Projekt_dzieñ_6;

namespace Projekt.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeCollectPoints_ShouldCorrectResult()
        {
            // arrange
            var empl = new Employee("Sebastian", "Dres", 24);
            empl.AddScore(10);
            empl.AddScore(8);
            empl.AddScore(-8);

            // act
            var result = empl.Result;

            // assert
            Assert.AreEqual(10, result);

        }
        [Test]
        public void WhenEmployeeCollectThreePoints_ShouldCorrectResult()
        {
            var empl = new Employee("Pawe³", "Kowalski", 34);
            empl.AddScore(10);
            empl.AddScore(-5);
            empl.AddScore(-2);

            var result = empl.Result;

            Assert.AreEqual(3, result);
        }

    }
}