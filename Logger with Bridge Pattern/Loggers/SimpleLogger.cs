namespace Logger_with_Bridge_Pattern
{    
    public class SimpleLogger : ILogger
    {        
        public SimpleLogger(IWriter writer)
        {
            Writer = writer;
        }

        public IWriter Writer { get; private set; }

        public void LogError(string data)
        {
            Writer.Write($"Log Error: {data}");
        }

        public void LogInfo(string data)
        {
            Writer.Write($"Log Info: {data}");
        }

        public void LogWarning(string data)
        {
            Writer.Write($"Log Warning: {data}");
        }
    }
}