using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day20MoodAnalyzer;

namespace MoodAnalyzerTest
{
    [TestClass]
    public class UC3TestCase
    {
        [TestMethod]
        public void Given_NULL_Mood_Should_Throw_MoodAnalysisException()
        {
            try
            {
                string message = null;
                MoodAnalyse3 moodAnalyse = new MoodAnalyse3(message);
                string mood = moodAnalyse.AnalyseMood();
            }
            catch (MoodAnalysisException e)
            {
                Assert.AreEqual("Mood should not be null", e.Message);
            }
        }
        [TestMethod]
        public void Given_Empty_Mood_Should_Throw_MoodAnalysisException_Indicating_EmptyMood()
        {
            try
            {
                string message = "";
                MoodAnalyse3 moodAnalyse = new MoodAnalyse3(message);
                string mood = moodAnalyse.AnalyseMood();
            }
            catch (MoodAnalysisException e)
            {
                Assert.AreEqual("Mood should not be Empty", e.Message);
            }
        }


    }
}
