using System;
using System.Collections.Generic;
using System.Text;

namespace Day20MoodAnalyzer
{
    public class MoodAnalysisException : Exception
    {
        public enum ExceptionType
        {
            NULL_Msg, 
            EMPTY_Msg,
           
        }
        private readonly ExceptionType type;

        public MoodAnalysisException(ExceptionType Type, string message) : base(message)
        {
            this.type = Type;
        }
    }
}
