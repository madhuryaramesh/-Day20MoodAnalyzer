using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day20MoodAnalyzer;

namespace MoodAnalyzerTest
{
    [TestClass]
    public class UC7TestCase
    {
        
        [TestMethod]
        public void GivenHappy_ShouldReturnHappy_WithReflectorDynamically()
        {
            string result = MoodAnalyserFactory.Setfield("Happy", "message");
            Assert.AreEqual("Happy", result);
        }

        [TestMethod]
        public void GivenWrongFieldShouldReturnException()
        {
            try
            {
                string result = MoodAnalyserFactory.Setfield("Happy", "messageWrong");
                Assert.AreEqual("Happy", result);
            }
            catch (MoodAnalysisException ex)
            {
                Assert.AreEqual("Field not Found", ex.Message);
            }
        }

        [TestMethod]
        public void GivenEmptyMessageShouldReturnException()
        {
            try
            {
                string result = MoodAnalyserFactory.Setfield(null, "message");
                Assert.AreEqual("Happy", result);
            }
            catch (MoodAnalysisException ex)
            {
                Assert.AreEqual("Message should not be null", ex.Message);
            }
        }
    }
}
