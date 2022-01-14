using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day20MoodAnalyzer;

namespace MoodAnalyzerTest
{
    [TestClass]
    public class UC6TestCase
    {
        
        [TestMethod]
        public void GivenHappyMessage_ShouldReturn_HappyMood_UsingReflectorInvoke_Method()
        {
            string expected = "HAPPY";
            string mood = MoodAnalyserFactory.InvokeAnalyseMood("Happy", "AnalyseMood");
            Assert.AreEqual(expected, mood);
        }
        [TestMethod]
        public void GivenHappyMessageWhenImproperMethodShouldThrowMoodAnalysisException()
        {
            try
            {
                string expected = "method not found";
                string mood = MoodAnalyserFactory.InvokeAnalyseMood("Happy", "AnalyseMoodWrong");
                Assert.AreNotEqual(expected, mood);
            }

            catch (MoodAnalysisException ex)
            {
                Assert.AreEqual("method not found", ex.Message);
            }
        }
    }
}
