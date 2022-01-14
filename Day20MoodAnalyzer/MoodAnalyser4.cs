using System;
using System.Collections.Generic;
using System.Text;

namespace Day20MoodAnalyzer
{
    public class MoodAnalyser4
    {
        private string message;

        public MoodAnalyser4()
        {

        }

        public MoodAnalyser4(string message)
        {
            this.message = message;
        }

        public string AnalyseMood()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.EMPTY_Msg, "Mood should not be Empty");
                }

                if (this.message.Contains("Sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NULL_Msg, "Mood should not be null");
            }
        }
    }
}
