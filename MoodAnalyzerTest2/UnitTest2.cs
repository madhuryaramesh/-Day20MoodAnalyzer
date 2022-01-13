using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day20MoodAnalyzer;

namespace MoodAnalyzerTest2
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        [DataRow(null)]
        public void TestMethod2(string message)
        {
            string expected = "HAPPY";
            MoodAnalyzer2 obj = new MoodAnalyzer2(message);
            string mood = moodAnalyzer.AnalyseMood();
            Assert.AreEqual(expected, mood);
        }
    }
}
