namespace Logger_with_Bridge_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new DetailedLogger(new JsonWriter());

            logger.LogError("compile error while client executing");
            logger.LogInfo("admin visits home page");
            logger.LogWarning("int to double unsafe cast");

            logger = new DetailedLogger(new XMLWriter());

            logger.LogError("compile error while client executing");
            logger.LogInfo("admin visits home page");
            logger.LogWarning("int to double unsafe cast");

            logger = new SimpleLogger(new BinaryWriter());

            logger.LogError("compile error while client executing");
            logger.LogInfo("admin visits home page");
            logger.LogWarning("int to double unsafe cast");

            logger = new SimpleLogger(new ConsoleWriter());

            logger.LogError("compile error while client executing");
            logger.LogInfo("admin visits home page");
            logger.LogWarning("double to int unsafe cast");

        }
    }
}