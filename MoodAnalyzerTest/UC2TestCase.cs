using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day20MoodAnalyzer;

namespace MoodAnalyzerTest
{
    [TestClass]
    public class UC2TestCase
    {
        [TestMethod]
        [DataRow(null)]
        public void TestMethod(string message)
        {
            // Arrange
            string expected = "HAPPY";
            MoodAnalyse2 moodAnalyzer = new MoodAnalyse2(message);

            //Act
            string mood = moodAnalyzer.AnalyseMood();

            // Assert
            Assert.AreEqual(expected, mood);
        }


    }
}
