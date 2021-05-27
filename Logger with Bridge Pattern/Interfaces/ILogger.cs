namespace Logger_with_Bridge_Pattern
{  
    public interface ILogger
    {
        IWriter Writer { get; }
        void LogInfo(string data);
        void LogWarning(string data);
        void LogError(string data);
    }
}