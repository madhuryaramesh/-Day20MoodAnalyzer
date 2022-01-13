using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day20MoodAnalyzer;

namespace MoodAnalyzerTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string expected = "SAD";
            string message = "I am in Sad Mood";
            MoodAnalyzer analyzer = new MoodAnalyzer(message);
            string mood = analyzer.AnalyseMood();
            Assert.AreEqual(expected, mood);
        }

        [TestMethod]
        public void TestMethod2()
        {
        
            string expected = "HAPPY";
            string message = "I am in Any Mood";
            MoodAnalyzer moodAnalyse = new MoodAnalyzer(message);
            string mood = moodAnalyse.AnalyseMood();
            Assert.AreEqual(expected, mood);
        }
    }
}
