using System;

namespace Logger_with_Bridge_Pattern
{
    public class DetailedLogger : ILogger
    {
        public DetailedLogger(IWriter writer)
        {
            Writer = writer;
        }

        public IWriter Writer { get; private set; }

        public void LogError(string data)
        {
            Writer.Write($"Log Error: {data}, Date: {DateTime.Now:F}");
        }

        public void LogInfo(string data)
        {
            Writer.Write($"Log Info: {data}, Date: {DateTime.Now:F}");            
        }

        public void LogWarning(string data)
        {
            Writer.Write($"Log Warning: {data}, Date: {DateTime.Now:F}");                        
        }
    }
}