using System;
using System.Collections.Generic;
using System.Text;

namespace Day20MoodAnalyzer
{
    public class MoodAnalyse2
    {
        private string message;

       
        public MoodAnalyse2(string message)
        {
            this.message = message;
        }

        public string AnalyseMood()
        {
            try
            {
                if (this.message.Contains("Sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch
            {
                return "HAPPY";
            }
        }
    }
}
