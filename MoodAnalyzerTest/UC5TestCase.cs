using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day20MoodAnalyzer;

namespace MoodAnalyzerTest
{
    [TestClass]
    public class UC5TestCase
    {
        
        [TestMethod]
        public void GivenMoodAnalyseClassNameShouldReturnMoodAnalyseObject_UsingParameterizedConstructor()
        {
            object expected = new MoodAnalyser4("HAPPY");
            object obj = MoodAnalyseFactory5.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyzerApp.MoodAnalyser4",
                "MoodAnalyser4", "HAPPY");
            expected.Equals(obj);
        }

        [TestMethod]
        public void GivenImproperClassNameShouldThrowMoodAnalysisException_UsingParameterizedConstructor()
        {
            string expected = "Class not Found";
            try
            {
                object obj = MoodAnalyseFactory5.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyzerApp.DemoClass",
                "MoodAnalyser4", "HAPPY");
            }
            catch (MoodAnalysisException e)
            {
                Assert.AreEqual(expected, e.Message);
            }
        }

        [TestMethod]
        public void GivenImproperConstructorNameShouldThrowMoodAnalysisException_UsingParameterizedConstructor()
        {
            string expected = "Constructor not Found";
            try
            {
                object obj = MoodAnalyseFactory5.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyzerApp.MoodAnalyse",
                "DemoConstructor", "HAPPY");
            }
            catch (MoodAnalysisException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }
    }
}
